---
uid: help-en-import-from-excel
title: Import from Excel
description: Import from Excel
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, import
so.topic: help
language: en
---

# Import from Excel

[!include[Back up database before import](includes/caution-backup-before-import.md)]

If you have an Excel spreadsheet with a list of your companies/contacts and associated data, you can easily import them into SuperOffice. The spreadsheet may for example contain:

* A list of leads/prospects that you want to import into SuperOffice.

    > [!TIP]
    > Add a column with, for example, the text "prospect" for all the contacts, to make it easy to link them to the correct category in SuperOffice CRM.

* A company/contact list with "cleansed" data. That is, data that has been exported and checked for quality, and is to be imported again.
* Companies and contacts from other applications and formats, such as finance systems, other CRM clients, email clients (other than Gmail and Outlook) and Windows installations of SuperOffice CRM.

## How can I prepare the Excel spreadsheet before import?

* The Excel spreadsheet should as a minimum contain columns with company names and contact names (first name and last name).
* Check that the data is up-to-date. For example, are postal addresses and telephone numbers correct?

To import an Excel spreadsheet into the SuperOffice database:

## Import companies/contacts from an Excel file

1. [!include[Open Import](includes/open-import.md)]

2. Make sure that **Contacts** is selected under **Select an import source** and then click the Excel icon ( ![icon][img1] ). The **Upload file** dialog opens.

3. Click **Upload file** to select the Excel spreadsheet you want to import.

4. Browse to the required Excel spreadsheet and click **Open**. The data from the spreadsheet will be displayed in the table.

> [!NOTE]
> At this stage, companies/contacts from Excel have not yet been imported into the SuperOffice database. SuperOffice will only upload the company/contact list from the spreadsheet, so that you can specify the import settings.

## Adjust the import

As the Excel spreadsheet may contain anything from just a few to a large number of columns, it is important that the columns with data you want to import are linked to the correct SuperOffice field.

> [!NOTE]
> If the Excel spreadsheet had a title row at the top, this will also be displayed in the list. You can remove this when you preview the data in the next step.

1. Find the column containing the name of the companies, click the **(No Selection)** column title and select **Company: Name**.

1. Find the column containing the first and last names of the contacts, click the **(No Selection)** column title and select **Contact: First name** and **Contact: Last name**. If there is a single column containing both first and last names, select **Contact: Full name**.

1. Select the SuperOffice fields for the rest of the columns in the table. Skip the columns you do not want to import.

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Remove the checks for the rows you do NOT want to import. If the Excel spreadsheet contained a heading row, you can remove it here.

1. When you have checked that this actually is the data you want to import, click **Import**.

### Troubleshooting

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**I can't get any further!**

You must link all the required SuperOffice fields to their respective columns to continue. The required fields will be displayed above the table. If you have specified that contacts without companies should be added as new companies, only the SuperOffice field **Company: Name** is mandatory.

## Complete the import

[!include[Step: complete the import](includes/import-complete.md)]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../media/icons/admin/import-excel-small.bmp
