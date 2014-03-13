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
                cell2.Text = "R$ " + this.FormatValue(carne.PrecoUnitario, "#,##0.00");
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = this.FormatValue(carne.Quantidade, "#,##0.00") + " Kg";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = "R$ " + this.FormatValue(carne.PrecoFinal, "#,##0.00");
                row.Cells.Add(cell4);

                Table1.Rows.Add(row);
            }

            // Preenche o total
            TableRow finalRow = new TableRow();
            TableCell finalCell1 = new TableCell();
            finalCell1.Text = "Total de Carnes";
            finalRow.Cells.Add(finalCell1);

            // Coluna preco unitário
            TableCell finalCell2 = new TableCell();
            finalCell2.Text = "-";
            finalRow.Cells.Add(finalCell2);

            TableCell finalCell3 = new TableCell();
            finalCell3.Text = "-";
            finalRow.Cells.Add(finalCell3);

            TableCell finalCell4 = new TableCell();
            finalCell4.Text = "R$ " + this.FormatValue(ctrl.calculaPrecoFinalAlimento(listaCarnes), "#,##0.00");
            finalRow.Cells.Add(finalCell4);

            Table1.Rows.Add(finalRow);

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
                cell2.Text = "R$ " + this.FormatValue(bebida.PrecoUnitario, "#,##0.00");
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = this.FormatValue(bebida.Quantidade, "#,##0.00") + " litros";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = "R$ " + this.FormatValue(bebida.PrecoFinal, "#,##0.00");
                row.Cells.Add(cell4);

                Table2.Rows.Add(row);
            }

            // Preenche o total
            finalRow = new TableRow();
            finalCell1 = new TableCell();
            finalCell1.Text = "Total de Bebidas";
            finalRow.Cells.Add(finalCell1);

            // Coluna preco unitário
            finalCell2 = new TableCell();
            finalCell2.Text = "-";
            finalRow.Cells.Add(finalCell2);

            finalCell3 = new TableCell();
            finalCell3.Text = "-";
            finalRow.Cells.Add(finalCell3);

            finalCell4 = new TableCell();
            finalCell4.Text = "R$ " + this.FormatValue(ctrl.calculaPrecoFinalAlimento(listaBebidas), "#,##0.00");
            finalRow.Cells.Add(finalCell4);

            Table2.Rows.Add(finalRow);
        }

        public string FormatValue(object value, string format)
        {
            // verifica se o valor é um número decimal...
            decimal decimalValue;
            if (!decimal.TryParse(Convert.ToString(value), out decimalValue))
                return Convert.ToString(value); // se não for, retorna o string...
            else
                return decimalValue.ToString(format); // retorna o valor formatado...
        }
    }
}