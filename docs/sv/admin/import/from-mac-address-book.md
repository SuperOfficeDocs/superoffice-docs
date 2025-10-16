---
uid: help-sv-import-from-mac-address-book
title: Importera från Mac-adressbok
description: Importera från Mac-adressbok
keywords: importera från Mac
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/admin/import/learn/import-from-mac-address-book
language: sv
---

# Importera från Mac-adressbok

[!include[Back up database before import](includes/caution-backup-before-import.md)]

## Importera företag/kontakter från en Mac-adressbok

<!-- NEED complete rewrite to get correct behavior, need more info from Max/Office integration team.  -->

Ikonen visas under Import om användaren har installerat WebTools for Mac och öppnar Inställningar och underhåll.

1. [!include[Open Import](includes/open-import.md)]

2. Klicka på ![ikon][img2] Mac-ikonen under **Välj en importkälla**. Mac-adressboken öppnas och en dialogruta visas medan exporten från adressboken pågår.

    > [!NOTE]
    > Företagen/kontakterna från Outlook importeras inte till SuperOffice-databasen än. SuperOffice läser bara in företags-/kontaktlistan från Outlook så att du kan ange importinställningar.

    När importen från Outlook är klar visas företagen/kontakterna i fönstret **Importera**.

### Visas det ett felmeddelande?

[!include[WebTools](includes/missing-webtools.md)]

## Anpassa importen

[!include[Adjust for Gmail/Outlook](includes/adjust-email-only.md)]

### Felsökning

[!include[Contacts without icons](includes/troubleshoot-import.md)]

## Slutför importen

[!include[Step: complete the import](includes/import-complete.md)]

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../media/icons/admin/import-outlook-small.png
