<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASP_Jordi.aspx.cs" Inherits="Pruebas.ASP_Jordi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <%--<script language="C#" runat="server">
        void Button_Click(Object Sender, EventArgs e)
        {
            //Label1.Text = Server.HtmlEncode(Text1.Text);
            userInput.Text = Text1.Text;
            Text1.Text = "";
        }
   </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label id="Label1" 
                 Text="Select you date:" 
                 runat="server"/>
            <p>
        
            <asp:TextBox id="Text1" 
                Text=""
                Width="200px"  
                runat="server" />

            <asp:Button id="Button1" 
                Text="Submit" 
                OnClick="btn_onClick" 
                runat="server"/>

            </p>
            
            <asp:Calendar id="calendar1" runat="server" OnSelectionChanged="btn_onClick_calendar">

           <OtherMonthDayStyle ForeColor="LightGray"/>

           <TitleStyle BackColor="Green"
                       ForeColor="White"/>

           <DayStyle BackColor="LightSeaGreen"/>

           <SelectedDayStyle BackColor="LightGreen"
                             Font-Bold="True"/>

      </asp:Calendar>

            <asp:Label ID="userInput"
                runat="server"/>
            </p>

            <asp:Label ID="showdate" 
                runat="server"/>

            <asp:Label ID="especial"
                runat="server" />

           <asp:DropDownList ID="ddlBirthday" 
               Width="200" 
               runat="server" 
               AutoPostBack="false" 
               onchange="ddl_changed(this)" />

        </div>
    </form>
</body>
</html>
