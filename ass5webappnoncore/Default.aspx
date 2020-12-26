<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ass5webappnoncore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <div class="text-center">
        <h1 class="display-4">Assignment 5</h1>
        <p>Student ID: 12001018</p>
    </div>



      <table width="100%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="#EAEAEA">
            <tr align="left" style="background-color:#004080;color:White;">
                <td>ID</td>
                <td>Title</td>
                <td>FirstName</td>
                <td>LasttName</td>
                <td>EmailAddress</td>
            </tr>


            <%Response.Write(ass5webappdesk.fillTable.getWhileLoopData());%>

        </table>
    </asp:Content>

