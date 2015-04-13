<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="\Content\bootstrap.css" />
    <script src="\Scripts\jquery-2.1.3.js"></script>
    <script src ="\Scripts\less-1.5.1.js"></script>
    <script src="\Scripts\bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class ="col-xs-12">
        <div class="col-md-6 col-md-offset-3">
            <h1 class="h1"> See your data in a whole new way</h1>
            <h4 class="h4">You can now experience your charts and spreadsheets in new ways with Three.JS and WebVR. Simply upload an Excel spreadsheet to get started, or browse one of the sample data sets. Move around inside your data, and experience scale like never before.<br /></h4>
            <asp:Label ID="Label1" runat="server" Text="Upload .xlsx file" CssClass="h4"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-input" /><br />
            <asp:Button ID="UploadButton" runat ="server" text ="Visualize" OnClick="UploadButton_Click" CssClass="btn"/>
        </div>
      </div>
    </form>
</body>
</html>
