---
uid: pb-usercontrols-comparison
title: Webpage using SuperOffice web controls
description: Webpage using SuperOffice web controls
keywords:
author: Tony Yates
date: 06.24.2016
content_type: tutorial
category: customization
topic: PageBuilder
platform: web
deployment: onsite
---

# Webpage using SuperOffice web controls

It is possible to get the SuperOffice application's look-and-feel when developing an ASP.Net site.

## Add references

The first step is to add the necessary references. We need to add the *SuperOffice.Web.UI.Controls.dll*.

![07][img1]

## Add style sheets

The next step is to add the stylesheets. These are necessary for us to get the SuperOffice look and feel.

> [!NOTE]
> When adding stylesheets, preserve the folder structure of the SuperOffice application.

We have added the ".css" files called *DefaultStyles.css* and *SuperOffice.Web.UI.Controls.css* since these styles sheets contain the styles for the controls that we plan to use in the application.

## Add image folder

Next, we need to add an *Image* folder with the relevant images used by the stylesheets. Again, preserve the folder structure.

![08][img2]

## Create web.config

Once this is done, we need to create a *web.config* file. Here, we have copied the file from SuperOffice and made some changes to suit our needs. One such change is to remove the authentication tags. Next, we have made changes to the [ImplicitAnonymous][1] tags section to which is reflected below.

```XML
<ImplicitAnonymous>

  <!-- Implicit Anonymous is what you get when you do not explicitly authenticate as a user. Usually disabled in SIX.web, which uses explicit users -->
  <add key="Allowed" value="true"/>

  <!-- Database user that NetServer should use to log on -->
  <add key="DBUser" value="audience"/>

  <!--Password of database user -->
  <add key="DBPassword" value="audience"/>

  <!-- Should all implicit anonymous users share the same connection -->
  <add key="CommonDBConnection" value="True"/>

  <!-- SuperOffice anonymous user (associate of type anonymous) to be used -->
  <add key="SoUser" value="ANONYMOUS1"/>

  <!-- Password of SuperOffice anonymous user -->
  <add key="SoPassword" value=""/>

</ImplicitAnonymous>
```

## Design the page

Once the above steps are done, we are ready to develop our website using SuperOffice controls. The site will calculate the number of days left for a particular holiday (Christmas, New Year, and Summer Equinox). Below is the code that shows how SuperOffice Controls have been used.

[!code-html[HTML](includes/timetoholiday.cshtml)]

Before any control is used, it is necessary to register the namespace that contains them.

[!code-html[HTML](includes/timetoholiday.cshtml?range=3)]

The next step is to link the SuperOffice stylesheet since we want our webpage to maintain the SuperOffice look.

[!code-html[HTML](includes/timetoholiday.cshtml?range=11)]

Now we are ready to use SO Controls. In the example, we have used controls such as SoTextBox, SoDropDownList, and SoButton. When going through all the tags, it can be seen that to give the correct look we have made use of the CssClass property to get the correct style from our style sheet.

## Add logic to the page

Once the page design has been done, we are now ready to construct the logic (code behind the application).

```csharp
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.mdControls;
public partial class Time2Holiday : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    //Display the current date
    TextBox txtCurDate = soPanel.FindControl("txtCurrDateValue") as TextBox;
    txtCurDate.Text = System.DateTime.Now.ToString();

    //Add values to the drop down list
    if (!IsPostBack)
    {
      ddlHoliday.Items.Add("Christmas");
      ddlHoliday.Items.Add("New Year");
      ddlHoliday.Items.Add("Summer Equinox");
    }
  }
  protected void LoginBtn_Click(object sender, EventArgs e)
  {
    //Variable Declaration
    //Current Date related variables
    DateTime currentDate = DateTime.Today.Date;
    int currentYear = DateTime.Today.Year;

    //Holidays related variables
    DateTime christmas = new DateTime(currentYear, 12, 25);
    DateTime newYear = new DateTime(currentYear + 1, 1, 1);
    DateTime sumEqui = new DateTime(currentYear, 6, 20);

    //Variable related to the number of days in between
    TimeSpan numberOfDays;
    int numberDays = 0;

    //DropDownlist instantiation
    DropDownList newHolidayList = soPanel.FindControl("ddlHoliday") as DropDownList;

    //TextBox instantiation which is used to display the numbers
    TextBox txtNumDays = soPanel.FindControl("txtNumberOfDaysValue") as TextBox;

    //Calculation of the Number of days in between
    //If the Holiday is Christmas
    if (newHolidayList.SelectedValue.Equals("Christmas"))
    {
      numberOfDays = christmas - currentDate;
      if (numberOfDays.Days < 0)
      {
        numberDays = 365 + numberOfDays.Days;
        txtNumDays.Text = numberDays.ToString() + " days to Christmas";
      }
      else
        txtNumDays.Text = numberOfDays.Days.ToString() + " days to Christmas";
    }

    //If the holiday is the new year Date
    if (newHolidayList.SelectedValue.Equals("New Year"))
    {
      numberOfDays = newYear - currentDate;
      txtNumDays.Text = numberOfDays.Days.ToString() + " days to New Year";
    }

    //If the Holiday is Summer Equinox
    if (newHolidayList.SelectedValue.Equals("Summer Equinox"))
    {
      numberOfDays = sumEqui - currentDate;
      if (numberOfDays.Days < 0)
      {
        numberDays = 365 + numberOfDays.Days;
        txtNumDays.Text = numberDays.ToString();
      }
      else
        txtNumDays.Text = numberOfDays.Days.ToString() + " days to Summer Equinox";
    }
  }
}
```

When looking at the above code it can be seen that the SO controls can be used in a similar way to that of ASP.net controls.

## Result

![09][img3]

To run the code in addition to following the above steps, the `Database` elements of the *web.config* file should be modified to reflect the SuperOffice Database of the machine that the site is been run on. Further, the *Images* and the *App_Themes* folders should be copied from the SuperOffice installation folder.

<!-- Referenced links -->
[1]: ../../../../api/config/data.md

<!-- Referenced images -->
[img1]: media/image007.jpg
[img2]: media/image008.jpg
[img3]: media/image009.jpg
