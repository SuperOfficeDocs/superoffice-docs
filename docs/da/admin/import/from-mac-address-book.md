---
uid: help-da-import-from-mac-address-book
title: Import fra Mac-adressebog
description: Import fra Mac-adressebog
keywords: Indstillinger og vedligeholdelse, importer
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: howto
index: true
redirect_from: /da/admin/import/learn/import-from-mac-address-book
language: da
---

# Import fra Mac-adressebog

[!include[Back up database before import](includes/caution-backup-before-import.md)]

## Import af firmaer/personer fra Mac-adressebog

<!-- NEED complete rewrite to get correct behavior, need more info from Max/Office integration team.  -->

Ikonet i Importer vises, hvis brugeren har WebTools til Mac installeret og åbner Indstillinger og vedligeholdelse.

1. [!include[Open Import](includes/open-import.md)]

2. Klik på Mac-ikonet ![icon][img2] under **Vælg en importkilde**. Mac-adressebog åbnes, og der vises en dialogboks, mens eksporten fra adressebogen kører.

    > [!NOTE]
    > Firmaerne/personerne fra Outlook bliver ikke importeret i SuperOffice-databasen endnu. SuperOffice indlæser blot firma-/personlisten fra Outlook, så du kan angive importindstillingerne.

    Når importen fra Outlook er fuldført, vises firmaerne/personerne i skærmbilledet **Importer**.

### Vises der en fejlmeddelelse?

[!include[WebTools](includes/missing-webtools.md)]

## Tilpas importen

[!include[Adjust for Gmail/Outlook](includes/adjust-email-only.md)]

### Fejlfinding

[!include[Contacts without icons](includes/troubleshoot-import.md)]

## Fuldfør importen

[!include[Step: complete the import](includes/import-complete.md)]

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../media/icons/admin/import-outlook-small.png
