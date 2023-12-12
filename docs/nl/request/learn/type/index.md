---
uid: help-nl-request-type
title: Verzoektypen
description: Verzoektypen
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: verzoek, type
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Verzoektypen

Alle verzoeken die zijn geregistreerd in SuperOffice hebben een type. De standaardtype is "Request". Om verzoektypes te bekijken, toe te voegen, bij te werken en te verwijderen, ga naar **Instellingen en onderhoud**.

> [!NOTE]
> Deze functie vereist een Service Premium gebruikersplan (om verzoektypes te maken en bij te werken) en een Development Tools licentie om schermopmaak te definiëren op basis van verzoektypes in de Screen Designer. (Alleen beschikbaar in pilot.)

## Waarom verzoektypen gebruiken?

Het belangrijkste voordeel van verzoektypes is efficiënte ondersteuning. Een specifiek verzoektype richt zich op een reeks attributen die nodig zijn voor een specifiek proces.

## Voorbeeld

Het financiële team gebruikt verzoeken om inkomende factuurclaims te beheren, waarbij de zichtbaarheid van het factuurnummer als aangewezen veld noodzakelijk is. Daarentegen gebruikt het verkoopteam verzoeken om inkomende leads aan te pakken. In gevallen waarin een verzoek betrekking heeft op een lead, heeft het factuurnummer geen relevantie en moet volledig worden weggelaten uit het zicht.

## Waar kan ik de verzoektypen vinden?

* In **Instellingen en onderhoud**, selecteer **Verzoeken** in de navigator en vervolgens het tabblad **Verzoektypen**.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Instellingen

| Instelling | Beschrijving |
|---|---|
| Naam | De naam van het verzoektype. |
| Beschrijving | Legt het doel van het verzoektype uit.|
| Pictogram | Wordt gebruikt als visueel label om het type aan te geven. Kies uit een set vooraf gedefinieerde opties. Standaard: ticketpictogram.|
| Als standaard gebruiken | Geeft aan of dit het standaardtype is voor nieuwe verzoeken. |
| Beschikbare statussen | Een subset van verzoekstatussen die relevant zijn voor dit type. Gebruikt om de keuzelijst in de gebruikersinterface te filteren. Een leeg veld betekent dat alle statussen beschikbaar zijn. |
| Standaardstatus | De [status][4] die wordt ingesteld wanneer een agent een nieuw verzoek creëert. Heeft voorrang op andere voorkeuren. Verplicht als **Beschikbare statussen** zijn ingesteld. |
| Beschikbare prioriteiten | Een subset van verzoekprioriteiten die relevant zijn voor dit type. Gebruikt om de keuzelijst in de gebruikersinterface te filteren. Een leeg veld betekent dat alle prioriteiten beschikbaar zijn. |
| Standaardprioriteit | De [prioriteit][3] die wordt ingesteld wanneer een agent een nieuw verzoek creëert. Heeft voorrang op andere voorkeuren. Verplicht als **Beschikbare prioriteiten** zijn ingesteld. |
| Antwoordsjabloon | Het [antwoordsjabloon][5] dat wordt gebruikt wanneer een agent antwoordt op een verzoek van dit type. |

## Gerelateerde inhoud

* [Verzoektype aanmaken][1]
* [Verzoektype verwijderen][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
