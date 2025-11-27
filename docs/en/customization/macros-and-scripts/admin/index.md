---
uid: help-en-crmscript
title: CRMScript
description: CRMScript is a feature that allows you to automate tasks in or modify the behavior of SuperOffice.
keywords: CRMScript
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: concept
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /en/automation/crmscript/learn/macro-script
  - /en/automation/crmscript/learn/screen/index
  - /en/automation/crmscript/learn/index
language: en
index: true
---

# CRMScript

CRMScript is a feature that allows you to automate tasks in or modify the behavior of SuperOffice. Automating tasks and processes will help you to save time and will make you and your colleague more productive.

The different tools, macros and scripts, triggers and scheduled tasks, have different capabilities and are used for different purposes. The following is an introduction to the flexible and powerful embedded scripting tool – CRMScript.

## Access CRMScript

To access the functions in CRMScript open SuperOffice Settings and maintenance and click <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** in the navigator.

Triggers are scripts that are executed for specific events in the system, such as when a new sale is created or a request gets closed. Triggers can react silently to what happens, or block the operation and show an explanation back to the user.

## About macros

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

## Macros and scripts tab

In the **Macros and scripts** tab on **CRMScript** you will find a list of the scripts and macros in the system, grouped in folders. Click a script or macro in the list to view, edit or run it.

The **Macros and scripts** tab includes the following buttons: **New script**, **New macro**, **New folder**, and **Search**.

### Script screen

When you click a script or macro in the **Macros and scripts** tab, the **Script** screen opens. In addition to the information in the top part of the screen, you can find more script details in the **Description** and **Script** tabs.

**Options:**

| Button | Description |
|---|---|
| Macros and scripts | Used to return to the list of the scripts and macros. |
| Edit script | Used to edit the [script or macro][8]. |
| Run script | Used to run the script or macro in standard mode. |
| Debug script | Used to open the **Debugger** screen and run the selected script or macro in debug mode. The script stops at the first line. You can open a [debug session][4] from the **Debug sessions** tab. |
| Trace script | Used to start [tracing the script or macro][5]. |

## Related content

* [Create a script][8]
* [Create a macro][9]
* [Create folder][10]
* [Learn the CRMScript language][6]
* [CRMScript API reference][7]

<!-- Referenced links -->
[2]: trigger.md
[3]: schedule-task.md
[4]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[5]: ../../../../en/automation/crmscript/debugging/using-trace.md
[6]: ../../../../en/automation/crmscript/overview/index.md
[7]: ../../../../en/automation/crmscript/reference/index.md
[8]: create-script.md
[9]: create-macro.md
[10]: create-script.md#folder
