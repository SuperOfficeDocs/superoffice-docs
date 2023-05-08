---
uid: help-en-fastsearcher
title: Using FastSearcher
description: Using FastSearcher
author: SuperOffice RnD
so.date: 05.08.2023
keywords: search, FastSearcher
so.topic: howto
language: en
---

# FastSearcher

You can use FastSearcher in various ways:

* You can search directly from the Navigator to access the required company, contact, sales, project or selection.
* You can search for companies, contacts, sales, projects and selections from within dialogs containing the relevant fields, for example, the **Appointment** and **Document** dialogs, to link them to the appointment or document.
* You can search directly in the [time zone selector][2] to find the time zone for the required city or country.

[!include[Examples of searches](includes/freetext-search-examples.md)]

## Using FastSearcher in the Navigator

1. Click the word **Company**, **Contact**, **Sale**, **Project** or **Selection** in the Navigator on the left of the window. An empty field is displayed at the top. Below this is a [list of records you have previously worked with][1].

    ![FastSearcher - screenshot][img1]

2. In the box, enter the name of the record to search for. While you type, the list below displays all matching records.

    Examples:

    * You can search for a sale by entering the name of the sale or the name of a company linked to the sale, in the FastSearcher field for **Sales** in the Navigator.

        ![FastSearcher - screenshot][img2]

    * You can search for a contact in the FastSearcher field for **Companies** in the Navigator.

3. Click the required record to open it.

## Using FastSearcher in dialogs

1. Open the relevant dialog.

2. In the relevant box, enter the name of the record to search for. While you type, the list below displays all matches.

    ![FastSearcher - screenshot][img3]

3. Click the required company, contact, sale, project or selection to link to the record.

> [!TIP]
> If you type a percent sign (%) in front of the search text, all records which *contain* the search text are displayed. For example, if you type %joh, both "Johnson Plumbing" and "Peter Johnson" are shown.

### FastSearch tips

You can use %% to see all records of a certain type, such as all companies, all selections, all projects.

If, for example, you want to see all the document templates available in SuperOffice CRM, go to the **+New** menu and click **Document**. In the top field in the document screen, which indicates types of document templates, type %%. You will then see a drop-down list that includes the full list of document templates available.

![Type in two percentage signs in the FastSearcher to see all records -screenshot][img4]

<!-- Referenced links -->
[1]: ../../learn/basics/history.md
[2]: ../../globalization-and-localization/learn/time-zones.md

<!-- Referenced images -->
[img1]: media/quicksearch-company.bmp
[img2]: media/quicksearch-sale.bmp
[img3]: media/quicksearch-dialog.bmp
[img4]: media/getstarted-document-fastsearcher.png
