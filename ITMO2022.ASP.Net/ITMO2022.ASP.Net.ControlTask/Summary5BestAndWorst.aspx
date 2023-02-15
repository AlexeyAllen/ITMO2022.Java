<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Summary5BestAndWorst.aspx.cs" Inherits="ITMO2022.ASP.Net.ControlTask.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Top 5 best students</h2>
    <p>
        <asp:GridView ID="GridViewBest" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceBest" Width="259px">
            <Columns>
                <asp:BoundField DataField="Top 5 best students" HeaderText="Top 5 best students" ReadOnly="True" SortExpression="Top 5 best students" />
                <asp:BoundField DataField="Sum of grades" HeaderText="Sum of grades" ReadOnly="True" SortExpression="Sum of grades" />
            </Columns>
        </asp:GridView>
    </p>
    <h2>Top 5 worst students</h2>
    <p>
        <asp:GridView ID="GridViewWorst" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceWorst" Width="257px">
            <Columns>
                <asp:BoundField DataField="Top 5 worst students" HeaderText="Top 5 worst students" ReadOnly="True" SortExpression="Top 5 worst students" />
                <asp:BoundField DataField="Sum of grades" HeaderText="Sum of grades" ReadOnly="True" SortExpression="Sum of grades" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceWorst" runat="server" ConnectionString="<%$ ConnectionStrings:StudentScoreDB3 %>" SelectCommand="SELECT top 5 CONCAT(StudentInfoIdId,' ', FirstName,' ', LastName)
 AS &quot;Top 5 worst students&quot;,
    (
        SELECT max(g.TotalSumMark) FROM GradeInfoes g 
        WHERE g.gradeid = StudentInfoes.StudentInfoIdId 
    ) as &quot;Sum of grades&quot;
FROM StudentInfoes
ORDER BY &quot;Sum of grades&quot; asc"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSourceBest" runat="server" ConnectionString="<%$ ConnectionStrings:StudentScoreDB3 %>"
            SelectCommand=" SELECT top 5 CONCAT(StudentInfoIdId,' ', FirstName,' ', LastName)
 AS &quot;Top 5 best students&quot;,
    (
        SELECT max(g.TotalSumMark) FROM GradeInfoes g 
        WHERE g.gradeid = StudentInfoes.StudentInfoIdId 
    ) as &quot;Sum of grades&quot;
FROM StudentInfoes
ORDER BY &quot;Sum of grades&quot; desc"></asp:SqlDataSource>
    </p>
</asp:Content>
