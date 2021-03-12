---
title: sop_open_dialog
description: Open a new dialog with SoProtocol
author: Tony Yates
so.date: 06.24.2016
keywords: soprotocol
so.topic: howto
so.client: web
so.envir: onsite
---

# How to open a new dialog

You can use the SoProtocol to open new pages in different ways. The SoProtocol defines the user-interface state that the user sees. For example, if you want to see the contact page with the contact ID 2 and the activity archive for that contact the SoProtocol will look like below.

`http://www.example.com/SuperOffice/default.aspx?contact.main.activityarchive?contact_id=2`

We can use this string to navigate to another page without clicking in the browser.

If we type the following link on the browser it will lead us to the page shown on the screenshot.

`http://www.example.com/SuperOffice/Default.aspx?contact.main.minimonth.personarchive?contact_id=34&person_id=81`

![21][img1]

This is the simplest way that we can use the SoProtocol string to open a dialog.

## Open from JavaScript

We can use the SoProtocol from inside a JavaScript as well. This is also fairly simple we can use a method like `window.location.href` to transfer to the SuperOffice web application. All we have to do is add the following code to HTML page.

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
  window.location.href="http://www.example.com/Six/default.aspx?contact.main.activityarchive?contact_id=3";
}
</script>
</html>
```

Here also we can see that we are trying to navigate to the contact page that contains the contact id 3. We can notice that we have executed the JavaScript on a link that says "Click Here to Invoke SuperOffice". Once we click on the link it will show us the login screen of the CRM.web application. After we have logged in the application will take us to the contact page that consists of information of the contact id 3 in this case.

Before we click the link, the login page, and finally the contact page:

![24][img2]

![25][img3]

![26][img4]

After we have logged in we are taken straight to the contact page that contains information on contact ID 3.

## Inside an iframe

Since the SoProtocol string acts as a URL we can use it inside an iframe. This is very simple all you have to do is give the SoProtocol string as the src value of the iframe. Below is the code that you have to add as the HTML code of your web page.

```html
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
  <title>testPage</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <iframe id="SuperOfficeFrame" src="http://www.example.com/Six/default.aspx?contact.main.activityarchive?contact_id=3" width="1200" height="800" marginwidth="0" marginheight="0" frameborder="1"></iframe>
    </div>
  </form>
</body>
</html>
```

In the above code, we have asked for contact ID 3. So when the iframe gets executed it will first take us to the login page of SuperOffice web since we have not logged into the system. After we have logged in the SoProtocol string will take us to the contact that we wanted.

The login page and then the contact page:

![22][img5]

![23][img6]

After the login, the SoProtocol has taken us to the correct contact.

An important point to remember!

The standard way to login to the CRM.web is through the login page. However, it is possible to login to CRM.Web via an URL if the username and password are passed as part of the URL.

`http:www.example.com/SuperOffice/Security/Login.aspx?UserId=sam&Password=sam&Culture=en-us&TrayApp=no`

* UserId and Password refers to the SuperOffice login name and Password
* Culture refers to the culture string which determines the user interaction language
* TrayApp which could be either "yes" or "no" indicates whether the TrayApp is installed or not.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image021.jpg
[img2]: media/image024.jpg
[img3]: media/image025.jpg
[img4]: media/image026.jpg
[img5]: media/image022.jpg
[img6]: media/image023.jpg
