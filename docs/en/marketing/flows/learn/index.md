---
uid: help-en-flows
title: Marketing automation - flows
description: Introduction to SuperOffice marketing automation and flows.
keywords: flow, marketing automation, campaign, success criteria, segment
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 11.3
content_type: concept
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Marketing automation - flows

Imagine effortlessly delivering the perfect email to your audience precisely when they need it. Relevant emails not only increase the chances of being read but also impact the engagement with your call-to-action (CTA) links and foster stronger customer relationships. With marketing automation, you can customize emails for specific customer segments based on their position in the sales cycle, product interests, engagement level, and more.

But it does not stop there. Address communication challenges across every stage of your customer journey.

* Enhance the entire customer journey​: Capture and nurture leads; Upsell/cross-sell to existing customers; Facilitate onboarding and adoption; Streamline event sign-up processes; Send reminders.

* Be relevant with less manual effort​: Reach out to both prospects and existing customers from the same tool; Use triggers and filters to create segmented drip campaigns; Gain deeper insight in marketing activities​.

* Leverage CRM data for targeted marketing efforts: Segment your audience and deliver tailored information using CRM data; Understand customer needs and create personalized journeys.

* Align marketing and sales​: Automate the handshake between marketing and sales teams by connecting CRM activities and notifications​; CRM activities can influence ongoing automation​; Ensure transparency between marketing, sales and service​.

* Reporting from lead to revenue​: Prove the impact of marketing efforts by connecting marketing and sales reports.

The drag-and-drop flow designer is your tool for building these dynamic flows.

![Drag-and-drop flow designer -screenshot][img2]

## <a id="ex"></a>Use cases

* **Welcome new customers:** Send personalized emails, discounts, and share your brand story. Support the onboarding of new products.
* **Engagement campaigns:** Keep active customers engaged and informed with relevant content, product updates, and exclusive offers.
* **Up/cross sell campaigns:** Recommend related items based on purchase history or behaviors to drive revenue.
* **Event sign-up processes:** Including reaching out via SMS, webinar reminders, and follow-up.

## What is a flow

A flow is an automated sequence of marketing-related steps, such as sending a message, updating participant information, or creating an activity.

A **trigger** serves as the flow's starting point, defining WHEN a person is suggested as a participant in a flow. For example, when a person submits a [Contact Me form][9]. You can also [manually enroll SuperOffice contacts][4].

Additional **filters** are then applied to determine if that person belongs to the segment the flow targets. Filters determine WHO is added as participants. For instance, a lead-capturing flow that targets only prospects and not existing customers.

After enrollment, participants progress along the defined path. Upon completing a step, they move to the next. Participant status is reassessed before any action in a step. Learn more about [enrollment and flow logic][5].

## Workflow

Marketing automation follows roughly this workflow:

1. Plan your communication​.
1. [Create the content​.][7]
1. [Build the flow.][1]
1. [Define steps and actions.][6]
1. Set goals and track success.
1. [Monitor and analyze​.][3]

Flows support different ways of working​. Plan and create content before the flow is set up, then connect already prepared content to a specific flow. Or, begin by setting up the flow and leave room for the emails, which will come from content writers later.

## Where to find flows

SuperOffice Marketing has 1 tab pertaining to flows.

![Marketing Flows panel -screenshot][img1]

The **Flows tab** allows you to create new flows and view previously created ones. Use the secondary row of tabs (All, Recent, Running) and the search box to explore the available flows. Double-click a flow to view details about it.

Choose between list or tile **view mode** in the lower-right corner.

| Icon | Mode | Description |
|:-:|---|---|
| <i class="ph ph-squares-four" aria-label="2x2 tiles"></i> | Tile (thumbnail) | Shoes a thumbnail of each flow with essential data. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> to open, edit, copy, or delete the flow. |
| <i class="ph ph-list" aria-label="List"></i> | List (archive, grid) | Shows a list of all flows with information presented in columns. You cam group, filter, and customize the columns similar to columns in [section tabs][12]. Right-click to open the context menu to open, edit, copy, or delete the flow. |

## <a id="view"></a>The View flow screen

At the top, you can see the flow's name and its location within the folder structure. You have the following options:

| Option | Description |
|---|---|
| Running | Toggle this slider button to start or pause the flow. |
| Edit | Opens the flow in edit mode. |

The **View flow** screen consists of the following tabs:

* **Summary:** Provides basic information about the flow and various statistics.
* **Flow:** Offers a read-only view of the flow, allowing users to get an overview without pausing and editing the flow. Click a step to view the details.
* **Reports:** Displays charts with statistics for the flow, used to monitor its performance.
* **Participants:** Presents a list of all participants within the flow, showing their email address, company affiliation, enrollment date, current status, current step, last sending received, date of the last sending, and status of the last sending.
* **Flow Content:** Includes flow mailings and forms used by the flow.

## <a id="success"></a>Success criteria

Success criteria establish the parameters for determining the success of a flow. For example:

* Contact updated
* Sale created on contact or company
* Follow-up created
* Request created
* Participant added to selection or project
* Form submitted
* Link clicked

By defining success criteria, you can gauge the efficacy of the flow: Are we achieving our objectives while the contact remains engaged in the flow? The **success rate** represents the percentage of enrolled participants in the flow who complete it with the success criteria fulfilled.

A success criterion may entail a change in a contact's category (such as transitioning to a sales-ready lead) while they are engaged in the flow. All interactions with the contact contribute to this change.

Any associate can fulfill success criteria by modifying data in the CRM database. The flow automation will respond appropriately, regardless of how the success criteria were met. Whether data is updated automatically by the flow or manually by a sales representative, the system functions consistently.

Upon meeting a success criterion, the campaign may either stop or proceed for the participant. In both cases, the participant is considered successful. You can determine if these successful participants should transition to a more relevant flow.

It is advisable for most automated flows to set success criteria for enrolled participants. However, it is not mandatory to define such criteria.

## <a id="req"></a>Requirements

* Marketing Premium license (new tier)
* Sales essential or premium - to create a sale
* Service essential or premium - to create a request
* SMS connector - to send SMS

### Functional rights

Access to flows and flow content is controlled by a user's role and [functional rights][11].

| Action | Flow administrator | Can edit flow content |
|---|:-:|:-:|
| View flow | X | X |
| Create/edit flow content | X | X |
| Delete flow content | X | |
| Create/edit flow (open flow editor, save) | X | |
| Run/pause/end flow | X | |

## Related content

* [Create flow][1]
* [How to run, pause, and end a flow][2]
* [View statistics][3]

<!-- Referenced links -->
[1]: create.md
[2]: run-pause-end.md
[3]: view-statistics.md
[4]: participants.md
[5]: participants.md#logic
[6]: define-flow-actions.md
[7]: content.md
[9]: ../../forms/learn/tutorial-contact-me.md
[11]: ../../../admin/user-management/role/functional-rights.md
[12]: ../../../learn/section-tabs/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flows-panel.png
[img2]: ../../../../media/loc/en/marketing/flow-editor-with-step-menu.png
