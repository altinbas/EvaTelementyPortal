using EVA.Service.Loger;
using ns1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVA.Service
{
    public partial class frmMain : Form
    {
        #region Property, Local variables and Contructors
        //manager class for serial connecttion
        SerialPort mSerialPortManager;
        //It use for the data getting 
        bool mReadingIsEnable;
        //Sperater 
        readonly string mPachageSparater;
        readonly string mValueSparater;
        readonly string mHost;
        readonly string mSecurityCode;
        readonly Loger.LogManager mLogManager;
        Thread mReaderTheread;
        delegate void mWriterHandler(string argName);
        private Helpers.JSONConverterHelper mJsonManager;
        private bool mIsSendNetwork;
        private List<Models.JSONFileMainModel> mJsonModelList;
        private HttpClient mClient;
        private List<LogModel> mLogs;
        public frmMain()
        {
            InitializeComponent();
            mPachageSparater = Helpers.AppSettingHelper.PachageSperator;
            mValueSparater = Helpers.AppSettingHelper.ValueSperater;
            mHost = Helpers.AppSettingHelper.Host;
            mSecurityCode = Helpers.AppSettingHelper.HostSecyrityKey;
            mJsonManager = new Helpers.JSONConverterHelper();
            mClient = new HttpClient();
            mLogManager = new Loger.LogManager(Helpers.AppSettingHelper.SQLiteConnection);
            mIsSendNetwork = chcSendData.Checked;
            chcSendData.CheckedChanged += ChcSendData_CheckedChanged;
        }

        private void ChcSendData_CheckedChanged(object sender, EventArgs e)
        {
            mIsSendNetwork = chcSendData.Checked;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            fnRefreshPorts();
            fnGetMetaData();
        }
        #endregion
        #region Service Events
        /// <summary>
        /// Reads data from serial port and involke the related methods to do operation.
        /// </summary>
        public void fnReadFromSerial()
        {
            List<byte> lcBuffer = new List<byte>();
            while (mReadingIsEnable)
            {
                try
                {
                    if (mSerialPortManager.IsOpen)
                    {
                        //string message = ((char)_serialPort.ReadByte()).ToString();
                        var lcData = mSerialPortManager.ReadByte();
                        if ((char)lcData == mPachageSparater.FirstOrDefault())
                        {
                            mWriterHandler lcDelegate = new mWriterHandler(fnWriteConsole);
                            lcDelegate += fnUpdateUI;
                            lcDelegate += fnLog;
                            if (mIsSendNetwork)
                            {
                                lcDelegate += fnSendServer;
                            }
                            this.Invoke(lcDelegate, System.Text.Encoding.UTF8.GetString(lcBuffer.ToArray()));
                            lcBuffer.Clear();
                        }
                        else
                            lcBuffer.Add((byte)lcData);
                    }
                }
                catch (TimeoutException) { }
                catch (IOException ex)
                {
                    if (!mSerialPortManager.IsOpen)
                    {
                        BtnDisconnect_Click(null, null);
                        MessageBox.Show($"Connection has been closed!", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading!\n {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// The method wrrites the serial data to console.
        /// </summary>
        /// <param name="argText"></param>
        void fnWriteConsole(string argText)
        {
            txtConsole.AppendText($"\n{argText} @ {DateTime.Now.ToString("HH:mm:ss")}");
            txtConsole.Focus();
            txtConsole.SelectionStart = txtConsole.Text.Length;
        }
        private void fnLog(string argText)
        {
            try
            {
                var lcDataArray = argText.Split(mValueSparater[0]);
                var lcOperationCode = Convert.ToInt32(lcDataArray[0]);
                var lcValue = double.Parse(lcDataArray[1]);
                var lcValueText = mJsonModelList.FirstOrDefault(a => a.Code == lcDataArray[0]).Name;
                mLogManager.fnLog(new Loger.LogModel { OperationCode = lcOperationCode, Value = lcValue, Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ms") , Title = lcValueText });
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Scan for aviable ports and list them into listbox.
        /// </summary>
        private void fnRefreshPorts()
        {
            try
            {
                cmbSelectPort.Items.Clear();
                cmbSelectPort.Items.AddRange(SerialPort.GetPortNames());
                if (cmbSelectPort.Items.Count > 0)
                {
                    cmbSelectPort.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Update to the controlls 
        /// </summary>
        /// <param name="argText"></param>
        private void fnUpdateUI(string argText)
        {
            try
            {
                var lcSplitedArray = argText.Split(mValueSparater.First());
                var lcOpcode = lcSplitedArray[0];
                var lcOpValue = lcSplitedArray[1];
                var lcCurrentDate = DateTime.Now;
                var lcModel = mJsonModelList.FirstOrDefault(a => a.Code == lcOpcode);
                foreach (var control in grpMasterData.Controls)
                {
                    if (control is Label && (control as Label).Tag.Equals($"val{lcOpcode}"))
                    {
                        (control as Label).Text = $"{String.Format(lcModel.Format, lcOpValue)} @ {lcCurrentDate.ToString("HH:mm:ss")}";
                    }
                }
                if (lcModel.UseGUI)
                {
                    Label lcGUILabel = (Label)pnlDashboard.Controls.Find(lcModel.GUIControlName, true).First();
                    lcGUILabel.Text = string.Format(lcModel.Format, lcOpValue);
                    if (lcModel.UseGauge)
                    {
                        var lcGauge = pnlDashboard.Controls.Find(lcModel.GaugeName, true).First();
                        var lcSpliteedData = lcOpValue.Split('.').First();
                        if (lcGauge != null && lcGauge is BunifuGauge)
                        {
                            (lcGauge as BunifuGauge).Value = int.Parse(lcSpliteedData);
                        }
                        else if (lcGauge != null && lcGauge is BunifuProgressBar)
                        {
                            (lcGauge as BunifuProgressBar).Value = int.Parse(lcSpliteedData);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private async void fnSendServer(string argText)
        {
            try
            {
                var lcSplitedArray = argText.Split(mValueSparater.First());
                var lcOpcode = lcSplitedArray[0];
                var lcOpValue = lcSplitedArray[1];
                var lcContent = new FormUrlEncodedContent(new[]
                {
                     new KeyValuePair<string, string>("securityCode", mSecurityCode),
                     new KeyValuePair<string, string>("key", lcOpcode),
                     new KeyValuePair<string, string>("value", lcOpValue)
                });
                // var res = await mClient.GetStringAsync($"{mHost}?securityCode={mSecurityCode}&key={lcOpcode}&value={lcOpValue}");
                var res = await mClient.PostAsync($"{mHost}", lcContent);
            }
            catch (Exception ex)
            {
                fnWriteConsole($"Network error:{ex.Message}!");
            }
        }
        /// <summary>
        /// Created the dynamic controls
        /// </summary>
        private async void fnGetMetaData()
        {
            try
            {
                mJsonModelList = await mJsonManager.fnGetDataFromJsonAsync();
                var lcCounter = 0;
                foreach (var data in mJsonModelList)
                {
                    Label lblTitile = new Label
                    {
                        Visible = true,
                        Text = $"{data.Code}-{data.Name}",
                        Tag = data.Code,
                        ForeColor = Color.White,
                        BackColor = Color.Red,
                        Width = 135,
                        Height = 20,
                        Margin = new Padding(3),
                        Padding = new Padding(2),
                        Location = new Point(25, 25 + (lcCounter * 25)),
                    };
                    Label lblValue = new Label
                    {
                        Visible = true,
                        Text = "..",
                        Tag = $"val{data.Code}",
                        ForeColor = Color.White,
                        BackColor = Color.Red,
                        Width = 200,
                        Height = 20,
                        Margin = new Padding(3),
                        Padding = new Padding(2),
                        Location = new Point(165, 25 + (lcCounter * 25)),
                    };
                    grpMasterData.Controls.Add(lblTitile);
                    grpMasterData.Controls.Add(lblValue);
                    lcCounter += 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Sennds data to device using serial connection
        /// </summary>
        private void fnSendData()
        {
            try
            {
                if (mSerialPortManager.IsOpen)
                {
                    mSerialPortManager.Write(txtData.Text);
                    fnWriteConsole($"Send data{txtData.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting the service: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the logs data from the database
        /// </summary>
        void fnLoadLogs()
        {
            try
            {
                txtSearch.Clear();
                lstTypes.Items.Clear();
                lstTypes.Items.Add("All");
                lstTypes.Items.AddRange(mLogManager.fnGetLogTyps().ToArray());
                lstTypes.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #region Button Events
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            fnRefreshPorts();
        }
        /// <summary>
        /// It start to listen the selected port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
                mReaderTheread = new Thread(fnReadFromSerial);
                mSerialPortManager = new SerialPort(cmbSelectPort.SelectedItem.ToString(), 38400, Parity.None, 8, StopBits.One);
                // Set the read/write timeouts
                mSerialPortManager.ReadTimeout = 500;
                mSerialPortManager.WriteTimeout = 500;
                mSerialPortManager.Open();
                mReadingIsEnable = true;
                mReaderTheread.Start();
                lblStatus.Text = "RUNNING...";
                fnLog("000:0.0");
                btnDisconnect.Enabled = true;
                btnRefresh.Enabled = btnStart.Enabled = !btnDisconnect.Enabled;
                fnWriteConsole($"Service Started {cmbSelectPort.SelectedItem}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting the service: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Disconnect button cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                mSerialPortManager.Close();
                mReaderTheread.Abort();
                lblStatus.Text = "STOPPED";
                fnWriteConsole($"\nService closed @ {DateTime.Now.ToString("HH:mm:ss")} from port :{cmbSelectPort.SelectedItem}");
                mReaderTheread = null;
                btnDisconnect.Enabled = false;
                btnRefresh.Enabled = btnStart.Enabled = !btnDisconnect.Enabled;
            }
            catch (Exception ex)
            {
                //  MessageBox.Show( $"An error occurred while stoping the service: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Clear button cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pnlDashboard.Visible = false;
            pnlLog.Visible = false;
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pnlDashboard.Visible = true;
            pnlLog.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var lcResult = MessageBox.Show("Are you sure you want to exit from the app?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lcResult == DialogResult.Yes)
            {
                if (mSerialPortManager != null && mSerialPortManager.IsOpen)
                {
                    mSerialPortManager.Close();
                }
                Application.Exit();
            }
        }

        private void BtnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(73, 80, 92);
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHide_MouseLeave(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.Transparent;
        }

        private void BtnHide_MouseMove(object sender, MouseEventArgs e)
        {
            btnHide.BackColor = Color.FromArgb(73, 80, 92);
        }
        /// <summary>
        /// Send button cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendData_Click(object sender, EventArgs e)
        {
            fnSendData();
        }
        #endregion
        #region Other UI Events
        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            pnlLog.Visible = true;
            pnlDashboard.Visible = false;
            fnLoadLogs();
        }
        #endregion

        private void LstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mLogs = mLogManager.fnGetLogs(lstTypes.SelectedItem.ToString());
                grdLogs.DataSource = mLogs;
                grdLogs.ForeColor = Color.Black;
                grdLogs.Columns["Date"].Width = 250;
            }
            catch (Exception)
            {

            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                grdLogs.DataSource = mLogs;
            }
            else
            {
                grdLogs.DataSource = mLogs.Where(a => a.Date.Contains(txtSearch.Text) || a.Title.Contains(txtSearch.Text)).OrderByDescending(a=>a.Date).ToList();
            }
        }

        private void GrdLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
