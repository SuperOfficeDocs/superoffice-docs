---
uid: help-nl-sale-add-type
title: Verkooptype toevoegen
description: Verkooptype toevoegen
author: SuperOffice RnD
date: 06.29.2022
keywords: verkooptype
topic: howto
language: nl
---

# Verkooptype toevoegen

[!include[Must be admin](../../../learn/includes/req-admin.md)]

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

> [!NOTE]
> Een offerte hoort bij een verkoop en alle verkopen hebben een verkooptype. In elk verkooptype kunt u veel eigenschappen van de offerte definiëren, zoals bijlagen, goedkeuringsinstellingen, gebruik van alternatieven en sjablonen.

[!include[Edit list item](includes/edit-list-item.md)] wanneer de lijstitems verkooptypen zijn:

1. Typ de gewenste naam voor het item in het veld **Naam**.

    [!include[Mandatory](includes/note-mandatory-field.md)]

2. Selecteer de gewenste categorie voor het verkooptype in de keuzelijst **Categorie verkooptype**.

    > [!TIP]
    > U kunt nieuwe opties maken en toevoegen aan de vooraf gedefinieerde opties door [items toe te voegen][2] aan de lijst **Verkoop - Categorie (voor verkooptype)** in Instellingen en onderhoud.

3. Voer in **Geschatte duur van dit verkoopproces** een duur in voor het verkooptype (aantal weken, dagen of maanden). Wanneer u een nieuwe verkoop van dit verkooptype maakt, wordt de verkoopdatum ingesteld in relatie tot de tijd die u hier invoert (de datum van vandaag + geschatte tijdsduur).

4. Geef een beschrijving op van het verkooptype onder aan het dialoogvenster.

5. Geef informatie op in de tabbladen **Fasen**, **Offertebijlagen**, **Offertestandaarden** en **Offertegoedkeuring**. Dit wordt hieronder beschreven.

    > [!NOTE]
    > De tabbladen **Offertebijlagen**, **Offertestandaarden** en **Offertegoedkeuring** zijn alleen relevant als u de licentie Verkoopoffertebeheer hebt.

6. [!include[Save or cancel](includes/save-or-cancel.md)]

## Tabblad Fasen

Op het tabblad **Fasen** doet u het volgende:

1. Schakel in de lijst **Fasen die worden gebruikt voor dit verkooptype** de fasen in die u voor het verkooptype wilt opnemen. Deze stap is optioneel, maar als u het verkooptype aan een verkoopgids wilt koppelen, moet u ten minste twee fasen inschakelen.

    [Een fase maken][3].

2. Schakel **Dit verkooptype is gekoppeld aan een handleiding** in als u wilt dat alle verkopen van dit verkooptype een [verkoophandleiding][5] volgen.

3. U kunt zo nodig de optie **Voorstellen de verkoop automatisch naar de volgende fase te verplaatsen** selecteren.

    Wanneer alle vervolgactiviteiten en documenten voor een fase zijn voltooid, wordt u gevraagd of u naar de volgende fase wilt gaan.

4. Schakel de optie **Dit verkooptype heeft belanghebbenden** om het koppelen van [belanghebbenden][4] aan verkopen van dit verkooptype toe te staan.

## Tabblad Offertebijlagen

Op het tabblad **Offertebijlagen** kunt u documenten toevoegen die u samen met de offerte naar de klant wilt verzenden. Bijvoorbeeld productspecificaties, brochures enz.

> [!NOTE]
> De documenten moeten eerst als documentsjablonen worden toegevoegd in SuperOffice.

### Een offertebijlage bijvoegen

1. Klik op **Toev.**
2. Zoek in het scherm Zoeken [naar de documenten die u wilt toevoegen][1].
3. Selecteer een of meer documenten en klik op **OK**. De documenten worden weergegeven op het tabblad **Offertebijlagen**.
4. Selecteer de documenten die u wilt invoegen in de kolom **Bijvoegen**.

Wanneer u een offerte maakt met dit verkooptype, worden de geselecteerde documenten toegevoegd aan de offerte als bijlagen. Ze worden echter niet toegevoegd in het sectietabblad **Activiteiten** van de verkoop.

## Offertestandaarden

Instellingen voor offertes met dit verkooptype:

* **Toevoegen alternatieven aan offerte toestaan**: selecteer deze optie als gebruikers wordt toegestaan verschillende alternatieven toe te voegen aan een offerte.
* **Standaardaantal dagen dat een offerte geldig is**: geef het aantal dagen op dat een offerte geldig blijft. Deze waarde kan worden gewijzigd wanneer de offerte is verzonden.
* **Sjabloon offerte-opmaak**: selecteer de sjabloon die u wilt gebruiken voor de offerte.
* **Opdrachtbevestigingssjabloon**: selecteer de sjabloon die u wilt gebruiken voor de bevestiging.

## Offertegoedkeuring

Hier kunt u kiezen of de offerte moet worden goedgekeurd als de totaalkorting boven een bepaalde grenswaarde uitkomt of als het winsttotaal onder een bepaalde grenswaarde ligt:

* Geen goedkeuring nodig. Geen limieten. De offerte behoeft geen goedkeuring.
* **Totaalkorting ligt boven limiet**. Voer een geldig percentage in.
* **Winsttotaal ligt onder limiet**. Voer een geldig percentage in.

## Gerelateerde inhoud

* [Offertesjablonen][6]

<!-- Referenced links -->
[2]: adding-items.md
[3]: ../../../sale/learn/screen/sale-stage.md
[4]: ../../../sale/learn/stakeholders/index.md
[5]: ../../../sale/learn/screen/sales-guide-admin.md
[1]: ../../../search-options/learn/search-criteria.md
[6]: ../../../document/templates/learn/quote-templates.md

<!-- Referenced images -->
