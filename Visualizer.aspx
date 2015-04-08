﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Visualizer.aspx.cs" Inherits="Visualizer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%@ PreviousPageType VirtualPath="~/index.aspx" %> 
    <link rel="stylesheet" type ="text/css" href ="Styles.css" />
    <script src ="Scripts\jquery-2.1.3.js"></script>
    <script src ="Scripts\PageScripts.js"></script>
    <!-- For drawing elements -->
    <script src ="Scripts\three.min.js"></script>
    <!-- For positional information from VR hardware -->
    <script src ="Scripts\VRControls.js"></script>
    <!-- Camera Rendering -->
    <script src ="Scripts\VREffect.js"></script>
    <!-- Device Polyfill for browser API -->
    <script src ="Scripts\webvr-polyfill.js"></script>
    <!-- VR enter/exit, consistency for webvr apps -->
    <script src="Scripts\webvr-manager.js"></script>
    <script>
        var string = JSON.stringify(<%=_graphJSON%>);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Go" OnClientClick="PaintCanvas(string); return false;"/>
        <br />
    </div>
        <asp:Label ID="test" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
