<%@ Page Title="Bem vindo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Cadastro de Clientes</h1>
        <formview>
             <asp:Label ID="lblID" runat="server" Font-Size="Small" Text="ID:"></asp:Label>
             <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
             <asp:Label ID="lblNome" runat="server" Font-Size="Small" Text="Nome: "></asp:Label>
             <asp:TextBox ID="txtNome" runat="server" Width="30%"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNome" ErrorMessage="Nome é obrigatório" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
             <asp:Label ID="lblCPF" runat="server" Font-Size="Small" Text="CPF: "></asp:Label>
             <asp:TextBox ID="txtCPF" runat="server" Width="20%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCPF" ErrorMessage="CPF é obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCPF" ErrorMessage="Valor inválido para CPF" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{11}"></asp:RegularExpressionValidator>
            <br />
            <br />
             <asp:Label ID="lblRG" runat="server" Font-Size="Small" Text="RG: "></asp:Label>
             <asp:TextBox ID="txtRG" runat="server" Width="10%"></asp:TextBox>
             <asp:Label ID="lblDataExp" runat="server" Font-Size="Small" Text="Data Expedição: "></asp:Label>
             <asp:TextBox ID="txtDataExp" runat="server"></asp:TextBox>
             <asp:Label ID="lblOrgaoExp" runat="server" Font-Size="Small" Text="Órgão de Expedição:  "></asp:Label>
             <asp:TextBox ID="txtOrgaoExp" runat="server"></asp:TextBox>
             <asp:Label ID="lblUF" runat="server" Font-Size="Small" Text="UF Expedição: "></asp:Label>
             <asp:TextBox ID="txtUF" runat="server"></asp:TextBox>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtUF" ErrorMessage="UF Inválida" ForeColor="Red" ValidationExpression="[a-zA-Z]{2}"></asp:RegularExpressionValidator>
             <br />
             <br />
             


             <asp:Label ID="lblDataNasc" runat="server" Font-Size="Small" Text="Data de Nascimento: "></asp:Label>
             <asp:TextBox ID="txtDataNasc" runat="server" Width="10%"></asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDataNasc" ErrorMessage="Data de nascimento é obrigatória" ForeColor="Red"></asp:RequiredFieldValidator>

             <asp:Label ID="lblSexo" runat="server" Font-Size="Small" Text="Sexo: "></asp:Label>
             <asp:TextBox ID="txtSexo" runat="server" Width="10%"></asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSexo" ErrorMessage="Sexo obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>

             <asp:Label ID="lblEstado" runat="server" Font-Size="Small" Text="Estado Civil: "></asp:Label>
             <asp:TextBox ID="txtEstado" runat="server" Width="10%"></asp:TextBox>

             
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEstado" ErrorMessage="Estado civil obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>

             
             <br />
             <br />
             <h2>Endereço</h2>
            <br />
            <br />
             <asp:Label ID="lblCEP" runat="server" Font-Size="Small" Text="CEP: "></asp:Label>
             <asp:TextBox ID="txtCEP" runat="server" Width="10%"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCEP" ErrorMessage="CEP obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
             <asp:Label ID="lblLogradouro" runat="server" Font-Size="Small" Text="Logradouro: "></asp:Label>
             <asp:TextBox ID="txtLogradouro" runat="server" Width="30%"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtLogradouro" ErrorMessage="Logradouro obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
             <asp:Label ID="lblNumero" runat="server" Font-Size="Small" Text="Número: "></asp:Label>
             <asp:TextBox ID="txtNumero" runat="server" Width="5%"></asp:TextBox>
             
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtNumero" ErrorMessage="Número obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
             
            <br />
            <br />

            <asp:Label ID="lblComplemento" runat="server" Font-Size="Small" Text="Complemento: "></asp:Label>
            <asp:TextBox ID="txtComplemento" runat="server" Width="10%"></asp:TextBox>
            <asp:Label ID="lblBairro" runat="server" Font-Size="Small" Text="Bairro: "></asp:Label>
            <asp:TextBox ID="txtBairro" runat="server" Width="10%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtBairro" ErrorMessage="Bairro obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Label ID="lblCidade" runat="server" Font-Size="Small" Text="Cidade: "></asp:Label>
            <asp:TextBox ID="txtCidade" runat="server" Width="10%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtCidade" ErrorMessage="Cidade obrigatória" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Label ID="lblUFendereco" runat="server" Font-Size="Small" Text="UF: "></asp:Label>
            <asp:TextBox ID="txtUFendereco" runat="server" Width="10%"></asp:TextBox>
        </formview>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtUFendereco" ErrorMessage="UF obrigatória" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtUFendereco" ErrorMessage="UF Inválida" ForeColor="Red" ValidationExpression="[a-zA-Z]{2}"></asp:RegularExpressionValidator>
    <br />
    <br />
        <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />

        
        <asp:Button ID="btnAtualiza" runat="server" OnClick="btnAtualiza_Click" Text="Atualizar" />
        <asp:Button ID="btnDeletarCliente" runat="server" OnClick="btnDeletarCliente_Click" Text="Deletar" CausesValidation="False" />

        
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtDataNasc" ErrorMessage="Formato de data deve ser dd/MM/yyyy" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{2}/\d{2}/\d{4}"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtDataExp" ErrorMessage="Formato de data deve ser dd/MM/yyyy" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{2}/\d{2}/\d{4}"></asp:RegularExpressionValidator>

        
        <h2>Lista de Clientes:</h2>
        <asp:GridView ID="GridView1" runat="server" CellSpacing="3" CellPadding="2" ClientIDMode="Static">
            <AlternatingRowStyle BackColor="#C6F0FD" />
            <HeaderStyle Font-Bold="True" />
            </asp:GridView>
        
</asp:Content>

