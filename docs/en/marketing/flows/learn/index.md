---
uid: help-en-flows
title: Marketing automation - flows
description: Introduction to SuperOffice marketing automation and flows.
keywords: flow, marketing automation, campaign, success criteria, segment
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.24.2024
so.version: 10.3.5
so.topic: concept
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Marketing automation - flows

What if you could send the right email to the right recipients at the right time? Relevant emails are more likely to be read by receivers, it affects if any call to action (CTA) links are clicked or not, and can positively influence a customer relationship. With marketing automation, you can tailor emails to a specific set of customers, where they are in their sales cycle, their level of engagement with specific products or services, their actions and so on.

But that is not all. You can also address communication challenges in any part of your customer journey.

* Impact the entire customer journey​: Lead capturing and lead nurturing campaigns;​ Up/cross sell to existing customers​; Onboarding and adoption​; Event sign-up processes​; Reminders​.

* Be relevant with less manual effort​: Communicate both with prospects and existing customers from the same tool; Use triggers and filters to create segmented drip campaigns; Gain more insight in marketing activities​.

* Leverage CRM data for precise marketing efforts: Use CRM data to segment your audience and send the most relevant information; Understand customer needs and craft a journey personalized for them.​

* Align marketing and sales​: Automate the handshake between marketing and sales by connecting CRM activities and notifications​; CRM activities can influence ongoing automation​; Ensure transparency between marketing, sales and service​.

* Reporting from lead to revenue​: Prove the impact of marketing efforts by connecting marketing and sales reports.

## <a id="ex" />Use cases

* Welcome new customers: Send personalized emails, discounts, offer your brand story. Support onboarding of new products.
* Engagement campaigns​: Keep active customers engaged and informed. Relevant content, product updates, exclusive offers and so on.
* Up/cross sell campaigns​: Recommend related items based on purchase history or behaviors to drive revenues.​
* Event sign-up processes, incl reaching out via SMS; Webinar reminder and follow-up.

## What is a flow

A flow is an automated sequence of marketing-related steps such as send a message, update participant, or create an activity.

A **trigger** is the flow's starting point. It defines WHEN a person is suggested as a participant to a flow. For example, the person has submitted a [Contact me form][6]. You can also [enroll SuperOffice contacts manually][4].

Additional **filters** are then applied to determine if that person is part of the segment the flow pertains to. Filters decide WHO are added as participants. For example, a lead capturing flow that targets only prospects and not existing customers.

After enrolling, participants progress along the defined path. Once a person completes a step, they move to the next. Participant status is reassessed before any action in a step. Read more about [enrollment and flow logic][5].

## Workflow

Marketing automation follows roughly this workflow:

1. Plan your communication​.
1. Create the content​.
1. Build the flow.
1. Define steps and actions.
1. Set goals and track success.
1. Monitor and analyze​.

Flows support different ways of working​. Plan and create content before the flow is set up, then connect already prepared content to a specific flow. Or, begin by setting up the flow and leave room for the emails, which will come from content writers later.

## Where can you find flows?

SuperOffice Marketing has 1 tab pertaining to flows.

![Marketing Flows panel -screenshot][img1]

The **Flows tab** allows you to create new flows and view previously created ones. Use the secondary row of tabs (All, Recent, Running) and the search box to explore the available flows. Double-click a flow to view details about it.

Choose between list or tile **view mode** in the lower-right corner.

| Icon | Mode | Description |
|:-:|---|---|
| [icon][img8] | List (archive, grid) | Shows a list of all flows with information presented in columns. You cam group, filter, and customize the columns similar to columns in [section tabs][12]. Right-click to open the context menu to open, edit, or delete the flow. |
| [icon][img9] | Tile (thumbnail) | Shoes a thumbnail of each flow with essential data. Click the hamburger menu to open, edit, or delete the flow. |

## <a id="view" />The View flow screen

At the top, you can see the flow's name and its location within the folder structure. You have the following options:

|Option | Description |
|---|---|
| Running | Toggle this slider button to start or pause the form. |
| Edit | Opens the flow in edit mode. |

The **View flow** screen consists of the following tabs:

* **Summary:** shows basic information about the flow and various statistics.
* **Flow:** shows a read-only view of the flow - to get an overview without pausing and editing the flow.
* **Reports:** shows charts with statistics for the flow. Used to monitor the flow's performance.
* **Participants:** a complete view of all participants within the flow, their email address, what company they belong to, when they were added as participant, current status, current step, last sending they received, date for last sending, and the status on last sending.
* **Flow content:** Flow mailings and link to forms used by the flow.

## <a id="success" >Success criteria

Success criteria establish the parameters for determining the success of a flow. By defining success criteria, you can gauge the efficacy of the flow: Are we achieving our objectives while the contact remains engaged in the flow? The **success rate** represents the percentage of enrolled participants in the flow who complete it with the success criteria fulfilled.

A success criterion may entail a change in a contact's category (such as transitioning to a sales-ready lead) while they are engaged in the flow. All interactions with the contact contribute to this change.

Any associate can fulfill success criteria by modifying data in the CRM database. The flow automation will respond appropriately, regardless of how the success criteria were met. Whether data is updated automatically by the flow or manually by a sales representative, the system functions consistently.

Upon meeting a success criterion, the campaign may either stop or proceed for the participant. In both cases, the participant is considered successful. You can determine if these successful participants should transition to a more relevant flow.

It is advisable for most automated flows to set success criteria for enrolled participants. However, it is not mandatory to define such criteria.

## <a id="req" />Requirements

* Marketing Premium license (new tier)
* SQLServer 2016 or newer - to define actions based on form submission data
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
| Create/edit flow (open flow editor, save) | x | |
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
[6]: ../../forms/learn/tutorial-contact-me.md
[11]: ../../../admin/user-management/learn/role/functional-rights.md
[12]: ../../../learn/section-tabs/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flows-panel.png
[img8]: ../../../../../common/icons/view-list.png
[img9]: ../../../../../common/icons/view-thumbs.png
