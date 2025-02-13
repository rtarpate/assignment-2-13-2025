using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_13_2025
{

    //insturctions:
    //create methods to perform tasks in the follwoing menu
    //add a student by input name
    //remove a student by input name
    //sort student list
    //display all students
    //exit
    internal class Program
    {
        //the data structure to store the student list
        static List<string> studnets = new List<string>(); //global list

        //method to process to add a studnet
        static void AddStudent()
        {
            Console.WriteLine("Enter a name to add to the list ");

            string name = Console.ReadLine();

            students.Add(name);

        }

        //method to process remove a studnet
        static void RemoveStudent()
        {
            Console.WriteLine("Enter a name of a student to be removed");
            string name = Console.ReadLine();
            if (students.Contains(name))
            {
                students.Remove(name);
                Console.WriteLine(name + " is removed from the list");
            }
            else
            {
                console.WriteLine(name + " is not on the list");
            }
        }

        //method to sort student
        static void SortStudent()
        {
            students.Sort();
            Console.WriteLine("Student list is sorted");
        }

        //method to display student
        static void DisplayStudent()
        {
            Console.WriteLine("Here is the list ");
            foreach (string student in students)
            {
                Console.WriteLine(" * " + student);

            }
        }



        static void Main(string[] args)
        {
            //declaratins:
            int selction = 0; //take usr input



            Console.WriteLine("Welcome to student management app");

            while (true) //repeat forever
            {

                Console.WriteLine("input a number to select an option below: \n" +
                    "1: add a student by input name  \n " +
                    "2: remove a student by name \n " +
                    "3: sort student list\n " +
                    "4: display all students\n " +
                    "5: exit ");
                int selection = Convert.ToInt32(Console.ReadLine()); // take user input

                switch (selection)
                {
                    case 1:
                        //process add a studnet
                        AddStudent();
                        break;
                    case 2:
                        //process remove a studnet
                        RemoveStudent();
                        break;
                    case 3:
                        //process sort all studnets
                        SortStudent();
                        break;
                    case 4:
                        //process display student list
                        DisplayStudent();
                        break;
                    case 5:
                        //process exit
                        return;

                    default:
                        //process add a studnet
                        Console.WriteLine("invalid option");
                        return;






                }
            }
        }

    }
}
