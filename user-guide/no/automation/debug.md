---
uid: help-en-automation-script-debug
title:  Debug sessions
description:  Debug sessions
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: no
---

# Debug sessions

[!include[Requirement](../includes/req-expander-services.md)]

The **Debug sessions** tab contains a list of all active debug sessions in the system. Click a session in the list to open it in **Debugger**.

To go to the **Debug sessions** tab:

* In SuperOffice Service: Select ![icon][img2] **System settings** > **System design** > **CRMScript** and go to the **Debug sessions** tab.
* In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator and go to the **Debug sessions** tab.

## Start debug session

You can start one of these sessions by running a script in debug mode from the **Script** screen, or by calling the function "Void enableDebug(String key)" in a CRMScript.

You can also click ![icon][img1] **Start tracing scripts** to start [tracing][2] the scripts in the list.

## Debugger

The debug tool makes it easy to find and fix bugs inside your scripts and macros. You can debug your scripts and macros in a production environment, without interfering with the other SuperOffice users. It allows you to investigate your scripts and macros in real time, while they are executed. You can step through the execution of your script, use breakpoints and view the variable values.

You can debug a script or macro by opening it in the **Macros and scripts** tab and click ![icon][img4] **Debug script**.

To go to the **Macros and scripts** tab:

* In SuperOffice Service: Select ![icon][img2] **System settings** > **System design** > **CRMScript** and go to the **Macros and scripts** tab.
* In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator and go to the **Macros and scripts** tab.

You can also click ![icon][img3] **Trace script** to start [tracing a script][2].

<!-- Referenced links -->
[2]: tracing.md

<!-- Referenced images -->
[img1]: ../../media/icons/btn-executescript.png
[img2]: ../../media/icons/globalmenu-settings-small.png
[img3]: ../../media/icons/btn-script-trace-small.png
[img4]: ../../../common/icons/bug.png

