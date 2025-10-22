---
uid: help-da-user-plans
title: Brugerplaner
description: SuperOffice brugerplaner og abonnementer
keywords: brugerplan, licens, essential, premium
author: Christian Mogensen, Bergfrid Dias
date: 04.23.2024
version: 10.3.5
content_type: concept
deployment: online
platform: web
index: true
language: da
---

# SuperOffice brugerplaner og abonnementer

Du kan vælge mellem 3 selvstændige **løsninger** – Sales, Marketing og Service – baseret på forskellige roller i din virksomhed. Hver løsning findes i to niveauer: **Essential** og **Premium**. Find de rigtige planer at basere din applikation på.

Alle løsninger kan have forskellige tilføjelser. En tilføjelse (add-on) er en softwareudvidelse, der giver ekstra funktioner. Den kan udvide bestemte funktioner i programmet eller tilføje ny funktionalitet.

Brugerplaner identificeres ved, at `ExtraFlags` er sat til 1 i modullicensposten, og at `ExtraInfo`-feltet indeholder `"set="`.

## Fælles funktioner i alle planer og niveauer

* Personoplysninger
  * Firmaer og personer
  * Relationer
  * Brugerdefinerede felter
  * Samtykkehåndtering
* Kalender
  * Dagbog og invitationer
  * Integration med videomøder
* Mobil CRM
* Dokumenthåndtering
  * Dokumenter og skabeloner
  * Sprogunderstøttelse
  * MS SharePoint-dokumenter
  * Google Workplace-dokumenter
* E-mail
  * SuperOffice-indbakke
  * SuperOffice til Outlook 365
  * SuperOffice til Google
* Søgning / Udvalg
  * Statisk udvalg
  * Dynamisk udvalg
  * Udvalgsopgaver
  * Send e-mail til (maks. 500)
* Rapportering og dashboards
  * Dashboards med standarddiagrammer
  * Udskriv

## Sales

[For sælgere][3]. Indeholder de fælles CRM-funktioner.

**Essential:**

* Salgs- og mulighedsstyring
* Salgsprognoser
* Dashboards med standardfliser
* Valutaunderstøttelse
* Salgssekretær

**Premium:**

* Salgsguide
* Salgsprognose på produktniveau
* Dashboards med brugerdefinerede fliser
* Interessenter
* Salgsmålsætninger og KPI'er
* Aktivitetsmonitorer (SAINT)
* Kombinerede udvalg
* Projektstyring
* Quote Management

## Service

[Til håndtering af indgående henvendelser][4]. Indeholder de fælles CRM-funktioner.

**Essential:**

* Sagsstyring
* Kategorisering
* Autosvar og svartemplater
* Mobil CRM-sagsstyring
* Standard Service-rapporter
* Dashboards med standardfliser

**Premium:**

* Automatisk regelbaseret eskalering
* Automatisk tildeling til agent
* Advarsler og notifikationer – tidsbegrænsninger
* Vidensbase (FAQs)
* Aktivitetsmonitorer (SAINT)
* Dashboards med brugerdefinerede fliser
* Kombinerede udvalg
* Projektstyring

## Marketing

[For marketingmedarbejdere][2]. Indeholder de fælles CRM-funktioner.

**Essential:**

* Udsendelser (personlige masse-mails)
* Inkluderet mailsendetjeneste (MailGun)
* Træk-og-slip e-maildesigner
* Firma-specifikke e-mailskabeloner
* Bibliotek med gratis e-mailskabeloner
* Indbygget billedbibliotek
* Google Analytics-sporing
* Sporing af åbninger og klik
* Brugerdefinerede handlinger ved klik
* Dashboards med brugerdefinerede fliser
* Håndtering af afviste e-mails
* Håndtering af spamklager
* Formularer (webformularer)
* Formularindsendelser med brugerdefinerede handlinger
* Samtykkestyring i formularer
* Firma-specifikke formulartemplater
* Bibliotek med gratis formulartemplater
* Double opt-in og landingssider
* Automatisk svarmail ved indsendelse
* Kombinerede udvalg (opret/rediger)
* Projektstyring

**Premium:**

* Marketing automation (flows)

## Brugere med flere planer

Når en person har brug for adgang til mere end én plan, bliver de en flerplansbruger (tidligere kaldet komplet bruger).

Grundplanerne:

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

## Tilgængelige tilføjelsesabonnementer

* [Customer Engagement Platform (CEP)][8]
* [SuperOffice AI][7]
* [Expander Services][5]
* [Kalendersynkronisering][6]

## Hvordan påvirker brugerplaner min app?

En kunde kan vælge én af følgende faktureringsperioder til deres CRM-løsning:

* månedligt
* kvartalsvis
* halvårligt
* årligt

Kontraktperioden er 12 måneder. Efter de første 12 måneder fornyes den automatisk i henhold til den valgte faktureringsperiode.

Kunder kan kombinere planer efter behov. De kan også tilføje eller ændre brugerplaner senere.

Du bør tage højde for denne fleksibilitet, når du integrerer specifikke funktioner og fastlægger din prismodel.

<!-- Referenced links -->
[2]: https://www.superoffice.com/crm/marketing-features/
[3]: https://www.superoffice.com/crm/sales-features/
[4]: https://www.superoffice.com/crm/service-features/
[5]: expander-services.md
[6]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/nebula-synchronizer/
[7]: ../../ai/learn/index.md
[8]: ../../../../release-notes/9.2/cep/9.2-R01-update.md
