---
uid: help-en-automation-script-debug
title:  Debug sessions
description: Debug sessions
author: SuperOffice RnD
date: 06.29.2022
keywords: CRMScript
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Debug sessions

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

The **Debug sessions** tab contains a list of all active debug sessions in the system. Click a session in the list to open it in **Debugger**.

## Go to the Debug sessions tab

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Click **CRMScript** and select the **Debug sessions** tab.

## Start debug session

You can start one of these sessions by running a script in debug mode from the **Script** screen, or by calling the function "Void enableDebug(String key)" in a CRMScript.

You can also click **Start tracing scripts** to start [tracing][2] the scripts in the list.

## Debugger

The debug tool makes it easy to find and fix bugs inside your scripts and macros. You can debug your scripts and macros in a production environment, without interfering with the other SuperOffice users. It allows you to investigate your scripts and macros in real time, while they are executed. You can step through the execution of your script, use breakpoints and view the variable values.

You can debug a script or macro by opening it in the **Macros and scripts** tab and click <i class="ph ph-bug" aria-hidden="true"></i> **Debug script**.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Click **CRMScript** and select the **Macros and scripts** tab.

You can also click **Trace script** to start [tracing a script][2].

<!-- Referenced links -->
[2]: tracing.md
