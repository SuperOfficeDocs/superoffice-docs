---
uid: help-nl-request-relations
title: Verzoekrelaties
description: Leer hoe u gerelateerde verzoeken kunt koppelen met behulp van bovenliggende, onderliggende en gerelateerde relaties om verbonden problemen in SuperOffice Service beter te volgen en te beheren.
keywords: verzoekrelaties, verzoeken koppelen, bovenliggend verzoek, onderliggend verzoek, gerelateerde verzoeken
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
category: service
topic: request
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: nl
---

# Verzoekrelaties

Met verzoekrelaties kunt u verzoeken koppelen om verbindingen tussen problemen weer te geven. Dit is handig wanneer meerdere verzoeken gerelateerd zijn aan hetzelfde probleem, wanneer een verzoek afhankelijk is van een ander, of wanneer u hiërarchische verbindingen tussen verzoeken moet volgen.

> [!NOTE]
> Verzoekrelaties worden gebruikt om verzoeken aan andere verzoeken te koppelen. Om relaties tussen bedrijven en personen te definiëren, zie [Bedrijfs- en persoonsrelaties][4].

## Relatietypen

Er zijn drie soorten verzoekrelaties:

* **Gerelateerd:** Een niet-hiërarchische verbinding tussen verzoeken.

* **Bovenliggend:** Een verzoek dat een of meer onderliggende verzoeken heeft.

* **Onderliggend:** Een verzoek dat gekoppeld is aan een bovenliggend verzoek. Elk verzoek kan slechts één bovenliggend verzoek hebben.

## Gebruikssituaties

Gebruik **gerelateerd** wanneer verzoeken verbonden zijn maar geen hiërarchie hebben.

**Meerdere klanten melden hetzelfde probleem**
Wanneer verschillende klanten onafhankelijk van elkaar hetzelfde probleem melden, koppelt u de verzoeken als gerelateerd. Dit biedt een plat overzicht van alle getroffen klanten en helpt een consistente communicatie te garanderen.

**Verzoeken met meerdere vragen**
Als een verzoek niet-gerelateerde vragen bevat, splits het dan in afzonderlijke verzoeken voor elke afdeling. Koppel ze vervolgens als gerelateerd om te tonen dat ze uit dezelfde context afkomstig zijn.

Gebruik **bovenliggend en onderliggend** wanneer verzoeken een hiërarchische of afhankelijkheidsrelatie hebben.

**Incidentbeheer met oorzaakaanalyse**
Maak een bovenliggend verzoek om het onderliggende probleem te volgen. Koppel elk klantrapport als onderliggend verzoek. Een bovenliggend verzoek kan meerdere onderliggende verzoeken hebben, maar elk verzoek kan slechts één bovenliggend verzoek hebben.

**Omgaan met afhankelijkheden**
Wanneer één verzoek moet worden opgelost voordat een ander kan worden voltooid, koppelt u ze met behulp van een bovenliggende-onderliggende relatie om de afhankelijkheid duidelijk te tonen.

## Verzoekrelaties weergeven

Wanneer een verzoek een of meer relaties heeft, kunt u deze zien op het tabblad **Relaties** in het verzoekscherm.

### Archiefweergave

De standaardweergave toont relaties als een lijst met de volgende kolommen:

* Verzoek-ID
* Titel
* Laatst gewijzigd
* Eigenaar
* Status
* Relatietype

![Verzoekrelaties in lijstweergave -screenshot][img1]

### Boomstructuurweergave

Klik op **Boomstructuurweergave** om relaties in een hiërarchische structuur weer te geven, waardoor bovenliggende-onderliggende relaties gemakkelijker te visualiseren zijn:

![Verzoekrelaties in boomstructuurweergave -screenshot][img2]

> [!TIP]
> Het tabblad **Relaties** toont een oranje indicator wanneer het verzoek een of meer relaties heeft, waardoor gekoppelde verzoeken in één oogopslag gemakkelijk te identificeren zijn.

### Verschillende perspectieven

Relaties zijn bidirectioneel. Beide verzoeken in de relatie tonen de verbinding:

* Als Verzoek A **bovenliggend** is van Verzoek B, zal Verzoek B Verzoek A als zijn bovenliggende verzoek weergeven
* Als Verzoek A **gerelateerd** is aan Verzoek B, zal Verzoek B weergeven dat het gerelateerd is aan Verzoek A

![Dezelfde relatie bekeken vanuit het gerelateerde verzoek -screenshot][img3]

## <a id="add"></a>Verzoekrelatie toevoegen

U kunt een relatie toevoegen vanaf de volgende locaties:

