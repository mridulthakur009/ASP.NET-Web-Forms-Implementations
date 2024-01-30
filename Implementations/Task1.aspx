<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task1.aspx.cs" Inherits="Implementations.Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:TextBox ID="TextBox1" runat="server" Width="158px"></asp:TextBox>
            <br />
            <br />
            <input type="button" ID="Button1" OnClick="func1()" value="Submit" />
            <br />
        </div>
        <input type="button" ID="Button2" value="Button" Width="63px" />
    </form>
</body>
<script src="Scripts/jquery-3.4.1.js"></script>
    <script>
        $(document).ready(function () {
            debugger
            $('#Button2').click(function () {
                var text1 = $('#TextBox1').val();
                console.log(text1);
                $('input[ID=Button2]').val(text1);
            })
        })

        function func1() {
            document.getElementById('Button1').value = document.getElementById('TextBox1').value;
        }
    </script>
</html>
