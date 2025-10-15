---
uid: help-nl-ai-categorization-setup
title: AI-gebaseerde categorisering instellen
description: Hoe u categorisering in SuperOffice AI traint en configureert
keywords: AI, categorisering, machine learning, training
author: digitaldiina
date: 10.15.2025
version: 11.5
content_type: howto
license: aiplatform, categorization
category: automation
topic: ai
deployment: online
platform: web
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
index: true
redirect_from: /nl/ai/admin/index
---

# AI-gebaseerde categorisering instellen

Categorisering gebruikt machine learning om categorieën voor te stellen voor binnenkomende verzoeken op basis van hun inhoud. Voordat deze functie kan worden gebruikt, moet de AI worden getraind met een selectie van bestaande verzoeken.

> [!NOTE]
> Categorisering vereist het SuperOffice AI Platform en een **Categorization-licentie**. SuperOffice AI is alleen beschikbaar voor CRM Online.

## 1. Een selectie van verzoeken maken

U moet eerst een selectie van verzoeken in SuperOffice maken om het AI-model te trainen.

1. Klik op <i class="ph ph-list-magnifying-glass" aria-label="Zoeken pictogram"></i> **Zoeken** of ga naar **Nieuw** > **Selectie**.

    ![Nieuwe selectieopties in Sales client -screenshot][img1]

1. Kies **Verzoek** als selectietype. Gebruik **Verzoek zoeken** of kies uit **Typische zoekopdrachten**.

    ![Typische zoekopdrachten voor verzoekselectie -screenshot][img2]

1. Zoekercriteria definiëren:
    1. Voeg filters toe om de verzoeken te matchen die u wilt gebruiken voor training.
    2. Klik op **Zoeken**.

    ![Criteria voor verzoekselectie -screenshot][img3]

1. De selectie opslaan:
    1. Klik op **Opslaan als selectie**.
    2. Kies statisch of dynamisch.
    3. Voer een naam in en klik op **Opslaan**.

    ![Selectietype kiezen -screenshot][img4]
    ![Selectienaam invoeren -screenshot][img5]

> [!NOTE]
> Alleen de eerste 5000 verzoeken in de selectie worden geanalyseerd.

## 2. De selectie kiezen in Instellingen en onderhoud

1. Open **Instellingen en onderhoud**.
1. Selecteer **AI-diensten** uit de Navigator.
1. Onder **Categorisering** opent u de dropdown en zoekt u naar de selectienaam.
1. Selecteer de juiste verzoekselectie.

    ![Verzoekselectie kiezen in AI-diensten -screenshot][img6]

## 3. De verzoekselectie analyseren

Zodra een geldige selectie is gekozen, wordt de knop **Verzoeken analyseren** actief.

> [!NOTE]
> Grote datasets kunnen uren of zelfs dagen duren om te analyseren.

1. Klik op **Verzoeken analyseren** om het trainingsproces te starten.
1. Wanneer de training is voltooid, toont de status **Laatste training** *model succesvol getraind*.
1. Als er fouten optreden, bekijk dan het bericht en maak indien nodig een nieuwe selectie.

    ![Trainingsresultaten en feedback -screenshot][img7]
    ![Voorbeelden van trainingsoverzicht -screenshot][img8]

## 4. Suggesties inschakelen

Na succesvolle training:

1. Selecteer het selectievakje **AI gebruiken om categorieën voor te stellen** om de functie te activeren.

    ![Selectievakje om AI-suggesties in te schakelen -screenshot][img9]

## 5. Resultaat: categoriesuggesties in verzoeken

Wanneer ingeschakeld, zien gebruikers een voorgestelde categorie in de verzoekvoettekst. Door op de link te klikken wordt de categorie toegepast op het verzoek en wordt de suggestie weggenomen.

Als er geen match is, wordt geen suggestie getoond.

## Hertrainen of selectie wijzigen

U kunt op elk moment een nieuwe of bijgewerkte selectie opnieuw analyseren:

1. Ga naar **Instellingen en onderhoud** > **AI-diensten**.
1. Onder **Categorisering** kiest u een nieuwe selectie.
1. Klik op **Verzoeken analyseren** om opnieuw te trainen.

## Gerelateerde inhoud

* [Hoe u een selectie maakt][1]
* [Verzoekencategorisering][2]
* [Andere AI-diensten][3]

<!-- Referenced links -->
[1]: ../../search-options/selection/learn/create.md
[2]: ../learn/categorization.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/choose-new-selection.png
[img2]: ../../../media/loc/en/search-options/typical-request-searches.png
[img3]: ../../../media/loc/en/ai/find-request-search-criteria.png
[img4]: ../../../media/loc/en/ai/select-selection-type-dialog.png
[img5]: ../../../media/loc/en/ai/name-selection-input.png
[img6]: ../../../media/loc/en/ai/select-category-menu.png
[img7]: ../../../media/loc/en/ai/categorization-analysis.png
[img8]: ../../../media/loc/en/ai/categorization-summary.png
[img9]: ../../../media/loc/en/ai/use-ai-suggested-categories-checkbox.png
