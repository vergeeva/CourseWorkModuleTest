<%@ Page Language="C#" Debug="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Trade_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 633px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Таблица &quot;Товары&quot;"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"> 
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Код_товара" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                            <asp:BoundField DataField="Код_товара" HeaderText="Код_товара" InsertVisible="False" ReadOnly="True" SortExpression="Код_товара" />
                            <asp:BoundField DataField="Артикул_товара" HeaderText="Артикул_товара" SortExpression="Артикул_товара" />
                            <asp:BoundField DataField="Наименование_товара" HeaderText="Наименование_товара" SortExpression="Наименование_товара" />
                            <asp:BoundField DataField="Цена_товара_шт" HeaderText="Цена_товара_шт" SortExpression="Цена_товара_шт" />
                        </Columns>
                        <SelectedRowStyle BackColor="#CCFFCC" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ОптоваяТорговляConnectionString %>" SelectCommand="SELECT * FROM [Товары]"></asp:SqlDataSource>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить" Width="122px" OnClick="ButtonAdd_Click" />
&nbsp;
                    <asp:Button ID="ButtonUpdate" runat="server" Text="Изменить" Width="122px" OnClick="ButtonUpdate_Click" />
                    &nbsp;<br />
                    <asp:Button ID="ButtonDelete" runat="server" Text="Удалить" Width="122px" OnClick="ButtonDelete_Click" />
&nbsp;</td>
                <td>

                    Артикул товара<br />
                    <asp:TextBox ID="АртикулTB" runat="server"></asp:TextBox>
                    <br />
                    Наименование товара<br />
                    <asp:TextBox ID="НаименованиеTB" runat="server" Width="211px"></asp:TextBox>
                    <br />
                    Цена<br />
                    <asp:TextBox ID="ЦенаTB" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Result" runat="server" Font-Bold="True" Font-Italic="False" Text="Статус"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
