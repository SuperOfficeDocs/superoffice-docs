---
uid: help-no-ui-web-panels
title: Nettleserfaner
description: Nettleserfaner
keywords: nettleserfane, www fane
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

* **Sidepanel** – Vises i det sammenleggbare panelet på siden av mange CRM-skjermbilder.
* **Verktøylinje** – Legger til en knapp på verktøylinjen.
* **Navigatorknapp** – Legger til en knapp på hovedmenyen.
* **Paneler:**
  * **Firma-, Person-, Prosjekt-, Salg- og Utvalgskort** – Legger til en snarvei i **www**-fanen for hvert skjermbilde.
  * **Webpanel på SuperOffice-knapp** – Åpnes fra SuperOffice-logoen (øvre venstre hjørne). Flere URL-er vises som faner til høyre.
  * **Seksjonstabber (i Firma-, Person-, Prosjekt- og Salgsskjermbilder)** – Legger til en separat fane som åpner panelinnholdet.
* **Dialogbokser:**
  * **Oppfølgingsdialogboks** – Legger til en snarvei i **www**-fanen av oppfølgingsdialogboksen.
  * **Dokument-, Produkt- og Tilbudsdialogbokser** – Legger til en snarvei i **www**-fanen av hver dialogboks.
* **Menyer:**
  * **Verktøymeny** – Vises under **Andre applikasjoner** når du klikker på **Verktøy**-knappen i Navigatoren.
  * **Vis-meny** – Vises i menyalternativet **Andre applikasjoner**.
* **Dashbord-fliser** – Tilgjengelige i fliseinnholdsvelgeren for dashbord-widgets.

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

## Relatert innhold

* [Legg til webpanel][1]
* [Bygge webpaneler][2]

<!-- Referenced links -->
[1]: add-web-panel.md
[2]: ../../../../en/customization/web-panels/dev/index.md

<!-- Referenced images -->