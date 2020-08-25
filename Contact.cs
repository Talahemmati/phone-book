using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Contact
    {
        public string firstname { get; set; }
        public string familyname { get; set; }
        public string phonenumber { get; set; }


        public Contact()
        {
            this.firstname = null;
            this.firstname = null;
            this.phonenumber = null;
        }
        public Contact(string firstname, string familyname, string phonenumber)
        {
            this.firstname = firstname;
            this.firstname = familyname;
            this.phonenumber = phonenumber;
        }
        public override string ToString()
        {
            return "First name: " + this.firstname + " \n" +
                   "Family name: " + this.familyname + " \n" +
                   "Phonenumber: " + this.phonenumber+" \n";
        }
    }

}
    
