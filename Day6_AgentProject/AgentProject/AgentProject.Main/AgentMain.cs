using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgentProject.Models;
using AgentProject.Exceptions;
using AgentProject.Bal;
using System.Collections.Concurrent;
using System.Net.Http.Headers;

namespace AgentProject.Main
{
    internal class AgentMain
    {
        static AgentBal agentBal;

        static AgentMain()
        {
            agentBal = new AgentBal();
        }

        public static void WriteFileMain()
        {
            Console.WriteLine(agentBal.WriteFileBal());
        }

        public static void ReadFileMain()
        {
            Console.WriteLine(agentBal.ReadFileBal());
        }

        public static void DeleteAgentMain()
        {
            int agentno;
            Console.WriteLine("Enter Agent number ");
            agentno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(agentBal.DeletAgentBal(agentno));
        }

        public static void UpdateAgentMain()
        {
            Agent agent = new Agent();
            
            //Console.WriteLine("Enter Agent Number  ");
            //agent.AgentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Name  ");
            agent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name:  ");
            agent.LastName = Console.ReadLine();

            Console.WriteLine("Enter Gender (MALE/FEMALE)   ");
            agent.Gender = Console.ReadLine();

            Console.WriteLine("Enter City:  ");
            agent.City = Console.ReadLine();

            Console.WriteLine("Enter Preminum Amount  ");
            agent.PremiumAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(agentBal.UpdateAgentBal(agent));
        }

        public static void SearchAgentMain()
        {
            int agentno;
            Console.WriteLine("Enter AgentId   ");
            agentno = Convert.ToInt32(Console.ReadLine());
            Agent agent = agentBal.SearchAgentBal(agentno);
            if (agent != null)
            {
                Console.WriteLine(agent);
            }
            else
            {
                Console.WriteLine("*** Agent Record Not Found ***");
            }
        }
        public static void ShowAgentMain()
        {
            List<Agent> employList = agentBal.ShowAgentBal();
            Console.WriteLine();
            Console.WriteLine("Agent Record Are ..");
            Console.WriteLine("-----------------------------");
            foreach (Agent agent in employList)
            {
                Console.WriteLine(agent);
            }
        }

        public static void AddAgentMain()
        {
            Agent agent = new Agent();

            //Console.WriteLine("Enter AgentId  ");
            //agent.AgentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Name  ");
            agent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name:  ");
            agent.LastName = Console.ReadLine();

            Console.WriteLine("Enter Gender (MALE/FEMALE)   ");
            agent.Gender = Console.ReadLine();

            Console.WriteLine("Enter City:  ");
            agent.City = Console.ReadLine();

            Console.WriteLine("Enter Preminum Amount  ");
            agent.PremiumAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(agentBal.AddAgentBal(agent));
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("O P T I O N S");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Add Agent");
                Console.WriteLine("2. Show Agent");
                Console.WriteLine("3. Search Agent");
                Console.WriteLine("4. Update Agent");
                Console.WriteLine("5. Delete Agent");
                Console.WriteLine("6. Write to File");
                Console.WriteLine("7. Read From File");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Enter Your Choice  ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddAgentMain();
                        }
                        catch (AgentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 2:
                        ShowAgentMain();
                        break;
                    case 3:
                        SearchAgentMain();
                        break;
                    case 4:
                        try
                        {
                            UpdateAgentMain();
                        }
                        catch (AgentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 5:
                        DeleteAgentMain();
                        break;
                    case 6:
                        WriteFileMain();
                        break;
                    case 7:
                        ReadFileMain();
                        break;
                    case 8:
                        return;
                }
            } while (choice != 8);

        }
    }
}

