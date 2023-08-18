<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson.aspx.cs" Inherits="SummerSchoolRegisterS.Lesson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçiniz" ></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci Id'si giriniz"></asp:Label>
            <asp:DropDownList ID="DropDownListStd" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ders Talebi Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
