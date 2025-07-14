using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1P1
{
    public class Employee : Person,ICloneable
    {
        public string CompanyName
        {
            //
            //Method Name : property string CompanyName
            //Purpose : Automatic public property to give access to corresponding compiler generated field 
            //Re-use : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler generated field
            //Output Type : string
            //              - value stored in the corresponding compiler generated field
            //
            get; set;
        }//end property
        public Employee(string id, string firstName, string lastName, string companyName) : base(id, firstName, lastName)
        {
            //
            //Method Name : Employee(string id, string firstName, string lastName, string companyName) : base(id, firstName, lastName)
            //Purpose : To display the Employee information
            //Re-use : GetInfo()
            //Input Parameter : none
            //Output Type : string
            //              - the Employee information
            //
            this.CompanyName = companyName;
        } // end method
        public override string GetInfo()
        {
            //
            //Method Name : string GetInfo()
            //Purpose : To display the Employee information
            //Re-use : GetInfo()
            //Input Parameter : none
            //Output Type : string
            //              - the Employee information
            //
            return base.GetInfo()+"\nCompany: "+CompanyName;
        } // end method
        public override string ToString()
        {
            //
            //Method Name : string ToString()
            //Purpose : To display the Employee information
            //Re-use : GetInfo()
            //Input Parameter : none
            //Output Type : string
            //              - the Employee information
            //
            return GetInfo();
        } // end method
        public object Clone()
        {
            //
            //Method Name : object Clone()
            //Purpose : To create a perfect copy of an Employee object
            //Re-use : none()
            //Input Parameter : none
            //Output Type : object
            //              - the clone of Employee object
            //
            Employee newEmp = new Employee(this.ID,this.FirstName,this.LastName,this.CompanyName);
            return newEmp;
        } // end method
    } // end class
} //end namespace
