<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Label ID="lblBookID" runat="server" Text="BookID" width="254px"></asp:Label>
		<asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
		<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
		<p>
			<asp:Label ID="lblBookName" runat="server" Text="Book Name" width="254px"></asp:Label>
			<asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
		</p>
		<p>
			<asp:Label ID="lblNumberAvailable" runat="server" Text="Number Available" width="254px"></asp:Label>
			<asp:TextBox ID="txtNumberAvailable" runat="server"></asp:TextBox>
		</p>
		<p>
			<asp:Label ID="lblReleaseDate" runat="server" Text="Release Date (DD/MM/YYYY)"></asp:Label>
			<asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
		</p>
		<p>
			<asp:CheckBox ID="chkInStock" runat="server" Text="In Stock" />
		</p>
		<p>
			<asp:Label ID="lblError" runat="server"></asp:Label>
		</p>
		<p>
			<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
			<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
		</p>
    </form>
</body>
</html>
