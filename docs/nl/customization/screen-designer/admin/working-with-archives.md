---
uid: help-nl-screen-designer-archive
title: Werken met sectietabbladen (archieven)
description: Schermontwerper Opmaak bewerken - Archieven (sectietabbladen)
keywords: sectietabblad toevoegen, nieuw sectietabblad, archieftabblad toevoegen, sectietabblad aanpassen, sectietabbladopmaak
author: Bergfrid Dias
date: 10.09.2025
version: 10.2.11
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: nl
index: true
redirect_from:
  - /nl/ui/screen-designer/learn/edit-layout-archives
  - /nl/customization/screen-designer/working-with-archives
---

# Werken met sectietabbladen (archieven)

U kunt de opmaak aanpassen door sectietabbladen (ook wel archieven genoemd) toe te voegen of te verwijderen op de hoofdkaarten voor de schermen Bedrijf, Persoon, Verkoop, Project en Verzoek.

Het aanpassen van sectietabbladen gebeurt meestal om te voldoen aan de specifieke behoeften van verschillende gebruikersgroepen. U kunt een opmaak maken die is afgestemd op een specifieke gebruikersgroep, zodat de sectietabbladen relevante inhoud voor die groep tonen.

![Voeg de naam toe aan de nieuwe sectietabblad/archief opmaak en selecteer de gebruikersgroep(en) waarvoor deze moet worden weergegeven -screenshot][img6]

## Sectietabbladen begrijpen

Sectietabbladen, die zich onderaan de meeste SuperOffice CRM-schermen bevinden, tonen gerelateerde gegevens zoals personen, activiteiten, projecten en verkopen. Hoewel sommige sectietabbladen, zoals verkoopgidsen en offertes, geen archieven zijn, zullen we ze voor de eenvoud allemaal archieven of archieftabbladen noemen.

Bij het maken van een nieuw opmaak voor een gebruikersgroep, moet u overwegen welke gegevens zij het meest nodig hebben. Door archieven aan te passen, kunt u informatie filteren en prioriteren, waardoor gebruikers sneller kunnen vinden wat ze nodig hebben.

## Sectietabbladen toevoegen

U kunt op elk scherm met een sectietabbladgebied een nieuw tabblad toevoegen. Afhankelijk van het gekozen scherm kunt u een nieuw tabblad toevoegen met de inhoud: document, afspraak, product, project, projectlid, verkoop, belanghebbenden, verzoek, persoon en relatie.

![Selecteer het type inhoud dat u in het sectietabblad wilt weergeven -screenshot][img5]

**Stappen:**

1. Open de Schermontwerper.

1. Kies bovenaan een scherm om aan te passen en klik op **Archieven**.

1. Selecteer een opmaak uit de lijst en klik op **Opmaak bewerken** onder de voorbeeldweergave.

1. Klik op **Toevoegen** om het secties **Tabblad** te openen.

1. Vervang "Nieuw tabblad" door de naam van het archief en voer een beschrijving in voor het nieuwe tabblad. Optioneel kunt u op <i class="ph ph-translate" aria-label="Translate"></i> klikken om de teksten in andere talen toe te voegen.

1. Pas de **Unieke naam voor tabblad** (soprotocol) indien nodig aan.

1. Selecteer in de sectie **Instellingen** het gegevenstype (inhoud) dat in het archief moet worden weergegeven.

    Gegevens zijn beperkt tot het huidige scherm. Als u bijvoorbeeld een archief toevoegt aan het Bedrijfsscherm, worden alleen gegevens getoond die aan het **huidige** bedrijf zijn gekoppeld.

1. Voeg criteria toe of bewerk ze onder **Filter** om de weergegeven gegevens te verfijnen. Deze criteria werken vergelijkbaar met de [zoekfilters in het **Zoeken**-scherm][2] en in selecties.

    Klik op **Voorbeeldweergave bijwerken** om de gefilterde gegevens te zien.

1. (Optioneel) Gebruik **Geavanceerde opties** om acties voor enkele klikken en dubbele klikken aan te passen. Standaard selecteert een enkele klik een rij en opent een dubbele klik een record/entiteit in SuperOffice.

    > [!TIP]
    > Houd de muisaanwijzer boven het informatiepictogram <i class="ph ph-info" aria-label="Info"></i> voor voorbeelden.

1. Sleep het archief naar de gewenste positie in de voorbeeldweergave.

1. Selecteer **Concept opslaan** of **Opslaan + Publiceren** om uw wijzigingen op te slaan. Klik op **Annuleren** om uw wijzigingen te annuleren.

## Bestaand sectietabblad bewerken

Om een bestaand archief te bewerken, selecteert u het en werkt u de velden en instellingen bij in de secties **Tabblad** en **Instellingen**. U kunt het tabblad ook verplaatsen door het naar een nieuwe positie te slepen.

### Beperkingen

* Standaardtabbladen kunnen niet worden bewerkt.

* Sommige tabbladen, zoals **Offerte**, **Verkoopgids** en **Projectgids**, kunnen niet worden bewerkt, omdat ze specifieke functies hebben.

## Sectietabblad verwijderen

1. Selecteer het archief of sectietabblad.

1. Klik op **Taak** > **Tabblad verwijderen**.

1. Bevestig door op **OK** te klikken. Het tabblad wordt verborgen, maar niet verwijderd.

![Klik op Taak en vervolgens op Tabblad verwijderen om ongewenste tabbladen in het sectietabblad (archief) te verwijderen -screenshot][img1]

Om deze wijzigingen ongedaan te maken, klikt u op **Tabbladen herstellen**.

## Gerelateerde inhoud

* [Nieuw opmaak maken][4]

<!-- Referenced links -->
[2]: ../../../search-options/learn/search-criteria.md
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive-add-tab.png
[img6]: ../../../../media/loc/en/customization/admin-screendesigner-add-archive-layout.png
