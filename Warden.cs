using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accommodation_management
{
    class Warden
    {
        private string wardenID;
        private string wardenName;
        private string email;
        private string contactNumber;

        public Warden (string wardenID, string wardenName, string email, string contactNumber )
        {
            this.wardenID = wardenID;
            this.wardenName = wardenName;
            this.email = email;
            this.contactNumber = contactNumber;
        }

        public string WardenID
        {
            get { return wardenID; }
        }

        public string WardenName
        {
            get { return wardenName; }
        }
    }
}
