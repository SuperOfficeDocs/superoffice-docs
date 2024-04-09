---
uid: help-en-flow-actions
title: Define flow actions
description: Define flow actions
keywords: flow, automation, flow action
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.09.2024
so.version: 10.3.5
so.topic: howto
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Define flow actions

## Available actions

* Send message
* Update participant
* Create activity

## Send message

### Send email

An email step is used for sending an email to an active flow participant. You can select an already prepared email or adding a new one.

1. Drag the **Send email** box from the step menu and drop it into an available slot in the flowchart.
1. Choose one of the options:

    * Create new email for this step. Enter a name and click **Create**. This opens the Mailing wizard at the Template step.
    * Select existing email for this step. Click to select flow content.

![Add email step to flow -screenshot][img1]

> [!NOTE]
> Creating a new email as flow content is only possible from within flow UI.

**Step settings:**

* **Subject:** You can personalize the subject with contact variables (same as merge tags within the mailing editor).
* **Attachment:**

### Send SMS

An SMS step is used for sending an SMS to an active flow participant.

Flow participants without a registered phone number can either skip the step (continue to next step), or exit the flow, depending on step settings

**Step settings:**

* **From:** Defaults to flow setting "SMS sender".
* **Text:** Enter the SMS text. You can personalize the message with contact variables (same as merge tags within the mailing editor).
* **Exit flow if no mobile phone is registered:** What should happen if the contact is unable to receive the SMS?

> [!TIP]
> If you wish to send only one SMS, keep an eye on the counter in bottom-right corner. If the number of characters exceeds 160, the message is sent as multiple SMS segments and additional pricing may apply. We recommend to keep the message brief and informative.

## Update participant

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

Contact is added as member to the specified selection and/or project.

1. Drag the **Add to selection and/or project** box from the step menu and drop it into an available slot in the flowchart.
1. Add contact to static selection: choose a static contact selection from the list.
1. Add contact as project member: choose a project from the list.

> [!TIP]
> Start typing to search a list.

### Remove from selection/project

Contact is removed as member from the specified selection and/or project.

This step is similar to **Add to selection and/or project**.

## Create activity

* Create request
* Create follow-up
* Create sale

## Flow action vs. form action

## Flow action vs. link action

## What would you like to do now?

* Watch another movie

<!-- Referenced links -->
[11]: ../../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png
