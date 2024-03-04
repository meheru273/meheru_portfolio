<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatetable.aspx.cs" Inherits="WebApplication3.updatetable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
      body{
          margin-top:100px;
      }
#form1 {
    max-width: 400px;
    margin: 30px auto;
    padding: 20px;
    background-color: #f9f9f9;
    border: 1px solid #ccc;
    border-radius: 5px;
}

label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
}

input[type="text"] {
    width: 100%;
    padding: 8px;
    margin-bottom: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
}

#btnUpdate {
    background-color: #8F74FF;
    color: white;
    padding: 10px 20px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    font-size: 16px;
}

/* Change button color on hover */
#btnUpdate:hover {
    background-color: #45a049;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label for="txtImage">Image:</label>
                <asp:TextBox ID="txtImage" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtHeader">Header:</label>
                <asp:TextBox ID="txtHeader" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtDescription">Description:</label>
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtLink">Link:</label>
                <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </div>
        </div>
    </form>
</body>
</html>
