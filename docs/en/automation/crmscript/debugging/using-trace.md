---
uid: crmscript-debug-using-trace
title: Using trace
description: How to trace a CRMScript.
author: Bergfrid Dias
date: 12.21.2023
keywords: CRMScript, trace, debug
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
---

# Using trace

SuperOffice CRM Online has a built-in tracing feature. When turned on, all details will be logged when the script is run. You can then investigate the behavior of the script step by step by rewinding and fast-forwarding the [log][1]. You can also see all the variables at any given point.

## Starting a trace

1. Bring up your script in SuperOffice Settings and maintenance.
2. Click **Trace script**.
3. Make sure the trace has a description and is enabled.
4. Optionally, set **User filter** if you want a user-specific trace.
5. Optionally, enable notifications.
6. Optionally, specify sampling frequency, expiration, and exception-only tracing.
7. Click **OK**.

![Trace CRMScript statistics -screenshot][img1]

Now you've activated tracing on the script. Keep this tab open for now. In a new tab, do the task that will trigger the script. For example, if your script should run before saving a company, go to a company card, click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) and then click **Save**. Return to the open trace tab.

## Inspecting a trace

1. Click **Refresh** and select the row from the recent run.
    * The left side shows the script. The row you're tracing is highlighted.
    * The right side shows all available variables. Click the ellipse (…) to expand.

2. Use the slider or the **Step** buttons to "re-run" the script and explore the variables and statements.

3. When you are done, or want to update your script, click **Return**.

### Call stack depth

CRMScript keeps track of its current call stack depth, and saves it with the tracing information.

Consecutive code lines are usually at the same depth. Staying at a certain depth means that you don't step into functions being called.

Using the call-stack depth, you can do much more advanced stepping when inspecting a trace:

* Step back: Go back to the previous statement at the current depth.

* Step in: Go to the next trace frame.

* Step out scope: Exit current scope (for example a loop) and go to the next statement.

* Step out: Exit current function and go to the next statement.

* Step next: Go to the next statement at the same depth or higher in the stack.

## Max number of trace-runs and storage

A script trace will be disabled when it has traced 100 times or the sum of saved data for that trace reaches 100MB. If you have reached the limit, manually delete some trace-runs or wait until they expire. Expired trace-runs are automatically deleted nightly. Remember to re-enable the trace to resume tracing.

The number of runs and accumulated data size are shown per trace and in the list of traces.

Consider when and what you need to trace. The **Only trace when it is required** checkbox logs only unhandled exceptions or if the function `forceSaveTrace(true)` is called within the script. Pair this with notifications to monitor your scripts.

## Notifications

While editing the trace, you have the option to enable notifications. This feature pairs well with the exception-only setting. Input the email address where you'd like notifications sent after saving a trace run. To avoid excessive emails, indicate the number of emails you wish to dispatch; this count will decrease with each email sent.

<!-- Referenced links -->
[1]: ./log-messages.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/trace.png
