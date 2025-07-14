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
using static System.Console;

namespace S1P1
{
    public class Program
    {
        static List<Employee> empList;
        static Dictionary<string, Student> studDictionary;

        private static Employee FindEmployee(string id)
        {
            //
            //Method Name : Employee FindEmployee(string id)
            //Purpose : Search for Employee in empList
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            int indexFound = -1;
            int count = 0;
            while (count<empList.Count && indexFound==-1) 
            {
                if (empList[count].ID==id)
                {
                    indexFound= count;

                } //end if
                count++;
            } //end while
            return indexFound!=-1 ? empList[indexFound] : null;
        } //end method
        private static Student FindStudent(string id)
        {
            //
            //Method Name : Student FindStudent(string id)
            //Purpose : Search for Student in studDictionary
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            bool indexFlag = false;
            indexFlag = studDictionary.ContainsKey(id);

            return indexFlag != false ? studDictionary[id] : null;
        } //end method
        private static void Main(string[] args)
        {
            //
            //Method Name : void Main(string[] args)
            //Purpose : Main entry into program
            //Re-use : Initialise(); ShowMainMenu();
            // ProcessEmployeeMenu(); ProcessStudentMenu();
            //Input Parameter : string[] args
            // - command line args - not used
            //Output Type : none
            //
            char choice = '0';
            ConsoleKeyInfo cki;
            try
            {
                Initialise();
                WriteLine();
                ShowMainMenu();
                cki = ReadKey();
                WriteLine();
                choice = cki.KeyChar;
                while (choice != 'x' && choice != 'X')
                {
                    switch (choice)
                    {
                        case '1': ProcessEmployeeMenu();
                            break;
                        case '2': ProcessStudentMenu();
                            break;
                        case 'x':
                        case 'X':
                            break;
                        default:
                            WriteLine("Invalid input");
                            break;
                    } // end switch
                    WriteLine();
                    ShowMainMenu();
                    cki = ReadKey();
                    WriteLine();
                    choice = cki.KeyChar;
                } // end while
            } // end try
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            } // end catch
        } // end method

        private static void Initialise()
        {
            //
            //Method Name : void Initialise()
            //Purpose : Initialise and instantiate global variables
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            empList = new List<Employee>();
            studDictionary = new Dictionary<string, Student>();
        } // end method

