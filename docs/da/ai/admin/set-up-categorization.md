---
uid: help-da-ai-categorization-setup
title: Opsæt AI-baseret kategorisering
description: Sådan træner og konfigurerer du kategorisering i SuperOffice AI
keywords: AI, kategorisering, maskinlæring, træning
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
audience_tooltip: Indstillinger og vedligeholdelse
language: da
index: true
redirect_from: /da/ai/admin/index
---

# Opsæt AI-baseret kategorisering

Kategorisering bruger maskinlæring til at foreslå kategorier for indkommende sager baseret på deres indhold. Før denne funktion kan bruges, skal AI'en trænes ved hjælp af et udvalg af eksisterende sager.

> [!NOTE]
> Kategorisering kræver SuperOffice AI Platform og en **Categorization-licens**. SuperOffice AI er kun tilgængelig for CRM Online.

## 1. Opret et udvalg af sager

Du skal først oprette et udvalg af sager i SuperOffice for at træne AI-modellen.

1. Klik på <i class="ph ph-list-magnifying-glass" aria-label="Find ikon"></i> **Find** eller gå til **Ny** > **Udvalg**.

    ![Nye udvalgsmuligheder i Sales-klienten -screenshot][img1]

1. Vælg **Sag** som udvalgstype. Brug **Find sag** eller vælg fra **Typiske søgninger**.

    ![Typiske søgninger for sagudvalg -screenshot][img2]

1. Definer søgekriterier:
    1. Tilføj filtre for at matche de sager, du vil bruge til træning.
    2. Klik på **Find**.

    ![Kriterier for sagudvalg -screenshot][img3]

1. Gem udvalget:
    1. Klik på **Gem som udvalg**.
    2. Vælg statisk eller dynamisk.
    3. Indtast et navn og klik på **Gem**.

    ![Vælg udvalgstype -screenshot][img4]
    ![Indtast udvalgsnavn -screenshot][img5]

> [!NOTE]
> Kun de første 5000 sager i udvalget vil blive analyseret.

## 2. Vælg udvalget i Indstillinger og vedligeholdelse

1. Åbn **Indstillinger og vedligeholdelse**.
1. Vælg **AI-tjenester** fra navigatoren.
1. Under **Kategorisering** skal du åbne dropdown-menuen og søge efter udvalgsnavnet.
1. Vælg det korrekte sagudvalg.

    ![Vælg sagudvalg i AI-tjenester -screenshot][img6]

## 3. Analyser sagudvalget

Når et gyldigt udvalg er valgt, bliver knappen **Analyser sager** aktiv.

> [!NOTE]
> Store datasæt kan tage timer eller endda dage at analysere.

1. Klik på **Analyser sager** for at starte træningsprocessen.
1. Når træningen er fuldført, vil status **Seneste træning** vise *model trænet med succes*.
1. Hvis der opstår fejl, skal du gennemgå meddelelsen og oprette et nyt udvalg om nødvendigt.

    ![Træningsresultater og feedback -screenshot][img7]
    ![Eksempler på træningssammendrag -screenshot][img8]

## 4. Aktiver forslag

Efter vellykket træning:

1. Vælg afkrydsningsfeltet **Brug AI til at foreslå kategorier** for at aktivere funktionen.

    ![Afkrydsningsfelt for at aktivere AI-forslag -screenshot][img9]

## 5. Resultat: kategoriforslag i sager

Når det er aktiveret, vil brugere se en foreslået kategori i sagfoden. Ved at klikke på linket anvendes kategorien på sagen, og forslaget fjernes.

Hvis der ikke er et match, vises intet forslag.

## Gentræn eller skift udvalg

Du kan genanalysere et nyt eller opdateret udvalg når som helst:

1. Gå til **Indstillinger og vedligeholdelse** > **AI-tjenester**.
1. Under **Kategorisering** skal du vælge et nyt udvalg.
1. Klik på **Analyser sager** for at træne igen.

## Relateret indhold

* [Sådan opretter du et udvalg][1]
* [Sagkategorisering][2]
* [Andre AI-tjenester][3]

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
