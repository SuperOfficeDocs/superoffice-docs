---
uid: help-nl-screen-designer-grid
title: Werken met rasters
description: Hoe u rasters toevoegt en invult in een lay-out met behulp van de Schermontwerper in Instellingen en onderhoud.
keywords: schermopmaak, raster, tabelopmaak
author: Bergfrid Dias
date: 10.09.2025
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
license: development-tools
category: customization
topic: screen designer
language: nl
index: true
redirect_from: /nl/customization/screen-designer/working-with-grids
---

# Werken met rasters

[!include[Vereiste](../../../includes/req-dev-tools.md)]

Als u veel velden heeft, kunt u een rasterelement gebruiken om ze nauwkeuriger te positioneren. Dit is een alternatief voor positioneren op basis van sorteervolgorde en kolommen.

De onderstaande instructies gaan ervan uit dat u al [het opmaak aan het bewerken bent][1].

## Raster toevoegen

1. Selecteer het tabblad waaraan u een raster wilt toevoegen.

1. Klik om het secties **Elementen** te selecteren.

1. Klik en sleep het **Raster**-element naar het opmaak.

    ![Schermontwerper rasterelement -screenshot][img1]

1. Klik om het nieuwe raster te selecteren.

1. Pas in het secties **Instellingen** links het aantal kolommen en rijen aan uw behoeften aan.

    ![Schermontwerper rasterinstellingen -screenshot][img2]

1. Kies een rasterstijl: lijnen (standaard), geen of koptekst.

## Veld toevoegen aan raster

1. Ga naar de locatie van het raster.

1. Houd de aanwijzer boven het raster en klik op het blauwe potlood.

    ![Schermontwerper raster naar bewerkingsmodus -screenshot][img3]

    Hiermee wordt het raster in bewerkingsmodus gezet, wat wordt aangegeven door een groen vinkje.

    ![Schermontwerper raster in bewerkingsmodus -screenshot][img4]

1. Zorg ervoor dat het **Velden**-secties is geselecteerd.

1. [Sleep velden uit de lijst][2] naar een cel in het raster. U kunt ook [labels][3], [links en knoppen][4] toevoegen.

    > [!TIP]
    > Tab van cel naar cel voor efficiënte invoer.

1. Wanneer u klaar bent, klikt u op het groene vinkje om het raster te vergrendelen en de normale bewerkingsmodus te hervatten.

## Rasterinhoud bewerken

1. Zet het raster in bewerkingsmodus zoals hierboven beschreven.

1. Om een veld te verplaatsen, klikt u op **=** links van het veld en sleept u het naar een nieuwe cel.

    Als u een veld in een bezette cel neerzet, worden de inhoud van de twee cellen verwisseld.

1. Om een veld te verwijderen, houdt u de aanwijzer boven de cel en klikt u op het rode omcirkelde x.

## Rasteruiterlijk bewerken

1. Selecteer het tabblad met het raster.

1. Klik op het raster in de voorbeeldweergave. Zorg ervoor dat het raster zelf niet in bewerkingsmodus staat. Klik op het groene vinkje als u het ziet.

1. Pas de afmetingen en stijl van het raster aan in het secties **Instellingen**.

> [!NOTE]
> U kunt geen specifieke rijen of kolommen verwijderen, maar u kunt wel het aantal rijen en kolommen verminderen. Wanneer u het aantal rijen vermindert, verdwijnt de **laatste rij** uit de gebruikersinterface, samen met de inhoud ervan. Wanneer u het aantal kolommen vermindert, verdwijnt de **laatste kolom**. Verplaats eerst uw velden om verrassingen te voorkomen.

## Raster verplaatsen

Om een raster te verplaatsen, klikt u op **=** links van het raster en sleept u het veld naar een nieuwe positie. Dit is vergelijkbaar met het verplaatsen van velden.

## Raster verwijderen

Als u een raster verwijdert, worden ook de inhoud ervan (velden enzovoort) verwijderd.

Deze actie beïnvloedt alleen wat in de gebruikersinterface wordt weergegeven en verandert de database of waarden op geen enkele manier.

Om een raster te verwijderen:

* Houd de aanwijzer boven het raster en klik op het rode omcirkelde x.

Om een raster te herstellen:

* Als u aan een concept werkt, verwerp dan eenvoudig het concept om al uw wijzigingen ongedaan te maken.
* Als u het opmaak na verwijdering heeft gepubliceerd, moet u het raster opnieuw maken.

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-fields.md
[3]: working-with-tabs.md#label
[4]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/new-grid.png
[img2]: ../../../../media/loc/en/customization/grid-settings.png
[img3]: ../../../../media/loc/en/customization/hover-grid.png
[img4]: ../../../../media/loc/en/customization/edit-grid.png
