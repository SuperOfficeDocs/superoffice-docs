---
uid: help-en-admin-listpriorities-listpriorities-editpriority
title: admin listPriorities listPriorities editPriority
description: admin listPriorities listPriorities editPriority
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create priorities

The default priorities included with the system are **High**, **Medium** and **Low**. But you can both add new priorities and edit the settings of existing priorities.

To create a new priority:

[!include[Go to priority](includes/goto-priority.md)]

1. Click the **Add** button. A new priority opens to the right.

1. Enter a descriptive name for the priority (replace the text "Priority name" above the tabs).

1. [!include[Enter properties](../../../includes/enter-properties.md)]

    * **External**: Checking here makes the priority accessible from SuperOffice Customer Centre.

    * **Use as default**: Checking here makes this priority the default one.

    * **Deadline**: Specify the deadline that requests with this priority should have. This value is calculated on the basis of the time frame for the priority and saved for each request. The result specifies when the request's time frame expires.
    For example, if the time frame is from Monday to Friday, 09.00 to 17.00 and the request has a deadline of 2 hours, a request registered at 16.00 on Friday will have a deadline of 10.00 on the following Monday.

    * **Deleted**: Check this box to set the priority as been deleted and unavailable.

1. Under **Time frame** you specify the time frame that applies to request processing.

    * Specify time intervals for each day of the week.

    * In the **Holidays (day/month)** field, enter days which are to be excluded from the time frame in their entirety. This is normally used for public holidays when it is not desirable for requests to be escalated. The format is a comma-separated list of day/month entities. For example, to exclude 25th and 26th December, enter: 25/12, 26/12. You can also add dates using the date field below.

    * **Include year**: Checking here includes the year in the holiday dates.

1. In the **Escalating events** tab, you specify how the escalation chain operates in response to different events in the request. The following options are available:

    * **Request read by owner**: If you check here, the escalation chain is controlled as specified in the list box on the right when a request is read by the owner. In all the list boxes in this tab, you can choose from the operations: **Stop**, **Continue** and **Restart**.

    * **Changed user (manually)**: If you check here, the escalation chain is controlled as specified in the list box on the right when a request manually changes owner.

    * **New information**: If you check here, the escalation chain is controlled as specified in the list box on the right when new information arrives on a request. New information might be the customer or user adding a new message to the request, for example.

    * **Request closed**: If you check here, the escalation chain is controlled as specified in the list box on the right when a request is closed.

    * **Changed priority**: If you check here, the escalation chain is controlled as specified in the list box on the right when the priority of a request is replaced with this priority.

        > [!NOTE]
        > If you select **Continue**, the request proceeds at the same level in the escalation chain as it had before the change. In other words, the times are not used in the event of a change, only the level.

    * **New request**: If you check here, the escalation chain is controlled as specified in the list box on the right when a new request with this priority arrive in the system.

        * **Escalate requests according to time frame**: If you check here, requests that have this priority will only be escalated during the priority's defined time frame. In other words, outside of the periods defined in the **Time frame** tab, escalation will be "frozen".

1. Click **Save**. The priority is created. Now you can, for example, [link escalation levels to this priority][1].

<!-- Referenced links -->
[1]: create-escalation-level.md

<!-- Referenced images -->
