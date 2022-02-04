---
title: Overview
uid: b_tutorial_sale_foreignkeys
description: Sale foreign-keys tutorial
author: Steffan Alte
so.date: 07.25.2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# Overview

In addition to customizing the existing pages in SuperOffice, you can of course create new ones. The pages you create can contain any ASP.NET controls, but to be able to tap into the rest of the application, you will need to inherit from the SuperOfficer controls.

![sale dialog][img1]

This tutorial has 3 parts.

In part 1, we will look at how to create a user control that inherits from and thereby taps into the context of the SuperOffice web application directly, giving you access to everything that the standard SuperOffice user control has access to.

* How to set up the user control in a new view on an existing page
* How to easily configure your user control by using the configuration section for the control in the page configuration file.

In part 2, we will take a look at how you can create your own data handlers for a page, and we will be creating a new Sales data handler to be used in the **Sales** dialog to create new foreign keys when pressing the **Save** button.

* How to set up your own data handler
* How to create data sources for the controls on a page
* How to pass data from a custom user control to the custom data handler
* How to extend the Save functionality of a page

In part 3, we will look at how to create custom MDO controls.

* How to create an MDO provider plugin
* How to create and add the the MDO control to a page
* How to update a data carrier with the value of the selected item from your MDO control

The main point to take away from this tutorial is that you can extend and use the controls that are available to you in the CRM.web framework along with NetServer to build the functionality that suits your purpose.

## Best practices

* Put your modifications at the end of the config file and also add a comment letting other developers know that this is not a part of the standard installation.

* Always put your own controls (and other files) in separate folders instead of mixing them up with the installed files. This makes life a lot easier when upgrading SuperOffice.

* Name the soprotocols for your own views, controls, and so on with a specific prefix, so that they do not interfere with existing CRM.web soprotocols.

[!include[ALT](../includes/before-you-begin.md)]

[Let's start!][1]

<!-- Referenced links -->
[1]: 1-add-fk-datagrid-to-sale-page.md
[2]: 2-create-sale-datahandler.md
[3]: 3-create-custom-mdo-control.md

<!-- Referenced images -->
[img1]: media/image018.jpg
