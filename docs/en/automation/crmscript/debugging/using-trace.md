---
uid: crmscript-debug-using-trace
title: Using trace
description: How to trace a CRMScript.
keywords: Trace script, trace CRMScript, debug CRMScript
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/automation/crmscript/learn/tracing
  - /da/automation/crmscript/learn/tracing
  - /de/automation/crmscript/learn/tracing
  - /nl/automation/crmscript/learn/tracing
  - /no/automation/crmscript/learn/tracing
  - /sv/automation/crmscript/learn/tracing
---

# Using trace

SuperOffice CRM Online has a built-in tracing feature. When enabled, each run of a script or macro is recorded and stored in a [log][1]. You can investigate the behavior of the script step by step by rewinding and fast-forwarding through the recording. You can also inspect the variables at any point in the run.

## Tracing tab

The **Tracing** tab lists all traces in the system. Select any trace to view its details.

![Trace CRMScript statistics -screenshot][img1]

## Start a trace

1. Open your script or macro in Settings and maintenance.
1. Click **Trace script**.
1. Enter a clear **description**.
1. Optionally, set **User filter** to trace only runs by a specific user.
1. Optionally, enable notifications.
1. Optionally, configure sampling frequency, retention settings, and exception-only tracing.
1. Select **Enabled**.
1. Click **OK**.

After enabling a trace, keep the tab open. In a new tab, perform the action that triggers the script. For example, if your script runs before saving a company, go to a company card, click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>), and then click **Save**. Return to the trace tab and refresh.

## Inspect a trace

1. Click **Refresh** and select the row from the recent run.
    * The left side shows the script, with the current line highlighted.
    * The right side shows all variables. Click the ellipse (…) to expand.
1. Use the slider or **Step** buttons to move through the variables and statements.
1. Click **Return** when done.

### Call-stack depth

CRMScript keeps track of its current call stack depth, and saves it with the tracing information.

Consecutive code lines are usually at the same depth. Staying at a certain depth means that you don't step into functions being called.

Using the call-stack depth, you can do much more advanced stepping when inspecting a trace:

* **Step back:** Go to the previous statement at the current depth.
* **Step in:** Go to the next frame.
* **Step out scope:** Exit the current scope (for example, a loop) and go to the next statement.
* **Step out:** Exit the current function and go to the next statement.
* **Step next:** Go to the next statement at the same depth or higher.

## Manage all traces

1. Go to **CRMScript** > **Debug sessions**.
1. Click **Start tracing scripts** to turn on all enabled traces.
1. Click **Stop tracing scripts** to pause tracing.

## Edit a trace

1. In the **Tracing** tab, select a trace.
1. Click **Edit trace**.
1. Update the fields as needed.
1. Click **OK**.

## <a id="fields"></a>Field reference

| Field | Description |
|---|---|
| Description | A label for identifying the trace. |
| User filter | Limits tracing to a specific user. |
| Trace resolution | Sampling frequency. For example, 1 traces every run; 5 traces every fifth run. |
| Keep traces | How long to keep trace data before deletion. |
| Enabled | Activates the trace. |
| Notify | Sends notification emails. |
| Max number of notifications | Maximum number of emails to send. |
| Notification email | Recipient email address. |
| Only save if there is an unhandled exception | Saves trace runs only when an exception occurs, or when `forceSaveTrace(true)` is called. |

## Limits and storage

A trace is disabled when it reaches 100 runs or 100 MB of stored data. Delete older runs or wait for automatic nightly cleanup. Re-enable the trace to continue tracing.

Consider what you need to trace. The **Only trace when it is required** setting logs only unhandled exceptions or calls to `forceSaveTrace(true)`. Use this together with notifications to monitor scripts efficiently.

## Notifications

If notifications are enabled, emails are sent after saving a trace run. To avoid excessive messages, you can limit the number of emails sent. The counter decreases with each email.

## Related content

* [Log messages][1]

<!-- Referenced links -->
[1]: log-messages.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/trace.png
