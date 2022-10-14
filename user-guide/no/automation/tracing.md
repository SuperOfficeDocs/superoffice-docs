---
uid: help-en-automation-script-tracing
title: Tracing
description: Tracing
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: no
---

# Tracing

The tracing feature will record every detail in the execution of a script or macro and save it in a log. Every time the script or macro is used, the execution is recorded.

You can then investigate the script execution by rewinding and fast-forwarding through the recording. You get a full list of all the recorded executions of the script, and by whom the script was executed. This allows you to see how your scripts behaved and see all the variables at any given point.

## View tracings

The **Tracing** tab contains a list of all traces. Click a trace in the list to view the details.

## Start tracings

To start tracing scripts:

* Go to **CRMScript** > **Debug sessions** and click ![icon][img1] **Start tracing scripts** to start tracing the scripts in the list.
* Open a script or macro in **Debugger** and click ![icon][img2] **Trace script**.
* Open a script or macro in the **Macros and scripts** tab and click ![icon][img2] **Trace script**.

## Edit tracings

1. Click a trace in the **Tracing** list to open it.
2. Click ![icon][img3] **Edit trace**. The **Edit trace** screen displays.
3. Fill in the following fields:
    * **Description**: Enter a description of the trace, to make it easier to identify.
    * **User filter**: If you want to trace the script for a specific user, select the user from the list.
    * **Trace resolution**: Enter the sampling frequency of the trace log.
        Example: Enter 1 to log every command that is executed by the script. Enter 5 to log every fifth command that is executed by the script.
    * **Keep traces**: Select how long the trace logs should be kept.
    * **Enabled**: Select this option to activate the trace.
4. Click **OK** when you are done.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../media/icons/btn-executescript.png
[img2]: ../../media/icons/btn-script-trace-small.png
[img3]: ../../media/icons/edit.png

