<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="SummaryAll.aspx.cs" Inherits="ITMO2022.ASP.Net.ControlTask.WebForm3" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewAll" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceAll" Width="195px" DataKeyNames="StudentInfoIdId">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="StudentInfoIdId" HeaderText="StudentInfoIdId" ReadOnly="True" SortExpression="StudentInfoIdId" InsertVisible="False" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
        </Columns>
    </asp:GridView>
    <asp:GridView ID="SumAllGradesGridView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceGradeSum">
        <Columns>
            <asp:BoundField DataField="SumAllGrades" HeaderText="SumAllGrades" ReadOnly="True" SortExpression="SumAllGrades" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceGradeSum" runat="server" ConnectionString="<%$ ConnectionStrings:StudentScoreDB3 %>"
        SelectCommand="SELECT SUM(TotalSumMark) as SumAllGrades FROM GradeInfoes"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceAll" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StudentScoreDB3 %>"
        SelectCommand="SELECT * FROM [StudentInfoes]" 
        DeleteCommand="DELETE FROM [StudentInfoes] WHERE [StudentInfoIdId] = @StudentInfoIdId;
        DELETE FROM [GradeInfoes] WHERE [GradeId] = @StudentInfoIdId"> 
        <DeleteParameters>
            <asp:Parameter Name="StudentInfoIdId" Type="Int32" />
        </DeleteParameters>
    </asp:SqlDataSource>
</asp:Content>

<%--DELETE FROM [GradeInfoes] WHERE [gradeid] = @StudentInfoIdId;--%>

