---
uid: help-en-import-from-excel
title: Import from Excel
description: In this how-to guide you will learn how you can import all your prospect, customers and their contacts.
keywords: import, Excel, company, contact, spreadsheet
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/import/learn/import-from-excel
language: en
---

# Import from Excel

You can [import your customer data][2] in one go using Excel, Outlook, Gmail, or your ERP Synchronizer in SuperOffice CRM.

The Excel spreadsheet may for example contain:

* A list of leads/prospects that you want to import into SuperOffice.

    > [!TIP]
    > Add a column with, for example, the text "prospect" for all the contacts, to make it easy to link them to the correct category in SuperOffice CRM.

* A company/contact list with "cleansed" data (exported and checked for quality, and will be imported again).

* Companies and contacts from other applications and formats, such as finance systems, other CRM clients, email clients (other than Gmail and Outlook) and Windows installations of SuperOffice CRM.

## Before you begin

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Before you start your import, [prepare the Excel file][1]. Checklist:

* The Excel spreadsheet should as a minimum contain columns with company names and contact names (first name and last name).

* Check that the data is up-to-date. For example, are postal addresses and telephone numbers correct?

## Import companies/contacts from an Excel file

Watch this video or follow the steps below to learn how to import your contacts in to SuperOffice CRM using our import template (video length - 4:02):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/dVkCfpOkNl8]

### Steps

1. [!include[Open Import](includes/open-import.md)]

2. Make sure that **Contacts** is selected under **Select an import source** and then click the ![icon][img1] Excel icon.

3. In the **Upload file** dialog, click **Upload file** to select the Excel spreadsheet you want to import.

4. Browse to the required Excel spreadsheet and click **Open**. The data from the spreadsheet is displayed in the table.

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

1. [!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Remove the checks for the rows you do NOT want to import. If the Excel spreadsheet contained a heading row, you can remove it here.

1. When you have checked that this actually is the data you want to import, click **Import**.

### Troubleshooting

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**I can't get any further!**

You must link all the required SuperOffice fields to their respective columns to continue. The required fields are displayed above the table. If you have specified that contacts without companies should be added as new companies, only the SuperOffice field **Company: Name** is mandatory.

## Complete the import

[!include[Step: complete the import](includes/import-complete.md)]

## Related content

* [Configure import settings][3]
* [Import from Outlook][4]
* [Import from Gmail][5]
* [Import from ERP][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[4]: from-outlook.md
[5]: from-gmail.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png
