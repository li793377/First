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
        public static int addModule(Module module)
        {
            return ModuleSer.addModule(module);
        }
        public static int deleteModule(Module module)
        {
            return ModuleSer.deletemodule(module);
        }
        public static int updateModule(Module module)
        {
            return ModuleSer.updateModule(module);
        }
        public static string getMaxModuleID()
        {
            return ModuleSer.getMaxModuleID();
        }
        public static Module FindModuleByID(Module module)
        {
            return ModuleSer.FindModuleByID(module);
        }
        public static List<Module> getAllModule()
        {
            return ModuleSer.getAllModule();
        }
        public static List<Module> getModuleByIDName(Module module)
        {
            return ModuleSer.getModuleByIDName(module);
        }
        public static Module findModuleByName(Module module)
        {
            return ModuleSer.findModuleByName(module);
        }
    }
}
