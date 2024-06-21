---
uid: help-en-automation-schedule-task
title:  Scheduled tasks
description: Scheduled tasks
author: SuperOffice RnD
date: 06.29.2022
keywords: macro, script, schedule
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Scheduled tasks

In the **Scheduled tasks** tab you can specify that a script or macro should be run at specific times.

> [!TIP]
> Time-consuming tasks should be scheduled at times when few people are using SuperOffice.

Click a task in the list to edit its properties, such as when it was last executed, execution time and sent/received objects.

## Create a new scheduled task

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Click **CRMScript** and select the **Scheduled tasks** tab.

1. Click **New task**.

1. Select how often the task should be performed, in the **Frequency** list. **Run after another schedule** can be used to start a task after another task has completed. You can use this option to chain tasks together.

1. Click **OK**.

1. Fill in the following fields in the **Properties** tab:
    * **Name**: Enter a name for the task.
    * **ejScript/CRMScript**: Select the script or macro to use in the task.

1. Click **Apply** and go to the **Schedule** tab.

1. Select **Start now** to run the task the next time the system checks for scheduled tasks (normally withing 1 minute).

1. Select **Disable** if the task should be inactive for the time being.

1. Edit the schedule. The available fields will depend on the selected frequency:

    * **Never**: The task does not run unless you select **Start now**.
    * **Minute interval**: The task runs at the selected interval (in minutes). Make sure the interval is longer than the time it takes to run the task.
    * **Hourly**: The task runs hourly, at X minutes past the hour.
    * **Week interval**: The task runs weekly. Enter the time and on which day(s) the task should be run.
    * **Month interval**:The task runs monthly. Enter the time, on which day of the month, and in which month(s).
    * **After**: The task runs at the set date and time.
    * **Run after schedule**: The task runs when the selected scheduled task is complete. You can use this option to chain tasks together.

1. Set **Lock time in minutes** to prevent multiple tasks from the same schedule to run at the same time. You should set this value higher than the expected run time for your task. If your task takes more time than specified here, it is considered failed, and a new task from the same schedule is allowed to run.

1. Set **Minutes before restart after error**. This setting specifies the time before a failed task (a task that has crashed) will be re-run.

1. Click **OK**. The task is added to the list, and you can see the status and time of the next execution of the task.

## Related content

* [Best practices][1]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/code-quality/best-practices.md
