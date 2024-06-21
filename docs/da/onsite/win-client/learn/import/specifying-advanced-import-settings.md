---
uid: help-da-specifying-advanced-import-settings
title: Specifikation af avancerede importindstillinger
description: Specifikation af avancerede importindstillinger
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Angivelse af avancerede importindstillinger

Avancerede importindstillinger omfatter datoformatindstillinger og afgrænsertegn. De har til formål at sikre, at SuperOffice fortolker importfilen korrekt.

> [!NOTE]
> Hvis du vil tilknytte felterne korrekt fra importfilen, skal du muligvis redigere indstillingerne for tekstskilletegn, feltskilletegn og rækkeskilletegn.

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Klik på knappen **Avanceret**.

1. I dialogboksen **Avancerede indstillinger** skal du vælge et foruddefineret format på listen **Datoformat**. Du kan ikke bruge månedsnavne, kun tal.

    > [!NOTE]
    > **Native ID** betyder en SuperOffice-dato. SuperOffice tæller sekunderne siden 01.01.1970; det er dette nummer, der svarer til **Native ID**.

1. Vælg mellem de foruddefinerede indstillinger for decimalseparatorer på listen **Talformat**.

1. I feltet **Afkrydsningsfeltformat** skal du indtaste det eller de tegn, der bruges i importfilen, for at angive, at et afkrydsningsfelt er markeret.

1. I feltet **Tekstskilletegn** skal du indtaste det tegn, der bruges i importfilen til at omslutte almindelig tekst.

    > [!NOTE]
    > Tekstskilletegn erstatter alle felt- og rækkeskilletegn (se nedenfor). Hvis der f.eks. er et feltskilletegn mellem to tekstskilletegn, fortolkes den som almindelig tekst. Du behøver dog ikke at bruge tekstskilletegn, hvis importfilerne indeholder felt- eller rækkeskilletegn.

1. På listen **Feltskilletegn** skal du vælge mellem de foruddefinerede indstillinger, der angiver, hvilke tegn der adskiller felter fra hinanden.

1. På listen **Rækkeskilletegn** skal du vælge mellem de foruddefinerede indstillinger, der angiver, hvilke tegn der adskiller rækker fra hinanden.

1. På listen **Medarbejderformat** skal du vælge mellem de foruddefinerede formater, der angiver, hvordan navne i importfilen skal fortolkes, f.eks. om fornavne kommer før efternavne.

    > [!NOTE]
    > **Native ID** betyder medarbejderens **associate_id**, sådan som det er registreret i databasen. Hvis der ikke findes et sådant ID, bruges indholdet af feltet **Standardmedarbejder**.

1. På listen **Standardmedarbejder** skal du vælge, hvilket navn der skal angives som standard, hvis SuperOffice-databasen ikke kan fortolke medarbejderformatet i importfilen.

1. På listen **Landeformat** skal du vælge mellem de foruddefinerede formater, der angiver, hvordan lande skal fortolkes, f.eks. om landenavnet er på det lokale sprog eller på engelsk.

    > [!NOTE]
    > **Native ID** betyder **country_id**, sådan som det er registreret i databasen.

1. På listen **Standardlandenavn** skal du vælge, hvilket land du vil angive, hvis SuperOffice-databasen ikke kan fortolke landeformatet i importfilen.

1. På listen **Valuta** skal du vælge, hvilken valuta du vil angive, hvis SuperOffice-databasen ikke kan fortolke valutaformatet i importfilen.

1. Markér **Opdater fritekstindeks** for at opdatere fritekstindekset løbende under importen, så det er fuldstændigt opdateret, når importen er færdig.

    > [!NOTE]
    > Importhastigheden falder, hvis du markerer **Opdater fritekstindeks**. Hvis du vil importere store mængder data, er et alternativ at køre importen uden at markere denne indstilling og [generere et nyt fritekstindeks][2] senere fra skærmbilledet **Indstillinger**.

1. Når du har angivet de nødvendige indstillinger, skal du klikke på **OK**.

    [!include[Save mapping](includes/tip-save-mapping.md)]

> [!NOTE]
> Hvis du har angivet en importbeskrivelsesfil i feltet **Importbeskrivelsesfil**, indtastes oplysningerne allerede i dialogboksen **Avancerede indstillinger**. Du kan dog ændre denne information som beskrevet ovenfor. Husk, at importbeskrivelsesfilen skal gemmes, før den opdateres med nye indstillinger.

<!-- Referenced links -->
[2]: ../../../../admin/options/learn/freetext-search/regenerate-index.md

<!-- Referenced images -->
