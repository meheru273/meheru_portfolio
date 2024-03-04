<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showtable.aspx.cs" Inherits="WebApplication3.showtable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styleshowtable.css">
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <asp:GridView ID="projectform" runat="server" AutoGenerateColumns="false" OnRowCommand="projectcommand" >
                <Columns>
                    <asp:BoundField DataField="projectimage" HeaderText="image" />
                    <asp:BoundField DataField="projecth3" HeaderText="header" />
                    <asp:BoundField DataField="projectp" HeaderText="discription" />
                    <asp:BoundField DataField="projecta" HeaderText="link" />

                   <asp:TemplateField HeaderText="actions">
                        <ItemTemplate>
                       <asp:LinkButton ID="updateLinkButton" CommandName="upd" CommandArgument='<%# Eval("projecth3") %>' runat="server">Update</asp:LinkButton>
                       <asp:LinkButton ID="deleteLinkButton" CommandName="del" CommandArgument='<%# Eval("projecth3") %>' runat="server">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField> 


                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
