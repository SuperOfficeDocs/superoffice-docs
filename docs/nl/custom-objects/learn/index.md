---
uid: help-nl-custom-objects
title: Aangepaste objecten  en velden
description: Aangepaste objecten en velden
keywords: aangepast object, veld
author: Bergfrid Dias
date: 06.10.2026
version: 12.0
content_type: concept
license: devtools
tier: core
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Aangepaste objecten en velden

Alle bedrijven en organisaties hebben hun eigen eisen voor de informatie die ze moeten registreren met betrekking tot hun contacten, verkopen, projecten, contracten, enzovoort. Beheerders kunnen velden en tabellen toevoegen in SuperOffice om het type informatie dat kan worden geregistreerd aan te passen.

SuperOffice CRM en Service waren ooit twee aparte toepassingen met verschillende uitbreidingsmogelijkheden. [**Gebruikersgedefinieerde velden**][1] (kortweg udefs) horen thuis in SuperOffice CRM, terwijl [**extra tabellen**][3] (ook wel 3rd party-tabellen genoemd) en [**extra velden**][2] thuis horen in Service. De term **aangepast veld** omvat zowel gebruikersgedefinieerde velden als extra velden.

## Gebruik

* Een goed voorbeeld van een aangepast veld dat je kunt gebruiken op het scherm **Contact** is een veld genaamd "Tevreden klant", waar de waarde van het veld Ja of Nee is. Je kunt bijvoorbeeld je klanten een mailing sturen (met linkacties) waarin ze kunnen aangeven of ze tevreden zijn met je diensten. Dit geeft je waardevol inzicht in het algemene klanttevredenheidspercentage.

* Met de **Zoeken**-functie kun je zoeken naar de informatie die je registreert in aangepaste velden en selecties maken. Bijvoorbeeld, als je de verloopdatum van de onderhoudsovereenkomst registreert die je hebt met klanten, kun je een dynamische selectie maken die de klanten toont waarvoor de overeenkomst binnen minder dan een maand verloopt.

* Je kunt de informatie uit deze velden hergebruiken in documenten en e-mails als **sjabloonvariabelen**. Elk veld dat je toevoegt krijgt zijn eigen unieke ID (Prog ID), die in documenten kan worden gebruikt om contactspecifieke informatie samen te voegen. Dus als je een e-mail naar je klanten wilt sturen waarin staat dat hun onderhoudsovereenkomst binnenkort verloopt, kun je de sjabloonvariabele voor de verloopdatum gebruiken om de juiste verloopdatum van hun overeenkomst in het bericht weer te geven.

## Vereisten

[!include[License requirement](../../includes/req-dev-tools-transition.md)]

> [!NOTE]
> **CRM Suite (Growth-abonnement):** Uw abonnement bevat een limiet op het aantal aangepaste objecten. Wanneer de limiet is bereikt, is het aanmaken van extra objecten geblokkeerd. Zie [Plangrenzen][13] voor meer informatie.

Velden worden automatisch weergegeven op het [tabblad Meer][12] zodra ze zijn toegevoegd.

## Layout (positionering van velden)

Eventuele aangepaste schermindelingen (gemaakt in de Schermontwerper) kunnen de instellingen voor individuele aangepaste velden overschrijven.

Als u geen **Core**-plan heeft, gebruikt u de rang van de verschillende velden om ze te sorteren op het tabblad **Meer**.

## Gerelateerde inhoud

* [Brukerdefinerte felt][1]
* [Ekstrafelt][2]
* [Ekstra tabeller][3]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[12]: more-tab.md
[13]: ../../admin/license/crm-suite.md

<!-- Referenced images -->
