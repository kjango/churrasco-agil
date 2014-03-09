using ChurrascoAgil.Utils;
using System;
using System.Web.UI.WebControls;
using ChurrascoAgil.Utils.Controller;
using ChurrascoAgil.Utils.Model;
using ChurrascoAgil.Utils.Dao;
using System.Collections.Generic;

namespace ChurrascoAgil
{
    public partial class Resultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Requisita os parâmetros
            int homens = Convert.ToInt32(Request.Params["homens"]);
            int mulheres = Convert.ToInt32(Request.Params["mulheres"]);
            int criancas = Convert.ToInt32(Request.Params["criancas"]);
            
            // Calcula
            Calculo ctrl = new Calculo();

            AlimentoDao dao = AlimentoDao.getInstance();

            // Carne
            List<Alimento> listaCarnes = dao.select("carne");

            double quantidadeTotalCarne = ctrl.calculaQuantidadeTotalCarne(homens, mulheres, criancas);

            listaCarnes = ctrl.calculaQuantidadeCarne(quantidadeTotalCarne, listaCarnes);

            // Preenche tabelas

            foreach (Alimento carne in listaCarnes)
            {
                // Coluna nome
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = carne.Nome;
                row.Cells.Add(cell1);
                
                // Coluna preco unitário
                TableCell cell2 = new TableCell();
                cell2.Text = "R$ " + Convert.ToString(carne.PrecoUnitario);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = Convert.ToString(carne.Quantidade + "Kg");
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = Convert.ToString("R$ " + carne.PrecoFinal);
                row.Cells.Add(cell4);

                Table1.Rows.Add(row);
            }

            // Bebida
            List<Alimento> listaBebidas = dao.select("bebida");

            double litrosTotalBebida = ctrl.calculaLitrosTotalBebida(homens, mulheres, criancas);

            listaBebidas = ctrl.calculaLitrosBebida(litrosTotalBebida, listaBebidas);

            foreach (Alimento bebida in listaBebidas) {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = bebida.Nome;
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString("R$" + bebida.PrecoUnitario + "/l");
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = Convert.ToString(bebida.Quantidade + " litros");
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = Convert.ToString("R$ " + bebida.PrecoFinal);
                row.Cells.Add(cell4);

                Table2.Rows.Add(row);
            }
        }
    }
}