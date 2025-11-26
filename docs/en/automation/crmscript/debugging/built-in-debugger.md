---
uid: crmscript-built-in-debugger
title: Built-in debugger
description: Use the built-in CRMScript debugger to step through code, inspect variables, and manage active debug sessions.
keywords: debug CRMScript, debug script, debug sessions
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/automation/crmscript/learn/debug
  - /da/automation/crmscript/learn/debug
  - /de/automation/crmscript/learn/debug
  - /nl/automation/crmscript/learn/debug
  - /no/automation/crmscript/learn/debug
  - /sv/automation/crmscript/learn/debug
---

# Built-in debugger

SuperOffice CRM has an integrated graphic debugger. Use it to step through code, set breakpoints, and inspect variables in real time.

## How to run in debug mode

1. In **Settings and maintenance**, select **CRMScripts** in the navigator.

1. Open the **Macros and scripts** tab and select your script.

1. Click the **Debug script** button.

The debugger opens with the code panel on the left and variables, information, and script status on the right. You can:

* Click **Step** to go to the next statement.

* Click a line number to set a breakpoint, and then click **Next breakpoint** to advance the script to that point.

* Click a code line with a statement to run the script until that line

* Run to the end of the script.

* Stop execution of the script.

> [!CAUTION]
> Use the debugger with care. Otherwise, the server will soon become swamped with processes running scripts in debug mode.

## Debug sessions tab

The **Debug sessions** tab lists all active debug sessions in the system. Select a session to open it in the debugger.

### Start a debug session

A session starts when you run a script in debug mode from the **Script** screen, or when a script calls `enableDebug(String key)`.

You can also click **Start tracing scripts** to begin [tracing][2] the scripts in the list.

## Debug panel (onsite)

If you have an **onsite** tenant:

1. Call `enableDebug(String)` in the script with ID matching value set in */bin/rms.exe?action=debug*.
2. Then call `debugWait()` (consider it a breakpoint). This opens the **Debug** panel.

Parameters set in the **Debug** panel are stored in browser cookies and apply to your session only. This lets you debug without disturbing other users and avoids crowding the log files.

If the script is run from another browser (where the ID is different or not set), it will run as normal, ignoring all calls to `enableDebug()` and `debugWait()`. This allows you to debug in a "hot" environment.

## Related content

* [Tracing scripts][2]

<!-- Referenced links -->
[2]: using-trace.md
