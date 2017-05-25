using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DateAccess
{
   public  class Region
    {
       private SqlCommand cmd;

       public Region()
       {
           cmd = new SqlCommand();
           cmd.CommandType = CommandType.StoredProcedure;
       }
       /// <summary>
       /// 查询所有地区的歌手
       /// </summary>
       /// <param name="regionid"></param>
       /// <param name="regionName"></param>
       /// <returns></returns>
       public DataSet GetAllSinger(string regionid,string regionName)
       {
           cmd.CommandText = "GetAllSinger";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@RegionID", SqlDbType.Int).Value = regionid;
           cmd.Parameters.Add("@RegionName", SqlDbType.NVarChar, 50).Value = regionName;

           try
           {
               DataSet ds = DBAccess.QueryData(cmd);
               return ds;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
    }
}
