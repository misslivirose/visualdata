<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type ="text/css" href ="\Content\bootstrap.css" />
    <link rel="stylesheet" type ="text/css" href="\Content\bootstrap-theme.css" />
    <link rel="stylesheet" type="text/css" href="\Content\bootstrap-theme.css.map" />
    <script src="\Scripts\jquery-2.1.3.js"></script>
    <script src ="\Scripts\less-1.5.1.js"></script>
    <script src="\Scripts\bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h1> Welcome to the Excel Digital Visualizer</h1><br />
            <asp:Label ID="Label1" runat="server" Text="Upload .xlsx file"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
    </div>
        <p>
            <asp:Button ID="UploadButton" runat ="server" text ="Visualize" OnClick="UploadButton_Click" CssClass="btn-default"/>
        </p>
    </form>
</body>
</html>
