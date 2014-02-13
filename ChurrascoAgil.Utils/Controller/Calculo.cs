using ChurrascoAgil.Utils.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Controller
{
    public class Calculo
    {
        public void calcular()
        {
            AlimentoDao dao = AlimentoDao.getInstance();

            dao.select("teste");

        }
    }
}
