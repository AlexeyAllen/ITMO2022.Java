<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoInput.aspx.cs" 
    Inherits="ITMO2022.ASP.Net.ControlTask.StudentInfoInput" MasterPageFile="~/Site.master" 
    UnobtrusiveValidationMode="None"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Введите личные данные студента и данные о его успеваемости (от 1 до 5) по дисциплине "Базы данных"</h2>
        <div>
            <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
            <label>Имя:</label><asp:TextBox ID="firstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="firstName" ErrorMessage="Заполните поле имени" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Фамилия</label><asp:TextBox ID="lastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="firstName" ErrorMessage="Заполните поле фамилии" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>email:</label><asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="email" ErrorMessage="Заполните поле адреса" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="email" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ErrorMessage="E-mail is not in a valid format" Display="Dynamic" 
                ForeColor="Red">Адрес введен неверно!!!</asp:RegularExpressionValidator>
        </div>
        <div>
            <label>Номер телефона:</label><asp:TextBox ID="phoneNumber" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="phoneNumber" ErrorMessage="Заполните поле ввода телефона" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Оценка за урок 1:</label><asp:TextBox ID="lesson1Mark" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="lesson1Mark" ErrorMessage="Заполните поле ввода оценки за урок 1" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Оценка за урок 2:</label><asp:TextBox ID="lesson2Mark" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="lesson1Mark" ErrorMessage="Заполните поле ввода оценки за урок 2" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Оценка за урок 3:</label><asp:TextBox ID="lesson3Mark" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="lesson1Mark" ErrorMessage="Заполните поле ввода оценки за урок 3" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Оценка за урок 4:</label><asp:TextBox ID="lesson4Mark" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="lesson1Mark" ErrorMessage="Заполните поле ввода оценки за урок 4" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Оценка за урок 5:</label><asp:TextBox ID="lesson5Mark" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                ControlToValidate="lesson1Mark" ErrorMessage="Заполните поле ввода оценки за урок 5" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <button type="submit">Внести данные о студенте в базу данных</button>
        </div>
    </div>
</asp:Content>

