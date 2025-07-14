//
// Programmer       : RE Siase
// Purpose          : The purpose of this program is manage Employee and Student information
//

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace S1P1
{
    public class Person
    {
        public Address HomeAddress
        {
            //
            //Method Name : property Address HomeAddress
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        }//end property
        public string ID
        {
            //
            //Method Name : property string ID
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        }//end property
        public string FirstName
        {
            //
            //Method Name : property string FirstName
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        }//end property
        public string LastName
        {
            //
            //Method Name : property string LastName
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        }//end property
        public Person(string id, string firstName, string lastName)
        {
            this.ID= id;
            this.FirstName= firstName;
            this.LastName= lastName;
        } // end method
        public virtual string GetInfo()
        {
            //
            //Method Name : string GetInfo()
            //Purpose : To display the Person information
            //Re-use : none
            //Input Parameter : none
            //Output Type : string
            //              - the person information
            //
            return $"ID: {ID}\nName: {FirstName} {LastName}\nAddress: {HomeAddress}";
        } // end method
        public override string ToString()
        {
            //
            //Method Name : string ToString()
            //Purpose : To display the Person information
            //Re-use : GetInfo()
            //Input Parameter : none
            //Output Type : string
            //              - the person information
            //
            return GetInfo();
        } // end method
    } // end class
} // end namespace
