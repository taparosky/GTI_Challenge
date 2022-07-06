<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirCliente.aspx.cs" Inherits="WebFormsApp.InserirCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="addAlunoForm"
    ItemType="Escola_Macoratti.Macoratti.Models.Aluno" 
    InsertMethod="addAlunoForm_InsertItem" DefaultMode="Insert"
    RenderOuterTable="false" OnItemInserted="addAlunoForm_ItemInserted">
    <InsertItemTemplate>
        <fieldset>
            <ol>
                <asp:DynamicEntity runat="server" Mode="Insert" />
            </ol>
            <asp:Button runat="server" Text="Inserir" CommandName="Insert" />
            <asp:Button runat="server" Text="Cancelar" CausesValidation="false" OnClick="cancelButton_Click" />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
</asp:Content>
