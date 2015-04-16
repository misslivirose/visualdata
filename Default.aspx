<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300' rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="\Content\bootstrap.css" />
    <link rel="stylesheet" href="\Content\Styles.css" />
    <script src="\Scripts\jquery-2.1.3.js"></script>
    <script src="\Scripts\bootstrap.js"></script>
    <script src="\Scripts\PageScripts.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <div class="collapse navbar-collapse">
                        <ul class="nav navbar-nav ">
                            <li><a href="http://virtualinfinity.io"><b>Meet the Developer</b></a></li>

                            <!-- <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"> Examples <span class="caret"></span></a>
                                <ul class="dropdown-menu" role="menu">
                                    <li><a href="#">Cost of Living</a></li>
                                    <li><a href="#">% Women Employees</a></li>
                                </ul>
                            </li> -->
                        </ul>
                    </div>
                </div>
            </div>
        </nav>

        <div class="col-xs-12">
            <div class="col-md-6 text-justify">
                <br />
                <br />
                <h1 class="h1">See your data in a whole new way</h1>
                <h4 class="h4">You can now experience your charts and spreadsheets in new ways with Three.JS and WebVR. Simply upload an Excel spreadsheet to get started, or browse one of the sample data sets. Move around inside your data, and experience scale like never before.<br />
                </h4>
                <asp:Label ID="Label1" runat="server" Text="Upload .xlsx file" CssClass="h4"></asp:Label><br />
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-input" />
                <asp:DropDownList runat="server" CssClass="form-control form-inline" ID="something" OnSelectedIndexChanged="something_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="Examples" Value="default"></asp:ListItem>
                    <asp:ListItem Text="Cost of Living" Value="sampledata.xlsx"></asp:ListItem>
                    <asp:ListItem Text="Women in Tech" Value="uploadsample.xlsx"></asp:ListItem>
                </asp:DropDownList>

                <br />
                <asp:Button ID="UploadButton" runat="server" Text="Visualize" OnClick="UploadButton_Click" CssClass="btn btn-default" />

            </div>
        </div>

        <footer class="footer">
            <div class="container">
                <p class="text-muted" style="margin-top: 10px">A Virtual Infinity Project</p>
            </div>
        </footer>
    </form>
</body>
</html>
