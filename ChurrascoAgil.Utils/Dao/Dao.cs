using ChurrascoAgil.Utils.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Dao
{
    abstract class Dao
    {
        private string connectionString = "server=localhost;root id=root;password=1234;database=churrascoagil";
        protected MySqlConnection con = null;

        protected List<Alimento> listagem = null;
        private static Dao instance = null;

        private Dao()
        {
            con = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Retorna a instância de singleton
        /// </summary>
        /// <returns></returns>
        public static Dao getInstance() {
            if (instance == null) {
                instance = new Dao();
            }
            return instance;
        }

        /// <summary>
        /// Retorna a listagem de alimentos
        /// </summary>
        /// <returns></returns>
        public List<Alimento> getListagem()
        {
            if (listagem == null)
            {
                select();
            }

            return listagem;
        }

        /// <summary>
        /// Faz o select dos itens no banco de dados
        /// </summary>
        private abstract void select();
 
    }
}
