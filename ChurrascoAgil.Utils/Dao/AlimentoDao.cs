using ChurrascoAgil.Utils.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ChurrascoAgil.Utils.Dao
{
    internal class AlimentoDao
    {
        private string connectionString = "server=localhost;user=root;" +
            "password=1234;database=churrascoagil";

        protected MySqlConnection con = null;

        private static AlimentoDao instance = null;

        private AlimentoDao()
        {
            con = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Retorna a instância de singleton
        /// </summary>
        /// <returns></returns>
        public static AlimentoDao getInstance()
        {
            if (instance == null)
            {
                instance = new AlimentoDao();
            }
            return instance;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public List<Alimento> select(string alimento)
        {
            List<Alimento> listagem = new List<Alimento>();

            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + alimento, con);

            con.Close();

            return listagem;
        }
    }
}