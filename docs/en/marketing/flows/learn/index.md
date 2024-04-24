---
uid: help-en-flows
title: Marketing automation - flows
description: Introduction to SuperOffice marketing automation and flows.
keywords: flow, marketing automation, success criteria
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.23.2024
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

* Impact the entire customer journey​: Lead capturing and lead nurturing campaigns;​ Up/cross sell to existing customers​; Onboarding and adoption​; Event sign-up processes​; Reminders​

* Be relevant with less manual effort​: Communicate both with prospects and existing customers from the same tool; Use triggers and filters to create segmented drip campaigns; Gain more insight in marketing activities​

* Leverage CRM data for precise marketing efforts: Use CRM data to segment your audience and send the most relevant information; Understand customer needs and craft a journey personalized for them.​

* Align marketing and sales​: Automate the handshake between marketing and sales by connecting CRM activities and notifications​; CRM activities can influence ongoing automation​; Ensure transparency between marketing, sales and service​.

* Reporting from lead to revenue​: Prove the impact of marketing efforts by connecting marketing and sales reports.

## <a id="ex" />Use cases

* Welcome new customers: Send personalized emails, discounts, offer your brand story. Support onboarding of new products.
* Engagement campaigns​: Keep active customers engaged and informed. Relevant content, product updates, exclusive offers and so on.
* Up/cross sell campaigns​: Recommend related items based on purchase history or behaviors to drive revenues.​
* Event sign-up processes, incl reaching out via SMS; Webinar reminder and follow-up.

## What is a flow

A flow may have multiple steps. Once a participant completes a step, they move to the next. Participant status is reassessed before any action in a step.

## Workflow

Marketing automation follows roughly this workflow:

1. Plan your communication​.
1. Create the content​.
1. Build the flow.
1. Define steps and actions.
1. Set goals and track success.
1. Monitor and analyze​.

However, flows support different ways of working​. Plan and create content before the flow is set up, then connect already prepared content to a specific flow. Or, begin by setting up the flow and leave room for the emails, which will come from content writers later.

## Where can you find flows?

SuperOffice Marketing has 1 tab pertaining to flows.

![Marketing Flows panel -screenshot][img1]

View mode: archive (grid) or tiles

## <a id="view" />The View flow screen

At the top, you can see the flow's name and its location within the folder structure. You have the following options:

|Option | Description |
|---|---|
| Running | Toggle this slider button to start or pause the form. |
| Edit | Opens the flow in edit mode. |

The **View flow** screen consists of the following tabs:

* **Summary:** shows basic information about the flow and various statistics.
* **Flow:** shows a read-only view of the flow - to get an overview without pausing and editing the flow.
* **Reports:** shows charts with statistics for the flow.
* **Participants:**
* **Flow content:**

## Enrollment (when and who)

Use triggers and filters to create segmented drip campaigns.​

A **trigger** is the flow's starting point. It defined WHEN a contact is suggested as a participant to a flow. Additional **filters** are then applied to the suggested participants (automatically and manually added). Filters decide WHO are added as participants.

## <a id="success" >Success criteria

Success criteria establish the parameters for determining the success of a flow. By defining success criteria, you can gauge the efficacy of the flow: Are we achieving our objectives while the contact remains engaged in the flow? The **success rate** represents the percentage of enrolled participants in the flow who complete it with the success criteria fulfilled.

A success criterion may entail a change in a contact's category (such as transitioning to a sales-ready lead) while they are engaged in the flow. All interactions with the contact contribute to this change.

Any associate can fulfill success criteria by modifying data in the CRM database. The flow automation will respond appropriately, regardless of how the success criteria were met. Whether data is updated automatically by the flow or manually by a sales representative, the system functions consistently.

Upon meeting a success criterion, the campaign may either stop or proceed for the participant. In both cases, the participant is considered successful. You can determine if these successful participants should transition to a more relevant flow.

It is advisable for most automated flows to set success criteria for enrolled participants. However, it is not mandatory to define such criteria.

## <a id="req" />Requirements

* Marketing Premium license (new tier)
* SQLServer 2016 or newer?
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
[11]: ../../../admin/user-management/learn/role/functional-rights.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flows-panel.png
