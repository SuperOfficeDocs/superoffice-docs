---
uid: help-da-search-freetext
title: Fritekstsøgning
description: Fritekstsøgning
author: SuperOffice RnD
so.date: 06.29.2022
keywords: fritekst, søge
so.topic: howto
language: da
---

# Fritekstsøgning

> [!NOTE]
> Hvis felterne for fritekstsøgning ikke vises i det øverste højre hjørne, er denne indstilling ikke aktiveret i Indstillinger og vedligeholdelse .

Tekstfeltet øverst til højre i SuperOffice CRM kan bruges til fritekstsøgninger.

Her kan du søge i SuperOffice CRM efter tekst, som brugerne selv har lagt ind i databasen, for eksempel firmanavn, afdeling, information om personer og opfølgninger. Du kan søge efter tekst fra dialogboksen **Dokument**, men du kan ikke søge i det faktiske indhold af dokumenter.

![Fritekstsøgning -screenshot][img1]

> [!NOTE]
> Enkelte ord ignoreres i en fritekstsøgning.[!include[SM](../../learn/includes/are-defined-sm.md)]

## Fritekstsøgning fra tekstfeltet

1. Skriv den tekst, du vil søge efter (mindst tre bogstaver).
2. Tryk på **Enter** for at starte søgningen.
    > [!NOTE]
    > Der søges altid først efter tekst, som står i feltet **Vores ref.** i dialogboksen **Dokument**.
3. Skærmbilledet **Søgeresultater** åbnes og viser alle data, der indeholder søgeteksten grupperet i faner. Klik på fanen for at få vist listen over søgeresultater.

Du kan gå til en post på resultatlisten ved at dobbeltklikke på den.

Du kan få forhåndsvist poster i [sidepanelet][1]. Klik på listen øverst i sidepanelet, og vælg **Forhåndsvisning**. Klik på en post i søgeresultaterne for at få den forhåndsvist.

## Hvorfor får jeg ingen søgeresultater, når jeg ved, at de findes i databasen?

Hvis du ingen søgeresultater får på et søgeord, som findes i SuperOffice-databasen, skal du muligvis oprette indekset til fritekstsøgning i Indstillinger og vedligeholdelse.

[!include[Examples of searches](includes/freetext-search-examples.md)]

## Relaterede emner

* [Brug skærmbilledet Søg][2]
* [Hurtigsøgning][3]
* [Historiklisten][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: using-fastsearcher.md
[4]: using-history-list.md

<!-- Referenced images -->
[img1]: media/freetext.bmp
