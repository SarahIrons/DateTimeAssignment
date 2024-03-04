using System;
//DATE / TIME ASSIGNMENT

//  Perform these actions and create a console app that includes the following:


//Prints the current date and time to the console.

//Asks the user for a number.

//Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
namespace DateTimeAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            DateTime today = DateTime.Now; // set datetime to "now"
            string userInput = Console.ReadLine(); //get input number from user
             int inputNum = Convert.ToInt32(userInput);//convert string to integer
            DateTime newDate2 = today.AddHours(inputNum); // use datetime function to add hours to the given current time.
            Console.WriteLine("In " + inputNum + " hours, it will be " +
            newDate2) ; //display back to the user what the exact time will be in a x # of hours from now.
        }
    }
}
