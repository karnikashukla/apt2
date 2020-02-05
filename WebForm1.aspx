<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" Height="147px" Width="273px">
            </asp:GridView>
        </div>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>  
                        <div >  
                            <h4><%#Eval("id")%></h4>  
                            <h6><%#Eval("name")%></h6>  
                            <h6><%#Eval("mobile_number")%></h6> 
                        </div>  
                     
                </ItemTemplate> 
        </asp:DataList>
        
    </form>
</body>
</html>
