---
title: Folder structure
uid: web_client_folders
description: The contents of the web client installation folder
author: {github-id}
keywords:
so.topic: reference
so.envir: onsite
so.client: web
---

# Folder structure

In this section, we will be examining the contents of the web client installation folder.

The following table describes the folders most likely to be involved when creating and/or deploying customizations. Most integrations are only concerned with the App_Data, Bin, and JavaScripts folders, but sometimes so are Themes and Images.

| Folder | Description |
|---|---|
| App_Data | All SOML configuration files that constitute the entire application structure.<br>Edit existing pages or add your own. |
| App_Themes | Version-specific folders containing all CSS and Skin files used by the default theme.<br>The use of themes also lets you change all of the design elements, like fonts and colors in the entire application |
| Bin | All application-dependent assemblies, from archive providers to web controls, along with all NetServer assemblies needed for running the Services layer against the SuperOffice database. |
| Config | The SuperOffice configuration tool used for setting up database connection parameters, logging, language settings, and more.<br>Writes changes to *web.config*. |
| Images | All images used by SuperOffice. |
| JavaScripts | JavaScript (.js) files used by the Atlas (AJAX) framework. |
| Masterpages | The ASP.NET master pages used by SuperOffice. |
| Security | Login pages. |
| Services | TrayApp controls. |
| WebParts | All web controls (.ascx files) used in SuperOffice. |

> [!NOTE]
> Place any images and custom scripts you add inside sub-folders.

## Configuration files

The configuration files found in the *App_Data/WebClient/Web* folder define what pages exist in the application, what cards exist on each page, and what controls and fields exist on each card.

The main configuration files you need to know about are:

* SoApplicationConfiguration.config
* SoButtonBarPanel.config
* SoNavigatorPanel.config
* SoObjectMapping.config

### SoApplicationConfiguration.config

This file defines all the pages and dialogs in SuperOffice. If you want to add your own page, you will need to add a new element in the section.

### SoButtonBarPanel.config

This file defines all button links available at the bottom of SuperOffice, for example, the New Sale or New Appointment link buttons.

You can change, add or remove links by modifying this page.

### SoNavigatorPanel.config

This file defines all button links available on the left side of SuperOffice, for example, Contact, Project, and Diary.

You can change, add or remove links by modifying the section of this page.

### SoObjectMapping.config

This file defines all controls and assemblies known to SuperOffice. If your assemblies must be known, you will add them here as well.

There are several different object types, like Control, UserControl, and AjaxMethod.
