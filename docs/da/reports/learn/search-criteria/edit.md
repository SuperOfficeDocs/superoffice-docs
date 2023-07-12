---
uid: help-da-report-search-criteria-edit
title: Redigering af søgekriterier i rapporter
description: Redigering af søgekriterier i rapporter
author: SuperOffice RnD
so.date: 07.04.2022
keywords: rapport
so.topic: howto
language: da
---

# Redigering af søgekriterier i rapporter

Du kan redigere søgekriterier i foretrukne rapporter. Standardrapporter kan ikke redigeres som sådan, men du kan tilpasse søgekriterierne i dem og gemme dem som dine egne [foretrukne rapporter][1]).

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

1. Vælg en fane. Rapporterne vises på rapportlisten.

    > [!NOTE]
    > Det anbefales ikke, at du kører rapporter uden at angive søgekriterier, da dette kan generere ekstremt store rapporter og resultere i tidskrævende behandling.

1. Vælg den ønskede rapport på listen.

1. Dobbeltklik på det kriterium, du vil redigere, på kriterielisten.

1. Dialogboksen **Tilføj/rediger kriterier** åbnes.

1. [Rediger de ønskede informationer][2].

    > [!NOTE]
    > De kriterier, du kan vælge mellem, varierer afhængigt af den fane og rapport, du har valgt.

1. Klik på **OK** nederst i dialogboksen **Tilføj/rediger søgekriterier**, når du er færdig.

## Eksempel

Vi skal nu se, hvordan du justerer kriterierne i en salgsrapport:

1. Klik på fanen **Salg**. På rapportlisten vises en liste over standardrapporter for den fane, du valgte.
1. Vælg standardrapporten **Salg – Reelle salg**. Tekstfeltet viser en beskrivelse af rapporten og kriterielisten nedenfor, der viser kriterierne for den standardrapport, du har valgt.

Nu vil vi ændre standardrapportkriterierne lidt, så du kan se, hvordan du ændrer dem, så de passer til dine behov. Vi vil ændre standardrapporten, så den viser alt reelt salg fra den foregående måned, som *ikke* har status **Åben**.

1. Dobbeltklik på kriteriet **Salg: Dato** på kriterielisten. Dialogboksen **Tilføj/rediger kriterier** åbnes.

    ![Tilføj/rediger søgekriterier -screenshot][img3]

1. Klik på pilen ud for feltet **Denne måned**, skift perioden til **Sidste måned**, og klik på **OK**. Din rapport vil nu kun indeholde salg fra den foregående måned.

1. Vælg kriteriet **Salg: Ejer** på kriterielisten, og klik på knappen **Slet** nederst. Din rapport vil nu omfatte alle salg og ikke kun salg, hvor den pågældende bruger (dig) er registreret som ejer.

1. Dobbeltklik på **Salg: Status** i kriterielisten. Dialogboksen **Tilføj/rediger kriterier** åbnes. Nu skal vi ændre kriteriet **Salg: Status**, så rapporten kun indeholder salg, der ikke har status **Åben**.

    ![Tilføj/rediger søgekriterier -screenshot][img4]

1. Klik på pilen ud for feltet **Er en af**, og skift værdien til **Er ikke en af**.

1. I kolonnen **Valgte værdier** skal du vælge **Solgt** og klikke på ![ikon][img2]. Kriteriet flyttes til kolonnen længst til venstre.

1. I kolonnen længst til venstre skal du vælge **Åben** og klikke på ![ikon][img1]. Kriteriet flyttes til kolonnen **Valgte værdier**. Rapporten indeholder nu salg, der ikke har statussen **Åben**.

1. Klik på **OK**.

<!-- Referenced links -->
[1]: ../labels/add-format.md
[2]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/loc/en/reports/edit-criteria.bmp
[img4]: ../../../../media/loc/en/reports/edit-criteria-2.bmp
