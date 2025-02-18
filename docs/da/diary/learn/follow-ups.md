---
uid: help-da-follow-ups
title: Opfølgninger
description: Opfølgninger - møde, skal udføres, samtale
keywords: opfølgning, aftale, møde, telefon, ring til, opgave, deltager, dagbog
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
topic: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opfølgninger

*Opfølgning* er en samlet betegnelse for [møder](#meeting) og [opgaver](#todo). Et [telefonopkald](#call) er en blanding af de to. Disse aktiviteter er tæt knyttet til dagbogsskærmen og fungerer stort set på samme måde.

Åbn en eksisterende opfølgning ved at dobbeltklikke på den i Dagbogen eller i detaljekortet **Aktiviteter**.

## Generel information

| Ikon | Egenskab | Beskrivelse |
|:-:|---|---|
| <i class="ph ph-user" aria-label="Ejer"></i> | Ejer | Hvem opfølgningen tilhører. Den oprindelige skaber eller den tilknyttede person, som opfølgningen blev tildelt/delegeret til. |
| <i class="ph ph-text-align-left" aria-label="Venstrejustering"></i> | Titel | En beskrivende etiket. Yderligere detaljer placeres i dagsorden. |
| (en farvet prik) | Type | En foruddefineret liste over aktiviteter som møde (eksternt) og telefonopkald. |
| <i class="ph ph-buildings" aria-label="Firma"></i>, <i class="ph ph-user-circle" aria-label="Person"></i> | Firma / person | Hvem opfølgningen vedrører. |
| <i class="ph ph-clock" aria-label="Ur"></i> | Tid og dato | Hvornår opfølgningen begynder eller skal være færdig. |
| <i class="ph ph-arrows-clockwise" aria-label="Gentagelse"></i> | Gentagelse | Hvis og hvordan opfølgningen gentager sig. |
| (intet ikon) | Tilgængelighed | Ledig/optaget. Påvirker konflikthåndtering. |
| <i class="ph ph-bell" aria-label="Alarm"></i> | Alarm | Hvis og hvornår personen skal underrettes. |
| <i class="ph ph-currency-circle-dollar" aria-label="Salg"></i> | Salg | Et salg, der er knyttet til opfølgningen. |
| <i class="ph ph-clipboard-text" aria-label="Projekt"></i> | Projekt | Et projekt knyttet til opfølgningen. |
| <i class="ph ph-users" aria-label="Deltagere"></i> | Deltagere | Deltagere tilknyttet opfølgningen. |
| <i class="ph ph-chair" aria-label="Ressource"></i> | Ressource | Mødelokaler, lokationer eller ressourcer. |
| <i class="ph ph-map-pin" aria-label="Lokation"></i> | Lokation | Stedet eller adressen, hvor mødet finder sted. |

## Opret ny

Uanset hvor du er i SuperOffice CRM, kan du oprette en opfølgning ved at klikke på **Ny** på toplinjen og derefter vælge **Møde**, **Skal udføres**, eller **Opfølgning**.

> [!NOTE]
> Opfølgninger oprettet fra dagbogsskærmen er som standard møder. Du kan dog ændre typen, inden du gemmer.

## Find dine opfølgninger

I dagbogen vises møder og telefonopkald på fanerne **Dag**, **Uge**, **Måned**, og **Oversigt**, samt i sidepanelerne **Dag**, **Måned**, **Næste dag** og **Uge**.

Detaljekortet **Aktiviteter** (i Firma, Person, Salg, Projekt og Dagbog) viser alle opfølgninger, herunder opgaver.

## Typer af opfølgninger

| Type | Starttidspunkt | Sluttidspunkt | Varighed | Deadline | Vises i | Beskrivelse | Eksempel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Møde (aftale) | &#10003; | &#10003; | Beregnet | | Kalender | Aktivitet med defineret start- og sluttidspunkt | Eksternt møde med leverandør |
| Skal udføres (opgave) | | | | &#10003; | Detaljekortet Aktiviteter | Opfølgning uden starttidspunkt | Påmindelse om opgaver, der forfalder på et bestemt tidspunkt |
| Opfølgning (telefonopkald) | &#10003; | | &#10003; | | Detaljekortet Aktiviteter | Telefonopkald | Indgående opkald fra kunde |

## <a id="meeting"></a>Møde (aftale)

Møder er aktiviteter med en defineret start- og sluttid. De vises i ejerens kalender.

Et møde kan være en enkelt begivenhed eller en del af en tilbagevendende serie. Møder, der involverer en ressource og/eller flere deltagere, kaldes [invitationer][5].

Forfaldne og fuldførte møder vil blive vist i Detaljekortet **Aktiviteter** ud over i kalenderen.

### Almindelige scenarier

| Scenario | Ressource | 2+ deltagere | Beskrivelse |
|---|:-:|:-:|---|
| Egen tid reserveret | | | Du har afsat tid til at arbejde med noget alene |
| Egen tid og ressource reserveret | &#10003; | | Som ovenfor, plus behov for lokale eller udstyr |
| Møde med flere deltagere | &#10003; | &#10003; | Et møde, typisk også med en ressource eller lokation |

## <a id="todo"></a>Skal udføres (opgave)

En *opgave* er en opfølgning uden starttidspunkt. Den har normalt heller ingen varighed, men den har altid en **frist**. Skal udføres bruges til opgaver, der skal huskes inden en bestemt tid.

Som standard findes opgaver i dagbogens "to-do"-liste, hvor de kan markeres som færdige, når de er afsluttet. Hvis du angiver en start- og sluttid for en opgave, vil den blive placeret i dagbogen på det angivne tidspunkt.

## <a id="call"></a>Opfølgning (telefonopkald)

Et *telefonopkald* er en specifik handling og fungerer som en hybrid mellem et møde og en opgave:

* Når du planlægger et opkald, befinder det sig i to-do-listen med en deadline, ligesom en opgave.
* Når opkaldet foretages, får det en fastlagt starttid og ligner nu et møde.
  * Starttidspunktet bliver det aktuelle tidspunkt og dags dato.
  * Standardvarigheden er 15 minutter.

## Standardvarighed

Standardvarigheden er 1 time for et møde og 15 minutter for et opkald. For at ændre standardværdien:

1. Gå til <i class="ph ph-user-circle"></i> **Personlige indstillinger** og vælg **Præferencer**.
1. Vælg **Standardværdier**.
1. Indtast en værdi for en eller begge af følgende værdier, og klik **Gem**.
    * **Varighed for nyt møde**
    * **Varighed for ny opfølgning**

## <a id="more-tab"></a>Fanen Mere

[Fanen Mere][12] viser brugerdefinerede felter for opfølgningen.

## Relateret indhold

* [Opret en opfølgning][2]
* [Lær om aktiviteter][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md
[12]: ../../custom-objects/learn/more-tab.md
