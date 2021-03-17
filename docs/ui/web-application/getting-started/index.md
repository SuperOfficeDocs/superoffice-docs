---
title: getting_started       
description: Getting started with customizing the web application
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: generic
so.client: web
so.envir: onsite
---

# Getting started with customizing the web application

SuperOffice CRM Web delivers a comprehensible and highly extensible platform that enables virtually unlimited integration capabilities.

* Get familiar with the [contents of the installation folder][1]

* Study the [architecture][3]

* [Set up a custom folder][4] for your customizations.

Nearly all customizations involve changing at least one of the configuration files so that's the best place to continue this discussion.

* [Page configuration][1] - presents the SuperOffice Markup Language (SOML), which is the cornerstone of SuperOffice web client, and explains how SOML is used to define the structure of the web application.

* [User controls][2] - how to create a user control that will be put inside two new panels in the Sale dialog.

* [Data handlers][3] - to have control over what happens when data is retrieved and stored from a page, you will need to create your own data handler.

* [Custom MDO controls][4] you can create your own MDOs containing anything, whether that would be static data, data from another system, or specific data from SuperOffice. These controls have a lot built-in, like search capabilities and history.

* [Custom Archive controls][5] - create controls that display rows of information from built-in or custom archive providers

* [Custom AJAX methods][6] - how to call server-side methods both asynchronously and synchronously from client-side Javascript

## Themes

The stylesheets used are defined by using ASP.NET themes, which lets you create custom controls that look exactly like standard controls.

The use of themes also lets you change all of the design elements, like fonts and colors in the entire application to fit your own corporate design.

## WebParts

You can change the placement of HTML elements and controls from within these files, but you can not easily remove or add elements here. It is recommended to create your own controls that replace the standard ones instead of modifying these.

## App_Data

This is where you can make changes to the application by modifying the configuration files, add your own pages, and also remove elements if necessary. With the configuration files, you can actually change the web client web completely to suit your needs. We will be taking a much closer look at the different configuration files later.

## Troubleshooting

To debug, use the developer tools of your browser and the SuperOffice [Diagnostics viewer and Debug window][2]

<!-- Referenced links -->
[1]: folder-structure.md
[2]: debug.md
[3]: architecture.md
[4]: set-up-custom-folder.md
[1]: ../pagebuilder/config/index.md
[2]: ../tutorials/tutorial-1.md
[3]: ../pagebuilder/datahandlers.md
[4]: ../pagebuilder/usercontrols/lists/create-custom-mdo-controls.md
[5]: ../pagebuilder/usercontrols/archives/create-custom-archive-control.md
[6]: ../custom-ajax-methods.md

<!-- Referenced images -->
