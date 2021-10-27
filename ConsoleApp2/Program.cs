using System;
using System;
using System.Collections.Generic;
using System.Linq;
usingusing System.Threading;
 System.Text;
using SysteThre
   asks;

namespace ConsoleApp2
{

    interface WhoAmI
    {
        void Me();
    }

    public class EmployeeType : WhoAmI
    {

        string name;

        public void Me()
        {
            Console.WriteLine($"***{name}***");
        }

    }

    interface EmpAcc
    {
        void AccountDetails();
    }

    public class EmployeeAccount : EmpAcc
    {

        public int UId;

        public int AccountNumber;

        public void TakeDetails()
        {

            UId = Console.Read();

            AccountNumber = Console.Read();

        }


        public void AccountDetails()
        {

            Console.WriteLine($"User ID: {UId}");
            Console.WriteLine($"Acc No.: {AccountNumber}");
        }


    }
  

    interface EmpRole
    {


        public class messageBase
        {

            public void OnVideoEncoded(object source, EventArgs args)
            {
                Console.WriteLine("Sending a Text Message... ");
                Thread.Sleep(3000);
                Console.WriteLine("***DONE***");
            }
        }
        void EmployeeTypeDetails();
    }

    public class EmployeeRole : EmpRole
    {

        public string ERole;

        public string ETeam;

        public void EmployeeTypeDetails()
        {

            Console.WriteLine($"Emp Role : {ERole}");
            Console.WriteLine($"Emp Team : {ETeam}");
        }

    }

    public class Employee : EmployeeAccount, EmpRole, EmployeeType
    {


        public static int bonus = 1000;

        public static int SalaryCalculation(int num)
        {

            num += 10000;

            return num;

        }

        public void EmployeeTypeDetails()
        {
            throw new NotImplementedException();
        }

        //public void EmployeeTypeDetails()
        //{

        //}
    }


    public class Developer : Employee
    {

        public int DeveloperBaseSalary = 50000;

        //public int FinalSalary = Calc(DeveloperBaseSalary);

    }

    public class HR : Employee
    {

        public int baseSal = 40000;


    }
    class Program
    {
        static void Main(string[] args)
        {

            Developer dev = new Developer();

            //string name = dev.name;
        }
    }

}



