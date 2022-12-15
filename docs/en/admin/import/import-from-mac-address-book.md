---
uid: help-en-import-from-mac-address-book
title: Import from Mac Address book
description: Import from Mac Address book
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, import
so.topic: help
language: en
---

# Import from Mac Address book

[!include[Back up database before import](includes/caution-backup-before-import.md)]

## Import companies/contacts from Mac Address book

<!-- NEED complete rewrite to get correct behavior, need more info from Max/Office integration team.  -->
The icon in Import appears if user have WebTools for Mac installed and opening Settings and maintenance.

1. [!include[Open Import](includes/open-import.md)]

2. Click the Mac icon ( ![icon][img2] ) under **Select an import source**. Mac Address book will open and a dialog is displayed while the export from Address book is in progress.

    <details><summary>Is an error message displayed?</summary>

    You must install and configure SuperOffice WebTools to import companies from Outlook. In SuperOffice CRM, go to **File** > **Download** > **SuperOffice WebTools**. Contact user support if you experience problems.
    </details>

    > [!NOTE]
    > The companies/contacts from Outlook will not be imported into the SuperOffice database yet. SuperOffice will only upload the company/contact list from Outlook, so that you can specify the import settings.

    When the import from Outlook is finished, the companies/contacts are displayed in the **Import** screen.

## Adjust the import

[!include[Adjust for Gmail/Outlook](includes/adjust-email-only.md)]

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

### Troubleshooting

[!include[Contacts without icons](includes/troubleshoot-import.md)]

## Complete the import

[!include[Step: complete the import](includes/import-complete.md)]

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../media/icons/admin/import-outlook-small.bmp
