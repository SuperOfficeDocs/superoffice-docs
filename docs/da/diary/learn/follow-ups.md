---
uid: help-da-follow-ups
title: Opfølgninger
description: Opfølgninger - møde, skal udføres, samtale
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbog, opfølgning, aftale, møde, telefon, ring til, opgave
so.topic: concept
language: da
---

# Opfølgninger

*Opfølgning* er en samlet betegnelse for [møder](#meeting) og [opgaver](#todo). [Telefonopkald](#call) er en blanding av de to. Disse er tæt knyttet til dagbogsskærmen og fungerer alle på stort set samme måde.

Åbn en opfølgning ved at dobbeltklikke på den i dagbogen eller i detaljekortet **Aktiviteter**.

## Generel information

| Ikon | Egenskab | Beskrivelse |
|:-:|---|---|
| ![ikon][img9]| Ejer | Hvem opfølgningen tilhører. Den oprindelige skaber eller den tilknyttede person, som opfølgningen blev tildelt/delegeret til. |
| ![ikon][img3]| Titel | En beskrivende etiket. Yderligere detaljer placeres i dagsorden. |
| (en farvet prik) | Type | En foruddefineret liste over aktiviteter som møde (eksternt) og telefonopkald. |
| ![ikon][img7], ![ikon][img8] | Firma / kontakt | Hvem opfølgningen vedrører. |
| ![ikon][img10]| Tid og dato | Hvornår opfølgningen begynder eller skal være færdig. |
| ![ikon][img4]| Gentagelse | Hvis og hvordan opfølgningen gentager sig. |
| (intet ikon) | Tilgængelighed | Ledig/optaget. Påvirker konflikthåndtering. |
| ![ikon][img2] | Alarm | Hvis og hvornår personen skal underrettes. |
| ![ikon][img5] | Salg | Et salg, der er knyttet til opfølgningen. |
| ![ikon][img6] | Projekt | Et projekt knyttet til opfølgningen. |

## Opret ny

Uanset hvor du er i SuperOffice CRM, kan du oprette en ny opfølgning ved at klikke på knappen **+Ny** på Toplinjen og så vælge **Møde/Aftale**, **Skal udføres/Opgave**, eller **Opfølging/Samtale**.

> [!NOTE]
> Opfølgninger oprettet fra skærmbilledet Dagbog er som standard møder. Du kan dog ændre typen, inden du gemmer.

## Find dine opfølgninger

På skærmen Dagbog vises møder og telefonopkald på fanerne **Dag**, **Uge**, **Måned**, og **Vis**, og i sidepanelerne **Dag**, **Måned**, **Næste dag** og **Uge**.

Detaljekortet **Aktiviteter** i skærmbilledet Firma, Person, Salg, Projekt, Dagbog viser alle opfølgninger, herunder opgaver.

## Typer af opfølgninger

| Type | Starttidspunkt | Sluttidspunkt | Varighed | Deadline | Vises i | Beskrivelse | Eksempel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Aftale (møde) | &#10003; | &#10003; | Beregnet | | Kalender | Aktivitet med defineret start- og sluttidspunkt | Eksternt møde med leverandør |
| Skal udføres (opgave) | | | | &#10003; | Aktiviteter-sektionen | Opfølgning uden starttidspunkt | Påmindelse om opgaver, der forfalder på et bestemt tidspunkt |
| Opkald (opfølgning) | &#10003; | | &#10003; | | Aktiviteter-sektionen | Telefonopkald | Indgående opkald fra kunden |

## <a id="meeting" />Møde (aftale)

Møder er opfølgninger med defineret start- og sluttid, for eksempel møder. De vises i ejerens kalender.

Et møde kan være en enkelt begivenhed eller en del af en tilbagevendende serie. Mødeer, der involverer en ressource og/eller yderligere deltagere, kaldes [invitationer][5] (eller gruppebestillinger).

Forfaldne og fuldførte møder vil blive vist i **Aktiviteter**-fanen ud over i kalenderen.

### Vanlige scenarioer

| Scenario | Ressurs | 2+ deltakere | Beskrivelse |
|---|:-:|:-:|---|
| Egen tid reservert | | | Du har satt av tid til å jobbe med noe alene |
| Egen tid og ressurs reservert | &#10003; | | Som ovenfor, pluss behov for rom eller utstyr |
| Møde med flere deltakere | &#10003; | &#10003; | Et møde, vanligvis også med en ressurs eller sted |

## <a id="todo" />Skal udføres (opgave)

En *opgave* er en opfølgning uden starttid. Den har normalt heller ingen varighed, men den har altid en **frist**. Skal udføres bruges normalt til ting, du skal huske at gøre inden en bestemt tid.

Som standard finder du skal udføres på dagbogens "to-do"-liste, hvor de kan markeres som færdige, når de er udført. Hvis du angiver et start- og sluttidspunkt for en opgave, indføres den i dagbogen på det korrekte tidspunkt.

## <a id="call" />Opfølging (samtale)

En *samtale* repræsenterer en meget specifik handling - telefonopkaldet - og er en hybrid mellem et møde og en to-do:

* Når du først planlægger et opkald, befinder det sig på "to-do"-listen med en deadline, ligesom en opgave.
* Når du foretager opkaldet, fastsættes det på et tidspunkt og ligner nu en aftale.
  * Starttidspunktet bliver det nuværende tidspunkt og dagens dato.
  * Standardvarigheden er 15 minutter.

## Standardvarighed

Standardvarigheden er 1 timefor et møde og 15 minutter for en samtale. For at ændres standardværdier:

1. Gå til ![ikon][img14] **Personlige indstillinger** og vælg **Præferencer**.
1. Vælg **Bibehold standardværdier**.
1. Indtast en værdi for én eller begge af disse værdier og klik **Gem**.
    * **Varighed for ny aftale**
    * **Varighed for ny samtale**

## Relateret indhold

* [Oprettelse af opfølginger][2]
* [Få mere at vide om aktiviteter][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/diary-alarm.png
[img3]: ../../../../common/icons/title.png
[img4]: ../../../../common/icons/diary-recurring-transparent.png
[img5]: ../../../../common/icons/sale.png
[img6]: ../../../../common/icons/singlecolour/project.png
[img7]: ../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../common/icons/person.png
[img9]: ../../../../common/icons/associate-current.png
[img10]: ../../../../common/icons/now.png
[img14]: ../../../media/icons/personal-settings-small.png
