---
uid: help-en-admin-listpriorities-listpriorities-editpriority
title: admin listPriorities listPriorities editPriority
description: admin listPriorities listPriorities editPriority
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create priorities

To create a new priority:

1. Select ![icon](../../../media/icons/globalmenu-settings-small.png)**System settings** &gt; **Priorities**. The **Priorities** screen appears.
2. Click the **New priority** button. This takes you to the **Priority properties** screen.
3. In the **Properties** tab, enter the following information:
    * **Name**: Enter a descriptive name for the priority.
    * **Status**: In this list box, you select either **Normal**, meaning that the priority is active, or **Deleted**, meaning that it has been deleted and is unavailable.
    * **Sort order**: Here you enter a number between 0 and 100 which determines the sort value for this priority. The higher the value, the higher the priority.
    * **External**: Checking here makes the priority accessible from SuperOffice Customer Centre.
    * **Use as default**: Checking here makes this priority the default one.
    * **Escalate requests according to time frame**: If you check here, requests that have this priority will only be escalated during the priority's defined time frame. In other words, outside of the periods defined in the **Time frame** tab, escalation will be "frozen".
4. In the **Time frame** tab, you specify the time frame that applies to request processing.
    * Use the list boxes to specify time intervals for each day of the week.
    * In the **Holidays (day/month)** field, enter days which are to be excluded from the time frame in their entirety. This is normally used for public holidays when it is not desirable for requests to be escalated. The format is a comma-separated list of day/month entities. For example, to exclude 25th and 26th December, enter: 25/12, 26/12.
5. In the **Escalating events** tab, you specify how the escalation chain operates in response to different events in the request. The following options are available:
    * **Request read by owner**: If you check here, the escalation chain is controlled as specified in the list box on the right when a request is read by the owner. In all the list boxes in this tab, you can choose from the operations: **Stop**, **Continue** and **Restart**.

    * **Changed user (manually)**: If you check here, the escalation chain is controlled as specified in the list box on the right when a request manually changes owner.

    * **New information**: If you check here, the escalation chain is controlled as specified in the list box on the right when new information arrives on a request. New information might be the customer or user adding a new message to the request, for example.

    * **Request closed**: If you check here, the escalation chain is controlled as specified in the list box on the right when a request is closed.

    * **Changed priority**: If you check here, the escalation chain is controlled as specified in the list box on the right when the priority of a request is replaced with this priority.

        > [!NOTE]
        > If you select **Continue**, the request proceeds at the same level in the escalation chain as it had before the change. In other words, the times are not used in the event of a change, only the level.

    * **New request**: If you check here, the escalation chain is controlled as specified in the list box on the right when a new request with this priority arrive in the system.

    * **Deadline**: Click ![icon](../media/calendar.png), and specify the deadline that requests with this priority should have. This value is calculated on the basis of the time frame for the priority and saved for each request. The result specifies when the request's time frame expires. For example, if the time frame is from Monday to Friday, 09.00 to 17.00 and the request has a deadline of 2 hours, a request registered at 16.00 on Friday will have a deadline of 10.00 on the following Monday. You can choose to display the resulting value by configuring your profile, by clicking ![icon](../media/btn-editelementprofile.png) in the **Request** screen or in the search results screen and adding the **Deadline** field. See [Personal profiles](admin.listProfiles.personalProfile.md).
6. Click **OK**. The priority is created. Now you can, for example, link escalation levels to this priority. See [Work with escalation levels](admin.listPriorities.editAlert.md).
