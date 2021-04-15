using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    class ClsBllUserMaster
    {
        ClsDalUserMaster objdal = new ClsDalUserMaster();


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Company { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string PhoneNo { get; set; }

        public string EmailId { get; set; }

        public void save(int Flag)
        {
            objdal.Save(this, Flag);
        
        
        }


    }
}
