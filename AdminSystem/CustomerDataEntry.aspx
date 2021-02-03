<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="FirstName" width="75px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" Text="LastName" width="75px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="lblCustomerContact" runat="server" Text="Customer Contact" width="75px"></asp:Label>
        <asp:TextBox ID="txtCustomerContact" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerPwd" runat="server" Text="Customer Password" width="75px"></asp:Label>
        <asp:TextBox ID="txtCustomerPwd" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActiveAcc" runat="server" Text="ActiveAcc" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
    </body>
</html>
