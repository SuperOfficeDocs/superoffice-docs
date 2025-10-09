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
  - /nl/saint/admin/create-status
---

# Nieuwe activiteitsbewaking instellen

[!include[Requirement](../includes/note-saint-req.md)]

Met statusbewaking ziet u in één oogopslag alle klanten die aandacht nodig hebben.

Om een status te maken, definieert u de naam en beschrijving, voegt u minstens één criterium toe en geeft u optioneel een prioriteit, standaard-evenementtype of afbeelding op. De onderstaande stappen tonen het volledige proces.

## Stappen

1. Open het scherm **SAINT** in Instellingen en onderhoud en selecteer het tabblad **Bedrijf**, **Persoon** of **Project**.

1. Klik op **Toevoegen** onder de lijst **Statusbewaking**.

1. Vul in het dialoogvenster de volgende velden in:

    * **Naam:** Voer een beschrijvende naam in voor de status die u wilt toevoegen.
        Optioneel: Selecteer <i class="ph ph-translate" aria-label="Translate"></i> om [vertalingen toe te voegen][8] van de statusnaam.

    * **Beschrijving:** Voer een duidelijke beschrijving in van de status en welke actie vereist of aanbevolen is. U kunt ook [sjabloonvariabelen][9] gebruiken om de tekst aan te passen aan het bedrijf, de persoon of het project.

    ![Nieuw statusmonitoringdialoogvenster -screenshot][img1]

    De naam en beschrijving worden weergegeven in SuperOffice CRM wanneer de gebruiker over de statusafbeelding hovert of het statusdialoogvenster opent. U kunt de beschrijving later bewerken.

1. Klik op **Opslaan**. Selecteer vervolgens de nieuwe status in de lijst om door te gaan met de configuratie.

1. **Criteria voor de status instellen:**

    1. Selecteer onder de criterialijst **Toevoegen** om een nieuw criterium in te voegen.
    1. Selecteer een criteriatype, stel de voorwaarde in en geef een waarde op.

    ![Criterialijst met meerdere gedefinieerde voorwaarden en de knop Toevoegen onder de lijst -screenshot][img3]

    Elke status moet minstens één criterium bevatten. Herhaal indien nodig om meer toe te voegen.

1. *(Optioneel)* [Definieer een standaard-evenementtype][2] voor de status in het tabblad **Vervolgactiviteit maken**.

1. *(Optioneel)* [Selecteer een afbeelding om de status te visualiseren](#image).

1. Als er meerdere statussen in de lijst staan, stel dan de **prioriteit** in om te bepalen welke statusafbeelding op de kaart wordt weergegeven.
    Een bedrijf, persoon of project kan voldoen aan de criteria voor meerdere statussen, maar slechts één afbeelding kan worden weergegeven.
    Selecteer een status en gebruik de pijlknoppen onder de lijst om deze omhoog of omlaag te verplaatsen.

    ![Lijst van statusmonitoringen met prioriteiten -screenshot][img2]

1. Wanneer u klaar bent, selecteert u <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Geselecteerde statusbewaking regenereren** om de status te activeren.

## <a id="image"></a>Een afbeelding voor een status selecteren

U kunt een afbeelding toevoegen die wordt weergegeven op bedrijfs-, persoon- of projectkaarten die voldoen aan de statuscriteria. De afbeelding wordt weergegeven als een licht watermerk (40% transparantie) zodat deze andere inhoud niet verduistert.

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
> Gebruik eenvoudige, lichtgekleurde afbeeldingen die de status op een zinvolle manier vertegenwoordigen. Een spinnenweb kan bijvoorbeeld inactiviteit symboliseren.

## Sjabloonvariabelen gebruiken in beschrijvingen

U kunt sjabloonvariabelen gebruiken in het veld **Beschrijving** om de tekst te personaliseren die wordt weergegeven in vervolgactiviteiten of statusdialogen. Variabelen worden vervangen door informatie van het bedrijf, de persoon of het project.

### Voorbeeld

Een status zou bijvoorbeeld van toepassing kunnen zijn op bedrijven die aan de volgende criteria voldoen:

* Categorie = Klant
* Laatste verkoop meer dan 2 maanden geleden
* Aantal verkopen groter dan 50

De tekst in het veld **Beschrijving** zou dan als volgt kunnen luiden:

"&lt;name&gt; is eerder een goede klant geweest, maar we hebben al 2 maanden niets aan hen verkocht. &lt;cont&gt; is het hoofdcontact voor deze klant en zou de klant binnenkort telefonisch (&lt;cpho&gt;) of per e-mail (&lt;mail&gt;) moeten benaderen om erachter te komen waarom."

In dit voorbeeld worden de volgende sjabloonvariabelen gebruikt:

| Variabele | Beschrijving |
|---|---|
| name | De naam van het bedrijf |
| cont | De naam van ons contact voor het bedrijf |
| cpho | Het telefoonnummer van het bedrijf |
| mail | Het e-mailadres van het bedrijf |

## Gerelateerde inhoud

* [Statusbewaking bijwerken, verwijderen en herstellen][2]
* [Tellers en tellerinstellingen (periode)][7]
* [Statusbewaking en tellers regenereren][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png
