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
    public class Student : Person, ICloneable
    {
        public string SchoolName
        {
            //
            //Method Name : property string SchoolName
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        }//end property
        public Student(string id, string firstName, string lastName, string schoolName) : base(id, firstName, lastName)
        {
            this.SchoolName= schoolName;
        }  //end method
        public override string GetInfo()
        {
            //
            //Method Name : string GetInfo()
            //Purpose : To display the Student information
            //Re-use : GetInfo()
            //Input Parameter : none
            //Output Type : string
            //              - the Student information
            //
            return base.GetInfo()+"\nSchool: "+SchoolName;
        }  //end method
        public override string ToString()
        {
            //
            //Method Name : string ToString()
            //Purpose : To display the Student information
            //Re-use : GetInfo()
            //Input Parameter : none
            //Output Type : string
            //              - the Student information
            //
            return GetInfo();
        } // end method
        public object Clone()
        {
            //
            //Method Name : object Clone()
            //Purpose : To create a perfect copy of a Student object
            //Re-use : none()
            //Input Parameter : none
            //Output Type : object
            //             - the clone of Student object
            //
            Student newStud = new Student(this.ID, this.FirstName, this.LastName, this.SchoolName);
            return newStud; 
        } //end method

    } // end class
} //end namespace
