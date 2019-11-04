using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stu.DBHelper;
using MyBBS.Model;
using System.Data;
using System.Data.SqlClient;
namespace MyBBS.DAL
{
    public static class ModuleSer
    {
        public static Module FindModuleByID(Module module)
        {
            SqlParameter[] sp = {
                new SqlParameter("@moduleid", module.ModuleID),
            };
            string sql = "select * from tb_Module where 版块编号 like @moduleid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getModuleFromDataReader(dr);
        }
        public static Module findModuleByModuleName(Module module)
        {
            SqlParameter[] sp = {
                new SqlParameter("@modulename", module.ModuleName),
            };
            string sql = "select * from tb_Module where 版块名称 like @modulename";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getModuleFromDataReader(dr);
        }
        public static List <Module> getAllModule()
        {
            string sql = "select * from tb_Module ORDER BY 版块编号";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getListOfModuleFromDataReader(dr);
        }
        static Module getModuleFromDataReader(SqlDataReader dr)
        {
            Module module = new Module();
            while (dr.Read())
            {
                int moduleID = dr.GetOrdinal("版块编号");
                if (!dr.IsDBNull(moduleID))
                {
                    module.ModuleID = dr.GetString(moduleID);
                }
                int moduleName = dr.GetOrdinal("版块名称");
                if (!dr.IsDBNull(moduleName))
                {
                    module.ModuleName = dr.GetString(moduleName);
                }              
            }
            return module;
        }
        static List<Module> getListOfModuleFromDataReader(SqlDataReader dr)
        {
            List<Module> listOfModule = new List<Module>();
            while (dr.Read())
            {
                Module module = new Module();
                int moduleID = dr.GetOrdinal("版块编号");
                if (!dr.IsDBNull(moduleID))
                {
                    module.ModuleID = dr.GetString(moduleID);
                }
                int moduleName = dr.GetOrdinal("版块名称");
                if (!dr.IsDBNull(moduleName))
                {
                    module.ModuleName = dr.GetString(moduleName);
                }

                listOfModule.Add(module);
            }
            return listOfModule;
        }
    }
}
