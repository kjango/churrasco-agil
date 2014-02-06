<%@ Page Title="Calcule seu churrasco!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChurrascoAgil._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Participantes</h1>
        <table>
            <tr>
                <td>Homens</td>
                <td>Mulheres</td>
                <td>Crianças</td>
            </tr>
        </table>
    </div>

    <div>
        <div class="panel panel-default">
            <!-- Default panel contents -->
            <div class="panel-heading">Carnes</div>
            <div class="panel-body">
                <p>Relatório das Carnes</p>
            </div>

            <!-- Table -->
            <table class="table">
                <tr>
                    <th>Carne</th>
                    <th>Quantidade</th>
                    <th>Preço Un.</th>
                </tr>
                <tr>
                    <td>Picanha</td>
                    <td>Campo</td>
                    <td>R$ 14,90</td>
                </tr>
                <tr>
                    <td>Mignon</td>
                    <td>Campo</td>
                    <td>R$ 14,90</td>
                </tr>
                <tr>
                    <td>Linguiça</td>
                    <td>Campo</td>
                    <td>R$ 14,90</td>
                </tr>
                <tr>
                    <td>Frango</td>
                    <td>Campo</td>
                    <td>R$ 14,90</td>
                </tr>
            </table>
        </div>
        <div>

            <div class="panel panel-default">
                <!-- Default panel contents -->
                <div class="panel-heading">Bebidas</div>
                <div class="panel-body">
                    <p>Relatório das Bebidas</p>
                </div>
                <!-- Table -->
                <table class="table">
                    <tr>
                        <th>Bebidas</th>
                        <th>Litros</th>
                        <th>Preço Un.</th>
                    </tr>
                    <tr>
                        <td>Coca-cola</td>
                        <td>Campo</td>
                        <td>R$ 14,90</td>
                    </tr>
                    <tr>
                        <td>Cerveja</td>
                        <td>Campo</td>
                        <td>R$ 14,90</td>
                    </tr>
                    <tr>
                        <td>Água</td>
                        <td>Campo</td>
                        <td>R$ 14,90</td>
                    </tr>
                </table>
            </div>
        </div>
</asp:Content>