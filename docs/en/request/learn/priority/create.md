---
uid: help-en-request-priority-create
title: Create priority
description: Create priority
<<<<<<< HEAD
author: HanneGunnarsson
so.date: 06.29.2022
=======
author: SuperOffice RnD
so.date: 02.10.2023
>>>>>>> 12524e485807edd9647d7ffe0382f40dbcb340f9
keywords: request, priority
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Create priority

The default priorities included with the system are **High**, **Medium** and **Low**. But you can both add new priorities and edit the settings of existing priorities.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

**Steps:**

1. In Settings and maintenance, go to the **Priorities** screen by clicking the **Requests** button in the navigator and selecting the **Priorities** tab.

<<<<<<< HEAD
2. Click the **Add** button.
=======
    * In Settings and maintenance: Click the **Requests** button in the navigator. Then select the **Priorities** tab.
>>>>>>> 12524e485807edd9647d7ffe0382f40dbcb340f9

3. Enter a descriptive name for the priority by replacing the text *Priority name* above the tabs.

4. In the **Properties** tab, enter the following information:

    * External
    * Use as default
    * Deadline
    * Deleted

    For details about each field, see [Priority settings](#priority-settings).

5. Under **Time frame**, specify the time frame that applies to request processing.

    * Specify time intervals for each day of the week.

    * Optionally enter days to exclude in the **Holidays (day/month)** field. Select **Include year** to include the year in these dates.

6. In the **Escalation events** tab, specify how the escalation chain operates in response to different events in the request. The following options are available:

    * Request read by owner
    * Changed user (manually)
    * New information
    * Request closed
    * Changed priority

        > [!NOTE]
        > If you select **Continue**, the request proceeds at the same level in the escalation chain as it had before the change. In other words, the times are not used if there is a change, only the level.

    * New request
    * Escalate requests according to time frame

    For details about each option, see [Priority settings](#escalation-options).

7. Click **Save**. The priority is created. Now you can, for example, [link escalation levels to this priority][1].

## Priority settings

| Setting | Description |
|---|---|
| Name | A descriptive name for the priority. |
| Deleted | Is the priority active (normal) or deleted (unavailable).|
| External | Checking here makes the priority accessible from SuperOffice Customer Centre. |
| Use as default | Checking here makes this priority the default one. |
| Deadline | The deadline that requests with this priority should have. This value is calculated on the basis of the time frame for the priority and saved for each request. The result specifies when the request's time frame expires. |
| Time frame | Time intervals for each day of the week that applies to request processing. |
| Holidays (day/month) | Days to exclude from the time frame. This is normally used for public holidays when it is not desirable for requests to be escalated. The format is a comma-separated list of day/month entities. For example, to exclude 25th and 26th December, enter: 25/12, 26/12. You can also add dates using the date field below. |
| Include year | Checking here includes the year in the holiday dates. |
| Escalate requests according to time frame | If checked, requests with this priority are escalated only during the priority's defined time frame. Outside of the periods defined in the **Time frame** tab, escalation will be "frozen". |

## Escalation options

| Option | Description |
|---|---|
| Request read by owner | If checked, the escalation chain is controlled as specified in the list box on the right when a request is read by the owner. In all the list boxes in this tab, you can choose from the operations: **Stop**, **Continue** and **Restart**. |
| Changed user (manually) | If checked, the escalation chain is controlled as specified in the list box on the right when a request manually changes owner. |
| New information | If checked, the escalation chain is controlled as specified in the list box on the right when new information arrives on a request. For example, the customer or user adding a new message to the request. |
| Request closed | If checked, the escalation chain is controlled as specified in the list box on the right when a request is closed. |
| Changed priority | If checked, the escalation chain is controlled as specified in the list box on the right when the priority of a request is replaced with this priority. |
| New request | If checked, the escalation chain is controlled as specified in the list box on the right when a new request with this priority arrive in the system. |

<!-- Referenced links -->
[1]: escalation-levels.md

<!-- Referenced images -->
