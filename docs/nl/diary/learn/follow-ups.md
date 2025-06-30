---
uid: help-nl-follow-ups
title: Vervolgactiviteiten
description: Vervolgactiviteiten - vergadering, taak, gesprek
keywords: agenda, vervolgactiviteit, afspraak, vergadering, telefoon, bellen, taak, gesprek
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Vervolgactiviteiten

Een *vervolgactiviteit* is een verzamelnaam voor [vergaderingen](#meeting) en [taken](#todo). Een [telefoongesprek](#call) is een combinatie van beide. Vervolgactiviteiten zijn nauw verbonden met het scherm Agenda en werken grotendeels op dezelfde manier.

U opent een bestaande vervolgactiviteit door erop te dubbelklikken in de agenda of op het sectietabblad **Activiteiten**.

## Algemene informatie

| Pictogram | Eigenschap | Beschrijving |
|:-:|---|---|
| <i class="ph ph-user" aria-label="Eigenaar"></i> | Eigenaar | Aan wie de vervolgactiviteit toebehoort. De oorspronkelijke maker of de medewerker aan wie de vervolgactiviteit is toegewezen/gedelegeerd. |
| <i class="ph ph-text-align-left" aria-label="Links uitlijnen"></i> | Titel | Een beschrijvend label. Extra details worden in de agenda vermeld. |
| (een gekleurde stip) | Type | Een vooraf gedefinieerde lijst van activiteiten zoals Vergadering (extern) en Telefoongesprek. |
| <i class="ph ph-buildings" aria-label="Bedrijf"></i>, <i class="ph ph-user-circle" aria-label="Persoon"></i> | Bedrijf / persoon | Op wie de vervolgactiviteit betrekking heeft. |
| <i class="ph ph-clock" aria-label="Klok"></i> | Tijd en datum | Wanneer de vervolgactiviteit begint of moet worden afgerond. |
| <i class="ph ph-arrows-clockwise" aria-label="Herhaling"></i> | Herhaling | Of en hoe de vervolgactiviteit zich herhaalt. |
| (geen pictogram) | Beschikbaarheid | Vrij/bezet. Beïnvloedt conflicthantering. |
| <i class="ph ph-bell" aria-label="Alarm"></i> | Alarm | Of en wanneer de persoon moet worden geïnformeerd. |
| <i class="ph ph-currency-circle-dollar" aria-label="Verkoop"></i> | Verkoop | Een verkoop gekoppeld aan de vervolgactiviteit. |
| <i class="ph ph-clipboard-text" aria-label="Project"></i> | Project | Een project gekoppeld aan de vervolgactiviteit. |
| <i class="ph ph-users" aria-label="Deelnemers"></i> | Deelnemers | Deelnemers gekoppeld aan de vervolgactiviteit. |
| <i class="ph ph-chair" aria-label="Hulpmiddel"></i> | Hulpmiddel | Vergaderruimtes, locaties of hulpmiddelen. |
| <i class="ph ph-map-pin" aria-label="Locatie"></i> | Locatie | De locatie of het adres waar de vergadering plaatsvindt. |

## Nieuwe vervolgactiviteit maken

Waar u zich ook bevindt in SuperOffice CRM, u kunt een nieuwe vervolgactiviteit maken door op **Nieuw** te klikken in de bovenste balk en vervolgens te kiezen voor **Vergadering**, **Taak**, of **Vervolgactiviteit**.

> [!NOTE]
> Vervolgactiviteiten die worden aangemaakt vanuit het scherm Agenda zijn standaard vergaderingen. U kunt echter het type wijzigen voordat u opslaat.

## Uw vervolgactiviteiten vinden

In het scherm Agenda verschijnen afspraken en telefoongesprekken op de tabbladen **Dag**, **Week**, **Maand** en **Weergave**, evenals in de zijpanelen **Dag**, **Maand**, **Volgende dag** en **Week**.

Het sectietabblad **Activiteiten** (in de schermen Bedrijf, Persoon, Verkoop, Project en Agenda) toont alle vervolgactiviteiten, inclusief taken.

## Soorten vervolgactiviteiten

| Type | Starttijd | Eindtijd | Duur | Deadline | Weergegeven in | Beschrijving | Voorbeeld |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Vergadering (afspraak) | &#10003; | &#10003; | Berekend | | Agenda | Activiteit met vaste begin- en eindtijd | Externe meeting met leverancier |
| Taak | | | | &#10003; | Sectietabblad Activiteiten | Vervolgactiviteit zonder starttijd | Herinnering voor een taak met deadline |
| Gesprek | &#10003; | | &#10003; | | Sectietabblad Activiteiten | Telefoongesprek | Inkomend gesprek van een klant |

## <a id="meeting"></a>Vergadering (afspraak)

Vergaderingen zijn vervolgactiviteiten met een vaste begin- en eindtijd en worden weergegeven in de agenda.

Een vergadering kan een enkele gebeurtenis zijn of deel uitmaken van een herhalende reeks. Vergaderingen waarbij hulpmiddelen en/of extra deelnemers betrokken zijn, worden [uitnodigingen][5] genoemd.

Achterstallige en voltooide vergaderingen verschijnen in het sectietabblad **Activiteiten**, naast de kalender.

### Gangbare scenario's

| Scenario | Hulpmiddel | 2+ deelnemers | Beschrijving |
|---|:-:|:-:|---|
| Eigen tijd gereserveerd | | | U hebt tijd vrijgemaakt om alleen aan iets te werken |
| Eigen tijd en hulpmiddel gereserveerd | &#10003; | | Zoals hierboven, plus de behoefte aan ruimte of apparatuur |
| Vergadering met meerdere deelnemers | &#10003; | &#10003; | Een vergadering, meestal ook met een hulpmiddel of locatie |

## <a id="todo"></a>Taak

Een *taak* is een vervolgactiviteit zonder starttijd. Meestal heeft het ook geen vaste duur, maar het heeft altijd een **deadline**. Taken worden doorgaans gebruikt voor herinneringen aan dingen die u op een bepaald moment moet afronden.

Standaard vindt u taken in de takenlijst van de agenda, waar ze kunnen worden afgevinkt zodra ze zijn voltooid. Als u een begin- en eindtijd specificeert, wordt de taak ingepland op de aangegeven datum en tijd.

## <a id="call"></a>Gesprek

Een *gesprek* vertegenwoordigt een telefoongesprek en is een hybride tussen een vergadering en een taak:

* Wanneer u een gesprek inplant, verschijnt het in de takenlijst met een deadline, net als een taak.
* Wanneer u het gesprek voert, krijgt het een vaste tijd en gedraagt het zich als een vergadering.
  * De starttijd wordt de huidige tijd en datum.
  * De standaardduur is 15 minuten.

## Standaard duur

De standaardduur is 1 uur voor een vergadering en 15 minuten voor een gesprek. U kunt deze waarden aanpassen:

1. Ga naar <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** en selecteer **Voorkeuren**.
1. Selecteer **Standaardwaarden**.
1. Voer een nieuwe waarde in voor een of beide instellingen en klik op **Opslaan**.
    * **Duur van nieuwe vergadering**
    * **Duur van nieuw gesprek**

## <a id="more-tab"></a>Het tabblad Meer

Het [tabblad Meer][12] toont gebruikers gedefinieerde velden voor de vervolgactiviteit.

## Gerelateerde inhoud

* [Vervolgactiviteiten maken][2]
* [Meer informatie over activiteiten][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
