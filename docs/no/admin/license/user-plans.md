---
uid: help-no-user-plans
title: Brukerplaner
description: SuperOffice brukerplaner og abonnementer
keywords: brukerplan, lisens, essential, premium
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
deployment: online
platform: web
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
---

# SuperOffice brukerplaner og abonnementer

Du kan velge mellom 3 frittstående **løsninger** – Sales, Marketing og Service – basert på ulike roller i bedriften din. Innenfor hver løsning finnes det nivåer – planene **Essential** og **Premium**. Finn de riktige planene som applikasjonen din skal baseres på.

Alle løsninger kan ha ulike tillegg. Et tillegg (add-on) er en programvareutvidelse som gir ekstra funksjonalitet. Det kan utvide funksjoner i grensesnittet eller gi programmet nye egenskaper.

Brukerplaner identifiseres ved at feltet `ExtraFlags` er satt til 1 i modulens lisensrad, og at `ExtraInfo` inneholder `"set="`.

## Fellesfunksjoner i alle planer og nivåer

* Person- og kontaktoppfølging
  * Firma og personer
  * Relasjoner
  * Egendefinerte felt
  * Samtykkehåndtering
* Kalender
  * Dagbok og invitasjoner
  * Integrasjon for videomøter
* Mobil CRM
* Dokumenthåndtering
  * Dokumenter og maler
  * Språkstøtte
  * MS SharePoint-dokumenter
  * Google Workplace-dokumenter
* E-post
  * SuperOffice-innboks
  * SuperOffice for Outlook 365
  * SuperOffice for Google
* Søk / Utvalg
  * Statisk utvalg
  * Dynamisk utvalg
  * Utvalgsoppgaver
  * Send e-post til (maks 500)
* Rapporter og dashbord
  * Dashbord med standarddiagrammer
  * Utskrift

## Sales

[For selgere][3]. Inkluderer fellesfunksjonene for CRM.

**Essential:**

* Salgs- og mulighetshåndtering
* Salgsprognoser
* Dashbord med standardfliser
* Valutastøtte
* Salgssekretær

**Premium:**

* Salgsguide
* Salgsprognose på produktnivå
* Dashbord med egendefinerte fliser
* Interessenter
* Salgsmål og KPI-er
* Aktivitetsmonitorer (SAINT)
* Kombinerte utvalg
* Prosjekthåndtering
* Quote Management

## Service

[For håndtering av innkommende henvendelser][4]. Inkluderer fellesfunksjonene for CRM.

**Essential:**

* Sakshåndtering
* Kategorisering
* Autosvar og svartemaler
* Mobil CRM-sakshåndtering
* Standard Service-rapporter
* Dashbord med standardfliser

**Premium:**

* Automatisk regelbasert eskalering
* Automatisk tildeling til agent
* Varsler og tidsbegrensninger
* Kunnskapsbase (FAQ)
* Aktivitetsmonitorer (SAINT)
* Dashbord med egendefinerte fliser
* Kombinerte utvalg
* Prosjekthåndtering

## Marketing

[For markedsførere][2]. Inkluderer fellesfunksjonene for CRM.

**Essential:**

* Utsendelser (personlig masseutsendelse via e-post)
* Tjeneste for e-postutsendelser inkludert (MailGun)
* Dra-og-slipp e-postdesigner
* Firma-spesifikke maler
* Bibliotek med gratis e-postmaler
* Innebygd bildebibliotek
* Google Analytics-sporing
* Sporing av åpninger og klikk
* Egendefinerte handlinger ved klikk
* Dashbord med egendefinerte fliser
* Håndtering av avviste e-poster
* Håndtering av spamklager
* Skjemaer (webskjemaer)
* Skjemainnsending med egendefinerte handlinger
* Samtykkebehandling i skjemaer
* Firma-spesifikke skjemamaler
* Bibliotek med gratis skjemamaler
* Double opt-in og landingssider i skjemaer
* Automatisk svar-e-post ved innsending
* Kombinerte utvalg (opprett/rediger)
* Prosjekthåndtering

**Premium:**

* Marketing automation (flyter)

## Brukere med flere planer

Når samme person trenger tilgang til mer enn én plan, blir vedkommende en flerplanbruker (tidligere kalt komplett bruker).

Grunnplanene:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Disse kan kombineres til:

* Sales-Essentials + Service-Essentials
* Sales-Essentials + Service-Essentials + Marketing-Essentials
* Sales-Essentials + Service-Essentials + Marketing-Premium
* Sales-Essentials + Service-Premium
* Sales-Essentials + Service-Premium + Marketing-Essentials
* Sales-Essentials + Service-Premium + Marketing-Premium
* Sales-Essentials + Marketing-Essentials
* Sales-Essentials + Marketing-Premium

* Sales-Premium + Service-Essentials
* Sales-Premium + Service-Essentials + Marketing-Essentials
* Sales-Premium + Service-Essentials + Marketing-Premium
* Sales-Premium + Service-Premium
* Sales-Premium + Service-Premium + Marketing-Essentials
* Sales-Premium + Service-Premium + Marketing-Premium
* Sales-Premium + Marketing-Essentials
* Sales-Premium + Marketing-Premium

* Service-Essentials + Marketing-Essentials
* Service-Essentials + Marketing-Premium
* Service-Premium + Marketing-Essentials
* Service-Premium + Marketing-Premium

## Tilgjengelige tilleggsabonnementer

* [Customer Engagement Platform (CEP)][8]
* [SuperOffice AI][7]
* [Expander Services][5]
* [Kalendersynkronisering][6]

## Hvordan påvirker brukerplaner appen min?

En kunde kan velge én av følgende faktureringsperioder for sin CRM-løsning:

* hver måned
* hvert kvartal
* hvert halvår
* årlig

Avtaleperioden er 12 måneder. Etter de første 12 månedene fornyes abonnementet automatisk i henhold til valgt faktureringssyklus.

Kunder kan kombinere planene som passer best for deres behov. De kan også legge til eller bytte brukerplaner senere.

Du bør ta høyde for denne fleksibiliteten når du integrerer funksjoner og definerer prismodellen din.

<!-- Referenced links -->
[2]: https://www.superoffice.com/crm/marketing-features/
[3]: https://www.superoffice.com/crm/sales-features/
[4]: https://www.superoffice.com/crm/service-features/
[5]: expander-services.md
[6]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/nebula-synchronizer/
[7]: ../../ai/learn/index.md
[8]: ../../../../release-notes/9.2/cep/9.2-R01-update.md
