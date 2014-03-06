using ChurrascoAgil.Utils;
using System;
using System.Web.UI.WebControls;
using ChurrascoAgil.Utils.Controller;

namespace ChurrascoAgil
{
    public partial class Resultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calculo ctrl = new Calculo();

            //ctrl.calcular();

            string homens = Request.Params["homens"];

            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = homens;
            row.Cells.Add(cell1);

            TableCell cell2 = new TableCell();
            cell2.Text = new HelloWorld().sayHello();
            row.Cells.Add(cell2);

            TableCell cell3 = new TableCell();
            cell3.Text = "Conteudo 3";
            row.Cells.Add(cell3);

            Table1.Rows.Add(row);
        }
    }
}