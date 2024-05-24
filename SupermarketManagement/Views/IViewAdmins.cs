using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermarketManagement.Views
{
    public interface IViewAdmins
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        //Events
        event EventHandler AddEvent;
        event EventHandler ViewEvent;
        event EventHandler EditEvent;

        //Methods (For Forms)
        void setAdminsList(BindingSource adminsList);
        //void show();
    }
    
}
