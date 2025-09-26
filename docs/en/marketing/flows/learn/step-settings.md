---
uid: help-en-flow-step-settings
title: Step settings
description: Overview of settings for the various flow steps.
keywords: step, step setting, step field
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 11.3
content_type: reference
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Step settings

> [!NOTE]
> Many fields have a list of predefined values you can choose from. Click <i class="ph ph-caret-down" aria-label="Chevron"></i> to expand the list. Then select a value for that field. Alternatively, start typing in the field to search for a specific value, such as a selection name.

## Add to selection and/or project

| Setting | Description |
|---|---|
| Add contact to static selection | The participant becomes member of the specified static selection. |
| Add contact as project member | The participant becomes member of the specified project. |

## Create follow-up

| Setting | Description |
|---|---|
| Title | A descriptive label. Additional details go in the agenda. |
| Type | A pre-defined list of activities such as Meeting (external) and Phone-In. Available fields depend on the selected follow-up type. |
| Project | A project linked to the follow-up. |
| Date | When the follow-up starts or is due.<br />**Task date:** This means a to-do in the user's checklist<br />**Meeting date:** This means a follow-up in the diary. "First available" or "First available after x days/working days/weeks". |
| Assign to | The owner of the follow-up. The participant's "our contact" or "our service contact", or a specific named associate. |
| Agenda | Additional details about the follow-up, such as an agenda, a description, files, images, and links. Rich-text formatting options are available. |

## Create request

| Setting | Description |
|---|---|
| Title | A descriptive name for the request. |
| Request type | Targets a set of attributes needed for a specific process. Affects the available statuses and priorities. |
| Status | Indicates the request management phase (open or closed). |
| Category | A set of rules that define how requests are processed. |
| Priority | Reflects the importance of the request. |
| Owner | Who the request should be assigned to. |
| Message | The contents of the request. Rich-text formatting options and template variables for contact and the contact's company are available. |

## Create sale

| Setting | Description |
|---|---|
| Title | A descriptive name of the sale. Details go in the description. |
| Sale type | A named set of info about the sale process. Affects default sale stage and estimated sale date. Some sale types are linked to a [sales guide][14]. |
| Stage | The sale's current stage (open, lost, sold). |
| Amount | Expected amount for the pipeline. |
| Description | A more detailed description of the sale. |
| Project | A project linked to the sale. |
| Date | The estimated sale date. "Estimated by sale type" or "After X days/working days/weeks". |
| Owner | The person responsible for the sale. The participant's "our contact" or "our service contact", or a specific named associate. |

## Distribute to owner

| Setting | Description |
|---|---|
| Only apply new owner if the contact is currently unassigned | Ensures that ownership is only set if no owner is currently assigned. |
| Distribute contacts to | Choose one or more associates or a primary group. Contacts are distributed evenly across selected associates or group members. |
| If no one is available, assign contacts to | Fallback option. Choose a default owner if all selected associates/group members are unavailable. |

## Exit flow

The flow-control steps **split** and **wait for action** (and also Send SMS) have an **Exit flow** option to pull participants who do not meet a condition out of the flow. If selected, the dropped-out contact can be moved to a different flow and/or added to a selection.

| Setting | Description |
|---|---|
| Add participant to another flow after exit | The dropped-out contact is **suggested** as participant for the specified flow. Filters determine if they start that flow or not. |
| Add participant to static selection after exit | The dropped-out contact becomes member of the specified selection. You can create a new selection from the step settings. |

## Finish

Participants reaching the finish step has reached the end of the flow. Participant may have finished the flow with status = finished or finished with success. No more actions are happening to a participant in this flow when reaching the step.

| Setting | Description |
|---|-|
| Add to another flow when a success criterion is met | Finished with success |
| Add to another flow when no success criterion is met | Finished |

## Notify by email

| Setting | Description |
|---|---|
| To | The recipient - "our contact", "our service contact", or a specific email address. |
| Subject | Text for the email's subject field. |
| Text | Enter the message. |

You can personalize the subject and message with contact variables (same as merge tags within the mailing editor).

## Notify by SMS

| Setting | Description |
|---|---|
| To | The recipient - "our contact", "our service contact", or specific contacts. |
| From | Defaults to flow setting "SMS sender". |
| Text | Enter the SMS text. You can personalize the message with contact variables (same as merge tags within the mailing editor). |

## Send email

| Setting | Description |
|---|---|
| Create new email for this step | Opens the mailing wizard. |
| Select existing email for this step | See [Add content][1]. |
| Subject | Text for the email's subject field. You can personalize the subject with contact variables (same as merge tags within the mailing editor). |
| Attachment | Max 25MB total. |

## Send SMS

| Setting | Description |
|---|---|
| From | Defaults to flow setting "SMS sender". |
| Text | Enter the SMS text. You can personalize the message with contact variables (same as merge tags within the mailing editor). |
| Exit flow if no mobile phone is registered | What should happen if the contact is unable to receive the SMS? If true, you may add them to another flow or to a static selection after exit. |

## Split

| Setting | Description |
|---|---|
| Title | A short descriptive label. |
| Split based on | The data/behavior to differentiate on. |
| Branch name | A descriptive name on the branch, indicating which participants are moving down which branch. |
| Everyone else | The branch for handling participants who do not meet the conditions of any of the other branches. |
| Exit flow | Determines if participants ending up in the everyone-else branch should drop out. If true, you may add them to another flow or to a static selection after exit. If false, you can add more steps to this branch. |

The remaining fields for specifying branch settings depend on what the split is based on.

## Trigger

| Setting | Description |
|---|---|
| A person can only start this flow once | Whether the a contact can be re-enrolled in this flow. |
| Filter | A set of criteria that must be met for a suggested contact to be allowed into the flow. Only checked once. |
| Exclusion list | A static selection of persons who will not be added to the flow, or will exit the flow if already participating. |

## Update contact

This works similar to [bulk update][10].

## Wait time

| Setting | Description |
|---|---|
| Number of days/hours after previous step | The **duration** of the pause. Wait a specific amount of time. |
| Until specific date/time | The **end** of the pause. Wait until a specific date. |

## Wait for action

| Setting | Description |
|---|---|
| Maximum waiting time | How long to wait for any action (a timeout). Default: 7 days. |
| Exit flow if no actions within max waiting time | Participants who do not respond will leave the flow with status "drop out". If true, you may add them to another flow or to a static selection after exit. |

## Related content

* [Learn about activities][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guide/index.md
