<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="ITMO2022.ASP.Net.ControlTask.Sammary" MasterPageFile="~/Site.master" %>

<%@ Import Namespace="ITMO2022.ASP.Net.ControlTask" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Вывод 5 лучших и 5 худших студентов</h2>
        <h3>5 Лучших студентов: </h3>
        <table>
            <thead>
                <tr>
                    <th>Имя</th>
                    <th>Фамилия</th>
                    <th>Email</th>
                    <th>Телефон</th>
                    <th>Сумма баллов</th>
                </tr>
            </thead>
            <tbody>
                <% var bestData = StudentInfoRepository.GetStudentInfoRepository()
                                   .GetAllInfo()/*.Where(r => r.WillAttend.Value)*/;
                    foreach (var best in bestData)
                    {
                        string htmlString = String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>",
                            best.FirstName, best.LastName, best.Email, best.PhoneNumber);
                        Response.Write(htmlString);
                    } %>
            </tbody>
        </table>
        <h3>5 Худших студентов: </h3>
        <table>
            <thead>
                <tr>
                    <th>Имя</th>
                    <th>Фамилия</th>
                    <th>Email</th>
                    <th>Телефон</th>
                    <th>Сумма баллов</th>
                </tr>
            </thead>
            <tbody><%= Worse5Students()%> </tbody>
        </table>
    </div>
</asp:Content>


<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Вывод 5 лучших и 5 худших студентов</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Вывод 5 лучших и 5 худших студентов</h2>
            <h3>5 Лучших студентов: </h3>
            <table>
                <thead>
                    <tr>
                        <th>Имя</th>
                        <th>Фамилия</th>
                        <th>Email</th>
                        <th>Телефон</th>
                        <th>Сумма баллов</th>
                    </tr>
                </thead>
                <tbody>
                    <% var bestData = StudentInfoRepository.GetStudentInfoRepository()
                                 .GetAllInfo()/*.Where(r => r.WillAttend.Value)*/;
                        foreach (var best in bestData)
                        {
                            string htmlString = String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>",
                                best.FirstName, best.LastName, best.Email, best.PhoneNumber);
                            Response.Write(htmlString);
                        } %>
                </tbody>
            </table>
            <h3>5 Худших студентов: </h3>
            <table>
                <thead>
                    <tr>
                        <th>Имя</th>
                        <th>Фамилия</th>
                        <th>Email</th>
                        <th>Телефон</th>
                        <th>Сумма баллов</th>
                    </tr>
                </thead>
                <tbody><%= Worse5Students()%> </tbody>
            </table>
        </div>
    </form>
</body>
</html>--%>
