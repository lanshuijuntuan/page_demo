<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testEvents.aspx.cs" Inherits="page_demo.Page_demos.testEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
        <p>
        <asp:Button ID="btnTestEvent" Text="测试点击事件" runat="server" OnClick="btnTestEvent_Click" />
        </p>
    </form>
</body>
</html>
