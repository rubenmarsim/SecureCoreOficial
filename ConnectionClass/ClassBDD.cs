using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace ConnectionClass
{
    public class ClassBDD
    {
       private string _ConnectionString;
        SqlConnection connexxion;
        /// <summary>
        /// GetConnexionString
        /// </summary>
        public void  GetConnexionString(){
           _ConnectionString = ConfigurationManager.ConnectionStrings["Splash.SecureCoreConnectionString"].ConnectionString;
        }
        /// <summary>
        /// ConnectBD
        /// </summary>
        public void ConnectBD() {
            GetConnexionString();
            connexxion = new SqlConnection(_ConnectionString);
            connexxion.Open();
        }
        /// <summary>
        /// PortaTaula
        /// </summary>
        /// <param name="nomTaula"></param>
        /// <returns>DataSet</returns>

        public DataSet PortaTaula(string nomTaula) {
            ConnectBD();
            string query = "SELECT * FROM "+nomTaula+"";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli, nomTaula);
            connexxion.Close();
            return dtsCli;
        }
        /// <summary>
        /// PortarPerID
        /// </summary>
        /// <param name="nomTaula"></param>
        /// <param name="nomCamp"></param>
        /// <param name="valor"></param>
        /// <returns>DataSet</returns>
        public DataSet PortarPerID(string nomTaula,string nomCamp,int valor)
        {
            ConnectBD();
            string query = "SELECT * FROM " + nomTaula+ " WHERE " + nomCamp + " = " + valor + "";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli, nomTaula);
            return dtsCli;
           
        }
        /// <summary>
        /// PortarPerID
        /// </summary>
        /// <param name="nomTaula"></param>
        /// <param name="valor"></param>
        /// <returns>DataSet</returns>
        public DataSet PortarPerID(string nomTaula, int valor)
        {
            ConnectBD();
            string queryTable = "SELECT * FROM " + nomTaula;
            SqlDataAdapter adapterTable = new SqlDataAdapter(queryTable, _ConnectionString);
            DataSet dtsTable = new DataSet();
            adapterTable.Fill(dtsTable, nomTaula);
            DataColumn[] columns;
            columns = dtsTable.Tables[nomTaula].PrimaryKey;

            string NomPK;
            int num = columns.Count();
            NomPK = columns[0].ColumnName;

            string query = "SELECT * FROM " + nomTaula + " WHERE " + NomPK + " = " + valor + "";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli, nomTaula);
            return dtsCli;

        }
        /// <summary>
        /// Executa
        /// </summary>
        /// <param name="consulta"></param>
        public void Executa(string consulta)
        {
            try
            {
                ConnectBD();
                SqlCommand comanda = new SqlCommand(consulta, connexxion);
                comanda.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally {
                connexxion.Close();

            }
        }
        /// <summary>
        /// Actualitzar
        /// </summary>
        /// <param name="dts"></param>
        /// <param name="consulta"></param>
        public void Actualitzar(DataSet dts, string consulta)
        {
            try
            {
                ConnectBD();
                SqlDataAdapter adapterDts = new SqlDataAdapter(consulta, _ConnectionString);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adapterDts);
                 
                adapterDts.Update(dts);
            }
            catch (SqlException)
            {

            }
            finally{
                connexxion.Close();

            }
        }
        /// <summary>
        /// PortaPerConsulta
        /// </summary>
        /// <param name="consultaSql"></param>
        /// <returns>DataSet</returns>
        public DataSet PortaPerConsulta(string consultaSql)
        {

            ConnectBD();
          
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli);
            return dtsCli;
        }
        /// <summary>
        /// ComprobarUser
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contra"></param>
        /// <returns>DataSet</returns>
        public DataSet ComprobarUser(string nombre, string contra) {

            ConnectBD();
            string query = "SELECT Users.*, UserCategories.DescCategory,UserCategories.AccessLevel FROM Users INNER JOIN UserCategories ON Users.idUserCategory = UserCategories.idUserCategory WHERE UserName='" + nombre+ "' AND Password ='"+contra +"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli);
            connexxion.Close();
            return dtsCli;
        }

        

    }
}
