<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentUpdate.aspx.cs" Inherits="SummerSchoolRegisterS.StudentUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtId" runat="server" Text="Öğrenci Id" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtName" runat="server" Text="Öğrenci Adı" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtSurname" runat="server" Text="Öğrenci Soyadı" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:Label for="TxtNumber" runat="server" Text="Öğrenci Numarası" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:Label for="TxtImage" runat="server" Text="Öğrenci Fotoğrafı" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtImage" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:Label for="TxtPasword" runat="server" Text="Öğrenci Şifresi" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtPasword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Güncelle" OnClick="Button1_Click"  />

    </form>
</asp:Content>
