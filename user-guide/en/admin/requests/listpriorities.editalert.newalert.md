---
uid: help-en-admin-listpriorities-editalert-newalert
title: admin listPriorities editAlert newAlert
description: admin listPriorities editAlert newAlert
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create escalation levels

For each priority you can define one or more escalation levels, so that the system forwards the enquiry further through the organisation if it has not been read or handled within a specified time.

To create a new escalation level:

1. Click the **Requests** button in the navigator.
2. Select the **Priorities** tab.
3. Select a priority for which you want to create escalation levels.
4. Select the **Escalation levels** tab.
5. Click the **Add** button. You are now creating the first escalation level.
6. Enter the following information:
    * **Occurs after**: Enter how much time must pass before this escalation level is enabled. If the priority has been defined to have its escalation comply with the time frame, that will affect the time entered here. A priority with a time frame of Monday to Friday, 09.00 to 17.00 and first escalation level after 2 hours, would, for example, be escalated at 10.00 on Monday, if the request was registered at 16.00 on the preceding Friday.
    * **Reassign to**: If you want the request to be forwarded to another user when this escalation level occurs, check here. Then select the user you require in the list.
    * **Run script**: If you want a script to be run when this escalation level occurs, check here. Then select the script you require in the list.
7. Under **Send reply template**, you can define who should receive an e-mail and SMS when this escalation level is triggered. Select the check boxes for **E-mail** or **SMS** next to each recipient, and select the relevant reply template. If you select **Others**, you must enter the relevant e-mail addresses (use commas) and phone numbers in the fields below.
8. Click **Save**.
9. Repeat these steps to create additional escalation levels.
10. If you have created multiple escalation levels, you can define the order in which they should occur using the arrow buttons below the list of escalation levels.

## Delete escalation level

To delete an escalation level, do as follows:

1. Select the escalation level you want to delete.
2. Click the **Delete** button at the bottom of the screen.
