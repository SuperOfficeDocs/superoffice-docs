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

1. Drag the **Send email** step box from the step menu and drop it into an available slot in the flowchart.
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

* Update contact - available actions depend on field
* Add to selection/project
* Remove from selection/project

## Create activity

* Create request
* Create follow-up
* Create sale

## Flow action vs. form action

## Flow action vs. link action

## What would you like to do now?

* Watch another movie

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/marketing/flow-send-email-new.png
