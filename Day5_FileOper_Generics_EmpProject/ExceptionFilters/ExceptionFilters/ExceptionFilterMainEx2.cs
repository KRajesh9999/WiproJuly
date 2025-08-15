using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    internal class ExceptionFilterMainEx2
    {
        static void RaiseSeverity(string severity)
        {
            if (severity.Equals("low"))
            {
                throw new FilterExceptionMethod("low severity you can leave for time being...");
            }
            else if (severity.Equals("medium"))
            {
                throw new FilterExceptionMethod("medium severity you need to try to fix without leaving...");
            }
            else if (severity.Equals("high"))
            {
                throw new FilterExceptionMethod("high severity You need to fix on high priority...");
            }
            else if (severity.Equals("critical"))
            {
                throw new FilterExceptionMethod("critical error as fix first as stop all other works...");
            }
            else
            {
                throw new FilterExceptionMethod("No Error Occurred...");
            }
        }
        static void Main()
        {
            string severity;
            Console.WriteLine("Enter the severity (low/medium/high/critical) ");
            severity = Console.ReadLine();

            try
            {
                RaiseSeverity(severity);
            }
            catch(FilterExceptionMethod e) when (e.Message.Contains("low"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExceptionMethod e) when (e.Message.Contains("medium"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExceptionMethod e) when (e.Message.Contains("high"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExceptionMethod e) when (e.Message.Contains("critical"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterExceptionMethod e)
            {
                Console.WriteLine(e.Message);
            }
            catch  (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
