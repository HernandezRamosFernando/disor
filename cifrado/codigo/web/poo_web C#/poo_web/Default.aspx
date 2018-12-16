<%@ Page Language="C#" Inherits="poo_web.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label runat="server" Text="Texto"/>
            <asp:TextBox id="texto" runat="server" OnTextChanged="texto_TextChanged"/>      
	</form>
        <br>
    <form id="from2" runat="server">
            
            <asp:Label runat="server" Text="Cifrado Cesar"/>
            <br>
            
            <asp:Label runat="server" Text="desplazamiento"/>
            <asp:TextBox id="desplazamiento" runat="server"/>
            <br>
            <asp:Label runat="server" Text="Texto Cifrado"/>
            <br>
            <asp:TextBox id="texto_cifrado" runat="server"/>
            <br>
            <asp:Label runat="server" Text="Cifrado Inverso"/>
            
            <br>
            <asp:Label runat="server" Text="Texto Cifrado"/>
            <br>
            <asp:TextBox id="texto_inverso" runat="server"/>
                
        </form>
        
</body>
</html>


