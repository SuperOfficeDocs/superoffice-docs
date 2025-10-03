---
uid: using-soprotocol
title: Using SoProtocol
description: Using SoProtocol
keywords: soprotocol, deeplinking
author: Tony Yates
date: 04.12.2023
content_type: howto
category: customization
topic: soprotocol
platform: web
deployment: onsite
redirect_from: /en/ui/soprotocol/using-soprotocol
language: en
---

# Using SoProtocol

SoProtocol can be utilized to initiate the opening of new pages through various means. This protocol specifies the user-interface state presented to the user. For instance, if the goal is to display the contact page for a specific contact with an ID of 2 and its associated activity archive, the SoProtocol implementation would resemble the following.

`http://www.example.com/SuperOffice/default.aspx?contact.main.activityarchive?contact_id=2`

SoProtocol is used to navigate to other page, and even pre-select tabs within those pages without clicking in the browser.

The following link leads to the company page, selecting the main tab at the top and selecting the contacts tab (person archive) at the bottom of the page.

`http://www.example.com/SuperOffice/Default.aspx?contact.main.minimonth.personarchive?contact_id=34&person_id=81`

![contact][img1]

This is the simplest way that we can use the SoProtocol string to navigate.

## Open from JavaScript

SoProtocol can be invoked in JavaScript as well. This example is simple and uses `window.location.href` to transfer to the SuperOffice web application. All we have to do is add the following code to HTML page.

```html
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
  <title>Untitled Page</title>
</head>
<body>
  <form id="form1" runat="server">
    <ul>
    <li><a href="javascript: navigate()">Click Here to Invoke SuperOffice</a></li>
    </ul>
  </form>
</body>

<script type= "text/javascript">
function navigate()
{
  window.location.href="http://www.your-superoffice/default.aspx?contact.main.activityarchive?contact_id=3";
}
</script>
</html>
```

That example navigates to the contact page where contact id equals 3. Notice that the executed JavaScript was from the "Click Here to Invoke SuperOffice" link. Once clicked, the link might show a login screen, but once logged into the application, the link will take us to the contact page that consists of information where the contact id equals 3.

Before we click the link, the login page, and finally the contact page:

![24][img2]

![26][img1]

After we have logged in we are taken straight to the contact page that contains information on contact ID 3.

<!-- markdownlint-restore -->

> [!NOTE]
> The standard way to login to the CRM is through the login page.
> However, with onsite installations it is possible to login to CRM via an URL using the username and password as query string parameters.
>
> `https://www.your-superoffice.com/Security/Login.aspx?UserId=sam&Password=sam&Culture=en-us&TrayApp=no`
>
> * UserId and Password refers to the SuperOffice login name and Password
> * Culture refers to the culture string which determines the user interaction language

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/customization/soprotocol-contact.png
[img2]: ../../../media/loc/en/customization/soprotocol-image024.jpg
