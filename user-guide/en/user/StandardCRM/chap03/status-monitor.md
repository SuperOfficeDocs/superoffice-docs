---
uid: help-en-status-monitor
title: Status monitor
description: Status monitor
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Status monitors

This feature requires a licence for Sales Intelligence.

If you have purchased a licence for SAINT ("SAles INTelligence"), you can specify criteria for status monitors of companies, contacts and projects in SuperOffice Settings and maintenance. Statuses generated from these criteria can be visualised as an image shown in the company cards, contact cards or project cards. For example, you can display an image of a warning triangle for a customer who has required a lot of sales meetings but who has not generated any sales, or a spider's web for a customer who has not been contacted in more than three months. This provides you with a clear and instant indication of particular statuses, which may be very useful to sales staff.

<!-- Fix reuse ID=a1 -->

## Companies/contacts

<table>

<tbody>
<tr>
<td><p>Status name</p></td>
<td><p>Criteria</p></td>
<td><p>Explanation</p></td>
<td><p>Task</p></td>
</tr>
<tr>
<td><p>Expensive customer</p></td>
<td><p>**Number of activities** of type **Marketing** in period is high.</p>
<p>**Number of sales** with status **Sold** in period is low.</p></td>
<td><p>You have undertaken a lot of marketing towards the customer, but this has led to few or no sales.</p></td>
<td><p>Plan an internal meeting to find out what can be done to make the customer profitable.</p></td>
</tr>
<tr>
<td><p>Neglected customer</p></td>
<td><p>**Number of activities** with direction **Outgoing** in period is low.</p></td>
<td><p>You have had very little contact with the customer.</p></td>
<td><p>Plan a phone call with the customer to maintain customer relations.</p></td>
</tr>
<tr>
<td><p>Sleeping customer</p></td>
<td><p>**Number of activities** with direction **Incoming** in period is low or zero.</p>
<p>**Number of activities** with direction **Outgoing** in period is high.</p></td>
<td><p>You are trying to get into contact with the customer, but are getting little or no response.</p></td>
<td><p>Arrange a meeting with the customer to find out why they do not want to communicate.</p></td>
</tr>
</tbody>
</table>

## Projects

<table>

<tbody>
<tr>
<td><p>Status name</p></td>
<td><p>Criteria</p></td>
<td><p>Explanation</p></td>
<td><p>Task</p></td>
</tr>
<tr>
<td><p>Neglected project</p></td>
<td><p>**Project status** is set to ongoing.</p>
<p>**Date of last activity** (follow-up) is older than 14 days.</p></td>
<td><p>The project is active, but there have not been any activities for the last 2 weeks.</p></td>
<td><p>Plan a project meeting to get the wheels turning.</p></td>
</tr>
<tr>
<td><p>Unprofitable project</p></td>
<td><p>**Number of sales** (completed) is zero.</p>
<p>**Project status** is completed or stopped.</p></td>
<td><p>The project is complete, but nothing has been sold.</p></td>
<td><p>Plan an internal meeting to find out why no sales were achieved.</p></td>
</tr>
</tbody>
</table>

The way to create statuses is described in detail in the SuperOffice Settings and maintenance help.

When you see a status image for a company, contact or a project, you have two options:

* If you hold the mouse pointer over the image, a tooltip appears showing you the same of the status and a description. You also get information about any other statuses relating to the company, contact or project.
* If you click the image, the [View statuses dialog](Status_dialog.md) is displayed, and here you can see the name and description of the status and carry out relevant tasks for the company, contact or project.

> [!TIP]
> You can combine one or more of these statuses as criteria when you create a dynamic selection and, in this way, get a simple overview of companies, contacts or projects whose statuses meet these criteria.

## What would you like to do now?

[Use status monitors in a dynamic selection](Using_status_monitors_in_dynamic_selections.md)
