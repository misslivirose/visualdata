﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Visualizer.aspx.cs" Inherits="Visualizer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src ="PageScripts.js"></script>
    <script>
        var string = JSON.stringify(<%=_graphJSON%>);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Welcome to the Excel Digital Visualizer</h1><br />
            <asp:Label ID="Label1" runat="server" Text="Upload .xlsx file"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <button onclick="alertFromJSON(string)">Click Me!</button>
    </div>
    </form>
</body>
</html>
