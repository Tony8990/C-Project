<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Films.aspx.cs" Inherits="Films" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <asp:Repeater runat="server" ID="webFilmCollectionViewer">
    <ItemTemplate>
        <div>

            
           <asp:hyperlink id="linkToFilm" runat="server">
               <asp:label ID="Title" runat="server"></asp:label>
            </asp:hyperlink>
        </div>
    </ItemTemplate>    
    </asp:Repeater>

</asp:Content>

