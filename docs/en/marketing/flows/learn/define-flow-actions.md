---
uid: help-en-flow-actions
title: Define flow actions
description: Define flow actions
keywords: flow, automation, flow action, run script, distribute to owner
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 11.3
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Define flow actions

## Available actions

* [Send message](#send)
* [Update participant](#update)
* [Create activity](#create)
* [Internal actions](#internal)

> [!NOTE]
> When adding or updating flow actions, keep in mind that forms and tracked links have actions too. You should make sure there are no duplicate or conflicting actions. We recommend that you include all actions one place, either in the form or in the flow.

## <a id="send"></a>Send message

Things to consider:

* How often should we send new information?​
* Should the next email be based on contact engagement, when a contact is filling in a form or clicking a tracked link?
* Should all contacts get the same content?

### Send email (mailing)

An email step is used for sending an email to an active flow participant. You can select an already prepared email or add a new one.

1. Drag the **Send email** box from the step menu and drop it into an available slot in the flowchart.

    > [!NOTE]
    > When you add an email step, you need to provide email settings before starting the flow. You will see a warning icon (like in the screenshot below) if these settings are missing. You can still save the flow! Simply continue designing the flow and return to the email settings later.

1. Choose one of the options:

    * Create new email for this step. Enter a name and click **Create**. This opens the Mailing wizard at the **Template** step.
    * Select existing email for this step. Click to select flow content.

1. Enter the **subject** of the email. Contact variables (merge tags) are available.

1. Optionally, add one or more attachments (max 25MB total).

![Add email step to flow -screenshot][img1]

> [!NOTE]
> Creating a new email as flow content is only possible from within flow UI.

### Send SMS

An SMS step is used for sending an SMS to an active flow participant.

Flow participants without a registered phone number can either skip the step (continue to next step), or exit the flow, depending on step settings

1. Drag the **Send SMS** box from the step menu and drop it into an available slot in the flowchart.

1. Enter the sender and the SMS text. Contact variables (merge tags) are available.

1. Optionally, select **Exit flow if no mobile phone is registered** and choose how to handle contacts who are unable to receive the SMS.

> [!TIP]
> If you wish to send only one SMS, keep an eye on the counter in bottom-right corner. If the number of characters exceeds 160, the message is sent as multiple SMS segments and additional pricing may apply. We recommend to keep the message brief and informative.

## <a id="update"></a>Update participant

* Update contact
* Add to selection/project
* Remove from selection/project

### Update contact

Use this step to update relevant data on a contact or their company, before the participant is moved into next step in the flow.

1. Drag the **Update contact** box from the step menu and drop it into an available slot in the flowchart.
1. Select a field to update in the **Field** column. You can also type the name in the field. As you type each letter, the list below shows relevant matches.
1. Select an action in the **Action** column. The [available actions][11] depends on the type of field you selected in the previous step.
1. Specify new values if applicable.
1. To update additional fields, click **Add** and repeat steps 2-4.
1. Make sure all the fields you wish to update - and only those - have a checkmark. You can click the red X to remove excess lines.

![Update contact data in flow -screenshot][img2]

This works similar to [bulk update][11].

### Add to selection/project

Keep an overview of those who signed up, or was engaged, or to keep track and follow-up on later​. The contact is added as member to the specified selection and/or project.

1. Drag the **Add to selection and/or project** box from the step menu and drop it into an available slot in the flowchart.
1. Add contact to static selection: choose a static contact selection from the list or click **New** to create a new one.

1. Add contact as project member: choose a project from the list.

> [!TIP]
> Start typing to search a list.

### Remove from selection/project

Contact is removed as member from the specified selection and/or project.

This step is similar to **Add to selection and/or project**.

### <a id="distribute"></a>Distribute to owner

Distribute contacts evenly to selected associates or members of a specified primary group. Useful for sharing inbound leads or new contacts across a team.

1. Drag the **Distribute to owner** box from the step menu and drop it into an available slot in the flowchart.
1. Select one or more associates, or a group, to assign contacts.
1. Optionally, uncheck **Only apply new owner if the contact is currently unassigned** to overwrite any existing contact owner.
1. Optionally, set a fallback associate in **If no one is available, assign contacts to**.

The new owner will [receive a notification][10] for each assigned contact.

## <a id="create"></a>Create activity

The flow can automatically create a follow-up, request, and/or sale on the contact according to settings. By connecting CRM activities and notifications, your organization can bridge the gap between marketing and sales. Creating activities also lets you focus on contacts who are engaged​.

### Create follow-up

Example: Set up a free consultation on the first available time in Our contact’s diary. They will be notified in the **Notifications** panel​.

1. Drag the **Create follow-up** box from the step menu and drop it into an available slot in the flowchart.
1. Enter a title.
1. Select a follow-up type.
1. Specify a due date for a to-do or reserve the first available time for a meeting.
1. Assign to: choose who should follow up the participant: "our contact" or "our service contact", or a specific named associate.
1. Optionally, enter other information. For details, see the [list of step settings][1] and [how to create a follow-up][12].

### Create request

1. Drag the **Create request** box from the step menu and drop it into an available slot in the flowchart.
1. Enter a descriptive **title**.
1. Select a [request type][14], which will affect default values and available statuses and priorities.
1. Select [status][15], [category][16], and [priority][17].
1. **Owner:**
    * To assign the request to a specific person, select the name you require.
    * **Automatically assigned:** If you select this option, the system assigns the request in accordance with the applicable assignment rules.
    * **Unassigned:** You can also choose not to assign the request. The members of the relevant category then become responsible for dealing with the request.
1. Enter the actual message you want to add to the request.

For details, see the [list of step settings][1] and [how to create a request][13].

### Create sale

When contact arrives this step, the contact is mature, and has shown indications of being a sales opportunity.​

1. Drag the **Create sale** box from the step menu and drop it into an available slot in the flowchart.
1. Enter a descriptive **title**.
1. Select a sale type, which will affect default values and available stages.
1. Enter the required information in the other fields.
1. Owner: Choose who should follow up this lead: "our contact" or "our service contact", or a specific named associate.

    > [!NOTE]
    > Add a follow-up too, to notify the sale's owner about this new opportunity​.

For details, see the [list of step settings][1] and [how to create a sale][18].

## <a id="internal"></a>Internal actions

### Run script

Run custom business logic by triggering a CRM script as part of the flow.

1. Drag the **Run script** box from the step menu and drop it into an available slot in the flowchart.
1. Choose a [CRMScript][20] from the list.

> [!NOTE]
> The participant will proceed to the next step immediately after the script is triggered, without waiting for the result.

### Notify by email

Send a notification email to a specific person as part of the flow.

1. Drag the **Notify by email** box from the step menu and drop it into an available slot in the flowchart.
1. Specify the recipient (**To:**).
1. Enter the **subject** of the email.
1. Enter the message you wish to send.

Contact variables (merge tags) are available.

### Notify by SMS

Send a notification SMS to a specific person as part of the flow.

1. Drag the **Notify by SMS** box from the step menu and drop it into an available slot in the flowchart.
1. Specify the recipient (**To:**).
1. Enter the message you wish to send. Contact variables (merge tags) are available.

If no mobile phone number is specified on the selected contacts, no SMS will be received in the other end.

## Flow action vs. form action

Several action types are possible both as form action and as flow step​.

A [form action][6] might:

* Add contact to selection and/or project
* Add interest to contact
* Set default category and business for new contacts and companies
* Create a request
* Send a form response mailing to contact

## Flow action vs. link action

A [link action][7] might:

* Add contact to selection and/or project
* Update interests
* Add a value to an [extrafield][19] on contact
* Create a request
* Create a follow-up

<!-- Referenced links -->
[1]: step-settings.md
[6]: ../../forms/learn/define-form-actions.md
[7]: ../../tracked-links/learn/define-link-actions.md
[10]: ../../../learn/basics/notifications.md
[11]: ../../../learn/basics/bulk-update.md
[12]: ../../../diary/learn/create-follow-up.md
[13]: ../../../request/learn/create.md
[14]: ../../../request/admin/type/index.md
[15]: ../../../request/admin/status/index.md
[16]: ../../../request/admin/category/index.md
[17]: ../../../request/admin/priority/index.md
[18]: ../../../sale/learn/create.md
[19]: ../../../custom-objects/learn/extra-field.md
[20]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png
