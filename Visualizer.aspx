﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Visualizer.aspx.cs" Inherits="Visualizer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src ="PageScripts.js"></script>
    <!-- For drawing elements -->
    <script src ="three.min.js"></script>
    <!-- For positional information from VR hardware -->
    <script src ="VRControls.js"></script>
    <!-- Camera Rendering -->
    <script src ="VREffect.js"></script>
    <!-- Device Polyfill for browser API -->
    <script src ="webvr-pollyfill.js"></script>
    <!-- VR enter/exit, consistency for webvr apps -->
    <script src="webvr-manager.js"></script>
    <script>
        var string = JSON.stringify(<%=_graphJSON%>);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Welcome to the Excel Digital Visualizer</h1><br />
            <asp:Label ID="Label1" runat="server" Text="Upload .xlsx file"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" />
        <br />
        <button onclick="alertFromJSON(string)">Click Me!</button>
    </div>
    </form>
</body>
</html>
