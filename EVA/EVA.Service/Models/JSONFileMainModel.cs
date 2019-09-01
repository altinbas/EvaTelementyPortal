namespace EVA.Service.Models
{
    public class JSONFileMainModel
    {
        public int id { get; set; }
        //Strings
        public string Name { get; set; }
        public string Code { get; set; }
        public string Format { get; set; }
        public string GaugeName { get; set; }
        public string GUIControlName { get; set; }
        //bools
        public bool UseGUI { get; set; }
        public bool UseGauge { get; set; }

    }
}
