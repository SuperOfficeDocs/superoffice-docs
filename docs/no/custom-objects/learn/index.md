---
uid: help-no-custom-objects
title: Egendefinerte objekter
description: Egendefinerte objekter
author: Bergfrid Dias
so.date: 01.16.2024
so.version: 10
keywords: egendefinert objekt, felt, brukerdefinert, udef, ekstrafelt, ekstra tabell
so.topic: concept
language: no
so.audience: user
so.audience.tooltip: SuperOffice CRM

---

# Egendefinerte objekter og felter

## Brukerdefinerte felt

Alle firmaer og organisasjoner har egne krav til hvilke opplysninger de vil registrere. Dette kan være for firmaer, personer, salg, prosjekter og så videre. Som administrator kan du legge til dine egne felt i Innstillinger og vedlikehold.

Alle firmaer og organisasjoner har sine egne krav til informasjonen de trenger for å registrere om sine personer, salg, prosjekter, kontrakter og så videre. Du kan angi dine egne felt for SuperOffice CRM i **Felt**-bildet. På den måten kan du tilpasse typen opplysninger som kan registreres om firmaer, personer, prosjekter, salg, dokumenter og oppfølginger.

Flere deler av SuperOffice CRM, for eksempel Firma-bildet, har en egen fane som heter **Mer**. Her kan du legge inn egne felt for å tilpasse programmet til organisasjonens egne behov.

Alle firmaer og organisasjoner har sine egne krav til informasjonen de trenger for å registrere om sine kunder, salg, prosjekter, kontrakter og så videre. Du kan angi dine egne felt for SuperOffice CRM i **Felt**-bildet.

Du kan selvfølgelig legge til et bredt utvalg av tabeller og felt i SuperOffice for å lagre all informasjon som kundeserviceagentene dine trenger.

## Bruk

* Et godt eksempel på et egendefinert felt du kan bruke på **Personkortet**, er et felt kalt "Fornøyd kunde", der verdien av feltet er Ja eller Nei. Du kan for eksempel sende dine kontakter en e-post (med koblingshandlinger) der de kan si om de er fornøyde med tjenestene dine. Dette gir deg verdifull innsikt i den generelle kundetilfredshetsraten.

* Ved å bruke **Finn**-funksjonen, kan du søke etter opplysningene du registrerer i tilpassede felt og lage utvalg. For eksempel, hvis du registrerer utløpsdatoen for vedlikeholdsavtalen du har med kunder, kan du opprette et dynamisk utvalg som viser kunder der avtalen utløper om mindre enn en måned.

* Du kan gjenbruke informasjonen fra disse feltene i dokumenter og e-poster som **malvariabler**. Hvert felt du legger til får sin egen unike ID (Prog-ID), som kan brukes i dokumenter for å flette personspesifikk informasjon. Så hvis du vil sende en e-post til dine kunder som sier at vedlikeholdsavtalen deres snart utløper, kan du bruke malvariabelen for utløpsdato for å vise riktig utløpsdato for avtalen i meldingen.

## Krav

| Tilpasning | Lisens | Kommentar |
|---|---|---|
| Legg til/fjern brukerdefinert felt | Ingen | Vises automatisk på fanen Mer. Trenger Development Tools for å tilpasse plassering. |
| Tilpass layouten for fanen Mer | Development Tools | |
| Administrer side 1-felter | Development Tools | |
| Ekstra felt | Development Tools | |
| Ekstra tabell | Development Tools | |
| [Skjermdesigner][5] | Development Tools | SuperOffice versjon 10 og nyere. |
| [Egendefinerte skjermer][6] | Development Tools, Service | Opprett nye skjermer i Service. |

## Oppsett (plassering av felt)

Enhver form for grensesnitttilpasning krever en Development Tools-lisens. Eventuelle tilpassede skjermlayouter (opprettet i Skjermdesigneren) kan overstyre innstillingene for individuelle brukerdefinerte felt.

Hvis du ikke har en Development Tools-lisens, bruk rangeringen av de forskjellige feltene for å sortere dem på fanen **Mer**.

## Aktuelt innhold

* [Brukerdefinerte felt][1]
* [Ekstrafelt][2]
* [Ekstra tabeller][3]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[5]: ../../ui/screen-designer/learn/index.md
[6]: ../../ui/blogic/custom-screens/index.md

<!-- Referenced images -->
