﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 117px">
            Are you sure you want to delete this record?<br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="height: 29px" Text="Yes" />
&nbsp;<asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" height="29px" width="42px" />
        </div>
    </form>
</body>
</html>
