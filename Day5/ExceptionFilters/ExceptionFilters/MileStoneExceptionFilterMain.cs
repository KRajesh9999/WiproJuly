using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    internal class MileStoneExceptionFilterMain
    {
        static void ShowMileStoneInfo(string examCode)
        {
            if (examCode.Equals("M1"))
            {
                throw new MileStoneExceptionMethod("MileStone1 Contains Core Concepts of .NET");
            }
            else if (examCode.Equals("M2"))
            {
                throw new MileStoneExceptionMethod("MileStone2 Contains Asp.net Rajor Core Concepts...");
            }
            else if (examCode.Equals("M3"))
            {
                throw new MileStoneExceptionMethod("MileStone3 Contains Advanced Core Concepts with Db...");
            }
            else if (examCode.Equals("M4"))
            {
                throw new MileStoneExceptionMethod("MileStone4 Contains Advanced React Framework  ");
            }
            else if (examCode.Equals("Project"))
            {
                throw new MileStoneExceptionMethod("Project Capstone to be Done Last...");
            }
            else
            {
                throw new MileStoneExceptionMethod("No Error Occurred...");
            }
        }
        static void Main()
        {
            string examCode;
            Console.WriteLine("Enter Exam Code (M1, M2, M3, M4, Project)  ");
            examCode = Console.ReadLine();
            try
            {
                ShowMileStoneInfo(examCode);
            }
            catch (MileStoneExceptionMethod e) when (e.Message.Contains("MileStone1"))
            {
                Console.WriteLine(e.Message);
            }
            catch (MileStoneExceptionMethod e) when (e.Message.Contains("MileStone2"))
            {
                Console.WriteLine(e.Message);
            }
            catch (MileStoneExceptionMethod e) when (e.Message.Contains("MileStone3"))
            {
                Console.WriteLine(e.Message);
            }
            catch (MileStoneExceptionMethod e) when (e.Message.Contains("MileStone4"))
            {
                Console.WriteLine(e.Message);
            }
            catch (MileStoneExceptionMethod e) when (e.Message.Contains("Project"))
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
