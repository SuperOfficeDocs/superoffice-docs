---
title: Creating ASP.net website using SO controls
uid: aspnet_appointment_with_login
description: Creating ASP.net website using SO controls
author: Tony Yates
so.date: 06.24.2016
keywords: appointment, login
so.topic: tutorial
so.client: web
so.envir: onsite
---

# Creating ASP.net website using SO controls

This tutorial demonstrates how to create an ASP.NET website with SuperOffice controls such as SoTextBox and SoLabel.

**Goal:** a login page using SO controls and then to allow the user to retrieve a list of appointment details based on associate ID, appointment active date, and end date entered by the user.

![14 -screenshot][img1]

## Adding the references

Since we are planning to use SO controls, we need to add the *SuperOffice.Web.UI.Controls.dll* file. Visual Studios will also add dependent DLLs, such as *SOCore*.dll and *SuperOffice.Services.dll*.

Once the GUI state of the site is complete we need to have certain DLLs that enable us to retrieve data from the SuperOffice database. Since we plan to use the Services layer exposed by the NetServer, we need to add *SuperOffice.Services.dll* and *SuperOffice.Services.Impl.dll*.

### The basic references needed to create an ASP.Net website using SO controls

![11 -screenshot][img2]

## The web.config

When creating any website, it is necessary to have a *web.config* file. Here, we copy it from the SuperOffice application and modify it as required. The SuperOffice [Services][1] and [Database][2] sections need to remain in the config file so that we can talk to the database:

[!code-xml[XML](includes/webconfig.xml)]

Since we are not using the SuperOffice and PageBuilder features, we don’t need their sections in the config file:

[!code-xml[XML](includes/webconfig-exclude.xml?range=1-12)]

We can also clean out a lot of ASP.net config that is specific to SuperOffice

[!code-xml[XML](includes/webconfig-exclude.xml?range=14-55)]

The resulting config file has the settings necessary for SODatabase to talk to the database via the web service API, and for the DCF to talk to the resource DLLs.

## Theme - getting the SuperOffice look

To make the web controls look like SuperOffice, you need to copy the theme from SuperOffice to the new web site, and include a Theme directive in the *web.config* file:

```XML
<pages theme="Six" validateRequest="false" enableEventValidation="false" viewStateEncryptionMode="Never">
</pages>
```

Add the *Theme* folder to ASP.net (via the special ADD ASP.NET FOLDER menu) and copy the *DefaultStyles.css* from SuperOffice to the folder.

Add the *IMAGES* folder to the website to complete the look:

![12 -screenshot][img3]

## Login page

This is the page that is used by us to authenticate users – denying access to users we don’t recognize. The page consists of SO controls such as SoTextBoxes and a SoButton. Following is the source code for the Login.aspx page.

[!code-html[HTML](includes/login.cshtml)]

We have placed all our SO controls inside `<asp:Login></asp:Login>`. Before we use SO Controls we need to register them by using the below statement.

[!code-html[HTML](includes/login.cshtml?range=3)]

Once the registration is declared, we can use the SO controls on the page. For example, an SoTextBox is shown below.

[!code-html[HTML](includes/login.cshtml?range=21-25)]

We have placed the SoTextBox inside a div to specify the exact location that we want our control to be placed on the screen. `so:SoTextBox` tells the compiler a control which is of SoTextBox type is used and the ID of it "UserName" is used by the code behind to retrieve the user entered data. A required field validator is used to make sure that the user name is not null.

Then next unique SO control that is used by us is the SoButton:

[!code-html[HTML](includes/login.cshtml?range=32-34)]

The **Submit** button is an SoButton. It gets the SuperOffice look but is otherwise a plain old button. Once the button is clicked it accesses a method called `LoginBtn_Click` from the code behind.

The code behind *Login.aspx* is as follows.

[!code-csharp[CS](includes/login.aspx.cs)]

Since we just want to show how we can use SO controls in an ASP.Net website we have not made a special effort in our code behind the file to make any un-necessary validations and make the code lengthy.

What we have done once the **Submit** button is clicked is to retrieve the user-entered user name and password and stored them in session variables as shown below.

[!code-csharp[CS](includes/login.aspx.cs?range=24-30)]

Next, we have used the Session class’s `Session.Authenticate` method to validate the entered user name and password. And if the entered data is correct the user will be directed to the *Appointments.aspx* page. This is shown below.

[!code-csharp[CS](includes/login.aspx.cs?range=32,33,35,36)]

**The login screen without the styles or themes in place:**

![13 -screenshot][img4]

**With theme and images in place it looks more like SuperOffice:**

![14 -screenshot][img1]

## Appointments

Once the user has been authenticated he will be directed to this page. The page allows the user to enter some requirements and based on the entered requirements the data is retrieved using the NetServer services layer.

[!code-html[HTML](includes/appointments.cshtml)]

The above code reflects the GUI of the login page, it consists of 3 SoTextBoxes and a SoButton. These GUI elements have been added in the same way as on the login page and the IDs of the text boxes are used to link them to the code behind. Once the **Submit** button of the page has been clicked it will execute a `datesBtn_Click` method. Once the method has been executed the **Submit** button will disappear and instead a table containing the result will appear. This is also done through the code behind the file.

The code behind the file of the *Appointments.aspx* is as follows.

[!code-csharp[CS](includes/appointments.aspx.cs)]

The `Page_Load` method is used to switch the visibility state of the table that is used to display the results based on the data entered by the user. Once the **Submit** button of the page has been clicked it will execute `datesBtn_Click()`. The method checks and evaluates the Session using session variables. The values of the session variables have been updated when the user authenticates themselves on the login page.

Once the user has been validated the data entered into the SoTextBoxes are converted into TextBox types of the .NET framework. And then these are converted into the respective types that are accepted by the `GetActivityInformationListByDatesAndAssociate` method of the `IAppointmentAgent` created using the `AgentFactory`.

The appointments retrieve from the agent are stored in an array of type `ActivityInformationListItem`. A for loop is used to fetch the data from this array and display them on the Appointments page using an HTML table. When the results are displayed the **Submit** button would become invisible.

**Before:**

![15 -screenshot][img5]

**After:**

![16 -screenshot][img6]

<a href="../../../assets/downloads/testwebsite.zip" download>Click to download website source code</a>

<!-- Referenced links -->
[1]: ../../../../../data-access/docs/netserver/config/services.md
[2]: ../../../../../data-access/docs/netserver/config/data.md#database

<!-- Referenced images -->
[img1]: media/image014.jpg
[img2]: media/image011.jpg
[img3]: media/image012.jpg
[img4]: media/image013.jpg
[img5]: media/image015.jpg
[img6]: media/image016.jpg
