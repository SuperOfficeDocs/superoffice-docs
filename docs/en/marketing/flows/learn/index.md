---
uid: help-en-flows
title: Marketing automation - flows
description: Introduction to SuperOffice marketing automation and flows.
keywords: flow, marketing automation, success criteria
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.08.2024
so.version: 10.3.5
so.topic: concept
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Marketing automation - flows

What if you could send the right email to the right recipients at the right time? Relevant emails are more likely to be read by receivers, it affects if any CTAs are clicked or not, and can positively influence a customer relationship.

With marketing automation, you can tailor emails to a specific set of customers, where they are in their sales cycle, their level of engagement with specific products or services, their actions and so on.

* Qualify more leads
* Sae time on marketing tasks: "initiate and automate" > increased insight in marketing initiatives
* Real-time segmentation
* Scalable

## <a id="ex" />Use cases

* Onboarding program
* Event sign-up
* Life cycle emails
* Regular subscription programs
* Welcome new subscribers
* Webinar reminder and follow-up
* Cross sale (follow up after purchase)

## Flow steps

A flow may have multiple steps. Once a participant completes a step, they move to the next. Participant status is reassessed before any action in a step.

## Workflow

Plan and create content before the flow is set up, then connect already prepared content to a specific flow.
Or, begin by setting up the flow, leave room for the 3 emails which will come from content writers later.

## Where can you find flows?

SuperOffice Marketing has 1 tab pertaining to flows.

![Marketing Flows panel -screenshot][img1]

View mode: archive (grid) or tiles

## <a id="view" />The View flow screen

At the top, you have the following options:

|Option | Description |
|---|---|
| Running | Toggle this slider button to start or pause the form. |
| Edit | Opens the flow in edit mode. |

The **View flow** screen consists of the following tabs:

* **Summary:** shows basic information about the flow and various statistics.
* **Flow:**
* **Reports:** shows charts with statistics for the flow.
* **Participants:**
* **Flow content:**

## <a id="status" />Status

* **Running:**
* **Paused:**

## Enrollment (when and who)

A **trigger** is the flow's starting point. It defined WHEN a contact is suggested as a participant to a flow. Additional **filters** are then applied to the suggested participants. Filters decide WHO are added as participants.

## <a id="success" >Success criteria

Success criteria define what success means for a flow. You can track the effectiveness of their automation by observing how many participants meet these criteria.

A success criterion could be a change in a contact's category (to for example, sales ready lead) while they are in the flow. All interactions with this contact contribute to this change.

Any associate can fulfill success criteria by modifying data in the CRM database. The flow automation will respond correctly, regardless of how the success criteria were achieved. It makes no difference whether data is automatically updated by the flow, or manually updated by a sales representative.

When a success criterion is met, the campaign may stop or continue for the participant. In both cases, the participant is considered a success. You can decide if these successful participants should move to a more relevant flow.

Most automated flows should have a success criteria for enrolled participants, but defining a success criteria is not mandatory.

## <a id="req" />Requirements

* Marketing Premium license (new tier)
* SQLServer 2016 or newer?
* Sales essential or premium - to create a sale
* Service essential or premium - to create a request
* SMS connector - to send SMS

### Functional rights

How to control access to flows and flow content

* Flow administrator
* Can edit flow content

## Related content

* [Create flow][1]
* [View statistics][3]

<!-- Referenced links -->
[1]: create.md
[3]: view-statistics.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flows-panel.png
