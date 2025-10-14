---
uid: help-no-ui-web-panels
title: Nettleserfaner
description: Nettleserfaner
keywords: nettleserfane
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: no
index: true
redirect_from: 
  - /no/ui/web-panels/learn/index
  - /no/admin/lists/learn/web-panel
---

# Nettleserfaner

Et **webpanel** er et konfigurerbart område inne i SuperOffice CRM som viser innhold fra en nettside eller intern ressurs, basert på en URL. Dette lar deg integrere eksterne datakilder eller interne verktøy direkte i SuperOffice.

Webpaneler kan vises på ulike steder og er tilpasset konteksten brukeren jobber i, som et firmakort, en sak eller en oppfølging.

## Innholdstyper som støttes av nettleserfaner

Nettleserfaner støtter en rekke innholdstyper:

* **URL-er:** eksterne nettsider eller interne systemer
* **Skjermbilder:** SuperOffice CRM skjermbilde-snarveier
* **Utvalg:** snarveier til utvalg
* **Skript/makroer:** handlinger utløst via en knapp eller meny

## Visningsplasseringer for nettleserfaner

**Visningsplasseringen** defineres når du konfigurerer panelet. Dette styrer hvor i SuperOffice panelet vises.

* Sidepanel
* Verktøylinje
* Navigatorknapp (hovedmeny)
* Paneler:
  * Firma-, Person-, Prosjekt-, Salg- og Utvalgskort
  * SuperOffice-knapp webpanel
  * Seksjonstabber for Firma-, Person-, Prosjekt- og Salgsskjermbilder
* Dialogbokser:
  * Oppfølgingsdialogboks
  * Dokumentdialogboks
  * Produkt- og tilbudsdialogbokser
* Menyer:
  * Verktøymeny
  * Vis-meny
* Dashbord-fliser (via innholdsvelger dropdown)

### I Service (foreldet)

* Hovedskjermbilde
* Saksskjermbilde
* Firmaskjermbilde
* Personskjermbilde
* Ekstra tabelloppføringsskjermbilde

## <a id="www"></a>www-fanen

På steder som Firma, Person, Prosjekt og Salg vises nettleserfaner ofte under **www**-fanen.

Du kan gi fanen nytt navn i **Innstillinger og vedlikehold** > **Alternativer** > **Ledetekster**. For å flytte fanen innenfor CRM-grensesnittet bruker du listen **GUI - Webpanel**.

### Åpne i eget vindu

Alle innebygde URL-er kan åpnes i et eget nettleservindu ved hjelp av **Åpne i eget vindu**.

## Slik fungerer webpaneler

Webpaneler laster innhold dynamisk basert på CRM-kontekst og URL-en som er definert for panelet:

1. En bruker åpner en post (for eksempel et firma).
1. Systemet beregner URL-en ved å bruke tilgjengelige malvariabler.
    * For eksempel blir `http://server/side.asp?id=<cuid>` til `http://server/side.asp?id=123`
1. Hvis den nye URL-en er forskjellig fra den forrige, sender systemet en ny forespørsel.
1. Serveren svarer med den aktuelle websiden: den mottar URL-en, beregner siden ved hjelp av URL-parametere og returnerer resultatet.
1. Panelet viser websiden inne i SuperOffice CRM.

<!-- Referenced links -->

<!-- Referenced images -->