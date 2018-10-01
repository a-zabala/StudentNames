using System;
using System.IO;

namespace StudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Reads the file  
            StreamReader file =
                new StreamReader(@"C:\Users\angekr\Documents\Visual Studio 2017\Projects\StudentNames\StudentNames\studentdata.txt");
            
            //Goes through the lines of data until no more lines
            while ((line = file.ReadLine()) != null)
            {
                //Creates a student object
                Student student = new Student();
               //The line would output each line read from the file
               // Console.WriteLine(line);
               //Counts how many students are in the file
                counter++;
                    //This determines how many grades the student has 
                    int grades = line.Split().Length - 1;
                    string[] studentInfo = line.Split();
                    
                    student.Name = studentInfo[0];
                    
                   //Outputs only students that have 6 or more grades
                   if  (grades >= 6)
                    {
                        
                        Console.WriteLine(student.Name + " has " + grades + " grades");
                    }
                
            }


            file.Close();
           Console.WriteLine("There were {0} students.", counter);
            // Suspend the screen.  
            Console.ReadLine();
        }
    }
}
