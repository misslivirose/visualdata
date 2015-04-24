<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Visualizer.aspx.cs" Inherits="Visualizer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%@ PreviousPageType VirtualPath="~/Default.aspx" %> 
    <link rel="stylesheet" type ="text/css" href ="\Content\Styles.css" />
    <script src ="Scripts\jquery-2.1.3.js"></script>
    <script src ="Scripts\PageScripts.js"></script>
    <!-- For drawing elements -->
    <script src ="Scripts\three.min.js"></script>
    <script src ="Scripts\CSS3DObject.js"></script>
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
        $(document).ready(function () { PaintCanvas(string) });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    </form>
</body>
</html>
