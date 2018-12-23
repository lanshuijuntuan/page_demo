<%@ Page Language="C#" AutoEventWireup="true"  ResponseEncoding="UTF-8" CodeBehind="testAspPage.aspx.cs" Inherits="page_demo.Page_demos.testAspPage"  %>

<!DOCTYPE html>
<script runat="server">

    protected void BtnConvertToUpper_ServerClick(object sender, EventArgs e)
    {
        String lowerStr=this.tbx_lowerStr.Value;
        this.tbx_upperStr.InnerText=lowerStr.ToUpper();
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Convert To Upper</title>
</head>
<body>
    <h3>Convert To Upper</h3>
    <form id="form1" runat="server">
    <div>
        <h3>小写</h3><input  type="text" name="lowerStr" id="tbx_lowerStr" runat="server"/>
        <input type="submit"  name="convertToUpper" value="转为大写"  id="BtnConvertToUpper" runat="server" onserverclick="BtnConvertToUpper_ServerClick"/>  
        <br />
        <h3>大写</h3>
        <span runat="server" id="tbx_upperStr"></span>  
    </div>
    </form>
</body>
</html>
