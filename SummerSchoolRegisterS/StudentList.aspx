<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerSchoolRegisterS.StudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>Öğrenci Id</th>
                <th>Öğrenci Adı</th>
                <th>Öğrenci Soyadı</th>
                <th>Öğrenci Numarası</th>
                <th>Öğrenci Şifre</th>
                <th>Öğrenci Fotoğraf</th>
                <th>Öğrenci Bakiye</th>
                <th>İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    
                    <tr>
                        <td><%#Eval("Id")%></td>
                        <td><%#Eval("Name")%></td>
                        <td><%#Eval("Surname")%></td>
                        <td><%#Eval("Number")%></td>
                        <td><%#Eval("Password")%></td>
                        <td><%#Eval("Image")%></td>
                        <td><%#Eval("Balance")%></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"StudentDelete.aspx?ogrId="+Eval("Id")%>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"StudentUpdate.aspx?ogrId="+Eval("Id")%>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>

                        </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
</asp:Content>
