<%@ Page Title="Calcule seu churrasco!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChurrascoAgil._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align: center;">
        <h2>Passo 1</h2>
        <div class="well">Defina o número de homens, mulheres e crianças que estarão em seu churrasco.</div>
        <div>
            <table class="table">
                <tr>
                    <th>
                        <h4>Homens</h4>
                    </th>
                    <th>
                        <h4>Mulheres</h4>
                    </th>
                    <th>
                        <h4>Crianças</h4>
                    </th>
                    <th></th>
                </tr>
                <tr>
                    <td>
                        <div class="input-group input-group-sm">
                            <asp:TextBox CssClass="form-control" ID="NumHomens" runat="server" Width="72px"></asp:TextBox>
                        </div>
                    </td>
                    <td>
                        <div class="input-group input-group-sm">
                            <asp:TextBox CssClass="form-control" ID="NumMulheres" runat="server" Width="72px"></asp:TextBox>
                        </div>
                    </td>
                    <td>
                        <div class="input-group input-group-sm">
                            <asp:TextBox CssClass="form-control" ID="NumCriancas" runat="server" Width="72px"></asp:TextBox>
                        </div>
                    </td>
                    <td>
                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Próximo" OnClick="Button1_Click" Width="79px" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>