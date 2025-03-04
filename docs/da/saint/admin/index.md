---
uid: help-da-saint-admin
title: Konfigurer SAINT
description: Lær, hvordan du konfigurerer SuperOffice SAINT i denne guide.
keywords: SAINT, statusovervågning
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Konfigurer SAINT

Du kan følge op på dine kunder proaktivt ved at bruge SAINT, der står for Sales Intelligence. SuperOffice SAINT kan bruges på mange måder og til mange forskellige processer. Før du implementerer SAINT-funktionen, er det vigtigt at vide, hvad du ønsker at forbedre, og hvordan du kan analysere dig frem til dette.

Når du ved, hvad du vil forbedre, skal du prøve at tænke på de handlinger, dit firma kan iværksætte for at forbedre den eksisterende situation. Hvilke handlinger vil du iværksætte?

* Send en gruppemail ud ved hjælp af SuperOffice Udsendelser
* Ring til alle kunder i SAINT-udvalget
* Følg op på alle sager

[!include[Requirement](../includes/note-saint-req.md)]

Under fanen **Statusovervågning/SAINT** kan du oprette statusser for firmaer og projekter. Statusovervågning er funktionaliteten bag betegnelsen Sales Intelligence (SAINT). Den gør det lettere at følge op på firmaer, personer og projekter og giver mere intelligente søgemuligheder i SuperOffice CRM.

## Statusbilleder

Statusser kan vises som billeder på kortene til projekter, personer eller firmaer, som opfylder dine kriterier. Statusbilledet for en kunde, som du ikke har været i kontakt med et stykke tid, kunne for eksempel være et spindelvæv. Dermed gives der en visuel og direkte indikation på, hvordan forholdet til kunden er, eller hvordan det går med et projekt. Når brugeren klikker på eller holder musemarkøren over et statusbillede i SuperOffice CRM, vises der noget tekst. For eksempel for at angive de handlinger, der skal iværksættes (du indtaster selv teksten, når du opretter statussen).

## Standardopfølgning for status

Når brugeren åbner dialogboksen Status i SuperOffice CRM, får vedkommende også mulighed for at oprette en opfølgning til den aktuelle status. Opfølgningstype og -tekst kan foruddefineres.

### Eksempel

En status kan for eksempel gælde for firmaer, som opfylder følgende kriterier:

* Kategori = Kunde
* Sidste salg er mere end 2 måneder gammelt
* Antal salg er højere end 50

Teksten i feltet **Beskrivelse** kunne for eksempel være følgende:

"&lt;name&gt; har tidligere været en god kunde, men vi har ikke solgt noget til vedkommende i mere end 2 måneder. &lt;cont&gt; er den primære person for denne kunde og bør snart kontakte kunden telefonisk (&lt;cpho&gt;) eller via e-mail (&lt;mail&gt;) for at finde ud af hvorfor."

I dette eksempel er der brugt følgende skabelonvariabler for at skræddersy teksten til aktuel kontakt:

| Variabel | Beskrivelse |
|---|---|
| name | Navnet på firmaet |
| cont | Navnet på vores kontakt for firmaet |
| cpho | Telefonnummer til firma |
| mail | E-mailadresse til firma |

## Søgning og udvalg

Statusser og tællere kan bruges i søgninger og til at oprette dynamiske udvalg. Du kan for eksempel søge efter firmaer, personer eller projekter, som opfylder en status eller en tæller. [!include[Define counter](../includes/def-counter.md)]

Du kan oprette 3 forskellige tællere/perioder. Tællerne er det antal dage, du vil regne med for aktiviteter, salg og sager. De forskellige perioder er indstillet til det, der er vigtigt for dig. Du vil for eksempel have besked, hvis nogle af dine kunder ikke har haft nogen aktiviteter den seneste måned (30 dage), eller hvis der er uløste sager på kunderne, der er ældre end 30 dage.

## Perioder

Du kan angive op til tre forskellige perioder, så SAINT-kriterierne kan dække kortere eller længere perioder. Hvis du angiver tre perioder på henholdsvis 30, 60 og 90 dage, kan du vælge SAINT-kriterier for hver af disse perioder.

## Oprettelse af nye statusser

Først og fremmest skal du logge på SuperOffice CRM, gå til hovedmenuen i øverste højre hjørne og åbne Indstillinger og vedligeholdelse, hvorefter du skal klikke på SAINT i navigatoren. Der kan du konfigurere din Sales Intelligence og statusmonitorer.

Sådan opretter du en status:

1. [Oprettelse af ny status][1]
1. [Valg af billede til status][2]
1. [Valg af standardopfølgningstype til status][3]
1. [Angivelse af statuskriterier][4]
1. [Angivelse af periodelængde][5]

Du kan nu gå tilbage til SuperOffice CRM og åbne et nyt dynamisk udvalg for at se alle de personer, du skal følge op på.

Sørg for at tilføje dine SAINT-kriterier. Klik på Tilføj, klik derefter ud for feltet, og vælg Firma – Tællere (SAINT). Find din SAINT-statusovervågning. I vores eksempel vælger vi Forsømte kunder og klikker på OK. Opdater dit udvalg. Derefter ved du præcist, hvilke kunder der skal følges op på.

## Gendannelse og redigering af statusser

* [Gendannelse af slettet status][6]
* [Redigering af statusbeskrivelse][7]

## Administration og vedligeholdelse af statusovervågning

* [Administration af statusovervågning][8]

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
