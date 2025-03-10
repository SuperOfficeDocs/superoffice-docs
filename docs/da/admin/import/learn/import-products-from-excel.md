---
uid: help-da-import-products-from-excel
title: Import af produkter fra Excel
description: I denne guide lærer du, hvordan du kan importere alle dine produkter, beskrivelser og produktkoder.
author: Bergfrid Dias
date: 02.22.2023
keywords: importer, produkt, Excel
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Import af produkter fra Excel

[Import][2] er en fantastisk metode til hurtigt at udfylde eller opdatere databasen med prisoplysninger. Hvis du har et Excel-regneark med en liste af produkter, er det nemt og enkelt at importere dem til SuperOffice.

## Før du starter

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Før du starter importen, skal du [forberede Excel-filen][1]. Tjekliste:

* Excel-regnearket skal som minimum indeholde kolonner med: produktkode, produktnavn og listepris.
* Sørg for at tilføje en unik produktkode for hver række som en dubletnøgle.

## Eksport af produkter fra en Excel-importfil

Se denne video, eller følg trinnene for at lære, hvordan du importerer dine produkter til SuperOffice CRM ved hjælp af vores importskabelon (videolængde - 4:22):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xOTB6j2zzNo]

1. [!include[Open Import](includes/open-import.md)]

2. Klik på **Produkter** under **Vælg en importkilde**.

3. Vælg i **Importer til prisliste** den prisliste, du vil importere produkterne til.

4. Klik på Excel-ikonet ![icon][img1] under **Vælg en importkilde**.

5. Klik på **Upload fil** i dialogboksen **Upload fil** for at vælge det Excel-regneark, du vil importere.

6. Find det ønskede Excel-regneark, og klik på **Åbn**. Feltet **Filnavn** viser placeringen og navnet på den fil, du har valgt.

7. Klik på **Gem**. Dataene fra regnearket vises i tabellen, og navnet på importfilen vises nederst.

> [!NOTE]
> Produkter fra Excel bliver ikke importeret i SuperOffice-databasen endnu. SuperOffice indlæser blot personlisten fra regnearket, så du kan angive importindstillingerne.

## Tilpas importen

Da Excel-regnearket kan indeholde alt fra nogle få kolonner til et meget stort antal kolonner, er det vigtigt, at kolonnerne med data, du vil importere, knyttes til det rigtige SuperOffice-felt.

> [!NOTE]
> Regnearket skal som minimum indeholde de kolonner, du vælger til dubletkontrol i nedenstående procedure (navn, kode eller navn+kode).

1. Find kolonnen, der indeholder navnet på produkterne, klik på kolonnetitlen **(Ingen valgt)**, og vælg **Produkt: Navn**.

2. Find kolonnen, der indeholder navnet på produktkoden, klik på kolonnetitlen **(Ingen valgt)**, og vælg **Produkt: Kode**.

3. Vælg SuperOffice-felterne for resten af kolonnerne i tabellen. Spring over de kolonner, du ikke vil importere.

4. [!include[Configure import settings](includes/configure-import-settings.md)]

5. Klik på **Next**. Skærmbilledet **Forhåndsvisning** vises.

6. Gennemse importdataene for at rette eventuelle fejl, før importen starter.

    | Ikon | Beskrivelse |
    |---|---|
    | <i class="ph ph-warning" aria-label="Warning"></i> | Der er et problem med dataene i denne række. Se forklaringsteksten i tabeloverskriften. |
    | ![icon][img3] | Produktet findes ikke allerede og vil blive tilføjet. |
    | ![icon][img4] | Produktet findes allerede og vil blive opdateret. |
    | tom | Ingen opdatering. |

7. Fjern markeringen af de rækker, du IKKE vil importere. Hvis Excel-regnearket indeholdt en overskriftsrække, kan du fjerne den her.

8. Når du har kontrolleret, at dette rent faktisk er de data, du ønsker at importere, skal du klikke på **Importér**.

## Fuldfør importen

Når importen er fuldført, vises en liste over de importerede produkter. Over listen er der et link til den opdaterede prisliste.

## Relateret

* [Konfiguration af importindstillinger][3]
* [Import fra ERP][6]

<!-- Referenced links -->
[1]: create-import-file.md
[2]: index.md
[3]: configure-import-settings.md
[6]: import-from-erp.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-excel-small.png
[img3]: ../../../../media/icons/admin/import-preview-icon-product-new.png
[img4]: ../../../../media/icons/admin/import-preview-icon-product-changed.png
