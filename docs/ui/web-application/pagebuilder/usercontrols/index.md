---
title: usercontrols
description: UserControls
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# UserControls

UserControls, or GUI controls, are the building blocks of CRM.web webpage. Many of the UserControls are simple controls:

* SoButton
* SoCheckBox
* SoInputButton
* SoTextBox
* ...

There are more complex controls like the `ContactMainView` or the `PersonDialogHeader`, which contains multiple simple controls. The controls are identified by the relevant config file and the actual objects will be mapped using the config file called *SoObjectMapping.config*.

Some of the web controls will be standard ASP.NET controls with the SuperOffice look, while others may be more complex and be dependent on data and services from the page framework. All controls should implement a common interface for data binding and sentry, making it possible for them to be used outside web client context and be plugged into a back-end of another application.

## Library

The controls are composed of ASPX files and C# code in the web control library named **SuperOffice.Web.UI.Controls**. These controls are custom controls that inherit from `System.Web.UI.Control` and `System.Web.UI.WebControl`  control libraries from .NET Framework version 2.0.

## SoObjectMapping.config

Since all rendering and building of pages depend on XML configuration files, we need a mechanism that maps the objects of the pages to the actual objects of the system. These config files contain details such from which assembly a specific user control is taken from.

```XML
<object type="Control" mappingname="SoToolButton" assemblyname="SuperOffice.CRMWeb" objectname="SuperOffice.CRM.Web.UI.Controls.SoToolButton"></object>
```

[!include[ALT](../includes/object-parameters.md)]

For example, the above code tells us the object that is represented by this line is referred to as *SoToolButton* in other config files, resides in the *SuperOffice.CRMWeb* assembly, and is called `SuperOffice.CRM.Web.UI.Controls.SoToolButton`. The type tells us what role the object plays in the PageBuilder framework.

Once the object has been identified in the *SoObjectMapping.config* file, it could be used in any config file with statements like this:

```XML
<control id="selectionButton" type="SoToolButton">...</control>
```

## PageBuilder config files

**PageBuilder** is the mechanism that is defined by SuperOffice to build the pages of the CRM.web application. The PageBuilder framework consists of different config files, including:

* [Page config files][2]
* [Panel config files][3]
* [Card config files][4]
* [View config files][5]
* [Object mapping files][6]
* [Application config files][7]

The PageBuilder uses these config files together with the current values from the [SuperState][1] to build the webpages that the user sees.

<!-- Referenced links -->
[1]: ../superstate/index.md
[2]: ../config/page.md
[3]: ../config/panel.md
[4]: ../config/card.md
[5]: ../config/view.md
[6]: ../config/object-mapping.md
[7]: ../config/soapplicationconfiguration.md

<!-- Referenced images -->
