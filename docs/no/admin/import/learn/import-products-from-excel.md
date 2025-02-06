---
uid: help-no-import-products-from-excel
title: Importere produkter fra Excel
description: "I denne veiledningen lærer du hvordan du kan importere alle produktene, beskrivelsene og produktkodene dine."
author: Bergfrid Dias
date: 02.22.2023
keywords: importere, produkt, Excel
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Importere produkter fra Excel

[Import][2] er en effektiv måte å raskt fylle ut eller oppdatere databasen med prisinformasjon på. Hvis du har et Excel-regneark med en produktliste, er det lett å importere dem til SuperOffice.

## Før du begynner

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Før du starter importen, må du [klargjøre Excel-filen][1]. Sjekkliste:

* Excel-regnearket må som et minimum inneholde kolonner med Produktkode, Produktnavn og Listepris.
* Sørg for å legge til en unik produktkode for hver rad som en duplikatnøkkel.

## Eksportere produkter fra en Excel-importfil

Se denne videoen, eller følg trinnene for å finne ut hvordan du importerer produktene dine til SuperOffice CRM ved hjelp av importmalen vår (videolengde – 4.22):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xOTB6j2zzNo]

1. [!include[Open Import](includes/open-import.md)]

2. Klikk på **Produkter** under **Velg en importkilde**.

3. I **Importer til prisliste** velger du prislisten du vil importere produktene til.

4. Klikk på ![ikon][img1] Excel-ikonet under **Velg en importkilde**.

5. I dialogboksen **Last opp fil** klikker du på **Last opp fil** for å velge Excel-regnearket du vil importere.

6. Bla deg frem til ønsket Excel-regneark, og klikk på **Åpne**. I **Filnavn**-feltet vises plasseringen for og navnet på filen du har valgt.

7. Klikk på **Lagre**. Dataene fra regnearket vises i tabellen, og navnet på importfilen vises nederst.

> [!NOTE]
> Produkter fra Excel blir ikke importert i SuperOffice-databasen ennå. SuperOffice laster bare inn produktlisten fra regnearket, slik at du kan angi importinnstillingene.

## Tilpasse importen

Siden Excel-regnearket kan inneholde alt fra noen få kolonner til svært mange kolonner, er det viktig at kolonnene med data du vil importere, blir koblet til riktig SuperOffice-felt.

> [!NOTE]
> Regnearket må minst inneholde kolonnene du velger for duplikatkontroll i prosedyren under (navn, kode eller navn + kode).

1. Finn kolonnen som inneholder navnet på produktene, klikk på kolonnetittelen **(Ingen valgt)**, og velg deretter **Produkt: Navn**.

2. Finn kolonnen som inneholder produktkoden, klikk på kolonnetittelen **(Ingen valgt)**, og velg deretter **Produkt: Kode**.

3. Velg SuperOffice-feltene for resten av kolonnene i tabellen. Hopp over kolonnene du ikke vil importere.

4. [!include[Configure import settings](includes/configure-import-settings.md)]

5. Klikk på **Neste**. **Forhåndsvisning**-bildet kommer frem.

6. Bla gjennom importdataene for å fikse eventuelle problemer før importen starter.

    | Ikon | Beskrivelse |
    |---|---|
    | <i class="ph ph-warning" aria-label="Warning"></i> | Det er et problem med dataene på denne raden. Se forklaringsteksten i tabelloverskriften. |
    | ![ikon][img3] | Produktet finnes ikke allerede og blir lagt til. |
    | ![ikon][img4] | Produktet finnes allerede og blir oppdatert. |
    | tom | Ingen oppdatering. |

7. Fjern merkingen for de radene du IKKE vil importere. Hvis Excel-regnearket inneholdt en overskriftsrad, kan du fjerne den her.

8. Når du har kontrollert at dette faktisk er dataene du vil importere, klikker du på **Importer**.

## Ferdigstille importen

Når importen er fullført, vises en liste over de importerte produktene. Over listen vises en kobling til den oppdaterte prislisten.

## Relatert

* [Konfigurere importinnstillinger][3]
* [Importere fra ERP][6]

<!-- Referenced links -->
[1]: create-import-file.md
[2]: index.md
[3]: configure-import-settings.md
[6]: import-from-erp.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-excel-small.png
[img3]: ../../../../media/icons/admin/import-preview-icon-product-new.png
[img4]: ../../../../media/icons/admin/import-preview-icon-product-changed.png
