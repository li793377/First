using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
    public static class HostManager
    {
        public static int addHost(Host host)
        {
            return HostSer.addHost(host);
        }
        public static List<Host> getAllHost()
        {
            return HostSer.getAllHost();
        }
        public static Host FindHostByMouduleID(Host host)
        {
            return HostSer.FindHostByMouduleID(host);
        }
        public static Host FindHostByHostName(Host host)
        {
            return HostSer.FindHostByHostName(host);
        }
    }
}
