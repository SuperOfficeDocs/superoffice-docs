---
uid: help-nl-vervolgactiviteits
title: Vervolgactiviteit
description: Vervolgactiviteit - Vergadering, taak, gesprekken
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: agenda, vervolgactiviteit, afspraak, vergadering, telefoon, bellen, taak, gesprekken
so.topic: concept
language: nl
---

# Vervolgactiviteit

Een *vervolgactiviteit* is een verzamelnaam voor [vergaderingen](#meeting) en [taken](#todo). Een [telefoongesprek](#call) is een combinatie van beide. Vervolgactiviteiten zijn uw verwant aan het scherm Agenda. De werking van deze activiteiten is in hoofdlijnen hetzelfde.

Open en vervolgactiviteit door erop te dubbelklikken in het agenda of op het sectietabblad **Activiteiten**.

## Algemene informatie

| Pictogram | Eigenschap | Beschrijving |
|:-:|---|---|
| ![Pictogram][img9]| Eigenaar | Aan wie de vervolgactiviteit toebehoort. De oorspronkelijke maker of de medewerker aan wie de vervolgactiviteit is toegewezen/gedelegeerd. |
| ![Pictogram][img3]| Titel | Een beschrijvend label. Extra details worden in de agenda vermeld. |
| (een gekleurde stip) | Type | Een vooraf gedefinieerde lijst van activiteiten zoals Vergadering (extern) en Telefoongesprek. |
| ![Pictogram][img7], ![Pictogram][img8] | Bedrijf / contact | Op wie de vervolgactiviteit betrekking heeft. |
| ![Pictogram][img10]| Tijd en datum | Wanneer de vervolgactiviteit begint of moet worden afgerond. |
| ![Pictogram][img4]| Herhaling | Of en hoe de vervolgactiviteit zich herhaalt. |
| (geen pictogram) | Beschikbaarheid | Vrij/bezet. Beïnvloedt conflicthantering. |
| ![Pictogram][img2] | Alarm | Of en wanneer de persoon moet worden geïnformeerd. |
| ![Pictogram][img5] | Verkoop | Een verkoop gekoppeld aan de vervolgactiviteit. |
| ![Pictogram][img6] | Project | Een project gekoppeld aan de vervolgactiviteit. |

## Nieuwe maken

Ongeacht waar u zich bevindt in SuperOffice CRM kunt u een nieuwe vervolgactiviteit maken door te klikken op **Nieuw** op de bovenste balk en **Vergadering/Afspraak**, **Taak**, of **Vervolgactiviteit/Gesprek** te selecteren.

> [!NOTE]
> Vervolgactiviteit die worden aangemaakt vanaf het scherm Agenda zijn standaard vergadering. U kunt echter het type wijzigen voordat u opslaat.

## Vind uw vervolgactiviteit

Op het scherm Agenda verschijnen afspraken en telefoongesprekken op de tabbladen **Dag**, **Week**, **Maand** en **Weergave**, en in de zijpanelen **Dag**, **Maand**, **Volgende dag** en **Week**.

Het sectietabblad **Activiteiten** in het scherm Bedrijf, Persoon, Verkoop, Project, en Agenda toont alle vervolgactiviteiten, inclusief taken.

## Soorten vervolgactiviteit

| Type | Starttijd | Eindtijd | Duur | Deadline | Weergegeven in | Beschrijving | Voorbeeld |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Vergadering (afspraak) | &#10003; | &#10003; | Berekend | | Agenda | Activiteit met gedefinieerde start- en eindtijd | Externe vergadering met leverancier |
| Taak | | | | &#10003; | Tabblad Activiteiten | Vervolgactiviteit zonder starttijd | Herinnering voor zaken die op een bepaalde tijd moeten zijn afgerond |
| Vervolgactiviteit (Gesprek) | &#10003; | | &#10003; | | Tabblad Activiteiten | Telefoongesprek | Inkomend gesprek van klant |

## <a id="meeting" />Vergadering (afspraak)

Vergadering zijn activiteiten met een ingestelde begin- en eindtijd, zoals vergaderingen. Sie werden im Kalender des Besitzers angezeigt.

Een vergadering kan een enkele gebeurtenis zijn of deel uitmaken van een terugkerende reeks. Vergaderingen met een hulpmiddel en/of extra deelnemers worden [uitnodigingen][5] (of groepsreserveringen) genoemd.

> [!NOTE]
> Te laat uitgevoerde en voltooide vergaderingen worden weergegeven in het **Activiteiten**-tabblad, naast de kalender.

### Gangbare scenario's

| Scenario | Hulpmiddel | 2+ deelnemers | Beschrijving |
|---|:-:|:-:|---|
| Eigen tijd gereserveerd | | | U hebt tijd vrijgemaakt om alleen aan iets te werken |
| Eigen tijd en hulpmiddel gereserveerd | &#10003; | | Zoals hierboven, plus de behoefte aan ruimte of apparatuur |
| Vergadering met meerdere deelnemers | &#10003; | &#10003; | Een vergadering, meestal ook met een hulpmiddel of locatie |

## <a id="todo" />Taak

Een *taak* is een vervolgactiviteit zonder starttijd. Meestal heeft het ook geen duur, maar het heeft altijd een **deadline**. Taken worden doorgaans gebruikt voor dingen die je moet onthouden om op een bepaald tijdstip te doen.

Standaard vind je taken in de dagboek "to-do"-lijst, waar ze kunnen worden afgevinkt wanneer ze zijn voltooid. Als u een begin- en eindtijd opgeeft voor een taak, wordt de taak op de juiste dag en met de juiste tijd ingevoerd in de agenda.

## <a id="call" />Gesprek

Een *gesprek* vertegenwoordigt een zeer specifieke handeling - het telefoongesprek - en is een hybride tussen een vergadering en een taak:

* Wanneer u in eerste instantie een telefoongesprek plant, staat het op de "to-do"-lijst met een deadline, net als een taak.
* Wanneer u het gesprek voert, wordt het vastgelegd in de tijd en lijkt het nu op een vergadering.
  * Het begintijdstip wordt de huidige tijd en de datum van vandaag.
  * De standaardduur is 15 minuten.

### Standaard duur

De standaardduur van een vergadering is één uur en 15 minuten van een gesprek. U kunt standaardwaarden aanpassen.

1. Ga naar ![pictogram][img14] **Persoonlijke instellingen** en selecteer **Voorkeuren**.
1. Selecteer **Standaardwaarden**.
1. Voer een waarde in voor één of beide van deze waarden en klik op **Opslaan**.
    * **Duur van nieuwe afspraak**
    * **Duur van nieuw gesprek**

## Gerelateerde inhoud

* [Vervolgactiviteiten maken][2]
* [Meer informatie over activiteiten][4]

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
