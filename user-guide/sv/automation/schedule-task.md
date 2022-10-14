---
uid: help-en-automation-schedule-task
title:  Scheduled tasks
description:  Scheduled tasks
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: sv
---

# Scheduled tasks

In the **Scheduled tasks** tab you can specify that a script or macro should be run at specific times.

> [!TIP]
> Time-consuming tasks should be scheduled at times when few people are using SuperOffice.

Click a task in the list to edit its properties, such as when it was last executed, execution time and sent/received objects.

## Create a new scheduled task

1. Go to the **Scheduled tasks** tab:

    * In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator and select **Scheduled tasks** tab.
    * In SuperOffice Service: Select ![icon][img2] **System settings** > **System design** > **CRMScript**. Select the **Scheduled tasks** tab.

2. Click **New task**.

3. Select how often the task should be performed, in the **Frequency** list. **Run after another schedule** can be used to start a task after another task has completed. You can use this option to chain tasks together.

4. Click **OK**.

5. Fill in the following fields in the **Properties** tab:
    * **Name**: Enter a name for the task.
    * **ejScript/CRMScript**: Select the script or macro to use in the task.

6. Click **Apply** and go to the **Schedule** tab.

7. Select **Start now** to run the task the next time the system checks for scheduled tasks (normally withing 1 minute).

8. Select **Disable** if the task should be inactive for the time being.

9. Edit the schedule. The available fields will depend upon the selected frequency:
    * **Never**: The task will not be run unless you select **Start now**.
    * **Minute interval**: The task will be run at the selected interval (in minutes). Make sure the interval is longer than the time it takes to run the task.
    * **Hourly**: The task will be run hourly, at X minutes past the hour.
    * **Week interval**: The task will be run weekly. Enter at which time and on which day(s) the task should be run.
    * **Month interval**:The task will be run monthly. Enter at which time, on which day of the month and in which month(s).
    * **Once**: The task will be run at the set date and time.
    * **Run after schedule**: The task will be run when the selected scheduled task is complete. You can use this option to chain tasks together.

10. Set **Lock time in minutes**. The purpose of this setting is to prevent multiple tasks from the same schedule to run at the same time. You should set this value higher than the expected run time for your task. If your task takes more time than specified here, it will be considered failed, and a new task from the same schedule will be allowed to run.

11. Set **Minutes before restart after error**. This setting specifies the time before a failed task (a task that has crashed) will be re-run.

12. Click **OK**. The task is added to the list, and you can see the status and time of the next execution of the task.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../media/icons/globalmenu-settings-small.png

