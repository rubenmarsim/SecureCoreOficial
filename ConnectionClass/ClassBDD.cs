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
    /// <summary>
    /// Clase que nos permite conectarnos a una base de datos, hacer
    /// consultas, etc...
    /// </summary>
    public class ClassBDD
    {
        /// <summary>
        /// String que contiene el ConnectionString
        /// </summary>
        private string _ConnectionString;
        /// <summary>
        /// Clase que vamos a usar para gestionar DB tipo SQl Server
        /// </summary>
        SqlConnection connexxion;
        /// <summary>
        /// Metodo que coje el ConnectionString y lo guarda en la variable _ConnectionString
        /// </summary>
        public void  GetConnexionString(){
           _ConnectionString = ConfigurationManager.ConnectionStrings["SecureCodeSplashScreen.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
        }
        /// <summary>
        /// Abre la conexion con la Base de datos
        /// </summary>
        public void ConnectBD() {
            GetConnexionString();
            connexxion = new SqlConnection(_ConnectionString);
            connexxion.Open();
        }
        /// <summary>
        /// Coje la tabla que indiquemos de la DB
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla que queremos obtener</param>
        /// <returns>Devuelve un dataset con la tabla que hemos indicado</returns>
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
        /// Trae una consulta mediante un ID
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla en la que queremos trabajar</param>
        /// <param name="nomCamp">Nombre del campo en el cual queremos trabajar</param>
        /// <param name="valor">valor del ID</param>
        /// <returns>Devuelve un dataset</returns>
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
        /// Trae una consulta mediante un ID
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla en la que queremos trabajar</param>
        /// <param name="valor">valor del ID</param>
        /// <returns>Devuelve un dataset</returns>
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
        /// Executa una Query sin devolver nada, muy util para deletes, inserts, etc...
        /// </summary>
        /// <param name="consulta">Consulta que queremos ejecutar, puede ser un insert, update, etc...</param>
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
        /// Compara la informacion que le pasamos en el dataset con la info de la DB y
        /// cambia en la DB lo que encuentra diferente en el dataset
        /// </summary>
        /// <param name="dts">Dataset con la informacion modificada</param>
        /// <param name="consulta">Consulta a la DB</param>
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
        /// Coger informacion mediante una consulta
        /// </summary>
        /// <param name="consultaSql">Consulta que va a definir la info que se va a mostrar</param>
        /// <returns>Devuelve un Dataset con la consulta hecha</returns>
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
        /// <param name="nombre">nombre del usuario</param>
        /// <param name="contra">contraseña del usuario</param>
        /// <returns>Devuelve un Dataset</returns>
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
