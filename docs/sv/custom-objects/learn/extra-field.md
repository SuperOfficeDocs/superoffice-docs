---
uid: help-sv-extra-field
title: Extrafält
description: Extrafält
keywords: extrafält, anpassead fält, Service
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Extrafält

[!include[License requirement](../../includes/req-dev-tools.md)]

Ett *extrafält* är ett anpassat fält som du lägger till i en befintlig SuperOffice-databastabell. Du kan utvidga följande enheter:

* Kategori
* Företag
* Kontakt
* FAQ-kategori och post
* Meddelande
* Ärende
* Användare
* Dina [egna tabeller][6]

> [!NOTE]
> Extrafält på företag eller kontakt är inte samma som användardefinierade fält på dessa enheter!

Extrafält hanteras i **Inställningar och underhåll** > **Tabeller**.

## <a id="field-types"></a>Fälttyper

* Sannolikhet(ja/nej)
* Heltal
* Flyttal
* Textsträng (kort)
* Textsträng (lång)
* Datum
* Datum och tid
* Klockslag
* Tidsintervall
* Bilaga
* Dynamisk länk

Dessutom har varje enhet en relations typ. Till exempel *kontaktrelationen*.

Till skillnad från användardefinierade fält läggs extrafält till som faktiska fält i databastabellerna. Det finns inga fördefinierade platser du behöver ta hänsyn till, och i princip inga begränsningar.

### <a id="relation"></a>Relationer (förnyckel, FK)

Databastabeller är kopplade med *förnyckel* (FK). Dessa är fälttyper som slutar på *relation*.

* Kontaktrelation
* Företagsrelation
* Användarrelation
* Ärende- och Ärendehandläggarrelasjon
* Kategorirelation
* Prioritetsrelation
* FAQ-relation
* Säljrelation
* Projektrelation
* Mötesrelation
* Relation till extratabell

#### Tillgänglig i pilot från version 10.3.4

När ett relationsfält är inställt för att visa en-till-många-relationer lägger systemet automatiskt till ett detaljkort i relaterade standardenheter. Detta är inte samma sak som fliken **Relationer** på Företags- och Kontaktskärmarna.

![Detaljkort med extrafältrelation -screenshot][img1]

#### Tillgänglig i pilot från version 10.3.7

För att visa detaljerna för objekt i denna lista utan att behöva öppna varje enskild enhet:

1. Gå till sidopanelen och välj **Förhandsvisning**.
2. Klicka på ett objekt i det relationsbaserade detaljkortet. Sidopanelen visar en förhandsvisning av den valda enheten. I förhandsvisningen kan du:

    * Klicka på en standardenhet för att gå till den.
    * Klicka på ett anpassat objekt för att öppna en dialogruta för att visa eller redigera ytterligare information.

![Förhandsvisning extrafältrelation -screenshot][img2]

## Användning

Extrafält kan till exempel användas som sökkriterier och kolumner i försäljningar i SuperOffice CRM.

## Relaterat innehåll

* [Visa extrafält på detaljfanen][1]
* [Skapa extrafält][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/section-tab-for-relation.png
[img2]: ../../../media/loc/en/automation/preview-custom-object-from-side-panel.png
