---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: web_client_components       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: The installation contents # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: web                # online, web, win, pocket, or mobile
---

# The installation contents

After you have installed the SuperOffice web application, you will see that the application is an ASP.NET web application with standard elements like *App\_Data*, *App\_Themes*, and *web.config* in place. In this section, we will be examining the contents of the web client installation.

## App\_Data

The *App\_Data* folder contains all of the configuration files that define all pages, controls, and system configuration files for the entire web application. This is where you can make changes to the application by modifying the configuration files, add your own pages, and also remove elements if necessary.

With the configuration files, you can actually change the web client web completely to suit your needs. We will be taking a much closer look at the different configuration files later.

## Configuration files

The configuration files found in the *App\_Data/WebClient/Web* folder define what pages exist in the application, what cards exist on each page, and what controls and fields exist on each card.

The main configuration files you need to know about are:

* SoApplicationConfiguration.config
* SoButtonBarPanel.config
* SoNavigatorPanel.config
* SoObjectMapping.config

### SoApplicationConfiguration.config

This file defines all the pages and dialogs in SuperOffice. If you want to add your own page, you will need to add a new element in the section.

### SoButtonBarPanel.config

This file defines all button links available in the bottom of SuperOffice, for example, the New Sale or New Appointment link buttons.

You can change, add or remove links by modifying this page.

### SoNavigatorPanel.config

This file defines all button links available in the left side of SuperOffice, for example, Contact, Project, and Diary.

You can change, add or remove links by modifying the section of this page.

### SoObjectMapping.config

This file defines all controls and assemblies known to SuperOffice. If your assemblies must be known, you will add them here as well.

There are several different object types, like Control, UserControl, and AjaxMethod. We will be using some of these in later examples.

## App\_Themes

The stylesheets used are defined by using ASP.NET themes, which lets you create custom controls that look exactly like standard controls.

The use of themes also lets you change all of the design elements, like fonts and colors in the entire application to fit your own corporate design.

The *App\_Themes/\[version\]/* folder contains all of the CSS and Skin files used by the default theme.

## Bin

The bin folder contains all assemblies used by the application, along with all NetServer assemblies needed for running the Services layer against the SuperOffice database.

The Services layer of NetServer has been improved drastically both in functionality and performance since version 2.5, and all operations made against the SuperOffice database from the web application use the Service layer.

When creating your own controls and assembles to be used by the application, you should also use the Service layer for all your Create, Read, Update, and Delete (CRUD) operations.

SuperOffice can be configured to run everything on the webserver. This requires that the web server have direct access to the database, which can be dangerous. In a high-security setup, the web server is placed in a DMZ zone with direct access from the internet. The database server will then be placed inside your internal network, along with the application server - NetServer web services. The web server uses SOAP web-services to talk to the application server. The web server has no direct access to the database in this scenario.

## Config

Here you will find the SuperOffice configuration tool, used for setting up database connection parameters, logging, language settings, and more.

All of the changes made with this application will be written to the *web.config* file in the root folder of SuperOffice.

## Images

Here you will find all images used by SuperOffice. If you want to add your own images, you should place them in your own subfolder inside the *Images* folder.

## JavaScripts

This folder contains JavaScript (.js) files used by the Atlas (AJAX) framework.

## Masterpages

The ASP.NET master pages used by SuperOffice.

## Security

Login pages.

## Services

TrayApp controls. The Tray Application is a separate application used for handling diary event notifications and so on.

## WebParts

All web controls (.ascx files) used in SuperOffice. You can change the placement of HTML elements and controls from within these files, but you can not easily remove or add elements here. It is recommended to create your own controls that replace the standard ones instead of modifying these. We will be looking at examples on how to do this from the configuration files later.
