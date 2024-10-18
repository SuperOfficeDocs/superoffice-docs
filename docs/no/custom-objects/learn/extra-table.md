---
uid: help-no-extra-table
title: Ekstratabeller
description: Introduksjon til ekstratabeller i SuperOffice,
keywords: database, ekstratabell, tabellmappe, tredjepartstabell
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.8
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: no
---

# Ekstratabeller

[!include[License requirement](../../learn/includes/req-expander-services.md)]

SuperOffice Development Tools-lisensen gir deg muligheten til å opprette ekstratabeller (tilpassede objekter) i databasen.

**Tabeller**-skjermbildet er verktøyet ditt for tilpasning av databaseskjemaet.

## Slik får du tilgang

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/extra-table-old)

Tredjepartstabeller er umiddelbart tilgjengelige for standard CRUD-operasjoner i SuperOffice Service. Du må sette opp et webpanel for å få tilgang til dem fra Salgsklienten.

### [Ny (fra versjon 10.3.4 pilot)](#tab/extra-table-new)

Ikke lenger begrenset til SuperOffice Service, kan du enkelt utforske og vedlikeholde data i ekstratabeller fra SuperOffice CRM.

#### Bygg dashbord ved hjelp av tilpassede objekter

![Dashbord med tilpassede objekter -screenshot][img1]

#### Søk og utvalg

**Tilpasset objekt som søkekriterium for firma, person, salg, prosjekt, sak, aktivitet:**

![Tilpasset objekt som søkekriterium -screenshot][img2]

**Opprett utvalg av tilpassede objekter (10.3.7):**

![Søkeside med tilpassede objekter -screenshot][img3]

![Utvalg av tilpassede objekter -screenshot][img4]

#### Vedlikeholde data (10.3.7)

**Åpne oversikten over tilpassede objekter:**

![Oversikt over tilpassede objekter -screenshot][img5]

**Søk:**

![Oversikt over tilpassede objekter, søk -screenshot][img6]

**Forhåndsvisning:**

![Oversikt over tilpassede objekter, forhåndsvisning -screenshot][img7]

**Legg til/fjern elementer:**

Når du ser resultatene for et spesifikt element i oversikten **Tilpassede objekter**, klikker du på **Oppgave**-knappen og velger **Ny** eller **Slett**.

**Forhåndsutfyll felter når tilpasset objekt lastes (10.3.8):**

Den nye [SalesLoadCustomObject][6]-triggeren blir kalt før et tilpasset objekt-skjermbilde lastes. Bruk den til å sette standardverdier i felter og definere forretningsregler.

***
<!-- markdownlint-restore -->

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
* [Legge til trigger][5]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md
[5]: ../../../en/automation/trigger/create-trigger-script.md
[6]: ../../../en/automation/trigger/reference/CRMScript.Event.Trigger.yml#CRMScript_Event_Trigger_SalesLoadCustomObject

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/custom-object-dashboard.png
[img2]: ../../../media/loc/en/automation/find-custom-object-relation.png
[img3]: ../../../media/loc/en/automation/find-screen-with-custom-objects.png
[img4]: ../../../media/loc/en/automation/custom-object-selection.png
[img5]: ../../../media/loc/en/automation/go-to-custom-objects.png
[img6]: ../../../media/loc/en/automation/search-inventory.png
[img7]: ../../../media/loc/en/automation/preview-inventory-results.png

<!-- Referenced images -->
