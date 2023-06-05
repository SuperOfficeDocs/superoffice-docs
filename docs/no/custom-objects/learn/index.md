---
title: Egendefinerte objekter
uid: help-no-custom-objects
description: Egendefinerte objekter
author: Bergfrid Dias
so.date: 02.23.2023
keywords: egendefinert objekt
so.topic: concept
language: no
so.user: admin
so.user.tooltip: Settings and maintenance
---

# Egendefinerte objekter

## Brukerdefinerte felt

Alle firmaer og organisasjoner har sine egne krav til informasjonen de trenger for å registrere om sine personer, salg, prosjekter, kontrakter og så videre. Du kan angi dine egne felt for SuperOffice CRM i **Felt**-bildet. På den måten kan du tilpasse typen opplysninger som kan registreres om firmaer, personer, prosjekter, salg, dokumenter og oppfølginger.

## Egendefinerte felt og tabeller

Et godt eksempel på et egendefinert felt du kan bruke på **Personkortet**, er feltet «Fornøyd kunde», der verdien for feltet er Ja eller Nei.

Du kan for eksempel sende personene dine en e-post (med koblingshandlinger) der de kan oppgi om de er fornøyde med tjenestene dine. Dette gir deg verdifull innsikt i den generelle kundetilfredsheten.

Du kan selvfølgelig legge til et bredt utvalg av tabeller og felt i SuperOffice for å lagre all informasjon som kundeserviceagentene dine trenger.

![I Tabeller-bildet kan du enten velge å (a) opprette et ekstra felt eller (b) opprette en ny tabell -screenshot][img1]

### Ekstratabell

* [Introduksjon til ekstra tabeller][3]
* [Definere en tabell][4]

### Egendefinerte felter

Alle firmaer og organisasjoner har egne krav til hvilke opplysninger de vil registrere. Dette kan være for firmaer, personer, salg, prosjekter og så videre. Som administrator kan du legge til dine egne felt i Innstillinger og vedlikehold.

* [Brukerdefinerte felt][1]
* [Ekstrafelt][2]

#### Fordelene ved å legge til felt

Du kan bruke funksjonen Finn til å søke etter opplysningene du registrerer i disse feltene og lage utvalg.

Hvis du for eksempel registrerer utløpsdatoen for vedlikeholdsavtalen du har med personer, kan du opprette et dynamisk utvalg som viser personene som avtalen utløper for om mindre enn én måned.

Du kan gjenbruke opplysningene fra disse feltene i dokumenter og e-post ved å bruke malvariabler. Hvert felt du legger til, får sin egen unike ID (Prog-ID), som kan brukes i dokumenter til å flette personspesifikk informasjon.

Så hvis du vil sende en e-post til personene dine med informasjon om at vedlikeholdsavtalen deres snart utløper, kan du bruke malvariabelen for utløpsdato for å vise riktig utløpsdato for avtalen i meldingen.

#### Posisjonering

Alle egendefinerte bildeoppsett (opprettet i Skjermdesigner) ved hjelp av skjermdesigner kan overstyre innstillingene i felt.

Hvis du ikke har lisens til konfigurerbare Configurable Screens, bruker du rangeringen av de forskjellige feltene.

## Aktuelt innhold

* [Skjermdesigneren][5]

<!-- Referenced links -->
[1]: udef/index.md
[2]: extra-field/create.md
[3]: extra-table/index.md
[4]: extra-table/create.md
[5]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: media/create-extra-tables-and-fields.png
