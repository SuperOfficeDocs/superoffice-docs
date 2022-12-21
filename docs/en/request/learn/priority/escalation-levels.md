---
uid: help-en-request-escalation
title: Escalation levels
description: Escalation levels
author: SuperOffice RnD
so.date: 06.29.2022
keywords: request, priority, escalate
so.topic: howto
language: en
---

# Escalation levels

For each priority you can define one or more escalation levels, so that the system forwards the enquiry further through the organization if it has not been read or handled within a specified time.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Define new levels in Settings and maintenance

1. Go to the **Priorities** screen: Click the **Requests** button in the navigator. Then select the **Priorities** tab.

1. Select a priority for which you want to create escalation levels.

1. Select the **Escalation levels** tab.

1. Click the **Add** button. You are now creating the first escalation level.

1. Enter the following information:

    * **Occurs after**
    * **Reassign to**
    * **Run script**

    Details about each field are specified below.

1. Under **Send reply template**, you can define who should receive an email and SMS when this escalation level is triggered.

    Select the checkboxes for **Email** or **SMS** next to each recipient, and select the relevant reply template. If you select **Others**, you must enter the relevant email addresses (use commas) and phone numbers in the fields below.

1. Click **Save**.

1. Repeat these steps to create additional escalation levels.

1. If you created multiple escalation levels, you can define the order that they should occur in using the arrow buttons below the list of escalation levels.

## Define new level in Service

1. Go to the **Priorities** screen: Select ![icon][img1] > **Priorities**.

1. Click the **New escalation level** button. This takes you to the **Escalation level properties** screen.

1. In the **Actions** tab, enter the following information:

    * **Priority**
    * **Level** (the position in the escalation chain)
    * **Occurs after** (click ![icon][img2] and define the delay)
    * **Reassign to**
    * **Run script**

    Details about each field are specified below.

1. Optionally, specify use of reply templates in the **Send reply template by email to** and **Send reply template by SMS to** tabs.

    * Contact
    * Request owner
    * Category administrator
    * Others
    * Email address

    Details about each option are specified below.

    > [!NOTE]
    > If the **Send reply template by SMS to** tab is not displayed, this means that SMS has not been enabled for the licence you are using. Contact your system administrator for more information.

1. Click **OK**. The escalation level is created, and is displayed under the selected priority, in the **Priorities** screen.

## Escalation settings

| Setting | Description |
|---|---|
| Priority | The priority you want to link the escalation level to. |
| Occurs after | How much time must pass before this escalation level is enabled. If the priority is defined to have its escalation comply with the time frame, that will affect the time entered here. A priority with a time frame of Monday to Friday, 09.00 to 17.00 and first escalation level after 2 hours, would, for example, be escalated at 10.00 on Monday, if the request was registered at 16.00 on the preceding Friday. |
| Reassign to | If you want the request to be forwarded to another user when this escalation level occurs, check here. Then select the user you require in the list. |
| Run script | If you want a script to be run when this escalation level occurs, check here. Then select the script you require in the list. |

## Reply template settings

| Setting | Description |
|---|---|
| Contact | If checked, the reply template specified in the field to the right is sent to the contact for the request when this escalation level occurs. Select the required reply template in the list. |
| Request owner | If checked, the reply template specified in the field to the right is sent to the owner of the request when this escalation level occurs. Select the required reply template in the list. |
| Category administrator | If checked, the reply template specified in the field to the right is sent to the category administrator when this escalation level occurs. Select the required reply template in the list. |
| Others | If checked, the reply template specified in the field to the right is sent to the email address(es) entered in the field below. Select the required reply template in the list. |
| Email address | Here you enter the email address which the reply template in the **Others** field should be sent to. You can enter several addresses by separating them with commas. |

## Delete escalation level

1. Select the escalation level you want to delete.
2. Click the **Delete** button at the bottom of the screen.

<!-- Referenced images -->
[img1]: ../../../../media/icons/settings-small.png
[img2]: ../../../../../common/icons/diaryblack.png
