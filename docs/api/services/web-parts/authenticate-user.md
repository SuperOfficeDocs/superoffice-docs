---
# Mandatory fields.
title: authenticate_web_part       # (Required) Very important for SEO.
description: Authenticate a user in web parts # (Required) Important for SEO.including spaces.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Authenticate the user

In the following example, we provide a simple log-in screen. The code corresponding to authentication is written under the button’s click event.

## Log-in page

The log-in page has 2 text-boxes for entering the username and the password, and a submit button.

![02][img1]

```html
<div>
  &nbsp;&nbsp;
  <asp:TextBox ID="txtUserName" runat="server" Style="z-index: 100; left: 372px; position: absolute; top: 161px"></asp:TextBox>
  <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 101; left: 372px; position: absolute; top: 193px" TextMode="Password"></asp:TextBox>
  <asp:Label ID="Label1" runat="server" Style="z-index: 102; left: 265px; position: absolute; top: 163px" Text="Username" Width="77px"></asp:Label>
  <asp:Label ID="Label2" runat="server" Style="z-index: 103; left: 266px; position: absolute; top: 198px" Text="Password" Width="77px"></asp:Label>
  &nbsp;
  <asp:Label ID="lblError" runat="server" ForeColor="Red" Style="z-index: 104; left: 321px; position: absolute; top: 115px" Text="Authentication Failed" Visible="False" Width="174px"></asp:Label>
  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Style="z-index: 106; left: 348px; position: absolute; top: 248px" Text="Login" Width="48px" />
</div>
```

## On-click authentication

```csharp
using System.IO;
using System.Security.Cryptography;
using SuperOffice;
using SuperOffice.Security.Principal;

//When the login button is clicked the user is authenticated
protected void Button1_Click1(object sender, EventArgs e)
{
  //Retrieve the username and password from the text boxes
  userId = txtUserName.Text;
  password = txtPassword.Text;
  SoSession mySession;

  //Set SoCredentials
  SoCredentials myCredentials = new SoCredentials();

  //set the Authentication type
  myCredentials.AuthenticationType = SoAuthenticationType.CRM5;

  //set the user ID
  myCredentials.UserId = userId;

  //calculate the secret and set it
  myCredentials.Secret = CalculateCredentialsSecret(SoAuthenticationType.CRM5, GetDays(),userId, password);

  //Authenticate using the SoSession class
  //Authenticate the user
  mySession = SoSession.Authenticate(myCredentials);
  if (mySession != null)
  {
    //Fill the value to Session Variable
    Session["MySession"] = mySession.Suspend();

    //If successfully authenticated, direct to the next page.
    Response.Redirect("SalesData.aspx");
  }
  else
  {
    //Display the authentication failed message to the user
    lblError.Text = "Authentication Failed";
    txtPassword.Text = "";
    txtUserName.Text = "";
  }
}
```

When the login button is clicked, the username and password are retrieved from the text boxes. The `SoCredentials` are set based on the user’s authentication data. And we obtain the secret by calling `CalculateCredentialsSecret`.

[!code-csharp[CS](../../authentication/includes/calculatecredentialssecret.cs)]

Using the `Authenticate` method of the `SoSession` class, we try to authenticate the user. If authentication is successful a new session is created and the user is redirected to the **Sales** page.

> [!NOTE]
> This way of authenticating **with a secret** applies to SuperOffice 6.<br>[Version 7 and later uses a ticket][2]. See also [Authentication and SOAP calls][1].

**Next step:**  [Display open sales for the user][3] (build the **Sales** page)

<!-- Referenced links -->
[1]: ../../authentication/auth-and-soap-calls.md
[2]: ../../soap/make-soap-call-crm7.md
[3]: display-open-sales-for-user.md

<!-- Referenced images -->
[img1]: media/image002.jpg