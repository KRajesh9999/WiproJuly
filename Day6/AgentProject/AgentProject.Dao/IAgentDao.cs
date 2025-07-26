using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgentProject.Models;

namespace AgentProject.Dao
{
    internal interface IAgentDao
    {
        string AddAgentDao(Agent agent);
        List<Agent> ShowAgentDao();
        Agent SearchAgentDao(int agentno);

        string UpdateAgentDao(Agent agentUpdated);
        string DeleteAgentDao(int agentno);
        string WriteToFileDao();
        string ReadFromFileDao();

        int GenerateAgentNo();
    }
}
