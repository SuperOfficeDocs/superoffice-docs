---
uid: help-no-saint-admin
title: Konfigurer SAINT
description: Lær hvordan du konfigurerer SuperOffice SAINT i denne veiledningen.
keywords: SAINT, statusovervåking
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Konfigurer SAINT

Du kan følge opp kundene på en proaktiv måte ved å bruke SAINT, som står for Sales Intelligence. SuperOffice SAINT kan brukes på mange måter og i mange ulike prosesser. Før du implementerer SAINT-funksjonen, er det viktig å vite hva du ønsker å forbedre og hvordan du kan analysere dette.

Når du vet hva du vil forbedre, kan du prøve å tenke på hva firmaet kan gjøre for å forbedre den eksisterende situasjonen. Hva vil du gjøre?

* Sende ut en gruppeutsendelse ved hjelp av SuperOffice-utsendelser
* Ringe alle kunder i SAINT-utvalget
* Følg opp alle saker

[!include[Requirement](../includes/note-saint-req.md)]

Fra fanen **Statusovervåking/SAINT** kan du opprette statuser for firmaer, personer og prosjekter. Statusovervåking er funksjonaliteten konseptet Sales Intelligence (SAINT). Dette forenkler oppfølging av firmaer, personer og prosjekter og gir mer intelligente søkealternativer i SuperOffice CRM.

## Statusbilder

Statuser kan vises som bilder på kortene til prosjekter, personer eller firmaer som oppfyller kriteriene dine. Statusbildet for en kunde du ikke har hatt kontakt med på en stund kan for eksempel være et edderkoppnett. På denne måten får du en visuell og umiddelbar indikasjon på hvordan forholdet til kunden er, eller hvordan det går med et prosjekt. Når brukeren klikker eller holder musepekeren over et statusbilde i SuperOffice CRM, vises noe av teksten. For eksempel for å indikere handlingene som skal utføres (du skriver selv inn teksten når du oppretter statusen).

## Standardoppfølging for status

Når brukeren åpner statusdialogen i SuperOffice CRM, kan brukeren også opprette en oppfølging av den aktuelle statusen. Oppfølgingstype og -tekst kan forhåndsdefineres.

### Eksempel

En status kan for eksempel gjelde for firmaer som oppfyller følgende kriterier:

* Kategori = Kunde
* Siste salg er mer enn 2 måneder gammelt
* Antall salg større enn 50

Teksten i feltet **Beskrivelse** kan da være:

"&lt;navn&gt; har tidligere vært en god kunde, men vi har ikke solgt noe til dem på 2 måneder. &lt;forts&gt; er primærkontakten for denne kunden og bør kontakte kunden snart på telefon (&lt;cpho&gt;) eller e-post (&lt;post&gt;) for å finne ut hvorfor."

I dette eksempelet er følgende malvariabler brukt for å skreddersy teksten til gjeldende firma:

| Variabel | Beskrivelse |
|---|---|
| navn | Navnet på firmaet |
| cont | Navnet på vår kontaktperson for firmaet |
| cpho | Firmaets telefonnummer |
| e-post | Firmaets e-postadresse |

## Søk og utvalg

Statuser og tellere kan brukes i søk og til å opprette dynamiske utvalg. Du kan for eksempel søke etter firmaer, personer eller prosjekter som oppfyller en status eller en teller. [!include[Define counter](../includes/def-counter.md)]

Du kan sette opp 3 forskjellige tellere/perioder, disse tellerne er antall dager du vil telle aktiviteter, salg og forespørsler. De ulike periodene er angitt for hva som er viktig for deg. Du vil for eksempel bli varslet hvis noen av kundene dine ikke har hatt noen aktiviteter den siste måneden (30 dager), eller hvis det er uløste forespørsler på kundene som er eldre enn 30 dager.

## Perioder

Du kan angi opptil tre ulike perioder for tellere, slik at SAINT-kriteriene kan dekke kortere eller lengre perioder. Hvis du angir tre perioder på henholdsvis 30, 60 og 90 dager, kan du velge SAINT-kriterier for hver av disse periodene.

## Oppretting av nye statuser

Først logger du inn på SuperOffice CRM, går til hovedmenyen øverst til høyre og åpner Innstillinger og vedlikehold, og klikker på SAINT i navigatoren. Der kan du sette opp Sales Intelligence og statusovervåking.

Slik oppretter du en status:

1. [Opprett ny status][1]
1. [Velge bilde for status][2]
1. [Velge standard oppfølgingstype for status][3]
1. [Angi statuskriterier][4]
1. [Angi periodelengde][5]

Nå kan du gå tilbake til SuperOffice CRM og åpne et nytt dynamisk utvalg for å se alle personene du må følge opp.

Sørg for å legge til SAINT-kriteriene dine. Klikk på Legg til og deretter ved siden av feltet og velg Firma – Tellere (SAINT). Finn din SAINT-statusovervåking. I vårt eksempel velger vi Forsømte kunder og klikker på OK. Oppdater utvalget ditt, og så vet du nøyaktig hvilke kunder som må følges opp.

## Gjenopprett og rediger statuser

* [Gjenopprette slettet status][6]
* [Redigere statusbeskrivelse][7]

## Administrere og vedlikeholde statusovervåking

* [Administrer statusovervåking][8]

<!-- Referenced links -->
[1]: create-status.md
[2]: select-image-for-status.md
[3]: select-default-follow-up-type-for-status.md
[4]: select-status-criteria.md
[5]: select-period-length.md
[6]: restore-status.md
[7]: edit-status.md
[8]: manage-status-monitors.md

<!-- Referenced images -->
