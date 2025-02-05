---
uid: help-no-section-tab-activities
title: Aktivitetsfanen
description: Lær hvordan du bruker Aktivitetsdetaljkortet i SuperOffice CRM for å vise, administrere og følge opp aktiviteter, oppgaver og dokumenter for firmaer, personer, prosjekter og salg – alt i én organisert seksjon.
keywords: detaljkortet Aktiviteter, Aktiviteter-fanen, Aktivitetsfanen, detaljkort, aktivitetsarkiv, aktivitet
author: Bergfrid Skaara Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Aktivitetsfanen

Det finnes forskjellige typer [aktiviteter][1] i SuperOffice CRM, inkludert oppfølginger, utsendelser, skjemainnsendinger og chatoppføringer.

Detaljkortet **Aktiviteter** i SuperOffice CRM gir en omfattende oversikt over oppfølginger, dokumenter og e-poster knyttet til en bestemt enhet (firma, person, prosjekt eller salg). Dette gjør det enkelt å følge opp og administrere interaksjoner, slik at all relevant aktivitet er lett tilgjengelig.

![Detaljkortet Aktiviteter (Dagbok) -screenshot][img2]

## Tilgjengelighet av Aktivitetsfanen

Detaljkortet **Aktiviteter** er tilgjengelig for:

| Enhet   | Beskrivelse av detaljkortet |
|---------|--------------------------|
| [Firma][9] | Viser alle aktiviteter knyttet til firmaet. |
| [Person][10] | Viser alle aktiviteter som involverer personen, inkludert aktiviteter knyttet til personens tilknyttede firma. |
| [Dagbok][11] | En oppgaveliste som viser ikke utførte aktiviteter, inkludert de som ikke har et fastsatt klokkeslett eller en bestemt dato ennå. |
| [Salg][12] | Viser alle aktiviteter knyttet til salget, gir en oversikt over fremdrift og interaksjoner. |
| [Prosjekt][13] | Viser alle aktiviteter knyttet til prosjektet. |

## <a id="columns"></a>Kolonneoversikt for detaljkortet Aktiviteter

Aktivitetsfanen inneholder følgende kolonner for å vise nøkkelinformasjon om hver aktivitet:

| Kolonne | Beskrivelse |
|---------|-------------|
| Utført | Avkrysningsboks som indikerer om aktiviteten er utført. En hake i boksen (<i class="ph ph-check" aria-hidden="true"></i>) betyr utført, mens en tom boks betyr at aktiviteten pågår. |
| Typesymbol | Viser [aktivitetstypen][1] (som møte, samtale, dokument). Gjenspeiler teksten i **Type**-kolonnen. |
| Dato | Viser når et dokument ble opprettet eller når en oppfølging er planlagt |
| Type | Typen aktivitet, som møte, oppgave eller e-post. |
| Beskrivelse | En kort beskrivelse av aktiviteten. |
| Firma | Tilknyttet firma, hvis relevant. |
| Person | Personen knyttet til aktiviteten, hvis relevant. |
| Bruker-ID | Brukeren som opprettet aktiviteten. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Se aktiviteter

1. Gå til den relevante skjermen, som Firma, Person, Prosjekt eller Salg.

1. Klikk på detaljkortet **Aktiviteter** for å se alle aktiviteter knyttet til posten.

1. Dobbeltklikk på en rad for en aktivitet for å åpne og vise eller redigere detaljene for den aktiviteten.

### Filtrer aktiviteter

Du kan [filtrere listen][8] over aktiviteter ved å bruke avmerkingsboksene eller filtrene nederst i fanen. Dette hjelper deg med å fokusere på spesifikke aktivitetstyper eller tidsrammer.

### Inkluder utførte aktiviteter

For å inkludere utførte aktiviteter i listen, må du forsikre deg om at boksen **Utført** er krysset av. Dette gir deg en fullstendig oversikt over både pågående og tidligere aktiviteter.

## Administrere aktiviteter i Aktivitetsfanen

* **Legg til aktivitet:** Klikk **Legg til**, fyll ut detaljene, og klikk **Lagre**.

* **Åpne aktiviteter:** Dobbeltklikk på en aktivitet i listen. Hvis du dobbeltklikker på et dokument, åpnes dokumentet.

* **Flytt mellom aktiviteter:** Bruk piltastene for å navigere gjennom aktiviteter. Bruk **Forhåndsvisning** i [sidepanelet][2] for raskt å se detaljer.

* **Svar på eller videresend e-post:** Finn den lagrede e-posten, høyreklikk, og velg **Svar** eller **Videresend**.

## Ytterligere tips

* **Hurtignavigering:** Bruk [Navigatøren][7] for raskt å bytte mellom forskjellige poster og deres tilhørende Aktivitetsfaner.

* **Markere fullføring:** For å endre **Utført**-statusen for en aktivitet, klikk ganske enkelt på boksen.

* **Infoboks for full tekst:** Hvis ikke all teksten i et felt er synlig, hold musepekeren over feltet for å vise teksten i en infoboks.

## Relatert innhold

* [Introduksjon til aktiviteter][1]
* [Opprett oppfølginger][6]
* [Svar på eller videresend e-post fra Aktivitetsfanen][3]
* [Endre utført-statusen for en aktivitet][4]
* [Slett aktiviteter i aktivitetslisten][1]
* [Filtrer aktiviteter][8]
* [Grupper kolonner og oppsummer][5]

<!-- Referenced links -->
[1]: ../basics/activity.md
[2]: ../getting-started/main-screen/side-panel.md
[3]: send-email.md
[4]: ../../diary/learn/change-completed-status.md
[5]: configure-columns.md#calculate
[6]: ../../diary/learn/create-follow-up.md
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[12]: ../../sale/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/activities-detail.png
