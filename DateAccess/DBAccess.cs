using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DateAccess
{
   public  class DBAccess
    {
       /// <summary>
       /// 执行命令（insert,delete,update）,返回受影响的行数
       /// </summary>
       /// <param name="cmd"></param>
       /// <returns></returns>
       public static int ExecuteSQL(SqlCommand cmd)
       { 
       //创建连接对象
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SongConString"].ConnectionString);

           //创建命令对象（不需要，从参数中传入）
           cmd.Connection = conn;//新创建的链接对象，需要链接属性来链接

           try
           {
               //打开链接
               conn.Open();
               //执行命令
               int num = cmd.ExecuteNonQuery();
               return num;
           }
           catch (Exception ex)
           {

               throw new DBException(ex);//抛出新的异常
           }
           finally
           { 
           //关闭链接
               if (conn.State == ConnectionState.Open)
               {
                   conn.Close();
               }
           }
       }
       public static object GetScalar(SqlCommand cmd)
       { 
       //创建连接对象
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SongConString"].ConnectionString);

           //创建命令对象
           cmd.Connection = conn;//新创建的链接对象，需要链接属性来链接

           try
           {
               //打开链接
               conn.Open();
               //执行命令
               object date = cmd.ExecuteScalar();//返回一项数据（首行首列）
               return date;
           }
           catch (Exception ex)
           {

               throw new DBException(ex);
           }
           finally
           {
               //（5）关闭连接
               if (conn.State == ConnectionState.Open)
               {
                   conn.Close();
               }
           }
       }
       public static DataSet QueryData(SqlCommand cmd)
       {
           //创建连接
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SongConString"].ConnectionString);
           //创建命令对象
           cmd.Connection = conn;
           SqlDataAdapter ada = new SqlDataAdapter(cmd);
           DataSet ds = new DataSet();
           try
           {
               //打开链接 （不需要打开链接）
               //执行命令
               ada.Fill(ds);
               return ds;
           }
           catch (Exception ex)
           {

               throw new DBException(ex);
           }
           finally
           {
               //（5）关闭连接
               if (conn.State == ConnectionState.Open)
               {
                   conn.Close();
               }
           }
       }
    }
}
