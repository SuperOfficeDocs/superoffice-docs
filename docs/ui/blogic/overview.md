---
uid: service_ui
title: Service UI
description: UI interaction and customization for service
author: Bergfrid Dias
so.date:
keywords:
so.topic: concept
---

# UI interaction and customization

A guide to interacting with and customizing the SuperOffice UI through CRMScript.

## Screen events and hook scripts

* [Screen events][1] represent steps in the process of loading Service screens.

* *Hook scripts* are event-driven CRMScripts that do stuff at a specific point during loading.

## Extra menus and button scripts

* [Extra menus][2] let you make something easily available in SuperOffice Service. For example, a button that takes the user directly to a specific screen or a menu option that triggers a script.

* [Button scripts][3] are CRMScripts that are referenced by their **includeId** and run when the user clicks a custom button.

## Custom screens (bLogic)

**bLogic** is a system for [designing screens][4] and displaying content in SuperOffice Service.

Custom screens are based on a set of [screen elements][5] (controls) such as text, date, grid, and CRMScript.

There are 3 types of screen elements:

* [View elements][6]: display info (read-only)
* [Form elements][7]: create user interaction with input fields
* [Group elements][8]: create a hierarchy of elements and determine the layout of the screen

These are listed in the [element reference][9].

With scripts, you can:

* process the form data of a screen - for example, to create a request or send an email

* construct and modify a screen that requires a more dynamic layout - for example, to add an element only if the customer is of a specific category

## Screen choosers

[Screen choosers][10] are CRMScripts that redirect to a custom screen (or perform other actions before loading a standard screen).

## URL parameters

[URL parameters][11] let you control SuperOffice Service using simple HTTP commands.

## Web panels

[Web panels][12] let you add webpages inside SuperOffice CRM.

## SOProtocol

[SOProtocol][13] is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the entry in question.

## Classes

* [EventData][14]
* [HtmlElement][15]
* [MainMenu][16]

<!-- Referenced links -->
[1]: screen-events.md
[2]: extra-menus.md
[3]: button-scripts.md
[4]: custom-screens/index.md
[5]: custom-screens/add-screen-element.md
[6]: custom-screens/view-elements.md
[7]: custom-screens/form-elements.md
[8]: custom-screens/layout-elements.md
[9]: blogic-screen-elements/index.md
[10]: screen-choosers.md
[11]: url-parameters.md
[12]: ../web-panels/index.md
[13]: ../soprotocol/index.md
[14]: <xref:CRMScript.Native.EventData>
[15]: <xref:CRMScript.Native.HtmlElement>
[16]: <xref:CRMScript.Native.MainMenu>
