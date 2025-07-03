---
uid: help-nl-sale-add-type
title: Verkooptype toevoegen
description: Leer hoe u verkooptypen kunt toevoegen en beheren in SuperOffice CRM. Definieer verkoopfasen, koppel verkoopgidsen en stel offerte-instellingen in voor een gestroomlijnd verkoopproces.
keywords: verkooptype toevoegen, verkooptype, verkoop, offerte, fase, verkoopgids, lijst Verkoop - Type Fasen Offerte
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from:
  - /nl/admin/lists/learn/sale-type
  - /nl/sale/learn/screen/sales-type-for-stages
index: true
---

# Verkooptype toevoegen

[!include[Must be admin](../../learn/includes/req-admin.md)]

Het veld **Verkooptype** in het scherm Verkoop categoriseert verkopen en bepaalt hun workflows. Deze typen zijn vooraf gedefinieerd in de lijst **Verkoop - Type, Fasen, Offerte**, die u kunt beheren in **Instellingen en onderhoud** onder **Lijsten**.

Elke verkoop moet een verkooptype hebben, en deze types kunnen worden gekoppeld aan specifieke [verkoopfasen][1] en optioneel aan een [verkoopgids][4]. Verkoopgidsen helpen bij het stroomlijnen van het proces door verkopers door vooraf gedefinieerde fasen, vervolgactiviteiten en documenten te begeleiden.

## Een verkooptype toevoegen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de navigator.

1. Selecteer **Verkoop - Type, Fasen, Offerte** in het dropdownmenu. Het tabblad **Items** toont alle bestaande verkooptypen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

    ![Dialoogvenster Lijstitem bewerken voor verkooptypeconfiguratie -screenshot][img1]

1. Voer in het veld **Naam** een naam in voor het verkooptype. *(Verplicht)*

    Deze naam wordt weergegeven in het veld **Verkooptype** op de verkoopkaart.

1. Selecteer de juiste categorie in de lijst **Categorie verkooptype**.

    > [!TIP]
    > U kunt nieuwe opties toevoegen in de lijst **Verkoop - Categorie (voor verkooptype)**.

1. Geef de verwachte duur van het verkoopproces op in het veld **Geschatte duur van dit verkoopproces** (weken, dagen of maanden).

    Dit bepaalt de standaard einddatum bij het aanmaken van een verkoop.

1. In het tabblad **Fasen** selecteert u de fasen die voor dit verkooptype gelden in de lijst **Fasen die worden gebruikt voor dit verkooptype**.

    > [!NOTE]
    > Om het verkooptype aan een verkoopgids te koppelen, moet u ten minste twee fasen selecteren.

1. *(Optioneel)* Vink **Dit verkooptype is gekoppeld aan een gids** aan om het verkooptype te koppelen aan een [verkoopgids][4].

1. *(Optioneel)* Vink **Voorstellen de verkoop automatisch naar de volgende fase te verplaatsen** aan om gebruikers te vragen naar de volgende fase te gaan zodra alle activiteiten in de huidige fase zijn voltooid.

1. *(Optioneel)* Vink **Dit verkooptype heeft belanghebbenden** aan om [belanghebbenden][5] te kunnen koppelen aan verkopen van dit type. *(Vereist een SalesPremium-licentie.)*

1. Voeg indien nodig een beschrijving van het verkooptype toe in het veld **Beschrijving**.

