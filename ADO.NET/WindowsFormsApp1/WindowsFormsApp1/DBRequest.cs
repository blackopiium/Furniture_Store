using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public class DBRequest
    {

       
        private SqlConnection connection = new SqlConnection();
        public void ConnectTo(string DataSource, string InitialCatalog)
        {
            connection.ConnectionString = "Integrated Security=SSPI;"
                + "Data Source=" + DataSource + ";"
                + "Initial Catalog=" + InitialCatalog + ";";
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Disconnect()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch
            {

            }
        }
        public string GetTableFields(string TableName)
        {
            if (connection.State == ConnectionState.Open)
            {
                DataTable CurTable = new DataTable("ConnectedTab");
                SqlDataAdapter DBAdapt;
                try
                {
                    DBAdapt = new SqlDataAdapter("SELECT * FROM " + TableName, connection);
                    DBAdapt.Fill(CurTable);
                }
                catch (Exception e)
                {
                    throw e;
                }
                string ResStr = "";
                int ColCount = CurTable.Columns.Count;
                for (int i = 0; i < ColCount; i++)
                {
                    string StrCon = ", ";
                    if (i == ColCount - 1) StrCon = ";";
                    ResStr += CurTable.Columns[i].ColumnName + "[" + CurTable.Columns[i].DataType.Name + "]" + StrCon;
                }
                return ResStr;
            }

            else return null;
        }
        
       
        public DataTable SQLRequest(string RequestStr)
        {
            if (connection.State == ConnectionState.Open)
            {
                DataTable ResultTab = new DataTable("SQLresult");
                SqlDataAdapter DBAdapt;
                try
                {
                    DBAdapt = new SqlDataAdapter(RequestStr, connection);
                    DBAdapt.Fill(ResultTab);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return ResultTab;
            }
            else
                return null;
        }
    }


}

