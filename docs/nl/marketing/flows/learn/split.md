---
uid: help-nl-flow-split
title: Flow-controle - opsplitsen
description: Flow-controle - opsplitsen
keywords: Marketing, flow, opsplitsen, flow-controle, split-stap, tak, differentiëren, alle anderen
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Flow-controle - opsplitsen

Een split-stap verdeelt de deelnemers van de flow in 2 of meer takken op basis van één of meerdere voorwaarden. Dit maakt het mogelijk om alternatieve paden te gebruiken en deelnemers anders te behandelen op basis van contactgegevens of betrokkenheid.

Je kunt differentiëren op basis van:

* Bedrijfs-/contactgegevens
* Formulierindiening
* Formuliergegevens
* Geklikte link (gevolgde)
* Lidmaatschap in project
* Lidmaatschap in statische selectie

## Hoe het werkt

Wanneer de deelnemer bij de split komt, wordt eerst de voorwaarde van de **linker** tak geëvalueerd. Ze kunnen maar één pad volgen. Als er een overeenkomst is, gaan ze naar de volgende stap van die tak. Dan wordt de volgende voorwaarde van de andere tak gecontroleerd, enzovoort. Alle splits hebben een tak voor iedereen die niet aan een van de voorwaarden voldoet.

## Stappen

1. Sleep de **Opsplitsen**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.
1. Voer een beschrijvende **titel** in.

    > [!TIP]
    > Een beschrijvende titel en taknamen maken de flow gemakkelijker te lezen.

1. Kies waarop de split moet worden gebaseerd. Sommige opties vereisen dat je hier aanvullende details verstrekt.
1. Geef de nieuwe tak een naam.
1. Stel criteria in voor de specifieke tak. De opties zijn afhankelijk van waarop de split is gebaseerd.
1. Voeg optioneel meer takken toe en herhaal stap 4-5.
1. Kies of deelnemers die niet aan de criteria voldoen de flow moeten verlaten.
1. Ga door met het toevoegen van stappen aan elke tak.

Alle anderen gaan door:

![Marketing automatisering: flow opsplitsen basis van contactgegevens -screenshot][img1]

Alle anderen verlaten:

![Marketing automatisering: flow opsplitsen basis van contactgegevens -screenshot][img2]

> [!NOTE]
> Je kunt de tak "alle anderen" niet verwijderen.

### Split op basis van contactgegevens

Wanneer je ervoor kiest om deelnemers te splitsen op basis van contactgegevens, kun je kiezen uit de persoon- en bedrijfscriteria die beschikbaar zijn in **Persoon zoeken**.

* Voor elke tak, [selecteer waarden voor het criterium][11] in de verschillende velden op de lijn (vergelijkbaar met in het Zoeken scherm). Klik op **Toevoegen** om meer criteria in te voegen.

![Marketing automatisering: flow opsplitsen basis van bedrijfsgegevens -screenshot][img3]

### Split op basis van geklikte link

Wanneer geselecteerd, verschijnt er een veld om aan te geven welke e-mail verschijnt.

* E-mail: Kies **Elke e-mail** of een specifieke mailing.
* Voor elke tak, selecteer welke [gevolgde link][7] de deelnemer moet klikken om deze tak in te gaan.

![Marketing automatisering: flow opsplitsen basis van geklikte link -screenshot][img4]

### Split op basis van formulier ingediend ja/nee

Wanneer geselecteerd, verschijnt er een veld om aan te geven welk formulier wordt weergegeven.

* Formulier: Kies een specifiek formulier.

![Marketing automatisering: flow opsplitsen basis van ingediend formulier -screenshot][img5]

> [!NOTE]
> Deze split is onafhankelijk van de ingediende formuliergegevens. Er zijn geen tak-specifieke instellingen. Omdat dit een ja/nee-test is, kun je geen extra takken toevoegen.

### Split op basis van formuliergegevens

Deze voorwaarde is een variant van de split op basis van ingediend formulier met extra gegevenscriteria toegepast op de tak.

Wanneer geselecteerd, verschijnt er een veld om aan te geven welk formulier wordt weergegeven.

* Formulier: Kies een specifiek formulier.
* Voor elke tak, selecteer waarden voor het criterium in de verschillende velden op de lijn (vergelijkbaar met in het Zoeken scherm). Beschikbare criteria zijn afhankelijk van de velden van het geselecteerde formulier. Klik op **Toevoegen** om meer criteria in te voegen.

![Marketing automatisering: flow opsplitsen basis van formuliergegevens (contacteer mij) -screenshot][img6]

> [!NOTE]
> In dit scenario betekent **alle anderen** zowel deelnemers die het formulier niet indienen *als* indieners die niet voldoen aan de aanvullende criteria op een van de andere takken.

### Split op basis van lidmaatschap in project

* Voor elke tak, selecteer aan welk project de deelnemer lid moet zijn.

![Marketing automatisering: flow opsplitsen basis van lidmaatschap in project -screenshot][img7]

### Split op basis van statische selectie

Vergelijkbaar met de split op basis van lidmaatschap in project.

## Succescriteria gebruikt als voorwaarde voor vroegtijdig stoppen

Succescriteria kunnen ook worden gebruikt als een voorwaarde voor vroegtijdig stoppen in de flow, waardoor vertakking niet nodig is. Voordat een actie wordt uitgevoerd op een deelnemer in een flowstap, wordt de status van de deelnemer opnieuw geëvalueerd. Deze herbeoordeling houdt rekening met de succescriteria. Als een deelnemer aan de succescriteria voldoet, wordt hun status bijgewerkt naar *Voltooid met succes*, of ze blijven *Actief* als ze de flow moeten voltooien. Bij de eindstap krijgen deelnemers die aan de succescriteria hebben voldaan de status *Voltooid met succes*.

<!-- Referenced links -->
[7]: ../../tracked-links/learn/index.md
[11]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/split-flow-contact-data-no-exit.png
[img2]: ../../../../media/loc/en/marketing/split-flow-contact-data-yes-exit.png
[img3]: ../../../../media/loc/en/marketing/split-flow-company-data-dropdown.png
[img4]: ../../../../media/loc/en/marketing/split-flow-link-clicked.png
[img5]: ../../../../media/loc/en/marketing/split-flow-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/split-flow-form-data-contact-me.png
[img7]: ../../../../media/loc/en/marketing/split-flow-project-member.png
