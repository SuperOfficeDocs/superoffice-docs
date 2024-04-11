---
uid: help-en-flow-step-settings
title: Step settings
description: Overview of settings for the various flow steps.
keywords: flow, automation, step, step setting, step field
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.11.2024
so.version: 10.3.5
so.topic: reference
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Step settings

> [!NOTE]
> Many fields have a list of predefined values you can choose from. Click the arrow ![icon][img4] to expand the list. Then select a value for that field. Alternatively, start typing in the field to search for a specific value, such as a selection name.

## Add to selection and/or project

| Setting | Description |
|---|---|

## Create follow-up

| Setting | Description |
|---|---|
| Title | A descriptive label. Additional details go in the agenda. |
| Type | A pre-defined list of activities such as Meeting (external) and Phone-In. Available fields depend on the selected follow-up type. |
| Project | A project linked to the follow-up. |
| Date | When the follow-up starts or is due. |
| Task date: This means a to-do in the user's checklist. | |
| Meeting date: This means a follow-up in the diary. "First available" or "First available after x days/working days/weeks". | |
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

## Finish

| Setting | Description |
|---|---|

## Send email

| Setting | Description |
|---|---|

* **Subject:** You can personalize the subject with contact variables (same as merge tags within the mailing editor).
* **Attachment:**

## Send SMS

| Setting | Description |
|---|---|

* **From:** Defaults to flow setting "SMS sender".
* **Text:** Enter the SMS text. You can personalize the message with contact variables (same as merge tags within the mailing editor).
* **Exit flow if no mobile phone is registered:** What should happen if the contact is unable to receive the SMS?

## Split

| Setting | Description |
|---|---|

## Trigger

| Setting | Description |
|---|---|

## Update contact

This works similar to [bulk update][10].

## Wait time

| Setting | Description |
|---|---|

* Number of days/hours after previous step
* Until specific date/time

## Wait for action

| Setting | Description |
|---|---|

* Exit flow if no actions within max waiting time

## Related content

* [Learn about activities][11]

<!-- Referenced links -->
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guide/index.md

<!-- Referenced images -->
[img4]: ../../../../../common/icons/dropdown-icon.png
