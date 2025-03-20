---
uid: help-en-saint
title: Sales Intelligence (SAINT)
description: In this guide you will learn how SAINT can progress your sales and customer processes, as well as improve workflows.
keywords: SAINT, Sales Intelligence, activity monitor, status monitor
author: SuperOffice RnD
date: 10.18.2024
version: 9
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Activity monitors (SAINT)

Being proactive means to control an expected situation before it arises. With SuperOffice Sales Intelligence (SAINT) you get the opportunity to follow up on your customers at the right time and take control over any scenario. SAINT is designed to monitor your database and help you be proactive and anticipate events that may affect your business.

[!include[Requirement](../includes/note-saint-req.md)]

## What is SAINT and what can it do

Monitoring and analyzing the information inside your CRM system gives insight into what you can do to improve your business. With SuperOffice SAINT you can get insight by searching for information that is present and not present inside SuperOffice CRM. For example:

* Which customers did we not follow up on in the last 6 months?
* Which customers did not buy from us in the last 3 months?
* Are there customers with too many requests in the last 6 weeks?
* Do you have future activities registered on all current projects?

These questions are the starting point for the decision to take action. By taking action, you can improve or correct the existing situation.

## Statuses

If you have purchased a licence for SAINT ("SAles INTelligence"), you can specify criteria for status monitors of companies, contacts and projects in Settings and maintenance. Statuses generated from these criteria can be visualized as an image shown in the company cards, contact cards or project cards. For example, you can display an image of a warning triangle for a customer who has required a lot of sales meetings but who has not generated any sales, or a spider's web for a customer who has not been contacted in more than three months. This provides you with a clear and instant indication of particular statuses, which may be very useful to sales staff.

## A simple example

Our imaginary company Bridgecom sells computers, laptops and office software. As you know, every computer needs to be updated with new software or at times it needs to be replaced altogether. But the team at Bridgecom struggles to get an overview of the companies that need new computers and a software update. They would love to have a list of companies that haven't updated their computers in the last 2 years. This way they would know exactly what customers to follow up at the start of every month. But how do you find such information?

By using SAINT, Bridgecom can proactively search for all customers with no open or completed sales that were registered in the last 2 years on their Customer card. The SAINT selection will generate a list of these customers. Based on the information that is not present in the customer database – namely, there are no sales registered in the last 2 years.

With this overview, Bridgecom can decide how they wish to follow up on their customers to improve the relationships and to drive up sales.

![Selection of neglected customers in Settings and maintenance -screenshot][img1]

With SuperOffice SAINT you can analyze your database to get an overview of customers, sales, requests, and documents. This can be done in the form of charts and reports. Then, the people responsible for the situation that you analyzed with SAINT can take action to improve the existing situation.

[!include[Examples](../includes/status-examples.md)]

## Analysis

SAINT provides both real-time and ad-hoc analysis of continuously updated CRM data. Both methods are used to ensure relevant and correct feedback. The analysis is the starting point of it all.

With SuperOffice SAINT you are able to not only search for elements present in your database, but also search for elements that are missing.

### Example: search for missing elements

You can search for contacts that have not had any activities of a specific type (or have not expressed any sales-related intention) within a specified period. SAINT will give you all customers without a follow-up (open or completed) activity for the last 6 months.

![saint criteria's screen to find customers without a follow-up -screenshot][img2]

Finding what has not happened, but should have happened is an example of how SuperOffice SAINT can help you perform according to your defined rules or intentions.

For example, if your internal quality routine specifies that a specific action should be performed at a certain stage in a project, you can use SAINT to find whether or not this rule was followed through. Or, if your customer program states that customers of a certain category should be contacted every so often, SAINT can help you identify and list the customers that have not been followed up as planned.

These are examples of the type of insights your CRM data and SAINT can give you.

## Awareness

When the analysis is done, you need to trigger your colleagues to act on the results.

SuperOffice SAINT uses visual Status Indicators on a customer, potential customer, a sale or a project, displayed as a background picture on the card. It is impossible for an employee to overlook this indicator. The user will immediately see there is an opportunity, a problem or something that calls for action.

SAINT can be fun! You can use any background image, for example:

* A crying baby to symbolize the customers that have not been followed up,
* A dollar sign for customers with overdue sales,
* A lifebuoy for customers with too many service requests.

From the practical point of view, SAINT can provide an employee with suggested actions for a specific situation. They can create a follow-up activity or add the customer to a selection.

![Use a visual indicator like a crying baby to warn you that a customer needs to be followed up -screenshot][img3]

The SAINT criteria that generate the analyses you use will automatically become searchable "fields". Any user can use these fields to set up his or her customized list of actions or searches in SuperOffice Selection.

## Action

After the background image (visual status indicator) on a Contact/Company card or selection has made the user aware that action is required, they can access the SAINT selection. This selection holds all the customers that need to be followed up.

Using your SAINT selection, you can take action in the form of proactive, personal follow-ups, personalized email campaigns, or scheduled calls in the diaries of account managers.

As soon as the follow-up action is saved in SuperOffice CRM, the selection can be updated to give an accurate overview of the current situation. The customers you follow-up will automatically be removed from your selection.

## Working with SAINT in the user interface

When you see a status image for a company, contact or a project, you have two options:

* If you hold the mouse pointer over the image, a tooltip appears showing you the same of the status and a description. You also get information about any other statuses relating to the company, contact or project.

* If you click the image, the [View statuses dialog][1] is displayed, and here you can see the name and description of the status and carry out relevant tasks for the company, contact or project.

> [!TIP]
> You can combine one or more of these statuses as criteria when you create a dynamic selection and, in this way, get a simple overview of companies, contacts or projects whose statuses meet these criteria.
>
> If you need help to set up SAINT to progress your sales and customer processes, we always recommend using one of our skilled consultants.

## Behind the scenes

SAINT counters are stored in the [countervalue][3] table and updated automatically as you do things:

* When SAINT is enabled, whenever a contact or a project is created, a bunch of counter rows are created.

* Whenever a follow-up, document, or sale is created, then the corresponding counter rows are updated.

SAINT **values** are simple binary values (on or off) that determine the look and feel of the company and project cards. These values are stored in the [statusvalue][4] table.

## What would you like to do now?

* [Set up activity monitors][5]
* [Use status monitors in a dynamic selection][2]

<!-- Referenced links -->
[1]: status-dialog.md
[2]: ../../search-options/selection/learn/create.md
[3]: ../../database/tables/countervalue.md
[4]: ../../database/tables/statusvalue.md
[5]: ../admin/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/saint-selection.png
[img2]: ../../../media/loc/en/sale/saint-criteria.png
[img3]: ../../../media/loc/en/sale/saint-watermark.png
