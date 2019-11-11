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
        public static int deletemodule(Module module)
        {
            SqlParameter[] sp =
            {
                new SqlParameter ("@moduleid",module.ModuleID),
            };
            string sql = "delete from tb_module where 版块编号=@moduleid";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static int addModule(Module module)
        {
            SqlParameter[] sp = new SqlParameter[]
         {
                new SqlParameter("@moduleid",module.ModuleID),
                new SqlParameter("@modulename",module.ModuleName),
        };
            string sql = "insert into tb_module values( @moduleid,@modulename)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static string getMaxModuleID()
        {
            string sql = "select top 1 * from tb_module order by 板块编号";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getModuleFromDataReader(dr).ModuleID;
        }
        public static int updateModule(Module module)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@moduleid",module.ModuleID),
                new SqlParameter("@modulename",module.ModuleName),
            };
            string sql = "update tb_Module set 版块名称=@modulename where 版块编号=@moduleid";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static Module FindModuleByID(Module module)
        {
            SqlParameter[] sp = {
                new SqlParameter("@moduleid", module.ModuleID),
            };
            string sql = "select * from tb_Module where 版块编号 like @moduleid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getModuleFromDataReader(dr);
        }
        public static Module findModuleByName(Module module)
        {
            SqlParameter[] sp = {
                new SqlParameter("@modulename", module.ModuleName),
            };
            string sql = "select * from tb_Module where 版块名称 like @modulename";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getModuleFromDataReader(dr);
        }
        public static List<Module> getModuleByIDName(Module module)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@modulename",module.ModuleName),
                new SqlParameter("@moduleid",module.ModuleID),
            };
            string sql = "select * from tb_module where (版块名称 like @modulename or 版块编号 like @moduleid)";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getListOfModuleFromDataReader(dr);
        }
        public static List<Module> getAllModule()
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
