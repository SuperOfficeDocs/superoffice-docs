---
uid: help-en-mass-delete
title: Mass delete records (permanently)
description: In line with the GDPR requirements, you need to have a legal basis for storing the data of all your contacts. And when you no longer have a legal basis to do so, you need to remove their data from all of your systems.
author: Bergfrid Dias
date: 02.15.2023
keywords: selection, GDPR
topic: howto
language: en
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

SAINT can also be used to monitor contact information.

This means that you can, for example, use SAINT to identify contacts that you haven't had contact with at all over a given period. This would give you a list of contacts that you may want to remove from your CRM database or treat in a certain way, based on your company's GDPR policies.

Here is more information on [how to set up a SAINT selection][3].

If you are brand new to SAINT, it may be helpful to use a SuperOffice CRM expert to help you get started. Your local SuperOffice contact can assist you with this.

## Mass updating or deleting contacts

After you have created a list of all the contacts that need to be either updated or deleted, it is time to actually perform the changes you want.

To mass update, say legal basis or similar, select [bulk update][5] from your selection's **Task** tab.

To mass delete contacts from a selection, you can choose the **Delete all contacts** feature from the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in the bottom-right corner of the main screen.

![From the Task button on the selection screen you can mass delete companies and contacts -screenshot][img2]

1. Go to a selection. For example, [use the Find screen][1].

1. To delete just some of the selection members, select them in the list of members.

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Delete all**.

    ![On the selection, click on the Task button and select one of the wanted Delete functions -screenshot][img1]

1. When you are asked if you want to delete the records, click **Yes**.

1. When you are asked if you really want to delete the records from the database, click **Yes**.

[!include[Note about restore](../../../../learn/includes/note-restore.md)]

## What if you delete contacts by accident?

Deleting contacts can sometimes be tricky. If a contact or a company is deleted by mistake, you can undo it by using the [Recycle bin][4].

Even though a deleted contact or a company are immediately hidden from all users, they are still available for up to 14 days in the recycle bin, from where you can restore a company or a contact that was deleted by mistake.

The Recycle bin is located in your personal Preferences menu. You can see all the contacts that you have deleted, but also all the contacts that were deleted by other users.

![You can restore items you have deleted by opening the Recycle bin in your Personal settings menu -screenshot][img3]

<!-- Referenced links -->
[1]: ../../../learn/find-screen.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
[3]: ../create.md
[4]: ../../../../learn/basics/deleting-elements.md#restore
[5]: bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/search-options/company-selection-task-delete.png
[img2]: ../../../../../media/loc/en/search-options/company-selection-task-delete.png
[img3]: ../../../../../media/loc/en/learn/recycle-bin-personal-settings.png