       // Display menus
        public static void ShowMainMenu()
        {
            //
            //Method Name : void ShowMainMenu()
            //Purpose : Display the main menu
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            WriteLine();
            WriteLine("Please select an option:");
            WriteLine("========================");
            WriteLine("1. Employee Maintenance");
            WriteLine("2. Student Maintenance");
            WriteLine("X. Exit");
            WriteLine();
        } // end method ShowMainMenu()
        public static void ShowEmployeeMaint()
        {
            //
            //Method Name : void ShowEmployeeMaint()
            //Purpose : Display the Employee Maintenance menu
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            WriteLine();
            WriteLine("Employee Maintenance: Please select an option:");
            WriteLine("==============================================");
            WriteLine("1. List Employees");
            WriteLine("2. Add Employee");
            WriteLine("3. Remove Employee");
            WriteLine("4. Update Employee");
            WriteLine("R. Return");
            WriteLine();
        } // end method ShowEmployeeMaint()
        public static void ShowStudentMaint()
        {
            //
            //Method Name : void ShowStudentMaint()
            //Purpose : Display the Student Maintenance menu
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            WriteLine();
            WriteLine("Student Maintenance: Please select an option:");
            WriteLine("=============================================");
            WriteLine("1. List Students");
            WriteLine("2. Add Student");
            WriteLine("3. Remove Student");
            WriteLine("4. Update Student");
            WriteLine("R. Return");
            WriteLine();
        } // end method ShowStudentMaint()
        // Employee 
        public static void ProcessEmployeeMenu()
        {
            //
            //Method Name : void ProcessEmployeeMenu()
            //Purpose : Invoke appropriate method to handle user menu selection
            //Re-use : ShowEmployeeMaint();EmployeeList();EmployeeAdd();EmployeeRemove();
            // EmployeeUpdate()
            //Input Parameter : none
            //Output Type : none
            //
            char choice = '0';
            ConsoleKeyInfo cki;

            ShowEmployeeMaint();
            cki = ReadKey();
            WriteLine();
            choice = cki.KeyChar;
            while (choice != 'R'&&choice!='r')
            {
                switch (choice)
                {
                    case '1':
                        EmployeeList();
                        break;
                    case '2':
                        EmployeeAdd();
                        break;
                    case '3':
                        EmployeeRemove();
                        break;
                    case '4':
                        EmployeeUpdate();
                        break;
                    case 'r':
                    case 'R':
                        break;
                    default:
                        WriteLine("Invalid input");
                        break;
                } // end switch
                WriteLine();
                ShowEmployeeMaint();
                cki = ReadKey();
                WriteLine();
                choice = cki.KeyChar;
            } //end while
        } // end method
        public static void EmployeeAdd()
        {
            //
            //Method Name : void EmployeeAdd()
            //Purpose : Get new Employee info and try to add it to list
            //Re-use : FindEmployee()
            //Input Parameter : none
            //Output Type : none
            //
            string id, firstName, lastName, companyName,street,city;

            WriteLine("Please supply the following employee info:");
            Write("ID: ");
            id = ReadLine().ToUpper();
            if (FindEmployee(id) == null)
            {
                Write("First name: ");
                firstName = ReadLine();
                Write("Last name: ");
                lastName = ReadLine();
                Write("Street: ");
                street = ReadLine();
                Write("City: ");
                city = ReadLine();
                Write("Company name: ");
                companyName = ReadLine();
                Employee employee = new Employee(id, firstName, lastName, companyName)
                {
                    HomeAddress = new Address
                    {
                        Street = street,
                        City = city
                    } // end
                };
                empList.Add(employee);
                WriteLine("{0} added",id);
            } // end if
            else
            {
                WriteLine("{0} NOT added since already in the list",id);
            } // end else
            

        } // end method
        public static void EmployeeList()
        {
            //
            //Method Name : void EmployeeList()
            //Purpose : Display/List the Employee records in the list
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            if (empList.Count > 0)
            {
                foreach (Employee details in empList)
                {
                    WriteLine(details);
                } // end foreach
            } // end if
            else
            {
                WriteLine("No Employee records found");
            } // end else
        } // end method
        public static void EmployeeRemove()
        {
            //
            //Method Name : void EmployeeRemove()
            //Purpose : Try to remove a Employee record from the list
            //Re-use : FindEmployee()
            //Input Parameter : none
            //Output Type : none
            //
            string id = "";
            if (empList.Count > 0)
            {
                Write("Please enter the employee ID: ");
                id = ReadLine().ToUpper();
                if (FindEmployee(id) != null)
                {
                    empList.Remove(FindEmployee(id));
                    WriteLine("{0} removed from list",id);
                } // end if
                else
                {
                    WriteLine("{0} NOT removed since it is not in the list",id);
                }
              
            } // end if
            else
            {
                WriteLine("No employee records to remove from the list");
            } // end else
        } // end method
        public static void EmployeeUpdate()
        {
            //
            //Method Name : void EmployeeUpdate()
            //Purpose : Update existing employee info
            //Re-use : FindEmployee()
            //Input Parameter : none
            //Output Type : none
            //
            string id, firstName, lastName, companyName, street, city;
            if (empList.Count > 0)
            {
                Write("Please enter the employee ID: ");
                id = ReadLine().ToUpper();
                if (FindEmployee(id) != null)
                {
                    Write("New first name or press enter not to change: ");
                    firstName = ReadLine();
                    if (firstName.Length > 0)
                    {
                        FindEmployee(id).FirstName = firstName;
                    } //end if
                    Write("New last name or press enter not to change: ");
                    lastName = ReadLine();
                    if (lastName.Length > 0)
                    {
                        FindEmployee(id).LastName = lastName;
                    } // end if
                    Write("New street or press enter not to change: ");
                    street = ReadLine();
                    if (street.Length > 0)
                    {
                        FindEmployee(id).HomeAddress.Street = street;
                    } //end if
                    Write("New city or press enter not to change: ");
                    city = ReadLine();
                    if (city.Length > 0)
                    {
                        FindEmployee(id).HomeAddress.City = city;
                    } // end if
                    Write("New company name or press enter not change: ");
                    companyName = ReadLine();
                    if (companyName.Length > 0)
                    {
                        FindEmployee(id).CompanyName = companyName;
                    } // end if
                    WriteLine("{0} updated", id);
                } // end if
                else 
                {
                    WriteLine("{0} NOT updated since it is not in the list",id);
                } // end else
            } //end if
            else
            {
                WriteLine("No employee records to update in the list");
            } // end else
        } // end method
        // Student 
        public static void ProcessStudentMenu()
        {
            //
            //Method Name : void ProcessStudentMenu()
            //Purpose : Invoke appropriate method to handle user menu selection
            //Re-use : ShowStudentMaint();StudentList();StudentAdd();StudentRemove();
            // StudentUpdate()
            //Input Parameter : none
            //Output Type : none
            //
            char choice = '0';
            ConsoleKeyInfo cki;

            ShowStudentMaint();
            cki = ReadKey();
            WriteLine();
            choice = cki.KeyChar;
            while (choice != 'R' && choice != 'r')
            {
                switch (choice)
                {
                    case '1':
                        StudentList();
                        break;
                    case '2':
                        StudentAdd();
                        break;
                    case '3':
                        StudentRemove();
                        break;
                    case '4':
                        StudentUpdate();
                        break;
                    case 'r':
                    case 'R':
                        break;
                    default:
                        WriteLine("Invalid input");
                        break;
                } // end switch
                WriteLine();
                ShowStudentMaint();
                cki = ReadKey();
                WriteLine();
                choice = cki.KeyChar;
            } // end while
        } // end method
        public static void StudentAdd()
        {
            //
            //Method Name : void StudentAdd()
            //Purpose : Get new Student info and try to add it to dictionary
            //Re-use : FindStudent()
            //Input Parameter : none
            //Output Type : none
            //
            string id, firstName, lastName, schoolName, street, city;

            WriteLine("Please supply the employee info:");
            Write("ID: ");
            id = ReadLine().ToUpper();
    
            if (FindStudent(id) == null)
            {
                Write("First name: ");
                firstName = ReadLine();
                Write("Last name: ");
                lastName = ReadLine();
                Write("Street: ");
                street = ReadLine();
                Write("City: ");
                city = ReadLine();
                Write("School name: ");
                schoolName = ReadLine();

                Student newStud = new Student(id, firstName, lastName, schoolName)
                {
                    HomeAddress =new Address
                    {
                        Street=street,
                        City=city
                    } // end 
                }; // end
                studDictionary.Add(id, newStud);
                WriteLine("{0} added",id);
            } // end if
            else
            {
                WriteLine("{0} NOT added since already in the list", id);
            } // end else
        } // end method
        public static void StudentList()
        {
            //
            //Method Name : void StudentList()
            //Purpose : Display the Student records in the dictionary
            //Re-use : none
            //Input Parameter : none
            //Output Type : none
            //
            if (studDictionary.Count > 0)
            {
                foreach(Student detail in studDictionary.Values)
                {
                    WriteLine(detail.GetInfo());
                } //end foreach
            } // end if
            else
            {
                WriteLine("No Student records found");
            } // end else

        } // end method
        public static void StudentRemove()
        {
            //
            //Method Name : void StudentRemove()
            //Purpose : Try to remove a Student record from the dictionary
            //Re-use : FindStudent()
            //Input Parameter : none
            //Output Type : none
            //
            string id;
            
            if (studDictionary.Count > 0)
            {
                Write("Please enter the student ID: ");
                id = ReadLine().ToUpper();
                if (FindStudent(id) != null)
                {
                    studDictionary.Remove(id);
                    WriteLine("{0} removed from list", id);
                } // end if
                else
                {
                    WriteLine("{0} NOT removed since it is not in the list",id);
                } // end else
            } //end if
            else
            {
                WriteLine("No student records to remove from the list");
            } // end else
        } // end method
        public static void StudentUpdate()
        {
            //
            //Method Name : void StudentUpdate()
            //Purpose : Update existing student info
            //Re-use : FindStudent()
            //Input Parameter : none
            //Output Type : none
            //
            string id, firstName, lastName, schoolName, street, city;
            if (studDictionary.Count > 0)
            {
                Write("Please enter the student ID: ");
                id = ReadLine().ToUpper();
                if(FindStudent(id)!=null)
                {
                    Write("New first name or press enter not to change: ");
                    firstName = ReadLine();
                    if (firstName.Length > 0)
                    {
                        FindStudent(id).FirstName = firstName;
                    } //end if
                    Write("New last name or press enter not to change: ");
                    lastName = ReadLine();
                    if (lastName.Length > 0)
                    {
                        FindStudent(id).LastName = lastName;
                    } //end if
                    Write("New street or press enter not to change: ");
                    street = ReadLine();
                    if (street.Length > 0)
                    {
                        FindStudent(id).HomeAddress.Street = street;
                    } //end if
                    Write("New city or press enter not to change: ");
                    city = ReadLine();
                    if (city.Length > 0)
                    {
                        FindStudent(id).HomeAddress.City = city;
                    } // end if
                    Write("New school name or press enter not change: ");
                    schoolName = ReadLine();
                    if (schoolName.Length > 0)
                    {
                        FindStudent(id).SchoolName = schoolName;
                    } //end if
                    WriteLine("{0} updated", id);
                } //end if
                else
                {
                    WriteLine("{0} NOT updated since it is not in the list",id);
                } // end else
            } //end if
            else
            {
                WriteLine("No student records to update in the list");
            } //end else
        } // end method
    } // end class
} //end namespace