### Vanaf het verzoekscherm

1. Open het verzoek dat u wilt koppelen.

1. Selecteer het tabblad **Relaties**.

1. Klik op **Nieuwe relatie**.

1. Selecteer in het veld **Type relatie** **Gerelateerd**, **Bovenliggend** of **Onderliggend**.

1. Selecteer in de sectie **Koppeling naar** de optie **Koppeling naar bestaande** (standaard).

1. Begin met typen in het zoekveld om het verzoek te vinden dat u wilt koppelen. U kunt zoeken op verzoek-ID, titel, bedrijf of persoon.

1. Selecteer het verzoek uit de lijst. U kunt de cursor boven een verzoek in de lijst houden om een voorvertoning van de details te bekijken.

1. Voeg optioneel een opmerking toe die de relatie uitlegt.

1. Klik op **Koppelen** om de verbinding te maken.

### Vanuit het sectietabblad Verzoeken

1. Ga naar een Bedrijfs-, Persoons-, Verkoop- of Projectscherm.

1. Selecteer het sectietabblad **Verzoeken**.

1. Klik met de rechtermuisknop op het verzoek waarvan u een relatie wilt maken.

1. Selecteer **Relaties** in het contextmenu.

1. Volg stappen 4-9 hierboven om de relatie te voltooien.

![Contextmenu met optie Relaties -screenshot][img4]

## Nieuw verzoek als relatie maken

In plaats van te koppelen aan een bestaand verzoek, kunt u een nieuw verzoek maken terwijl u de relatie tot stand brengt:

1. Volg de bovenstaande stappen om het dialoogvenster **Relaties** te openen.

1. Selecteer in de sectie **Koppeling naar** de optie **Nieuw verzoek maken**.

1. Vul de verzoekdetails in.

1. Klik op **Koppelen** om zowel het nieuwe verzoek als de verbinding tegelijkertijd te maken.

## <a id="delete"></a>Verzoekrelatie verwijderen

1. Open het verzoek en selecteer het tabblad **Relaties**.

1. Zoek de relatie die u wilt verwijderen.

1. Klik onderaan het dialoogvenster op <i class="ph ph-x-circle" aria-label="Verwijderen-pictogram"></i> **Relatie verwijderen**, of klik met de rechtermuisknop op de relatie en selecteer **Relatie verwijderen**.

1. Bevestig de verwijdering.

Het verwijderen van een relatie verwijdert alleen de koppeling. De verzoeken blijven ongewijzigd.

## Probleemoplossing

### Knop Relatie verwijderen kan niet worden aangeklikt

De knop **Relatie verwijderen** is alleen actief wanneer u precies één relatie hebt geselecteerd. Zorg ervoor dat u:

* Een enkele relatie uit de lijst hebt geselecteerd
* Niet meerdere relaties hebt geselecteerd

### Kan geen bovenliggende of onderliggende relatie toevoegen

**Oorzaak:** Een verzoek kan slechts één bovenliggend verzoek hebben. Als het verzoek al een bovenliggend verzoek heeft, kunt u geen andere bovenliggende relatie toewijzen.

**Oplossing:** Verwijder eerst de bestaande bovenliggende relatie, of gebruik in plaats daarvan een **Gerelateerd** relatietype, dat meerdere verbindingen toestaat.

### Kan geen relatie maken

**Mogelijke oorzaken:**

* **Dubbele relatie:** De twee verzoeken zijn al gekoppeld. Controleer het tabblad Relaties om te zien of de relatie al bestaat.
* **Circulaire hiërarchie:** U kunt geen bovenliggende-onderliggende relatie maken die zou resulteren in een circulaire referentie (bijv. Verzoek A is het bovenliggende van Verzoek B en Verzoek B is het bovenliggende van Verzoek A).

**Oplossing:** Controleer bestaande relaties en pas uw hiërarchiestructuur aan om circulaire afhankelijkheden te voorkomen.

## Gerelateerde inhoud

* [Verzoek splitsen][2]
* [Verzoeken samenvoegen][1]
* [Sectietabblad Verzoeken][3]
* [Bedrijfs- en persoonsrelaties][4]

<!-- Referenced links -->
[1]: merge.md
[2]: split-request.md
[3]: ../../learn/section-tabs/requests-tab.md
[4]: ../../learn/basics/relations.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/request-relations-archive.png
[img2]: ../../../media/loc/en/request/request-relations-tree.png
[img3]: ../../../media/loc/en/request/request-relations-perspective.png
[img4]: ../../../media/loc/en/request/request-relations-context-menu.png
