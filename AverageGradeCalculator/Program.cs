using System.Diagnostics;

namespace AverageGradeCalculator
{
    internal class Program
    {
        static void Main()
        {

            //new edit
            string temp, paper;
            int gradeYear1 = 0, gradeYear2 = 0, gradeYear3 = 0;
            double averageYear1 = 0, averageYear2 = 0, averageYear3 = 0;
            char gradeLetter = ' ';
            string[] papernamesYear1;
            string[] papernamesYear2;
            string[] papernamesYear3;

            //Initial display message
            Console.WriteLine("AVERAGE GRADE CALCULATOR");
            Console.WriteLine("by Samuel Batchelor");
            
            Thread.Sleep(3000);

            Console.Clear();

            //Ask user for 1st year paper grades

            for (int year = 1; year <= 3; year++)
            {

                //Ask user for number of papers they would like to enter:
                Console.Write($"Please enter the number of papers you would like to enter for Year {year}: ");
                temp = Console.ReadLine();
                int numberOfPapers = Convert.ToInt32(temp);


                //Loop for each paper in a year
                for (int i = 1; i <= numberOfPapers; i++)
                {

                    Console.Write($"Please specify the name of a Year {year} paper: ");
                    paper = Console.ReadLine();

                    Console.WriteLine("Please enter the grade you received for that paper: ");
                    temp = Console.ReadLine();
                    int grade = Convert.ToInt32(temp);

                    if ((grade >= 80) && (grade <= 100))
                    {
                        
                        gradeLetter = 'A';
                        Console.WriteLine($"You scored an {gradeLetter}");

                    }
                    else if ((grade >= 65) && (grade <= 79))
                    {

                        gradeLetter = 'B';
                        Console.WriteLine($"You scored a {gradeLetter}");

                    }
                    else if ((grade >= 50) && (grade <= 64))
                    {

                        gradeLetter = 'C';
                        Console.WriteLine($"You scored a {gradeLetter}");
                    }
                    else 
                    {

                        gradeLetter = 'D';
                        Console.WriteLine($"You scored a {gradeLetter}");
                        

                    }



                    //Add to Overall score for each individual year
                        switch (year)
                    {

                        case 1:
                            //Add to Grade year 1 score
                            gradeYear1 += grade;
                            averageYear1 = (double)gradeYear1 / numberOfPapers;
                            break;

                        case 2:
                            //Add to Grade year 2 score
                            gradeYear2 += grade;
                            averageYear2 = (double)gradeYear2 / numberOfPapers;
                            break;

                        case 3:
                            //Add to Grade Year 3 score
                            gradeYear3 += grade;
                            averageYear3 = (double)gradeYear3 / numberOfPapers;
                            break;

                    }

                }

                //Calculate average scores for each year
                switch (year)
                {

                    case 1:
                        Console.WriteLine($"Average Year {year} score is {averageYear1}");
                        Thread.Sleep(1500);
                        break;
                       

                    case 2:
                        Console.WriteLine($"Average Year {year} score is {averageYear2}");
                        Thread.Sleep(1500);
                        break;
                     

                    case 3:
                        Console.WriteLine($"Average Year {year} score is {averageYear3}");
                        Thread.Sleep(1500);
                        break;


                }
                
                

                }


            


            double sumOfYearmarks = averageYear1 + averageYear2 + averageYear3;
            double averageOverall = sumOfYearmarks / 3;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Your overall average score was {averageOverall}");
            if ((averageOverall >= 80) && (averageOverall <= 100))
            {

                gradeLetter = 'A';
                Console.WriteLine($"You scored an {gradeLetter} for your degree");
            }
            else if ((averageOverall >= 65) && (averageOverall <= 79))
            {

                gradeLetter = 'B';
                Console.WriteLine($"You scored a {gradeLetter} for your degree");
            }
            else if ((averageOverall >= 50) && (averageOverall <= 64))
            {

                gradeLetter = 'C';
                Console.WriteLine($"You scored a {gradeLetter} for your degree");
            }
            else
            {

                gradeLetter = 'D';
                Console.WriteLine($"You scored a {gradeLetter} for your degree");


            }

            Console.ReadLine();

















        }

    }



 }
