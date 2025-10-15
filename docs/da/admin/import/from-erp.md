---
uid: help-da-import-from-erp
title: Import fra ERP
description: Import fra ERP
keywords: import, ERP
author: digitaldiina
date: 04.28.2025
version: 10.5.4
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /da/quote/learn/admin/sync/sync-import-from-erp
  - /da/admin/import/learn/import-from-erp
language: da
---

# Import fra ERP

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Følg nedenstående trin for at importere aktører (kunder, leverandører og enkeltpersoner) fra et ERP-system til SuperOffice-databasen.

## Valg af aktører, der skal importeres fra ERP-systemet

1. [!include[Open Import](includes/open-import.md)]
2. Klik på **ERP Sync** under **Vælg en importkilde**. Dialogboksen **Vælg ERP-link åbnes.**

    Hvis ERP-synkroniseringsknappen er inaktivt, skal du deaktivere synkronisering under fanen **Tilbud/Sync** > **Sync**.

3. I listen **ERP-link** [vælger du den forbindelse][2], du vil importere fra.
4. Vælg på listen **Aktørtype** det, som du vil importere. For eksempel kunder, leverandører eller enkeltpersoner.
5. Klik på **OK**. Dialogboksen **Søg i ERP** vises.
6. [Søg efter de aktører, du vil importere][1], f.eks. alle leverandører i en bestemt by.
7. Vælg på listen over søgeresultater de rækker, du vil importere.
8. Klik på  **Tilføj import**. Aktørerne vises i Indstillinger og vedligeholdelse.

> [!NOTE]
> Aktører fra ERP-systemet er i denne fase endnu ikke blevet importeret i SuperOffice-databasen. SuperOffice indlæser bare de aktører, du vil importere, så du kan definere importindstillingerne.

## Konfiguration af importen

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Fjern markeringen på de rækker, du IKKE vil importere.

1. Når du har kontrolleret, at dette reelt er de data, du vil importere, skal du klikke på **Importer**

## Fuldfør importen

Når importen er færdig, vises to lister:

* Nye aktører, der blev importeret.
* Eksisterende aktører, der blev opdateret af importen.

Over hver liste er der et link til udvalget, der indeholder de nye/opdaterede aktører.

> [!TIP]
> Hvis du vil slette importerede aktører fra SuperOffice, skal du bruge udvalget.

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: ../../erp/admin/add-connection.md

<!-- Referenced images -->
