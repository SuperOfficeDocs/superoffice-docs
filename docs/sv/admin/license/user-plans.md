---
uid: help-sv-user-plans
description: SuperOffice användarplaner och prenumerationer
keywords: användarplan, licens, essential, premium
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
language: sv
---

# SuperOffice användarplaner och prenumerationer

Du kan välja mellan tre fristående **lösningar** – Sales, Marketing och Service – anpassade efter olika roller i din organisation. Varje lösning finns i två nivåer: **Essential** och **Premium**. Hitta de planer som passar bäst för din applikation.

Alla lösningar kan ha olika tillägg. Ett tillägg är en mjukvaru­utökning som lägger till extra funktionalitet. Det kan utöka vissa funktioner i gränssnittet eller tillföra helt ny kapacitet.

Användarplaner identifieras genom att fältet `ExtraFlags` är satt till 1 i modullicensen och att `ExtraInfo` innehåller `"set="`.

## Gemensamma funktioner i alla planer och nivåer

* Kontaktuppgifter
  * Företag och kontakter
  * Relationer
  * Egendefinierade fält
  * Samtyckeshantering
* Kalender
  * Kalender och inbjudningar
  * Integration för videomöten
* Mobil CRM
* Dokumenthantering
  * Dokument och mallar
  * Språkstöd
  * MS SharePoint-dokument
  * Google Workplace-dokument
* E-post
  * SuperOffice-inkorg
  * SuperOffice för Outlook 365
  * SuperOffice för Google
* Sök / Urval
  * Statisk urval
  * Dynamisk urval
  * Urvalsaktiviteter
  * Skicka e-post till (max 500)
* Rapporter och dashboards
  * Dashboards med standarddiagram
  * Utskrift

## Sales

[För säljare][3]. Innehåller gemensamma CRM-funktioner.

**Essential:**

* Försäljnings- och affärshantering
* Försäljningsprognoser
* Dashboards med standardplattor
* Valutastöd
* Försäljningsassistent

**Premium:**

* Försäljningsguide
* Prognoser på produktnivå
* Dashboards med anpassade plattor
* Intressenter
* Mål och KPI:er
* Aktivitetsövervakning (SAINT)
* Kombinerade urval
* Projekthantering
* Quote Management

## Service

[För hantering av inkommande ärenden][4]. Innehåller gemensamma CRM-funktioner.

**Essential:**

* Ärendehantering
* Kategorisering
* Autosvar och svarsmallar
* Mobil CRM för ärenden
* Standardrapporter för Service
* Dashboards med standardplattor

**Premium:**

* Automatisk regelbaserad eskalering
* Automatisk tilldelning till agent
* Varningar och notifieringar – tidsgränser
* Kunskapsbas (FAQs)
* Aktivitetsövervakning (SAINT)
* Dashboards med anpassade plattor
* Kombinerade urval
* Projekthantering

## Marketing

[För marknadsförare][2]. Innehåller gemensamma CRM-funktioner.

**Essential:**

* Utskick (personliga massmejl)
* Inkluderad mejltjänst (MailGun)
* Dra-och-släpp e-postdesign
* Företagsanpassade mallar
* Gratis mallbibliotek
* Inbyggt bildbibliotek
* Google Analytics-spårning
* Spårning av öppningar och klick
* Egendefinierade åtgärder vid klick
* Dashboards med anpassade plattor
* Studshantering
* Spamklagomålshantering
* Formulär (webbformulär)
* Formulärinlämningar med anpassade åtgärder
* Samtyckeshantering i formulär
* Företagsanpassade formulärmallar
* Gratis formulärbibliotek
* Double opt-in och landningssidor
* Autosvar vid inlämning
* Kombinerade urval (skapa/redigera)
* Projekthantering

**Premium:**

* Marketing automation (flöden)

## Användare med flera planer

När samma person behöver tillgång till mer än en plan, blir de en flerplansanvändare (tidigare kallad komplett användare).

Grundplanerna:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Dessa kan kombineras som:

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

## Tillgängliga tilläggsprenumerationer

* [Customer Engagement Platform (CEP)][8]
* [SuperOffice AI][7]
* [Expander Services][5]
* [Kalendersynkronisering][6]

## Hur påverkar användarplaner min app?

En kund kan välja en av följande faktureringsperioder för sin CRM-lösning:

* varje månad
* var tredje månad
* var sjätte månad
* årligen

Avtalstiden är 12 månader. Efter de första 12 månaderna förnyas den automatiskt enligt vald faktureringscykel.

Kunder kan kombinera planer efter behov. De kan också lägga till eller ändra användarplaner senare.

Du bör ta hänsyn till denna flexibilitet vid integration av funktioner och fastställande av din prismodell.

<!-- Referenced links -->
[2]: https://www.superoffice.com/crm/marketing-features/
[3]: https://www.superoffice.com/crm/sales-features/
[4]: https://www.superoffice.com/crm/service-features/
[5]: expander-services.md
[6]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/nebula-synchronizer/
[7]: ../../ai/learn/index.md
[8]: ../../../../release-notes/9.2/cep/9.2-R01-update.md
