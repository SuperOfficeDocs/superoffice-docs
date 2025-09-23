---
uid: help-nl-saint-setup
title: Nieuwe activiteitsbewaking instellen
description: Nieuwe activiteitsbewaking instellen
keywords: SAINT, activiteitsbewaking, statusbewaking
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
redirect_from: 
  - /nl/sale/saint/learn/admin/create-status
  - /nl/sale/saint/learn/admin/select-image-for-status
  - /nl/saint/admin/select-image-for-status
---

# Nieuwe activiteitsbewaking instellen

[!include[Requirement](../includes/note-saint-req.md)]

Met statusbewaking heeft u op eenvoudige wijze een overzicht van alle klanten die aandacht nodig hebben.

Om een status te maken, definieert u de naam en beschrijving, voegt u ten minste één criterium toe en stelt u optioneel een prioriteit, standaard vervolgactiviteitstype of afbeelding in. De onderstaande stappen tonen het volledige proces.

## Stappen

1. Open het scherm **SAINT** in Instellingen en onderhoud en selecteer het tabblad **Bedrijf**, **Persoon** of **Project**.

1. Klik **Toevoegen** onder de lijst **Statusbewaking**.

1. Vul in het dialoogvenster deze velden in:

    * **Naam:** Voer een beschrijvende naam in voor de status die u wilt toevoegen.
        Optioneel: Selecteer <i class="ph ph-translate" aria-label="Translate"></i> om [vertalingen toe te voegen][8] van de statusnaam.

    * **Beschrijving:** Voer een duidelijke beschrijving in van de status en welke actie vereist is of aanbevolen wordt. U kunt ook [sjabloonvariabelen][9] gebruiken om de tekst aan te passen aan het bedrijf, de persoon of het project.

    ![New status monitor dialog -screenshot][img1]

    De naam en beschrijving worden weergegeven in SuperOffice CRM wanneer de gebruiker de muisaanwijzer op de statusafbeelding houdt of het statusdialoogvenster opent. U kunt later de beschrijving bewerken.

1. Klik **Opslaan**. Selecteer vervolgens de nieuwe status in de lijst om door te gaan met de instelling.

1. **Criteria voor de status opgeven:**

    1. Selecteer onder de criterialijst **Toevoegen** om een nieuw criterium in te voegen.
    1. Kies een criteriumtype, stel de voorwaarde in en voer een waarde in.

    ![Criteria list with multiple conditions defined and the Add button below the list -screenshot][img3]

    Elke status moet ten minste één criterium bevatten. Herhaal indien nodig om meer toe te voegen.

1. *(Optioneel)* [Definieer een standaard vervolgactiviteitstype][2] voor de status in het tabblad **Vervolgactiviteit maken**.

1. *(Optioneel)* [Selecteer een afbeelding om de status te visualiseren](#image).

1. Als er meerdere statussen in de lijst staan, stel dan de **prioriteit** in om te bepalen welke statusafbeelding op de kaart wordt weergegeven.
    Een bedrijf, persoon of project kan overeenkomen met de criteria voor meerdere statussen, maar er kan slechts één afbeelding worden weergegeven.
    Selecteer een status en gebruik de pijltjestoetsen onder de lijst om deze omhoog of omlaag te verplaatsen.

    ![List of status monitors with priorities -screenshot][img2]

1. Wanneer u klaar bent, selecteert u <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Geselecteerde statusbewaking regenereren** om de status te activeren.

## <a id="image"></a>Een afbeelding selecteren voor een status

U kunt een afbeelding toevoegen die wordt weergegeven op bedrijfs-, persoons- of projectkaarten die voldoen aan de statuscriteria. De afbeelding verschijnt als een licht watermerk (40% transparantie) zodat het andere inhoud niet verbergt.

Het toevoegen van een afbeelding is optioneel. Het kan helpen om aandacht te trekken en het type vervolgactie te symboliseren dat u wilt dat gebruikers ondernemen. Als u de status alleen wilt gebruiken voor zoekopdrachten of selecties, kunt u deze zonder afbeelding laten.

1. Selecteer in de statuslijst de gewenste status.
1. Vink aan de rechterkant van het scherm **Visualiseren** aan om de afbeelding weer te geven.
1. Selecteer **Afbeelding wijzigen**.
1. Voer een van de volgende handelingen uit:
    * Selecteer een van de bestaande afbeeldingen uit de lijst **Afbeeldingen**.
    * Selecteer **Toevoegen**, upload een bestand, voer een beschrijving in en selecteer **Opslaan**.
1. Selecteer **OK** om te bevestigen.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Gebruik eenvoudige, lichtgekleurde afbeeldingen die de status op een zinvolle manier weergeven. Een spinnenweb kan bijvoorbeeld inactiviteit symboliseren.

## Gerelateerde inhoud

* [Statusbewaking bijwerken, verwijderen en herstellen][2]
* [Tellers en tellerinstellingen (periode)][7]
* [Statusbewaking en tellers regenereren][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png
