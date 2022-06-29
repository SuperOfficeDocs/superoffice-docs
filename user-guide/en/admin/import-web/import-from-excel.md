---
uid: help-en-import-from-excel
title: Import from Excel
description: Import from Excel
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Import from Excel

![icon](../media/utropstegn.bmp) We recommend that you contact SuperOffice Support in order to back up the SuperOffice database before you import large amounts of data.

If you have an Excel spreadsheet with a list of your companies/contacts and associated data, you can easily import them into SuperOffice. The spreadsheet may for example contain:

* A list of leads/prospects that you want to import into SuperOffice.  
    > [!TIP]
    > Add a column with, for example, the text "prospect" for all the contacts, to make it easy to link them to the correct category in SuperOffice CRM.
* A company/contact list with "cleansed" data. That is, data that has been exported and checked for quality, and is to be imported again.
* Companies and contacts from other applications and formats, such as finance systems, other CRM clients, e-mail clients (other than Gmail and Outlook) and Windows installations of SuperOffice CRM.

To import an Excel spreadsheet into the SuperOffice database:

## A. Import companies/contacts from an Excel file

<!-- Fix reuse ID=a1 -->

* The Excel spreadsheet should as a minimum contain columns with company names and contact names (first name and last name).
* You should check that the data is up-to-date (e.g. that postal addresses, telephone numbers and sector are correct).

1. Open the **Import** screen by clicking the **Import** button in the Navigator ( ![icon](../media/Knapp-Import-liten.bmp) ).
2. Make sure that **Contacts** is selected under **Select an import source** and then click the Excel icon ( ![icon](../media/import-excel-small.bmp) ). The **Upload file** dialog opens.
3. Click **Upload file** to select the Excel spreadsheet you want to import.
4. Browse to the required Excel spreadsheet and click **Open**. The data from the spreadsheet will be displayed in the table.

> [!NOTE]
> At this stage, companies/contacts from Excel have not yet been imported into the SuperOffice database. SuperOffice will only upload the company/contact list from the spreadsheet, so that you can specify the import settings.

## B. Adjust the import

As the Excel spreadsheet may contain anything from just a few to a large number of columns, it is important that the columns with data you want to import are linked to the correct SuperOffice field.

> [!NOTE]
> If the Excel spreadsheet had a title row at the top, this will also be displayed in the list. You can remove this when you preview the data in the next step.

To do this:

1. Find the column containing the name of the companies, click the **(No Selection)** column title and select **Company: Name**.
2. Find the column containing the first and last names of the contacts, click the **(No Selection)** column title and select **Contact: First name** and **Contact: Last name**. If there is a single column containing both first and last names, select **Contact: Full name**.
3. Select the SuperOffice fields for the rest of the columns in the table. You do not need to do this for the columns you do not want to import.
4. Click **Configure import settings** and adjust the import settings as described in [Configure import settings](Import-settings-web.md).
5. In the **Consent comment** field, enter a comment about why you are registering these contacts in SuperOffice (purpose) and how/where you obtained their consent. The legal basis and consent source can be defined in **Import settings** (see [Configure import settings](Import-settings-web.md#setprivacy)). See also [Privacy](../privacy/privacy.md).
6. Click **Next**. The **Preview import** window will appear.  
    <!-- Fix reuse ID=a4 -->
    You must link all the required SuperOffice fields to their respective columns in order to continue. The required fields will be displayed above the table. If you have specified that contacts without companies should be added as new companies, only the SuperOffice field **Company: Name** is mandatory.
7. In **Preview import** you can browse through the import data before the import begins.  
    <!-- Fix reuse ID=a3 -->  
    <!-- Fix reuse ID=a2 -->
    Rows without icons are not imported. If you see that many contacts are not being imported, this may be because they are not linked to a company. In that case, you can do one of the following:

    If the contact is actually linked to a company, you need to return to the import source (Gmail, Outlook or Excel) and specify a company for the contact. Then start the import afresh.
    If the contact is not linked to a company, but should be registered under his or her own name in SuperOffice, you need to set up the person as a company, as follows:
    1. Click **Previous** and **Configure import settings**.
    2. Click the **If no company name** list under **Contact**.
    3. Select **Create company using contact name**.
    4. Click **Save**.
    5. Click **Next**, and check that the ![icon](../media/import-preview-icon-Company-New.bmp) icon is displayed next to the contact. The person will be registered as a company in SuperOffice CRM with himself or herself as the only contact.

    <table style=" vertical-align:top; margin-top:5px; width:100%; max-width:83.758%;" data-cellspacing="0">
    
    <tbody>
    <tr>
    <td>Icon</td>
    <td>Description</td>
    </tr>
    <tr>
    <td>![icon](../media/import-preview-icon-Company-New.bmp)</td>
    <td>The company does not exist and will be added.</td>
    </tr>
    <tr>
    <td>![icon](../media/import-preview-icon-Company-Changed.bmp)</td>
    <td>The company already exists and will be updated.</td>
    </tr>
    <tr>
    <td>![icon](../media/import-preview-icon-Person-New.bmp)</td>
    <td>The contact does not exist and will be added.</td>
    </tr>
    <tr>
    <td>![icon](../media/import-preview-icon-Person-Changed.bmp)</td>
    <td>The contact already exists and will be updated.</td>
    </tr>
    <tr>
    <td>empty</td>
    <td>No updating.</td>
    </tr>
    </tbody>
    </table>
8. Remove the checks for the rows you do NOT want to import. If the Excel spreadsheet contained a heading row, you can remove it here.
9. When you have checked that this actually is the data you want to import, click **Import**.

## C. Complete the import

When the import is complete, two lists will be displayed:

* New companies/contacts which have been imported.
* Existing companies/contacts which have been changed as a result of the import.

Above each list is a link to the selection with the new/changed companies/contacts.

**Tip**: If you have imported new companies/contacts and there are problems with the imported data, you can open this selection in SuperOffice CRM and delete the new companies/contacts.