1. Voor offertebeheer configureert u de velden in de tabbladen **Offertebijlagen**, **Offertestandaarden** en **Offertegoedkeuring**, zoals beschreven in [Toelichting op offertevelden](#quote-fields). *(Vereist een SalesPremium-licentie.)* Deze instellingen stellen u in staat offertes af te stemmen op de behoeften en processen van uw organisatie.

1. Klik op **Opslaan** om de wijzigingen toe te passen of op **Annuleren** om ze te negeren.

1. In de lijst **Fasen die worden gebruikt voor dit verkooptype**, vinkt u de fasen aan die u voor dit verkooptype wilt opnemen. Deze stap is optioneel, maar als u het verkooptype aan een verkoopgids wilt koppelen, moet u ten minste twee fasen selecteren.

## <a id="quote-fields"></a>Toelichting op offertevelden

Een offerte behoort tot een verkoop en elke verkoop heeft een verkooptype. In elk verkooptype kunt u eigenschappen van een offerte definiëren, zoals bijlagen, goedkeuringsinstellingen, gebruik van alternatieven en sjablonen.

<!-- markdownlint-disable MD051 -->
### [Tabblad Offertebijlagen](#tab/quote-attachment)

Op het tabblad **Offertebijlagen** kunt u documenten toevoegen die samen met de offerte naar de klant worden verzonden, zoals productspecificaties of brochures.

> [!NOTE]
> De documenten moeten eerst worden toegevoegd als documentsjablonen in SuperOffice.

#### Een offertebijlage toevoegen

1. Klik op **Toevoegen**.
1. In het dialoogvenster **Zoeken**, [zoek naar de documenten die u wilt toevoegen][7].
1. Selecteer een of meer documenten en klik op **OK**. De documenten worden weergegeven op het tabblad **Offertebijlagen**.
1. Selecteer de documenten die u wilt bijvoegen in de kolom **Bijvoegen**.

Wanneer een offerte met dit verkooptype wordt aangemaakt, worden de geselecteerde documenten als bijlagen toegevoegd. Ze verschijnen echter niet op het sectietabblad **Activiteiten** van de verkoop.

### [Tabblad Offertestandaarden](#tab/quote-defaults)

Op het tabblad **Offertestandaarden** kunt u de volgende instellingen configureren:

* **Toevoegen van alternatieven aan offerte toestaan:** Hiermee kunnen meerdere alternatieven in een enkele offerte worden opgenomen.
* **Standaardaantal dagen dat een offerte geldig is:** Bepaal het aantal dagen dat een offerte geldig blijft. Deze waarde kan worden aangepast wanneer de offerte wordt verzonden.
* **Sjabloon voor offerte-opmaak:** Kies een sjabloon voor de offerte.
* **Sjabloon voor orderbevestiging:** Kies een sjabloon voor orderbevestigingen.

### [Tabblad Offertegoedkeuring](#tab/quote-approval)

Op het tabblad **Offertegoedkeuring** kunt u bepalen of offertes goedkeuring vereisen onder bepaalde voorwaarden:

* **Geen goedkeuring nodig:** Geen limieten, de offerte kan zonder goedkeuring worden verzonden.
* **Totaalkorting is boven limiet:** Geef een percentage op waarbij goedkeuring vereist is als de korting deze limiet overschrijdt.
* **Totale winst is onder limiet:** Geef een percentage op waarbij goedkeuring vereist is als de winst onder deze limiet valt.

***
<!-- markdownlint-enable MD051 -->

## Een verkooptype bewerken of verwijderen

1. Volg stappen 1–2 van **Een verkooptype toevoegen** om de lijst **Verkoop - Type, Fasen, Offerte** te openen.

1. Om te bewerken:
    * Dubbelklik op het gewenste verkooptype om het dialoogvenster **Lijstitem bewerken** te openen.
    * Pas de velden aan en klik op **Opslaan**.

1. Om te verwijderen:
    * Selecteer het verkooptype in de lijst en klik op **Verwijderen**.

    > [!CAUTION]
    > Het verwijderen van een verkooptype verwijdert ook de koppeling met fasen en verkoopgidsen. Controleer of het niet actief in gebruik is voordat u het verwijdert.

## <a id="restore"></a>Een verwijderd verkooptype herstellen

Als een verkooptype is verwijderd, kunt u het herstellen in de lijst **Verkoop - Type, Fasen, Offerte**. Let op: herstellen herstelt niet automatisch de koppelingen met verkoopfasen of verkoopgidsen. U moet deze handmatig opnieuw instellen.

1. Ga naar de lijst **Verkoop - Type, Fasen, Offerte**.

1. Vink onderaan **Verwijderde items en koppen tonen** aan. Verwijderde items verschijnen doorgestreept in het tabblad **Items**.

1. Dubbelklik op het verwijderde item dat u wilt herstellen. Het dialoogvenster **Lijstitem bewerken** wordt geopend.

1. Klik op **Herstellen**.

1. Werk indien nodig de velden bij en klik op **Opslaan**. Het item is nu actief en verschijnt weer in de lijst.

## Gerelateerde inhoud

* [Een verkoopfase toevoegen][1]
* [Een verkoopgids maken][2]
* [Een verkoopgids bewerken][3]
* [Offertesjablonen beheren][6]

<!-- Referenced links -->
[1]: sale-stage.md
[2]: create-sales-guide.md
[3]: edit-sales-guide.md
[4]: ../learn/sales-guides.md
[5]: ../learn/stakeholders/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/edit-sale-type.png
