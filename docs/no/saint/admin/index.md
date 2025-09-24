---
uid: help-no-saint-admin
title: SAINT i Innstillinger og vedlikehold
description: Lær om nøkkelbegrepene i SuperOffice SAINT, inkludert kriterier, bilder, tellere og standardoppfølginger.
keywords: SAINT, aktivitetsovervåking, statusovervåking
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
index: true
redirect_from: /no/sale/saint/learn/admin/index
---

# SAINT i Innstillinger og vedlikehold

SAINT (Sales Intelligence) hjelper deg med å overvåke firmaer, personer og prosjekter slik at du kan følge opp til rett tid. En **aktivitetsovervåking** (også kjent som statusovervåking) kombinerer kriterier, tellere og valgfrie egenskaper for å fremheve poster som trenger oppmerksomhet.

Før du implementerer SAINT, er det viktig å vite hva du ønsker å forbedre og hvordan du vil analysere det. Vurder deretter hvilke proaktive tiltak firmaet ditt kan ta for å forbedre den nåværende situasjonen. For eksempel:

* Sende en gruppeutsendelse
* Ringe alle kunder i SAINT-utvalget
* Følge opp alle forespørsler

[!include[Requirement](../includes/note-saint-req.md)]

![SAINT-skjerm med statusliste, beskrivelse, bilde og kriterier -screenshot][img1]

## Statuslisten

Statuslisten på fanene **Firma**, **Person** og **Prosjekt** viser aktive statusmonitorer for den posten og – hvis **Vis slettede** er valgt – også slettede.

| Element | Beskrivelse |
|---|---|
| **Visualiser-ikon** <i class="ph ph-eye" aria-label="eye"></i> | Indikerer om et statusbilde vises på firma-, person- eller prosjektkort. Ikonet vises bare hvis **Visualiser**-boksen er merket av. |
| **Rødt X** | Vises ved siden av statuser som må [regenereres][8]. Disse statusene oppdateres ikke og returnerer ikke gjeldende data. |
| **Navnekolonne** | Viser navnene på statusene. Slettede statuser vises i rødt hvis **Vis slettede** er merket av nedenfor listen. |
| **Prioritetskolonne** | Bestemmer hvilket statusbilde som vises på kortet når et firma, en person eller et prosjekt samsvarer med kriteriene for flere statuser. Den høyeste prioritetsstatusen vises, mens andre aktive statuser er tilgjengelige som lenker i statusdialogen. |

## Egenskaper

En statusovervåking kombinerer flere egenskaper som definerer hvordan den fungerer:

* **Kriterier:** Hver status må inneholde ett eller flere kriterier. Disse betingelsene bestemmer hvilke firmaer, personer eller prosjekter statusen gjelder for. Du kan for eksempel definere en status for kunder uten salg de siste 90 dagene.

* **Statusbilder:** Et valgfritt bilde kan vises på firma-, person- eller prosjektkort som oppfyller kriteriene. For eksempel kan et edderkoppnett indikere inaktivitet. Bilder vises som lyse vannmerker og kan klikkes for flere detaljer.

* **Standardoppfølging:** Når en bruker klikker på statusen, kan de opprette en oppfølging. Typen og beskrivelsen kan være forhåndsdefinert, slik at oppfølgingen tydelig angir hvilken handling som kreves.

## Tellere og perioder

Tellere [sporer aktivitet over tid][5], som salg, forespørsler eller fullførte oppfølginger.
Du kan bruke tellere i søk og utvalg for å identifisere poster som oppfyller eller ikke oppfyller bestemte terskler.

Du kan definere opptil tre forskjellige perioder (for eksempel 30, 60 og 90 dager).
Dette lar deg bruke samme teller, som "Antall salg", på forskjellige tidsspenn.

## <a id="database"></a>Hvordan SAINT lagrer tellere og statuser

SAINT-tellere lagres i [countervalue][13]-tabellen og oppdateres automatisk når du gjør ting:

* Når SAINT er aktivert, opprettes det en rekke tellerlinjer hver gang en person eller et prosjekt opprettes.

* Når en oppfølging, et dokument eller et salg opprettes, oppdateres de tilsvarende tellerlinjene.

SAINT-**verdier** er enkle binære verdier (på eller av) som bestemmer utseendet til firma- og prosjektkortene. Disse verdiene lagres i [statusvalue][14]-tabellen.

## Aktuelt innhold

* [Sett opp en ny statusovervåking][1]
* [Visualiser statuser med bilder][2]
* [Tellere og tellerinnstillinger][5]
* [Oppdater, slett og gjenopprett statusovervåkinger][7]
* [Regenerer statusovervåkinger og tellere][8]

<!-- Referenced links -->
[1]: set-up.md
[2]: set-up.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: ../../../en/database/tables/countervalue.md
[14]: ../../../en/database/tables/statusvalue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png
