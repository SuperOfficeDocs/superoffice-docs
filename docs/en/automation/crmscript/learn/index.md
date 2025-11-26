---
uid: help-en-crmscript
title: CRMScript
description: CRMScript is a feature that allows you to automate tasks in or modify the behavior of SuperOffice.
author: SuperOffice RnD
date: 02.22.2023
keywords: CRMScript
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from:
  - /en/automation/crmscript/learn/macro-script
---

# CRMScript

CRMScript is a feature that allows you to automate tasks in or modify the behavior of SuperOffice. Automating tasks and processes will help you to save time and will make you and your colleague more productive.

The different tools, macros and scripts, triggers and scheduled tasks, have different capabilities and are used for different purposes. The following is an introduction to the flexible and powerful embedded scripting tool – CRMScript.

## Access CRMScript

To access the functions in CRMScript open SuperOffice Settings and maintenance and click <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** in the navigator.

Triggers are scripts that are executed for specific events in the system, such as when a new sale is created or a request gets closed. Triggers can react silently to what happens, or block the operation and show an explanation back to the user.

## Macros and scripts

In the **Macros and scripts** tab on **CRMScript** you will find a list of the scripts and macros in the system, grouped in folders. Click a script or macro in the list to [view, edit or run it][1].

### About macros

Macros are the user-friendly version of scripts: You do not need extensive knowledge about scripting or CRMScript to create macros.

With macros, you can customize and automate actions inside SuperOffice. It comes with an easy to use wizard that will help you setup your macro.

Macros have multiple functions in SuperOffice. They can be linked to specific [triggers][2] in the system (such as escalations or new message on request in SuperOffice) or be assigned to buttons in defined screens, so that users can click a button to perform a set of actions that are often repeated. This makes request management faster and users avoid unnecessary clicking.

For example, you can use macros:

* As a task/function in a menu point (such as in **Task** in the Request screen)
* When a request is escalated via the warning levels for priority
* As a planned task
* When they are activated by an email filter
* When a recipient clicks a tracked link in a mailing

### What is the difference between a script and a macro?

A macro is a set of predefined actions executed in a specific order, and require no programming skills to set up.

A script is a small program written to perform specific tasks, and requires programming skills to set up.

## Tabs

* [Macros and scripts][8] - Create macros and scripts to automate and schedule tasks in SuperOffice.
* [Triggers][2] - Define that a certain event in the system will trigger one or more predefined actions.
* [Scheduled tasks][3] - Specify that a script or macro should be run at specific times.
* [Debug sessions][4] - Find and fix bugs inside your scripts and macros.
* [Tracing][5] - Record every detail in the execution of a script or macro and save it in a log.

## Related content

* [View a script/macro][1]
* [Create a script][8]
* [Create a macro][9]
* [Create folder][10]
* [Learn the CRMScript language][6]
* [CRMScript API reference][7]

<!-- Referenced links -->
[1]: screen/index.md
[2]: trigger.md
[3]: schedule-task.md
[4]: debug.md
[5]: tracing.md
[6]: ../../../../en/automation/crmscript/overview/index.md
[7]: ../../../../en/automation/crmscript/reference/index.md
[8]: create-script.md
[9]: create-macro.md
[10]: create-script.md#folder
