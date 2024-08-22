---
uid: help-sv-extra-field
title: Extrafält
description: Extrafält
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: extrafält, anpassead fält, Service
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: sv
---

# Extrafält

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

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

### Relationer (förnyckel, FK)

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

## Användning

Extrafält kan till exempel användas som sökkriterier och kolumner i försäljningar i SuperOffice CRM.

## Relaterat innehåll

* [Visa extrafält på detaljfanen][1]
* [Skapa extrafält][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md
