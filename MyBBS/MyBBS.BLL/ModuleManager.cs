using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
 public static   class ModuleManager
    {
        public static Module FindModuleByID(Module module)
        {
            return ModuleSer.FindModuleByID(module);
        }
        public static List<Module> getAllModule()
        {
            return ModuleSer.getAllModule();
        }
        public static Module findModuleByModuleName(Module module)
        {
            return ModuleSer.findModuleByModuleName(module);
        }
    }
}
