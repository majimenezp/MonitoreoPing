using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;

namespace MonitoreoPing
{
    public class EnvioPing
    {
        private string server;
        public EnvioPing(string servidor)
        {
            server = servidor;
        }

        public bool Ejecutar()
        {
            Ping envioping = new Ping();
            PingReply respuestaping;
            try
            {
                respuestaping = envioping.Send(server);
                if (respuestaping.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
