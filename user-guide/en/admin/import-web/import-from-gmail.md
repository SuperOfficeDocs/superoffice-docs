---
uid: help-en-import-from-gmail
title: Import from Gmail
description: Import from Gmail
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Import from Gmail

![icon](../media/utropstegn.bmp) We recommend that you contact SuperOffice Support in order to back up the SuperOffice database before you import large amounts of data.

To import your Gmail companies into the SuperOffice database:

## A. Import companies/contacts from Gmail

1. Open the **Import** screen by clicking the **Import** button in the Navigator ( ![icon](../media/Knapp-Import-liten.bmp) ).
2. Click the Gmail icon ( ![icon](../media/import-gmail-small.bmp) ) under **Select an import source**. What you need to do in the next step depends on whether you are already logged in to Gmail.
3. One of the following dialogs will be displayed:
    * **Request for permission**: If this dialog appears, you are already logged in to Gmail. Click **Give access**.
    * **Google accounts**: If this dialog appears, you are not logged in to Gmail. Type in the user name and password, and log in to Gmail. Click **Give access**.  
        Your Gmail companies will be displayed in Settings and maintenance.

> [!NOTE]
> The companies from Gmail will not be imported into the SuperOffice database yet. SuperOffice will only upload the company list from Gmail, so that you can specify the import settings.

## 

## B. Adjust the import

By default, all the columns with companies/contacts from the e-mail application concerned (Outlook or Gmail) are linked to a SuperOffice field, but if you wish you can

* click a column heading and edit the SuperOffice field into which the data in the column is to be imported
* click a column heading and select **(None selected)** if you do not wish to import the data in the column

1. Click **Configure import settings** and adjust the import settings as described in [Configure import settings](Import-settings-web.md).
2. In the **Consent comment** field, enter a comment about why you are registering these contacts in SuperOffice (purpose) and how/where you obtained their consent. The legal basis and consent source can be defined in **Import settings** (see [Configure import settings](Import-settings-web.md#setprivacy)). See also [Privacy](../privacy/privacy.md).
3. Click **Next** when you have finished. The **Preview** window opens.  
    <a href="javascript:BSSCPopup(&#39;import-preview-icons.md&#39;);" id="a1" class="BSSCPopup" onmouseover="if (parseInt(navigator.appVersion) &gt;= 4 &amp;&amp; typeof(BSPSPopupOnMouseOver) == &#39;function&#39;) BSPSPopupOnMouseOver(event);">What do the different icons in the table mean?</a>
4. In **Preview** you can browse through the import data before the import begins.  
    <!-- Fix reuse ID=a2 -->
    Rows without an icon will not be imported. If you can see that many contacts will not be imported, this may be because they have not been linked to a company. Here, you can do one of the following:

    If the contact is actually linked to a company, you need to return to the import source (Gmail, Outlook or Excel) and specify a company for the person. Then start the import afresh.
    If the contact is not linked to a company, but is to be registered under his own name in SuperOffice, you must create the contact as a company. You do this as follows:
    1. Click **Previous** and **Configure import settings**.
    2. Click the **If company name is empty** list below **Contact**.
    3. Select **Create company using contact**.
    4. Click **Save**.
    5. Click **Next**, and check that the ![icon](../media/import-preview-icon-Company-New.bmp) icon is displayed next to the contact. The person will be registered as a company in SuperOffice CRM with himself or herself as the only contact.
5. Remove the check marks for the rows you do NOT want to import.
6. When you have verified that this actually is the data you want to import, click **Import**.

## C. Complete the import

When the import is complete, two lists will be displayed:

* New companies/contacts which have been imported.
* Existing companies/contacts which have been changed as a result of the import.

Above each list is a link to the selection with the new/changed companies/contacts.

**Tip**: If you have imported new companies/contacts and there are problems with the imported data, you can open this selection in SuperOffice CRM and delete the new companies/contacts.
