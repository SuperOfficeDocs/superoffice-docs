---
uid: help-no-extra-table
title: Ekstratabeller
description: Introduksjon til ekstratabeller i SuperOffice,
keywords: database, ekstratabell, tabellmappe, tredjepartstabell
author: Bergfrid Dias
date: 01.25.2024
version: 10
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: no
---

# Ekstratabeller

[!include[License requirement](../../learn/includes/req-expander-services.md)]

SuperOffice Development Tools-lisensen gir deg muligheten til å opprette ekstratabeller i databasen. Umiddelbart vil disse tredjepartstabellene være tilgjengelige for standard CRUD-operasjoner i SuperOffice Service. Du må sette opp et webpanel for å få tilgang til dem fra Salgsklienten.

**Tabeller**-skjermbildet er verktøyet ditt for tilpasning av databaseskjemaet.

## Tabeller-bilde

**Tabeller**-skjermbildet viser en liste over databasetabeller. Den viser både standardtabeller (forhåndsdefinert i systemet og danner grunnlaget for forskjellige kort) og ekstratabeller (tabeller du oppretter selv med valgfritt innhold).

Her kan du opprette nye tabeller og felt for forskjellige kort og dialogbokser. Kun administratorer har tilgang til denne funksjonaliteten.

### Tabellmapper

Tabellmapper brukes til å organisere egendefinerte tabeller.

## Konvensjoner

> [!CAUTION]
> Velg databasetabell- og feltnavn nøye. De kan ikke endres senere!
>
> Et logisk navn er best fordi det gjør det enklere å se hva databasen inneholder.

Prefikser sikrer at det du oppretter ikke skaper konflikt med fremtidige SuperOffice-tabell- og feltnavn. Det garanterer imidlertid ikke at du unngår navnekonflikter mellom forskjellige tredjeparter.

### Tabellnavn

* Må starte med **y_**
* Kan bare inneholde understrek, bokstavene a til z, og tall

### Feltnavn

* Må starte med **x_**
* Må være unikt innen tabellen
* Må være ett enkelt ord
* Kan bare inneholde understrek, bokstaver fra a til z, og tall

## Aktuelle emner

* [Legge til ekstratabell][2]
* [Legge til ekstrafelt][3]
* [Brukerdefinerte felt][4]
* [Egendefinerte skjermer][1]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md

<!-- Referenced images -->
