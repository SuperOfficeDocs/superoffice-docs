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

* [Set up a custom folder][4] for your customizations.

## Architecture

First conceived and built on ASP.NET technology in 2005, the CRM Web Framework used cutting-edge Web 2.0 techniques, and was delivered as one of the first enterprise CRM single-page applications (SPA) on the market. It continues to evolve, using the latest web development technologies, and remains the finest CRM platform available.

SuperOffice CRM Web is an application, from the ground up, built for extensibility. Nearly every feature, from user-interface (UI) to the database, is customizable.

![CustomCode][img6]

Like similar platforms, SuperOffice Web is comprised of several components that render a page in a browser. Its strength is its flexibility. The entire application structure is declared in XML configuration files.

[Read more about the architecture][3]

## Configuration

Nearly all customizations involve changing at least one of the configuration files so that's the best place to continue this discussion.

* [Page configuration][5] - the SuperOffice Markup Language (SOML) is the cornerstone of SuperOffice web client and used to define the structure of the web application.

  * Learn how to [change system config files][11]

* [User controls][6] - how to create a user control that will be put inside two new panels in the Sale dialog.

* [Data handlers][7] - to have control over what happens when data is retrieved and stored from a page, you will need to create your own data handler.

* [Custom MDO controls][8] you can create your own MDOs containing anything, whether that would be static data, data from another system, or specific data from SuperOffice. These controls have a lot built-in, like search capabilities and history.

* [Custom Archive controls][9] - create controls that display rows of information from built-in or custom archive providers

* [Custom AJAX methods][10] - how to call server-side methods both asynchronously and synchronously from client-side Javascript

## Troubleshooting

To debug, use the developer tools of your browser and the SuperOffice [Diagnostics viewer and Debug window][2]

<!-- Referenced links -->
[1]: folder-structure.md
[2]: debug.md
[3]: architecture.md
[4]: set-up-custom-folder.md
[5]: ../pagebuilder/config/soml.md
[6]: ../tutorials/tutorial-1.md
[7]: ../pagebuilder/datahandlers/index.md
[8]: ../pagebuilder/usercontrols/lists/create-custom-mdo-controls.md
[9]: ../pagebuilder/usercontrols/archives/create-custom-archive-control.md
[10]: ../custom-ajax-methods.md
[11]: change-system-config.md

<!-- Referenced images -->
[img6]: media/web-client-custom-code.png
