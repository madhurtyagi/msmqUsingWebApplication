<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="senderAndReceiver.aspx.cs" Inherits="msmqProgram.senderAndReceiver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Type Message<br />
			<asp:TextBox ID="TextBox1" runat="server" Width="338px"></asp:TextBox>
			<br />
			<br />
			<asp:Button ID="btnSend" runat="server" OnClick="Button1_Click" Text="Send" />
			<br />
        </div>
    	Receive Message<p>
			<asp:TextBox ID="TextBox2" runat="server" Width="336px"></asp:TextBox>
		</p>
		<p>
			<asp:Button ID="btnReceive" runat="server" OnClick="btnReceive_Click" Text="Receive" />
		</p>
    </form>
</body>
</html>
