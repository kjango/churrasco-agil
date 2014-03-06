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
        public List<Alimento> select(string tableName)
        {
            List<Alimento> listagem = new List<Alimento>();

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM item WHERE tipo = '" 
                + tableName + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Alimento a = new Alimento(
                    reader.GetString("nome"),
                    reader.GetFloat("precoUnitario"),
                    reader.GetString("tipo"),
                    reader.GetFloat("qtdeBase")
                    );

                listagem.Add(a);
            }

            con.Close();

            return listagem;
        }
    }
}