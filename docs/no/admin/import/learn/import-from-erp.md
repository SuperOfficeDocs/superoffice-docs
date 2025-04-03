---
uid: help-no-import-from-erp
title: Importere fra ERP
description: Importere fra ERP
keywords: import, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Importere fra ERP

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Følg fremgangsmåten under for å importere aktører (kunder, leverandører og enkeltpersoner) fra et ERP-system til SuperOffice-databasen.

## Velge aktører som skal importeres fra ERP-systemet

> [!NOTE]
> Hvis ![ikon][img1] ERP Sync-ikonet er inaktivt, må du slå av synkronisering i **Tilbud/Sync** > **Sync**-fanen.

1. [!include[Open Import](includes/open-import.md)]
2. Klikk på ![ikon][img1] ERP Sync-ikonet under **Velg en importkilde**. Dialogboksen **Velg ERP-kobling** vises.
3. I listen **ERP-kobling** velger du [koblingen][2] du vil importere fra.
4. I listen **Aktørtype** velger du hva du vil importere. For eksempel kunder, leverandører eller enkeltpersoner.
5. Klikk på **OK**. Dialogboksen **Søk i ERP** vises.
6. [Søk etter aktørene du vil importere][1], for eksempel alle leverandører i en bestemt by.
7. Merk av for de radene du vil importere, i listen med søkeresultater.
8. Klikk på **Legg til import**. Aktørene vises i Innstillinger og vedlikehold.

> [!NOTE]
> Aktører fra ERP-systemet blir ikke importert til SuperOffice-databasen ennå. SuperOffice laster bare inn aktørene du vil importere, slik at du kan angi importinnstillingene.

## Tilpasse importen

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Fjern merkingen for de radene du IKKE vil importere.

1. Når du har kontrollert at dette virkelig er dataene du vil importere, klikker du på **Importer**

## Ferdigstille importen

Når importen er fullført, vises to lister:

* Nye aktører som ble importert.
* Eksisterende aktører som ble oppdatert av importen.

Over hver liste er det en kobling til utvalget med de nye/endrede aktørene.

> [!TIP]
> Hvis du vil slette importerte aktører fra SuperOffice, bruker du utvalget.

<!-- Referenced links -->
[1]: ../../../search-options/learn/search-criteria.md
[2]: ../../../learn/admin/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-erp-small.png
