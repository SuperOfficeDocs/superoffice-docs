---
uid: help-nl-screen-designer-fields
title: Werken met velden
description: Hoe u velden toevoegt, verplaatst en verwijdert in een lay-out met behulp van de Schermontwerper in Instellingen en onderhoud.
keywords: veld toevoegen, nieuw veld, veld verplaatsen, veld verwijderen, veld verbergen, opmaak bewerken, veldinstellingen
author: Bergfrid Dias
date: 10.09.2025
version: 10
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: nl
index: true
redirect_from: /nl/customization/screen-designer/working-with-fields
---

# Werken met velden

[!include[Vereiste](../../../includes/req-dev-tools.md)]

Labels en velden vertegenwoordigen de essentiële inhoud van een scherm. Of u nu een nieuwe opmaak maakt of een bestaande wijzigt, begin met klikken op **Opmaak bewerken**. [Laat me de gedetailleerde stappen zien.][1] Wanneer u klaar bent, **sla het opmaak op of publiceer het**.

> [!TIP]
> U kunt overwegen [tabbladen toe te voegen of te verwijderen][2] voordat u de velden fijn afstemt.

![Schermontwerper, bedrijfskaart, standaard veldopmaak -screenshot][img1]

De lijst met velden op een scherm bevat alle standaard SuperOffice-velden voor dat gebied, plus alle aangepaste velden (zowel gebruikersgedefinieerde als extra velden).

## <a id="add"></a>Veld toevoegen

Elk veld kan op meerdere locaties verschijnen als dat relevant is.

1. Selecteer het tabblad waar u het veld wilt toevoegen.

1. Zorg ervoor dat het secties **Velden** is geselecteerd.

1. Zoek het gewenste veld in de **Velden**-lijst.

    > [!TIP]
    > Gebruik de filterfunctie om specifieke velden te vinden.

1. Sleep het veld uit de lijst naar een gestippeld gebied in het geselecteerde tabblad.

    ![Vakjes met gestippelde lijnen -screenshot][img6]

    Om een veld op alle tabbladen zichtbaar te maken, plaatst u het veld in de koptekst of voettekst van de hoofdkaarten.

## <a id="settings"></a>Veldinstellingen bewerken

Bewerk de veldopmaak (zoals lettergrootte) om de zichtbaarheid te verbeteren.

1. Selecteer het tabblad dat het veld bevat.

1. Klik op het veld in de voorbeeldweergave.

1. Bewerk in het secties **Instellingen** de veldopmaak. De beschikbare instellingen zijn afhankelijk van het geselecteerde veldtype.

    * Kies **Vet** of *Cursief* om de letterstijl te wijzigen
    * Wissel tussen links- en rechts uitgelijnde waarden
    * Kies tussen kleine, normale en grote lettergrootte

Zie het screenshot in de sectie over het [toevoegen van een kop of scheidingslijn][3] voor voorbeeldopmaak.

## <a id="move"></a>Veld verplaatsen

Voeg belangrijke aangepaste velden toe aan het hoofdtabblad (het meest linkse tabblad) voor gemakkelijke toegang. Verplaats minder belangrijke velden naar secundaire tabbladen als alternatief voor het verwijderen ervan.

**Stappen:**

1. Selecteer het tabblad dat het veld bevat.

1. Klik op **=** links van het veldlabel en sleep het veld naar een nieuwe positie.

    > [!TIP]
    > Om een veld naar een ander tabblad te verplaatsen, sleept u het naar het nieuwe tabblad, wacht u tot de voorbeeldweergave wordt bijgewerkt en plaatst u het veld vervolgens in een gestippeld gebied op het nieuwe tabblad.

## <a id="delete"></a>Veld verwijderen (verbergen)

Om onnodige rommel te verminderen, kunt u velden verbergen die nooit worden gebruikt. Verwijderde velden hebben alleen invloed op wat wordt weergegeven in de gebruikersinterface en wijzigen de database of tabelwaarden op geen enkele manier.

* Om een veld te verwijderen, houdt u de aanwijzer boven een veld en klikt u op de rode omcirkelde x.

* Om het veld te herstellen, voegt u het veld eenvoudig [opnieuw toe](#add).

> [!NOTE]
> Verplichte velden kunnen niet worden verwijderd. U kunt echter een verplicht veld naar een ander tabblad verplaatsen.

## Gerelateerde inhoud

* [Wijzig het aantal kolommen op een tabblad][4]
* [Labels en scheidingslijnen toevoegen][3]
* [Koppelingen en knoppen toevoegen][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#label
[4]: working-with-tabs.md#columns
[5]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
[img6]: ../../../../media/loc/en/customization/screendesigner-field-place.png
