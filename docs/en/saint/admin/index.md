---
uid: help-en-saint-admin
title: Set up SAINT
description: Learn how to set up SuperOffice SAINT in this guide.
keywords: SAINT, activity monitor
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Set up SAINT

You can follow up on your customers proactively by using SAINT, which stands for Sales Intelligence. SuperOffice SAINT can be used in many ways and for many different processes. Before successfully implementing the SAINT feature it is important to know what you wish to improve and how you can analyze this.

After you know what you want to improve, try to think of the action your company can take to improve on the existing situation. What action will you take?

* Send out a group mailing using SuperOffice Mailings
* Call all customers in the SAINT selection
* Follow up on all requests

[!include[Requirement](../includes/note-saint-req.md)]

Using the **Status monitors/SAINT** tab, you can create statuses for companies, contacts and projects. Status monitors represent the functionality behind the Sales Intelligence (SAINT) concept. This facilitates following up companies, contacts and projects and provides more intelligent search options in SuperOffice CRM.

## Status images

Statuses can be shown as images on the cards of projects, contacts or companies that fulfil your criteria. The status image for a customer you have had no contact with for a while could, for example, be a spider's web. This then provides a visual and immediate indication of what your relations with the customer are or how a project is progressing. When the user clicks or holds the mouse pointer over a status image in SuperOffice CRM, some text is displayed. For example, to indicate the actions that should be taken (you yourself enter the text when you create the status).

## Default follow-up for a status

When the user opens the status dialog in SuperOffice CRM, they may also create a follow-up for the status in question. The follow-up type and text can be predefined.

### Example

A status could, for example, apply to companies that fulfil the following criteria:

* Category = Customer
* Last sale more than 2 months old
* Number of sales greater than 50

The text in the **Description** field could then be:

"&lt;name&gt; has previously been a good customer, but we have not sold anything to them in 2 months. &lt;cont&gt; is the main contact for this customer and should get in touch with the customer soon by phone (&lt;cpho&gt;) or email (&lt;mail&gt;) to find out why."

In this example, the following template variables are used to tailor the text to the company in question:

| Variable | Description |
|---|---|
| name | The name of the company |
| cont | The name of our contact for the company |
| cpho | The company's phone number |
| mail | The company's email address |

## Searches and selections

Statuses and counters can be used in searches and to create dynamic selections. For example, you can search for companies, contacts or projects that fulfil a status or a counter. [!include[Define counter](../includes/def-counter.md)]

You can set up 3 different counters/periods, these counters are the number of days you want to count on activities, sales and requests. The different periods are set on what is important for you. For example, you want to be notified if some of your customers haven't had any activities the last month (30 days), or if there are unsolved requests on the customers that are older than 30 days.

## Periods

You can specify up to three different periods for counters, so that the SAINT criteria can cover shorter or longer periods. If you specify three periods of 30, 60 and 90 days respectively, you can select SAINT criteria for each of these periods.

## Creation of new statuses

First of all, log into SuperOffice CRM, go to the Main menu in the top-right corner and open Settings and maintenance, click on SAINT in the navigator. There you can set up your Sales Intelligence and status monitors.

To create a status:

1. [Create a new status][1]
1. [Select an image for a status][2]
1. [Select a default follow-up type for a status][3]
1. [Specify status criteria][4]
1. [Specify a period length][5]

You can now go back to SuperOffice CRM and open a new dynamic selection to see all the contacts you have to follow up on.

Make sure to add your SAINT criteria. Click Add, then click next to the field and choose Company – Counters (SAINT). Find your SAINT status monitor. In our example, we will choose Neglected Customers and click OK. Refresh your selection and you will know exactly which customers need to be followed up on.

## Restore and edit statuses

* [Restore a deleted status][6]
* [Edit a status description][7]

## Administrate and maintain status monitors

* [Manage status monitors][8]

<!-- Referenced links -->
[1]: create-status.md
[2]: select-image-for-status.md
[3]: select-default-follow-up-type-for-status.md
[4]: select-status-criteria.md
[5]: select-period-length.md
[6]: restore-status.md
[7]: edit-status.md
[8]: manage-status-monitors.md

<!-- Referenced images -->
