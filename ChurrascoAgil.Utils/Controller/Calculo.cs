using ChurrascoAgil.Utils.Dao;
namespace ChurrascoAgil.Utils.Controller
{
    public class Calculo
    {
        public void calcular()
        {
            AlimentoDao dao = AlimentoDao.getInstance();

            dao.select("carne");
        }
    }
}