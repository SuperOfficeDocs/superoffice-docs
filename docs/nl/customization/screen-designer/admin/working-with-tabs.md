---
uid: help-nl-screen-designer-tabs
title: Werken met tabbladen
description: Hoe u een tabblad in een lay-out toevoegt, organiseert, verwijdert en herstelt en hoe u de informatie organiseert in logische groepen met behulp van de Schermontwerper in Instellingen en onderhoud.
keywords: opmaak, tabbladindeling, tabblad toevoegen, tabblad verwijderen, tabblad herstellen, velden groeperen, Meer tabblad, kop toevoegen, label toevoegen, scheidingslijn toevoegen
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.7
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: nl
index: true
redirect_from: /nl/customization/screen-designer/working-with-tabs
---

# Werken met tabbladen

[!include[Vereiste](../../../includes/req-dev-tools.md)]

Deze gids gaat ervan uit dat u al [het opmaak aan het bewerken bent][2]. De volgende secties leggen uit hoe u tabbladen in SuperOffice CRM organiseert en aanpast, zodat de interface is afgestemd op de behoeften van uw organisatie.

## Tabblad toevoegen

Het maken van aangepaste tabbladen stelt u in staat om gerelateerde velden te groeperen op een manier die logisch is voor uw organisatie. U kunt bijvoorbeeld tabbladen maken die gewijd zijn aan specifieke zakelijke gebieden, zodat informatie gemakkelijker te vinden is.

**Stappen:**

1. Klik op **Toevoegen**. Het secties **Tabbladindeling** opent aan de linkerkant.

2. Vervang onder **Titel tabblad** de tekst "Nieuw tabblad" door de nieuwe naam van het tabblad.

    U kunt ook op <i class="ph ph-translate" aria-label="Translate"></i> klikken om de naam van het tabblad in andere talen toe te voegen.

3. Selecteer het aantal kolommen dat u in het nieuwe tabblad wilt gebruiken.

## Tabblad hernoemen

Als u het tabblad later moet hernoemen, selecteert u het tabblad en gaat u naar **Tabbladindeling**. **U kunt de naam van de standaardtabbladen niet wijzigen.**

## Tabblad verwijderen

Om de interface eenvoudiger te maken, kunt u tabbladen verwijderen die niet langer nodig zijn. Een opmaak moet ten minste één tabblad hebben. Als er nog maar één tabblad overblijft, kan dit niet worden verwijderd.

> [!NOTE]
> Als het tabblad verplichte velden bevat, moet u deze velden naar een ander tabblad verplaatsen voordat u het huidige verwijdert.

**Stappen:**

1. Selecteer het tabblad.
1. Klik op **Taak** en kies **Tabblad verwijderen**.
1. Klik op **OK** om te bevestigen en het dialoogvenster te sluiten.

## Tabblad herstellen

Als u een tabblad verwijdert en later besluit dat u het toch nodig heeft, kunt u het eenvoudig herstellen.

1. Open het opmaak in bewerkingsmodus.
1. Klik op **Taak** en selecteer **Tabbladen herstellen**.

> [!NOTE]
> Deze actie herstelt **alle** eerder verwijderde tabbladen.

## <a id="label"></a>Kop of scheidingslijn toevoegen

Labels en scheidingslijnen helpen bij het organiseren van velden binnen een tabblad, waardoor de informatie leesbaarder en toegankelijker wordt. Gebruik labels om koppen te maken en scheidingslijnen om secties binnen een kolom te scheiden.

1. Selecteer het tabblad waar u het element wilt toevoegen.

2. Selecteer de sectie **Elementen**.

3. Om een kop toe te voegen, sleept u het element **Label** naar het opmaak.

    * Vervang in het secties **Instellingen** de tekst "Nieuw label" door de nieuwe labelnaam. Optioneel kunt u op <i class="ph ph-translate" aria-label="Translate"></i> naast het label klikken om de naam van het label in andere talen toe te voegen.
    * Wijzig de lettertype-indeling indien nodig.

4. Om een horizontale scheidingslijn toe te voegen, sleept u het element **Scheidingslijn** naar het opmaak. Wijzig indien relevant het type ruimte.

![Schermontwerper velden en elementen -screenshot][img2]

## <a id="columns"></a>Velden in kolommen groeperen

Standaard hebben tabbladen twee kolommen, maar u kunt dit naar behoefte aanpassen. Elk tabblad kan 1, 2, 3 of 4 kolommen hebben, afhankelijk van de hoeveelheid informatie die u wilt weergeven.

> [!NOTE]
> Tabbladen met specifieke functies, zoals **ERP** en **Notitie**, ondersteunen geen kolomaanpassing. Ga naar **Instellingen en onderhoud** > **ERP** om de inhoud van het ERP-tabblad te configureren.

**Stappen:**

1. Selecteer het tabblad waar u de kolommen wilt aanpassen.
1. Ga naar het secties **Tabbladindeling**.
1. Kies een van de vier layoutopties.

Als u het aantal kolommen vermindert, worden de velden uit de verwijderde kolommen naar de laatste resterende kolom verplaatst. Als u bijvoorbeeld van drie naar twee kolommen reduceert, worden de velden uit de derde kolom naar de onderkant van de tweede kolom verplaatst.

Kolommen worden op elkaar gestapeld wanneer het scherm te klein is om ze horizontaal weer te geven.

Als u een breed scherm heeft, kunt u meer kolommen gebruiken om meer gegevens tegelijkertijd weer te geven. Wees echter voorzichtig: het gebruik van vier kolommen kan de zichtbaarheid van sommige velden verminderen. Het verbergen van veldlabels kan helpen om meer ruimte te creëren.

> [!TIP]
> Als een tabblad te vol wordt, overweeg dan om extra tabbladen toe te voegen om de informatie beter te organiseren.

## <a id="more"></a>Het Meer-tabblad

Het **Meer**-tabblad bevat automatisch alle [aangepaste velden][3], gerangschikt op volgorde. U kunt deze velden in dit tabblad configureren en optioneel toevoegen aan andere schermen.

[Gebruikersgedefinieerde velden][5] (udef) en [extra velden][4] worden op dezelfde manier gemaakt als voorheen.

## Gerelateerde inhoud

* [Werken met velden][1]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: edit-layout.md
[3]: ../../../custom-objects/learn/index.md
[4]: ../../../custom-objects/admin/create-extra-field.md
[5]: ../../../custom-objects/admin/add-udef.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/customization/field-settings.png
