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
        public static int UpdateHost(Host host)
        {
            return HostSer.UpdateHost(host);
        }
        public static Host Login(Host host)
        {
            return HostSer.Login(host);
        }
        public static int addHost(Host host)
        {
            return HostSer.addHost(host);
        }
        public static int deleteHost(Host host)
        {
            return HostSer.deleteHost(host);
        }
        public static List<Host> getAllHost()
        {
            return HostSer.getAllHost();
        }
        public static Host FindHostByModuleID(Host host)
        {
            return HostSer.FindHostByModuleID(host);
        }
        public static Host FindHostByHostName(Host host)
        {
            return HostSer.FindHostByHostName(host);
        }
    }
}
