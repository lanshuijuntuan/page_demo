<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testSession.aspx.cs" Inherits="page_demo.Page_demos.testSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Session</title>
</head>
<body>
    <h1>Test Session</h1>
    <form id="form1" runat="server">
    <div>
    Session Hit Counter:<asp:Label ID="lbl_sessionCount" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
