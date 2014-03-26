using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace ClassAndList
{
    public class DatabaseConnection
    {
        string strConnectionString;
        OracleConnection oracleConnection;
        OracleCommand oracleCommand = new OracleCommand();
        string query;
        OracleDataReader oracleReader;
        OracleDataAdapter oracleDataAdapter;
        OracleCommandBuilder oracleCommandBuilder;
        DataTable dataTable;

        public DatabaseConnection()
        {
            strConnectionString = "DATA SOURCE =dilbert.humber.ca:1521/grok; USER ID =n01011747; PASSWORD= oracle;";
            oracleConnection = new OracleConnection(strConnectionString);
            oracleCommand.Connection = oracleConnection;
        }
        public void OpenConnection(string Query)
        {
            try
            {
                this.query = Query;
                oracleCommand.CommandText = query;
                oracleConnection.Open();
                oracleReader = oracleCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void CloseConnection()
        {
            oracleConnection.Close();
        }

        public DataTable View()
        {
            try
            {
                oracleDataAdapter = new OracleDataAdapter(oracleCommand);
                oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);

                dataTable = new DataTable();
                oracleDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        //public List<string> getDataColour()
        //{
        //    List<string> temp = new List<string>();

        //    oracleDataAdapter = new OracleDataAdapter(oracleCommand);
        //    oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);

        //    dataTable = new DataTable();
        //    oracleDataAdapter.Fill(dataTable);

        //    while (oracleReader.Read())
        //    {
        //        temp.Add(oracleReader["Color"].ToString());
        //    }

        //    return temp;
        //}

        //public List<string> getDataManu()
        //{
        //    List<string> temp = new List<string>();

        //    oracleDataAdapter = new OracleDataAdapter(oracleCommand);
        //    oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);

        //    dataTable = new DataTable();
        //    oracleDataAdapter.Fill(dataTable);

        //    while (oracleReader.Read())
        //    {
        //        temp.Add(oracleReader["Manufacturer"].ToString());
        //    }

        //    return temp;
        //}


    }
}
