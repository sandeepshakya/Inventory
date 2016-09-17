using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Inventory.Sessions;

using UserM = Model.Models.Company;

namespace Inventory.Sessions
{
    public class InventorySessions
    {
        public static InventorySessions Current
        {
            get
            {
                InventorySessions session = (InventorySessions)HttpContext.Current.Session[SessionConstants.INVENTORY_SESSION_KEY];
                if (session == null)
                {
                    session = new InventorySessions();
                    HttpContext.Current.Session[SessionConstants.INVENTORY_SESSION_KEY] = session;
                }
                return session;
            }

        }
       
        public UserM UserDetailSessions { get; set; }
      
        public long Id { get; set; }
        public string ModuleName { get; set; }
        public string CurrentPage { get; set; }
        public string Roles { get; set; }
        public string userType { get; set; }
        public long SellerId { get; set; }
        public static void ClearSession()
        {
                       InventorySessions.Current.UserDetailSessions = null;
        }
    }
}