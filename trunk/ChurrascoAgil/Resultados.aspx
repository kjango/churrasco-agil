<%@ Page Title="Listagem do churrasco" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="ChurrascoAgil.Resultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center;">
    <h2>Passo 2</h2>
        <div class="well">A seguir a listagem de coisas que sugerimos para o seu churrasco. Sinta-se a vontade para fazer os seus ajustes!</div>
        </div>
    
    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">Carnes</div>
        <div class="panel-body">
            <p>Listagem de carnes necessárias para o churrasco</p>
        </div>
        <asp:Table ID="Table1" runat="server" CssClass="table">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Carne</asp:TableHeaderCell>
                <asp:TableHeaderCell>Preço/Kg</asp:TableHeaderCell>
                <asp:TableHeaderCell>Kg necessários</asp:TableHeaderCell>
                <asp:TableHeaderCell>Preço Final</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>

    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">Bebidas</div>
        <div class="panel-body">
            <p>Listagem de bebidas necessárias para o churrasco</p>
        </div>
        <asp:Table ID="Table2" runat="server" CssClass="table">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Bebida</asp:TableHeaderCell>
                <asp:TableHeaderCell>Preço/Kg</asp:TableHeaderCell>
                <asp:TableHeaderCell>Kg necessários</asp:TableHeaderCell>
                <asp:TableHeaderCell>Preço Final</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</asp:Content>