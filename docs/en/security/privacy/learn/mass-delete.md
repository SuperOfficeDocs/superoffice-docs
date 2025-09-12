---
uid: help-en-mass-delete
title: Mass delete records (permanently)
description: In line with the GDPR requirements, you need to have a legal basis for storing the data of all your contacts. And when you no longer have a legal basis to do so, you need to remove their data from all of your systems.
keywords: mass delete, delete personal data
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/search-options/selection/learn/howto/mass-delete
---

# Mass delete records (permanently)

In line with the GDPR requirements, you need to have a legal basis for storing the data of all your contacts. And when you no longer have a legal basis to do so, you need to remove their data from all of your systems.

This means you are not allowed to save a person's details forever. As a company, you need to think about and be able to justify – how long you will keep personal data before you erase or review the data you store.

To delete multiple records (contacts, companies, sales, projects, and so on), you can create a selection of these records and delete them in one operation.

> [!NOTE]
> This task is only available for users with administrator access. It is also a task you should think about carefully before performing, because it deletes all selected records permanently, both from the Selection screen and from the SuperOffice database.

## Determining what and when personal data needs to be deleted

How long you can keep data will depend upon a number of things that are specific to your company and are among the things you define as part of your privacy strategy.

For example, you may decide that you can justify saving the personal information about prospects for three years, and the personal data of lost customers for five years, or something similar.

Perhaps you decide that the time for storing personal data will be longer for people who have given their consent to receive marketing information and lost customers that keep on asking your company support questions.

All these conditions and terms you need to clarify and define as part of your GDPR strategy. It is recommended to seek legal advice on such matters to ensure compliance.

After you have determined the rules that apply for your company, you can use the Selection functionality and the [SAINT feature][2] in SuperOffice CRM to help you find the contacts that should be deleted, and them mass delete all contacts that you no longer want to keep in the system.

## Find contacts who should be deleted or reviewed with Selections

Selection is a tool to find data in your CRM database that fits a specific set of criteria.

Deleting all the contacts of a certain customer category and that you have not been in contact with for a certain period will help you to keep your database up to date.

You can, for example, create selections of all contacts defined as:

* Prospects
* Registered before a certain date
* That have no explicit consents documented
* That has had no interaction with your company during a given period

You can search and find contacts that meet more than one criteria, or you can create several selections and then look for the data that is common or different by creating a combined selection.

Selection is a very flexible and powerful tool, after you have mastered how to use it.

## Use SuperOffice SAINT to review your contacts

You can also use SAINT to help you identify possible contacts that need to be erased.

SAINT stands for "SAles INTelligence" and works by adding some smart algorithms to your CRM data.

Simply put, SuperOffice SAINT monitors the data you have stored in your CRM solution and alerts you to different statuses or action requests that you have defined as important. This may be anything from actions that have not yet happened in a given time, to values that are met or not met, and that you want to be alerted about, so you can take the action required.

SAINT can also be used to monitor contact information. This means that you can, for example, use SAINT to identify contacts that you have not had contact with at all over a given period. This would give you a list of contacts that you may want to remove from your CRM database or treat in a certain way, based on your company's GDPR policies.

SAINT criteria are located under **Counters (SAINT)** in the [list of criteria][9] on the **Find** screen.

If you are brand new to SAINT, it may be helpful to use a SuperOffice CRM expert to help you get started. Your local SuperOffice contact can assist you with this.

## Mass updating contacts

After [creating a selection][8] of contacts that need updating, you can quickly modify their details in bulk.

1. Open the required selection and go to the **Company/contact** tab.
1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) and select **Bulk update**.
1. Choose the field you want to update (for example, legal basis, category).
1. Apply the changes and confirm.

> [!TIP]
> [Bulk updating][5] helps keep your database consistent and compliant with company policies.

## Mass deleting contacts and companies

To comply with GDPR, you must remove personal data when you no longer have a legal basis to store it.

> [!CAUTION]
> Only administrators can perform this action. **Deleted records cannot be restored.**

### Steps

1. Open the required selection and go to the **Company/contact** tab.
1. To delete specific contacts, select them in the Company/contact tab.
1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) and select **Delete all contacts** or **Delete all companies and contacts**.
1. Confirm the deletion when prompted.

<!-- Referenced links -->
[9]: ../../../search-options/learn/search-criteria.md
[8]: ../../../search-options/selection/learn/create.md
[5]: ../../../learn/basics/bulk-update.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
