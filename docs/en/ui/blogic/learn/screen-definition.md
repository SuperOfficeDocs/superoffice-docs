---
uid: help-en-service-screen-definition
title: Screen definition
description: Screen definition
author: SuperOffice RnD
date: 06.29.2022
keywords: screen definition
content_type: reference
language: en
---

# Screen definition

[!include[Requirement](../../../includes/req-dev-tools.md)]

Here you can view the details of the selected screen.

* **Edit screen**: Used to edit the screen. See [Screen properties][1].

* **Edit language**: Used to edit screen texts for the available languages. Select a language tab and edit the available texts.

* **New element**: Used to add a new element to the screen. See element properties below.

* **New script**: Used to add a new script. Here you can enter a script to be run when the user clicks the button.

* **New macro**: Used to [add a new macro][5].

* **Show screen**: Shows the screen.

* **Design mode**: Shows the screen in design mode (see below).

* **List mode**: Shows all the screen elements in a list, as opposed to design mode.

## Button script properties

* **Name**: The name of the button.
* **Check field values first**: If this option is enabled, the content in the form fields will be validated before the script is executed. If one or more of the values are invalid, then the user will be returned to the form where the errors will be indicated.
* **Script**: Here you enter the script which this button executes.

## Element properties

Here you can edit the properties of a screen element, including a construction script for the element and simple values that are specific to the different types of elements (such as title, name). One such property is the body, which many elements have, and, because these can be quite long, they have their own pane.

## Design mode

In design mode, you can double-click the required option on the toolbar on the right to create an element. Each element has a rectangular handle you can click to display a menu, which lets you, for example, move the element or add the element type which is selected on the toolbar.

Many of the elements contain sample data when they are inserted, to illustrate the appearance they will have when the screen is run.

 The following tabs are displayed:

* **Elements**: The elements in the screen.
* **Buttons**: Lists the buttons connected to actions in the screen.

<!-- Referenced links -->
[1]: screen-properties.md
[5]: ../../../customization/macros-and-scripts/admin/create-macro.md

<!-- Referenced images -->
