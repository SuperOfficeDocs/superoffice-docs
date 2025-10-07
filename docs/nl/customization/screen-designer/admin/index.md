---
uid: help-nl-screen-designer
title: Schermontwerper
description: Kom te weten hoe u uw kaarten configureert in deze gids.
keywords: Schermontwerper, interface, opmaak, lay-out, aanpassen
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.11
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: nl
index: true
redirect_from: /nl/customization/screen-designer/index
---

# Schermontwerper <i class="ph ph-squares-four" aria-hidden="true"></i>

De **Schermontwerper** in SuperOffice CRM stelt u in staat om de opmaak van belangrijke schermen binnen de applicatie aan te passen, zodat de interface voldoet aan de specifieke behoeften van verschillende gebruikersgroepen in uw organisatie. Deze functie vervangt het oude [PageBuilder][9]-hulpmiddel en biedt een meer gestroomlijnde en flexibele manier om schermen te configureren, zonder codering.

![Schermontwerper, bedrijfskaart, standaard veldopmaak -screenshot][img5]

> [!NOTE]
> Deze functie vereist de licentie voor Development Tools en de functierechten "Veldbeheerder".

## Waarom de Schermontwerper gebruiken?

SuperOffice CRM wordt geleverd met standaardopmaken voor de Persoon-, Bedrijfs-, Verkoop-, Project- en Verzoekschermen en de Vervolgactiviteitdialoog. Verschillende teams hebben echter vaak verschillende informatiebehoeften. Met de Schermontwerper kunt u:

* Aangepaste opmaken maken die zijn afgestemd op de werkprocessen en prioriteiten van specifieke gebruikersgroepen (zoals verkoop, ondersteuning, management).

* De efficiëntie verbeteren door uw teams snel toegang te geven tot de informatie die voor hen het belangrijkst is.

* Overbodige velden verwijderen, nieuwe toevoegen en informatie opnieuw organiseren in logische groepen met behulp van tabbladen, kolommen en labels.

Als uw verkoopteam bijvoorbeeld de nadruk legt op klantinteracties, kunt u ervoor zorgen dat contactgegevens duidelijk worden weergegeven, terwijl minder relevante velden naar secundaire tabbladen worden verplaatst.

## Wat kan ik aanpassen?

Met de Schermontwerper kunt u:

* De standaardopmaak van schermen voor alle gebruikers wijzigen of aangepaste opmaken maken voor specifieke gebruikersgroepen.

* Opmaken ontwerpen die zijn geoptimaliseerd voor specifieke projecttypen, verkooptypen, aanmeldingstypen, vervolgactiviteittypen en documentsjablonen.

* Velden verbergen die nooit worden gebruikt.

* Belangrijke gegevens benadrukken door velden op te maken (bijvoorbeeld vetgedrukt of groot lettertype).

* Knoppen en koppelingen toevoegen om geautomatiseerde processen (CRMScript) of externe zoekopdrachten te starten.

* Aangepaste velden organiseren binnen het tabblad **Meer** of andere aangepaste tabbladen.

* Tabbladen toevoegen, herschikken of verwijderen indien nodig.

## Welke schermen kan ik configureren?

U kunt de volgende schermen en dialoogvensters aanpassen:

* Bedrijf
* Persoon
* Verkoop
* Project
* Verzoek
* Vervolgactiviteitdialoog
* Documentdialoog

## Hoe werken opmaken?

Opmaken in SuperOffice CRM bepalen hoe informatie aan gebruikers wordt gepresenteerd. De standaard (systeem) opmaken worden op alle gebruikers toegepast, tenzij een aangepaste opmaak is gemaakt en toegewezen aan een specifieke gebruikersgroep of typ.

* **Aangepaste opmaken**: Maak opmaken die specifiek zijn afgestemd op de behoeften van gebruikersgroepen.

* **Opmaaktoewijzing**: Opmaken voor de Verkoop-, Project- en Verzoekschermen kunnen verder worden verfijnd door ze toe te wijzen aan specifieke verkooptakken, projecttypen en verzoektypen. Evenzo kan de Vervolgactiviteitdialoog worden toegewezen aan vervolgactiviteittypen en de Documentdialoog aan documentsjablonen.

* **Opmakentatus**: Opmaken kunnen zich in de status *concept* of *gepubliceerd* bevinden. Gepubliceerde opmaken zijn toegewezen aan de bijbehorende gebruikersgroepen/typen.

![Schermontwerper concept opmaak -screenshot][img3]

![Schermontwerper gepubliceerde opmaak -screenshot][img4]

De lijst met **Opmak** toont alle bestaande opmaken, inclusief een voorbeeld van het scherm.

## Werken met de Schermontwerper

Om te beginnen met het aanpassen van schermen:

1. Open de Schermontwerper door te klikken op <i class="ph ph-list" aria-label="Main menu"></i>, **Instellingen en onderhoud** te selecteren en vervolgens **Schermontwerper** uit de navigatiebalk te kiezen.

2. Sleep velden naar de editor om ze aan uw opmaak toe te voegen.

3. Klik op een veld om het te verplaatsen of de instellingen bij te werken. De beschikbare instellingen zijn afhankelijk van het geselecteerde veldtype.

### Opmaakcomponenten

* **Velden:** Geeft alle gegevensvelden weer die beschikbaar zijn voor de geselecteerde schermopmaak. Gebruik filters om specifieke velden snel te vinden.

* **Elementen:** Bevat niet-gegevensgebonden elementen zoals labels, scheidingslijnen, koppelingen en knoppen.

* **Instellingen:** Hiermee kunt u de weergave en het gedrag van het geselecteerde veld aanpassen.

* **Tabbladindeling:** Biedt opties om velden en elementen in kolommen te rangschikken.

* **Tabbladen:** Kunnen worden toegevoegd, herschikt of verwijderd om informatie logisch te organiseren.

> [!NOTE]
> Nadat een opmaak is gepubliceerd, moeten gebruikers in de toegewezen groepen zich afmelden en opnieuw aanmelden om de wijzigingen te zien.

## Wat als ik de Schermontwerper niet gebruik?

Als u geen licentie voor Development Tools hebt, organiseert het tabblad **Meer** automatisch alle aangepaste velden in twee kolommen. Deze standaardinstelling biedt nog steeds een functionele interface, maar zonder de geavanceerde aanpassingsopties van de Schermontwerper.

## Samenvatting

Door de schermopmaken aan te passen met de Schermontwerper kunt u overbodige informatie elimineren, waardoor de interface voor uw teams schoner en efficiënter wordt. Als uw ondersteuningsteam bijvoorbeeld het bedrijfsadres niet prominent hoeft weer te geven, kunt u het verplaatsen naar een secundair tabblad, waardoor er ruimte vrijkomt voor relevantere velden.

## Gerelateerde inhoud

* [Opmaak toevoegen][2]
* [Opmaak bewerken (hoofdkaarten)][1]
* [Werken met velden][4]
* [Werken met archieven (sectietabbladen)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: working-with-fields.md
[9]: ../../../../en/ui/web-app/pagebuilder/index.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/status-draft.png
[img4]: ../../../../media/loc/en/customization/status-published.png
[img5]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
