---
uid: help-no-custom-objects
title: Egendefinerte objekter og felt
description: Egendefinerte objekter og felt
keywords: egendefinert objekt, felt, brukerdefinert, udef, ekstrafelt, ekstratabell
author: Bergfrid Dias
date: 06.10.2026
version: 12.0
content_type: concept
tier: core
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

[!include[License requirement](../../includes/req-dev-tools-transition.md)]

> [!NOTE]
> **CRM Suite (Growth-plan):** Planen din har en grense for antall egendefinerte objekter. Når grensen er nådd, er opprettelse av flere objekter blokkert. Se [Plangrenser][13] for detaljer.

Felt vises automatisk på [fanen Mer][12] når de er lagt til.

## Oppsett (plassering av felt)

Eventuelle tilpassede skjermlayouter (opprettet i Skjermdesigneren) kan overstyre innstillingene for individuelle brukerdefinerte felt.

Hvis du ikke har **Core**-planen, bruk rangeringen av de forskjellige feltene for å sortere dem på fanen **Mer**.

## Aktuelt innhold

* [Brukerdefinerte felt][1]
* [Ekstrafelt][2]
* [Ekstratabeller][3]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[12]: more-tab.md
[13]: ../../admin/license/crm-suite.md

<!-- Referenced images -->
