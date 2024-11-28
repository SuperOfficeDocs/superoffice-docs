---
uid: help-no-custom-objects
title: Egendefinerte objekter og felt
description: Egendefinerte objekter og felt
keywords: egendefinert objekt, felt, brukerdefinert, udef, ekstrafelt, ekstratabell
author: Bergfrid Dias
date: 01.29.2024
version: 10
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: no
---

# Egendefinerte objekter og felt

Alle firma og organisasjoner har egne krav til hvilke opplysninger de trenger å registrere angående kontakter, salg, prosjekter, kontrakter og så videre. Administratorer kan legge til felt og tabeller i SuperOffice for å tilpasse typen informasjon som kan registreres.

SuperOffice CRM og Service var en gang to separate applikasjoner med ulike utvidelsesalternativer. [**Brukerdefinerte felt**][1] (kort kalt udefs) hører hjemme i SuperOffice CRM, mens [**ekstratabeller**][3] (også kalt tredjepartstabeller) og [**ekstrafelt**][2] hører hjemme i Service. Begrepet **tilpasset felt** inkluderer både brukerdefinerte felt og ekstra felt.

## Bruk

* Et godt eksempel på et egendefinert felt du kan bruke på **Personkortet**, er et felt kalt "Fornøyd kunde", der verdien av feltet er Ja eller Nei. Du kan for eksempel sende dine kontakter en e-post (med koblingshandlinger) der de kan si om de er fornøyde med tjenestene dine. Dette gir deg verdifull innsikt i den generelle kundetilfredshetsraten.

* Ved å bruke **Finn**-funksjonen, kan du søke etter opplysningene du registrerer i tilpassede felt og lage utvalg. For eksempel, hvis du registrerer utløpsdatoen for vedlikeholdsavtalen du har med kunder, kan du opprette et dynamisk utvalg som viser kunder der avtalen utløper om mindre enn en måned.

* Du kan gjenbruke informasjonen fra disse feltene i dokumenter og e-poster som **malvariabler**. Hvert felt du legger til får sin egen unike ID (Prog-ID), som kan brukes i dokumenter for å flette personspesifikk informasjon. Så hvis du vil sende en e-post til dine kunder som sier at vedlikeholdsavtalen deres snart utløper, kan du bruke malvariabelen for utløpsdato for å vise riktig utløpsdato for avtalen i meldingen.

## Krav

| Tilpasning | Lisens | Kommentar |
|---|---|---|
| Legg til/fjern brukerdefinert felt | Ingen | Vises automatisk på [fanen Mer][12]. Trenger Development Tools for å tilpasse plassering. |
| Tilpass layouten for fanen Mer | Development Tools | |
| Administrer side 1-felter | Development Tools | |
| Ekstrafelt | Development Tools | |
| Ekstratabell | Development Tools | |
| [Skjermdesigner][5] | Development Tools | SuperOffice versjon 10 og nyere. |
| [Egendefinerte skjermer][6] | Development Tools, Service | Opprett nye skjermer i Service. |

## Oppsett (plassering av felt)

Enhver form for grensesnitttilpasning krever en Development Tools-lisens. Eventuelle tilpassede skjermlayouter (opprettet i Skjermdesigneren) kan overstyre innstillingene for individuelle brukerdefinerte felt.

Hvis du ikke har en Development Tools-lisens, bruk rangeringen av de forskjellige feltene for å sortere dem på fanen **Mer**.

## Aktuelt innhold

* [Brukerdefinerte felt][1]
* [Ekstrafelt][2]
* [Ekstratabeller][3]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[5]: ../../ui/screen-designer/learn/index.md
[6]: ../../../en/ui/blogic/custom-screens/index.md
[12]: more-tab.md

<!-- Referenced images -->
