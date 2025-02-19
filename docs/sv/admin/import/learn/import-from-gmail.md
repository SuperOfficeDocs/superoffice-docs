---
uid: help-sv-import-from-gmail
title: Importera från Gmail
description: Importera från Gmail
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar och underhåll, importera
topic: howto
language: sv
---

# Importera från Gmail

[!include[Back up database before import](includes/caution-backup-before-import.md)]

## Importera företag/kontakter från Gmail

1. [!include[Open Import](includes/open-import.md)]

2. Klicka på ![ikon][img2] Gmail-ikonen under **Välj en importkälla**.

3. Bevilja åtkomst. Vilken dialogruta som visas beror på om du redan är inloggad i Gmail eller inte

    * Om dialogrutan **Begär åtkomst** visas är du redan inloggad i Gmail. Klicka på **Bevilja åtkomst**.

    * Om dialogrutan **Google-konton** visas är du inte inloggad i Gmail. Ange användarnamn och lösenord och logga in i Gmail. Klicka på **Bevilja åtkomst**.
        Dina Gmail-företag visas under Inställningar och underhåll.

    > [!NOTE]
    > Företagen/kontakterna från Gmail importeras inte till SuperOffice-databasen än. SuperOffice läser bara in företagslistan från Gmail så att du kan ange importinställningar.

## Anpassa importen

[!include[Adjust for Gmail/Outlook](includes/adjust-email-only.md)]

### Felsökning

[!include[Contacts without icons](includes/troubleshoot-import.md)]

## Slutför importen

[!include[Step: complete the import](includes/import-complete.md)]

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/icons/admin/import-gmail-small.png
