using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance; 

        public Student() //Constructor 
        {
            SoonerID = 0;
            FirstName = "";
            LastName = "";
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;

        }
        public Student(int id, string fName, string lName, double BursarBalance)//overload constructer
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }
        public void MakePayment(double amount )
        {
            if (amount<0)
            {
                Console.WriteLine("Amount must be postiive");
            }

            BursarBalance -= amount; //subtracting from the bursar account 
        }
        public double CheckBalance()
        {
            return BursarBalance;
        }
        public override string ToString()
        {
            return $"({LastName}, {FirstName} ({SoonerID.ToString("N0")})";
        }
    }
   
}
