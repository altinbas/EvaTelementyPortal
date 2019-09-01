using EVA.BLL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EVA.BLL.Managers
{
    public class CanBusValueManager
    {
        static EVAPanelMainDBContext mContext=new EVAPanelMainDBContext();
         public static IQueryable<tblValue> fnGetValue()
         {
            return mContext.tblValues;
         }
        public static IQueryable<vwGetValuesByGroup> fnGetvwGetValuesByGroup(int argHistoryCount=3)
        {
            return mContext.vwGetValuesByGroups.Where(a => a.Number <= argHistoryCount);
        }
    }
}
