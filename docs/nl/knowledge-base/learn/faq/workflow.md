---
uid: help-nl-faq-workflow
title: Workflowfasen
description: Workflowfasen
keywords: Veelgestelde vragen
author: Bergfrid Dias
date: 03.14.2025
content_type: howto
license: servicepremium
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: nl
redirect_from: /nl/faq/learn/workflow
---

# Workflowfasen

Bij een nieuwe installatie bevat de workflows twee standaardfasen: **Niet-gepubliceerd** en **Gepubliceerd**. Het is mogelijk workflows toe te voegen tussen deze twee. Er kan bijvoorbeeld een workflow worden ingesteld voor het verzenden van een item voor Veelgestelde vragen ter proeflezing, zodat iemand het item controleert en vervolgens publiceert of terugstuurt voor verdere bewerking.

## Nieuwe fase maken

1. Ga naar <i class="ph ph-list" aria-label="Main menu"></i> in de bovenste balk en selecteer **Kennisdatabase** > **Veelgestelde vragen**.
1. Klik op de knop **Workflow**. Het scherm **Workflow weergeven** wordt geopend.
1. Klik op de knop **Nieuwe fase**. Het scherm **Nieuwe fase** wordt geopend.
1. Voer in het veld **Naam** een herkenbare naam in voor de fase.
1. Geef via de lijst **Nieuwe fase plaatsen tussen** aan waar in het proces u de nieuwe fase wilt tussenvoegen.
1. Klik op **OK**. Het scherm **Fase bewerken** wordt geopend.
1. Via de lijst **Gebruiker selecteren** selecteert u de naam van een gebruiker die toegang moet krijgen tot deze fase in de workflow.
1. Selecteer het toegangsniveau voor deze gebruiker. U kunt kiezen uit de volgende opties:
    * **Mag verplaatsen**: De gebruiker mag de workflowfase voor items wijzigen (publiceren of publicatie annuleren).
    * **Mag bewerken**: de gebruiker mag items in Veelgestelde vragen bewerken.
    * **Volledige toegang**: De gebruiker heeft alle rechten met betrekking tot de workflow.
1. Klik op **+** om de gebruiker toe te voegen aan de lijst onder **Gebruikerstoegang**.
1. Herhaal stap 7-9 om meer gebruikers toe te voegen.
1. Klik op **OK**. De fase wordt gemaakt en is beschikbaar wanneer u items in Veelgestelde vragen publiceert.

## Fase bewerken

U kunt zowel de naam van een fase wijzigen als de gebruikers die er toegang toe moeten krijgen.

1. Ga naar <i class="ph ph-list" aria-label="Main menu"></i> in de bovenste balk en selecteer **Kennisdatabase** > **Veelgestelde vragen**.
1. Klik op de knop **Workflow**.
1. Klik op de naam van de fase. Het scherm **Fase bewerken** wordt geopend.
1. Bewerk zo nodig de naam.
1. Geef aan welke gebruikers toegang moeten krijgen tot de fase:
    * Als u gebruikers wilt toevoegen, volgt u de bovenstaande procedure.
    * Als u gebruikers wilt verwijderen, selecteert u de betreffende gebruiker(s), klikt u op <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> en selecteert u **Toegang verwijderen voor geselecteerde gebruikers**.
1. Klik op **OK**. De wijzigingen worden opgeslagen.

## Fase verwijderen

1. Ga naar <i class="ph ph-list" aria-label="Main menu"></i> in de bovenste balk en selecteer **Kennisdatabase** > **Veelgestelde vragen**.
1. Klik op de knop **Workflow** (<i class="ph ph-gear" aria-hidden="true"></i>).
1. Klik op de naam van de fase. Het scherm **Fase bewerken** wordt geopend.
1. Klik op **Verwijderen**. Als de fase niet aan een item in Veelgestelde vragen is gekoppeld, wordt deze direct verwijderd.

    > [!NOTE]
    > u kunt de standaardfasen **Niet-gepubliceerd** en **Gepubliceerd** niet verwijderen.

1. Als de fase wel aan items in Veelgestelde vragen is gekoppeld, selecteert u naar welke fase in de workflow deze items moeten worden verplaatst. Selecteer de gewenste fase in de keuzelijst **Verplaatsen naar workflow**.
1. Klik op **Verwijderen**. De fase wordt verwijderd en gekoppelde items in Veelgestelde vragen worden verplaatst naar de geselecteerde fase.

## Publiceren via workflow

1. [Open het item in Veelgestelde vragen][1].
1. Om iets te wijzigen voorafgaand aan publicatie, volgt u de procedure bij [Items in Veelgestelde vragen publiceren][2].
1. Klik op de knop **Naar voren verplaatsen in workflow** totdat **Gepubliceerd** wordt weergegeven in het veld **Workflowfase** op het tabblad **Details**.

    > [!TIP]
    > U kunt publicatie van het items in Veelgestelde vragen annuleren door te klikken op de knop **Naar achteren verplaatsen in workflow**.

<!-- Referenced links -->
[1]: index.md
[2]: publish.md
