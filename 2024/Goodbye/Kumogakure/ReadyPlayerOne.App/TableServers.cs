using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyPlayerOne.App
{
    public class TableServers
    {
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        public TableServers()
        {
            servers.Add("Iveta Cleo");
            servers.Add("Evelyn Alzbeta");
            servers.Add("Alexander Lamar");
            servers.Add("Destine Nicole");
            servers.Add("Ahmed Omar");
            /*
             * servers.Add("Server 4");
            servers.Add("Server 5");
            servers.Add("Server 6");
            servers.Add("Server 7");
            servers.Add("Server 8");
            servers.Add("Server 9");
            servers.Add("Server 10");
            */
        }

        public string GetNextServer()
        {
            if (servers.Count == 0)
            {
                return "No servers available";
            }
            string serverName = servers[nextServer];

            nextServer++;
            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            //nextServer = (nextServer + 1) % servers.Count;  
            
            return serverName;
        }   
    }
}
