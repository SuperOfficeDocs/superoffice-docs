---
title: webapp_customization
description: Customizing pages using config files
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# Customizing pages using config files

In this section we will discuss how we can add labels, make use of the data handlers provided, adding customs controls, and using triggers.

## Application structure

The following table describes the folders most likely to be involved when creating and/or deploying customizations. Most integrations are only concerned with the App_Data, Bin, and JavaScripts folders, but sometimes so are Themes and Images.

| Folder| Description|
|---|---|
| App_Data | Contains all SuperOffice Markup Language (SOML) configuration files that constitute the entire application structure.  Change configuration files to suit your needs, i.e. add your own or edit existing pages. |
| App_Themes | Contains all stylesheets used by the application. The use of themes also lets you change all of the design elements, like fonts, colors, etc. in the entire application to e.g. fit your own corporate design. |
| Bin | Contains all application-dependent assemblies, from archive providers to web controls, as well as NetServer Service assemblies. |
| Images | Contains all images used by SuperOffice CRM Web. Custom images should be placed in a subfolder inside.|
| Javascripts | Contains all JavaScript (.js) files used by the application. Custom scripts should be placed in sub-folders.|

Nearly all customizations involve changing at least one of the configuration files so that's the best place to continue this discussion.

* [Page configuration][1] - presents the SuperOffice Markup Language (SOML), which is the cornerstone of SuperOffice web client, and explains how SOML is used to define the structure of the web application.

* [User controls][2] - how to create a user control that will be put inside two new panels in the Sale dialog.

* [Data handlers][3] - to have control over what happens when data is retrieved and stored from a page, you will need to create your own data handler.

* [Custom MDO controls][4] you can create your own MDOs containing anything, whether that would be static data, data from another system, or specific data from SuperOffice. These controls have a lot built-in, like search capabilities and history.

* [Custom Archive controls][5] - create controls that display rows of information from built-in or custom archive providers

* [Custom AJAX methods][6] - how to call server-side methods both asynchronously and synchronously from client-side Javascript

<!-- Referenced links -->
[1]: Page%20Configuration/Page%20Configuration.md
[2]: ../../pagebuilder/usercontrols/tutorial.md
[3]: ../../pagebuilder/datahandlers/tutorial.md
[4]: ../../pagebuilder/usercontrols/lists/create-custom-mdo-controls.md
[5]: ../../pagebuilder/usercontrols/archives/create-custom-archive-control.md
[6]: custom-ajax-methods.md

<!-- Referenced images -->
