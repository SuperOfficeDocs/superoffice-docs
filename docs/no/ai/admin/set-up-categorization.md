---
uid: help-no-ai-categorization-setup
title: Sett opp AI-basert kategorisering
description: Hvordan trene og konfigurere kategorisering i SuperOffice AI
keywords: AI, kategorisering, maskinlæring, trening
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
audience_tooltip: Innstillinger og vedlikehold
language: no
index: true
redirect_from: /no/ai/admin/index
---

# Sett opp AI-basert kategorisering

Kategorisering bruker maskinlæring til å foreslå kategorier for innkommende saker basert på innholdet deres. Før denne funksjonen kan brukes, må AI-en trenes ved hjelp av et utvalg av eksisterende saker.

> [!NOTE]
> Kategorisering krever SuperOffice AI Platform og en **Categorization-lisens**. SuperOffice AI er kun tilgjengelig for CRM Online.

## 1. Opprett et utvalg av saker

Du må først opprette et utvalg av saker i SuperOffice for å trene AI-modellen.

1. Klikk på <i class="ph ph-list-magnifying-glass" aria-label="Finn ikon"></i> **Finn** eller gå til **Ny** > **Utvalg**.

    ![Nye utvalgsalternativer i Sales-klienten -screenshot][img1]

1. Velg **Sak** som utvalgstype. Bruk **Finn sak** eller velg fra **Typiske søk**.

    ![Typiske søk for sakutvalg -screenshot][img2]

1. Definer søkekriterier:
    1. Legg til filtre for å matche sakene du vil bruke til trening.
    2. Klikk på **Finn**.

    ![Kriterier for sakutvalg -screenshot][img3]

1. Lagre utvalget:
    1. Klikk på **Lagre som utvalg**.
    2. Velg statisk eller dynamisk.
    3. Skriv inn et navn og klikk på **Lagre**.

    ![Velg utvalgstype -screenshot][img4]
    ![Skriv inn utvalgsnavn -screenshot][img5]

> [!NOTE]
> Kun de første 5000 sakene i utvalget vil bli analysert.

## 2. Velg utvalget i Innstillinger og vedlikehold

1. Åpne **Innstillinger og vedlikehold**.
1. Velg **AI-tjenester** fra navigatoren.
1. Under **Kategorisering** åpner du rullegardinmenyen og søker etter utvalgsnavnet.
1. Velg riktig sakutvalg.

    ![Velg sakutvalg i AI-tjenester -screenshot][img6]

## 3. Analyser sakutvalget

Når et gyldig utvalg er valgt, blir knappen **Analyser saker** aktiv.

> [!NOTE]
> Store datasett kan ta timer eller til og med dager å analysere.

1. Klikk på **Analyser saker** for å starte treningsprosessen.
1. Når treningen er fullført, vil statusen **Siste trening** vise *modell trent med suksess*.
1. Hvis det oppstår feil, gjennomgå meldingen og opprett et nytt utvalg om nødvendig.

    ![Treningsresultater og tilbakemelding -screenshot][img7]
    ![Eksempler på treningssammendrag -screenshot][img8]

## 4. Aktiver forslag

Etter vellykket trening:

1. Velg avkrysningsboksen **Bruk AI til å foreslå kategorier** for å aktivere funksjonen.

    ![Avkrysningsboks for å aktivere AI-forslag -screenshot][img9]

## 5. Resultat: kategoriforslag i saker

Når aktivert, vil brukere se en foreslått kategori i sakbunnteksten. Ved å klikke på lenken brukes kategorien på saken og forslaget fjernes.

Hvis det ikke er noe treff, vises intet forslag.

## Tren på nytt eller endre utvalg

Du kan analysere et nytt eller oppdatert utvalg på nytt når som helst:

1. Gå til **Innstillinger og vedlikehold** > **AI-tjenester**.
1. Under **Kategorisering** velger du et nytt utvalg.
1. Klikk på **Analyser saker** for å trene på nytt.

## Relatert innhold

* [Hvordan opprette et utvalg][1]
* [Sakkategorisering][2]
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
