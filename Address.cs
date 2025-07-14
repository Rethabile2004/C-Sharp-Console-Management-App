//
// Programmer       : RE Siase
// Purpose          : The purpose of this program is manage Employee and Student information
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1P1
{
    public class Address
    {
        public string Street
        {
            //
            //Method Name : property string Street
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        } // end property
        public string City
        {
            //
            //Method Name : property string City
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get;set;
        }//end property
        public override string ToString()
        {
            //
            //Method Name : string ToString()
            //Purpose : To display the Address information
            //Re-use : none
            //Input Parameter : none
            //Output Type : string
            //              - the Address information
            //
            return $"{Street}, {City}";
        } // end method
    } // end class
} // end namespace
