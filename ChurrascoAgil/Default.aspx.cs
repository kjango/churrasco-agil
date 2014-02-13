using System;
using System.Web.UI;

namespace ChurrascoAgil
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string homens = NumHomens.Text;
            string mulheres = NumMulheres.Text;
            string criancas = NumCriancas.Text;

            Response.Redirect("Resultados.aspx?homens=" + homens +
                "&mulheres=" + mulheres + "&criancas=" + criancas);
        }
    }
}