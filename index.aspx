<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h1> Welcome to the Excel Digital Visualizer</h1><br />
            <asp:Label ID="Label1" runat="server" Text="Upload .xlsx file"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
    </div>
        <p>
            <asp:Button ID="UploadButton" runat ="server" text ="Visualize" OnClick="UploadButton_Click"/>
        </p>
    </form>
</body>
</html>
