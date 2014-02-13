using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Dao
{
    class CarneDao : Dao
    {
        private override void select()
        {
            base.con.Open();
            // fazer select
            base.con.Close();
        }
    }
}
