<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">

        <div class="form-group">

                 <div>
            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            <br />  
                 <div>
            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:" style="font-weight: 700"></asp:Label>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
    </div>       
            <br />  
             <div>
        <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numarası:" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
</div>
                    <br />  
             <div>
        <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifresi:" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
</div>
                    <br />  
             <div>
        <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğrafı:" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
</div>


        </div>






        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>

