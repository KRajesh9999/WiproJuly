using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgentProject.Models;
using AgentProject.Dao;
using AgentProject.Exceptions;

namespace AgentProject.Bal
{
    public class AgentBal
    {
        public StringBuilder sb = new StringBuilder();
        public static AgentDaoImpl daoImpl;

        static AgentBal()
        {
            daoImpl = new AgentDaoImpl();
        }

        public List<Agent> ShowAgentBal()
        {
            return daoImpl.ShowAgentDao();
        }

        public string WriteFileBal()
        {
            return daoImpl.WriteToFileDao();
        }

        public string ReadFileBal()
        {
            return daoImpl.ReadFromFileDao();
        }

        public string DeletAgentBal(int agentno)
        {
            return daoImpl.DeleteAgentDao(agentno);
        }

        public string UpdateAgentBal(Agent agentUpdated)
        {
            if(ValidateAgent(agentUpdated) == true)
            {
                return daoImpl.UpdateAgentDao(agentUpdated);
            }
            throw new AgentException(sb.ToString());
        }

        public Agent SearchAgentBal(int agentno)
        {
            return daoImpl.SearchAgentDao(agentno);
        }

        public string AddAgentBal(Agent agent)
        {
            if(ValidateAgent(agent) == true)
            {
                return daoImpl.AddAgentDao(agent);
            }
            throw new AgentException(sb.ToString());
        }

        public bool ValidateAgent(Agent agent)
        {
            bool flag = true;
            //if (agent.AgentId <= 0)
            //{
            //    sb.Append("Agent no connot be zero or negative...\n");
            //    flag = false;
            //}

            if (agent.FirstName.Length < 3)
            {
                sb.Append("First Name contains min. 3 characters....\n");
                flag = false;
            }
            if (agent.LastName.Length < 3)
            {
                sb.Append("Last Name contains min. 3 characters....\n");
                flag = false;
            }
            if (agent.PremiumAmount < 10000 || agent.PremiumAmount > 100000)
            {
                sb.Append("PreminumAmount must be between 10000 and 100000...\n");
                flag = false;
            }
            return flag;
        }
    }
}
