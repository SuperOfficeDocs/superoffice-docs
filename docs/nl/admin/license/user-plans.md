---
uid: help-nl-user-plans
title: Gebruikersplannen
description: SuperOffice gebruikersplannen en abonnementen
keywords: gebruikersplan, licentie, essential, premium
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
language: nl
---

# SuperOffice gebruikersplannen en abonnementen

U kunt kiezen uit drie zelfstandige **oplossingen** – Sales, Marketing en Service – gebaseerd op verschillende rollen binnen uw organisatie. Binnen elke oplossing zijn er twee niveaus: **Essential** en **Premium**. Kies het juiste plan waarop u uw toepassing baseert.

Alle oplossingen kunnen uitgebreid worden met add-ons. Een add-on is een software-uitbreiding die extra functies toevoegt aan een programma. Dit kan bestaande functionaliteit uitbreiden of geheel nieuwe mogelijkheden bieden.

Gebruikersplannen worden geïdentificeerd door het veld `ExtraFlags = 1` in hun ModuleLicense-record en de `"set="`-waarde in het veld `ExtraInfo`.

## Gemeenschappelijke functies in alle plannen en niveaus

* Contactbeheer
  * Bedrijven en contactpersonen
  * Relaties
  * Aangepaste velden
  * Toestemmingsbeheer
* Agenda
  * Agenda en uitnodigingen
  * Integratie met videomeetings
* Mobile CRM
* Documentbeheer
  * Documenten en sjablonen
  * Taalondersteuning
  * MS SharePoint-documenten
  * Google Workplace-documenten
* E-mail
  * SuperOffice-inbox
  * SuperOffice voor Outlook 365
  * SuperOffice voor Google
* Zoeken / Selecties
  * Statische selecties
  * Dynamische selecties
  * Selectie-acties
  * E-mail verzenden naar (max. 500)
* Rapportage en dashboards
  * Dashboards met standaardgrafieken
  * Afdrukken

## Sales

[Voor de verkoper][3]. Bevat de gemeenschappelijke CRM-functionaliteit.

**Essential:**

* Beheer van verkoopkansen
* Verkoopprognoses
* Dashboards met standaardtegels
* Valutaondersteuning
* Verkoopsecretaresse

**Premium:**

* Verkoopgids
* Verkoopprognoses op productniveau
* Dashboards met aangepaste tegels
* Stakeholders
* Verkoopdoelen en KPI's
* Activiteitenmonitoring (SAINT)
* Gecombineerde selecties
* Projectbeheer
* Offertebeheer

## Service

[Voor het afhandelen van binnenkomende aanvragen][4]. Bevat de gemeenschappelijke CRM-functionaliteit.

**Essential:**

* Verzoek- / ticketbeheer
* Categorisatie
* Automatische antwoorden en antwoordsjablonen
* Mobile CRM voor verzoeken
* Standaard Service-rapporten
* Dashboards met standaardtegels

**Premium:**

* Geautomatiseerde escalaties op basis van regels
* Automatische toewijzing aan agent
* Waarschuwingen en meldingen – tijdslimieten
* Kennisbank (FAQ's)
* Activiteitenmonitoring (SAINT)
* Dashboards met aangepaste tegels
* Gecombineerde selecties
* Projectbeheer

## Marketing

[Voor de marketingprofessional][2]. Bevat de gemeenschappelijke CRM-functionaliteit.

**Essential:**

* Mailings (gepersonaliseerde massa-e-mails)
* Mailingservice inbegrepen (MailGun)
* Drag & drop e-mailontwerper
* Bedrijfsspecifieke e-mailsjablonen
* Gratis sjablonenbibliotheek
* Ingebouwde afbeeldingsbibliotheek
* Google Analytics-tracking
* Open- en klikstatistieken
* Aangepaste acties bij klikken
* Dashboards met aangepaste tegels
* Bouncebeheer
* Beheer van spamklachten
* Formulieren (webformulieren)
* Verwerking van inzendingen met aangepaste acties
* Toestemmingsbeheer in formulieren
* Bedrijfsspecifieke formulieren
* Gratis bibliotheek met formulieren
* Double opt-in en landingspagina's
* Automatische antwoordmails bij inzending
* Gecombineerde selecties (maken / bewerken)
* Projectbeheer

**Premium:**

* Marketingautomatisering (flows)

## Gebruikers met meerdere plannen

Wanneer één persoon toegang nodig heeft tot meerdere plannen, wordt hij of zij een gebruiker met meerdere plannen (voorheen "complete gebruiker" genoemd).

De basisplannen:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Deze kunnen worden gecombineerd tot:

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

## Beschikbare add-on-abonnementen

* [Customer Engagement Platform (CEP)][8]
* [SuperOffice AI][7]
* [Expander Services][5]
* [Agenda-synchronisatie][6]

## Wat betekenen gebruikersplannen voor mijn app?

Een klant kan één van de volgende factureringsperiodes kiezen voor zijn CRM-oplossing:

* maandelijks
* per kwartaal
* halfjaarlijks
* jaarlijks

De contractduur bedraagt 12 maanden. Na de eerste 12 maanden wordt het contract automatisch verlengd volgens de gekozen factureringsperiode.

Klanten kunnen plannen combineren die het beste bij hun behoeften passen. Ze kunnen ook later gebruikersplannen toevoegen of wijzigen.

Houd bij integraties en prijsmodellen rekening met deze flexibiliteit.

<!-- Referenced links -->
[2]: https://www.superoffice.com/crm/marketing-features/
[3]: https://www.superoffice.com/crm/sales-features/
[4]: https://www.superoffice.com/crm/service-features/
[5]: expander-services.md
[6]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/nebula-synchronizer/
[7]: ../../ai/learn/index.md
[8]: ../../../../release-notes/9.2/cep/9.2-R01-update.md
