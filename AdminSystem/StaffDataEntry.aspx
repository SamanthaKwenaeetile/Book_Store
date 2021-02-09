<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 664px">
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="125px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            <br />
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
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
            <br />
            <asp:Calendar ID="txtDOB" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="291px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
            <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
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
