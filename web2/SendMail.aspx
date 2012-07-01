<%@ Page Language="csharp" %>
<%@ Import Namespace = "System.Net.Mail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    void Page_Load() {
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.gmail.com";
        client.Port = 587;
        client.EnableSsl = true;

        client.Send("Steve@somewhere", "steve@superexpert.com",
            "Let's eat lunch!", "Lunch at the Steak House?");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send Mail</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Email Sent!
    </div>
    </form>
</body>
</html>
