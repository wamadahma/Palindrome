<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Palindrome.index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>Palimdrone</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="main.css" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
    <div id="PromptArea">

        <h2>Palindrome</h2>
   
         <form runat="server">
            <asp:TextBox id="InputBox" runat="server" CssClass="input-sm" Width="330px" AutoPostBack="false" onFocus="this.Select()" />
            <asp:Button id="SubmitButton" Text="Check for Palindrome" OnClick="CheckForPalimdrone" runat="server" CssClass="btn btn-primary"/>   
        </form> 
    
        <br />
        <br />
        <br />

         <asp:Label ID="ReportLabel" runat="server" Text="" CssClass="InfoLabel"></asp:Label>
    </div>


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>  
</body> 
</html>
 


