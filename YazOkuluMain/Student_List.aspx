<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Student_List.aspx.cs" Inherits="Student_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width: 95%;" class="table table-bordered table-hover table-striped">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>

        </tr>
        <tbody class="table-group-divider">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                
            <tr>
                <td><%#Eval("Id")%></td>
                <td><%#Eval("Name")%></td>
                <td><%#Eval("SurName")%></td>
                <td><%#Eval("Number")%></td>
                <td><%#Eval("Password")%></td>
                <td><%#Eval("Image")%></td>
                <td><%#Eval("Balance")%></td>
                <td>
                    <asp:HyperLink NavigateUrl='<%#"~/RemoveStudent.aspx?STDID=" + Eval("Id") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    <asp:HyperLink NavigateUrl='<%#"~/UpdateStudent.aspx?STDID=" + Eval("Id") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                </td>
            </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

