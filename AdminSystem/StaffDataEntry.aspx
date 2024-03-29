﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 664px">
            <br />
            <asp:Label ID="lblStaffID" runat="server" Text="StaffID" width="125px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click1" />
            <br />
            <br />
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="125px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            &nbsp;<br />
            <br />
            <asp:Label ID="lblStaffPwd" runat="server" Text="Staff Password "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffPwd" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSalary" runat="server" Text="Salary" width="125px"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth" width="125px"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <br />
        <br />
&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;
    </form>
</body>
</html>
