---
uid: help-da-search-freetext
title: Fritekstsøgning
description: Fritekstsøgning
author: SuperOffice RnD
date: 05.25.2023
keywords: fritekst, søge
topic: howto
language: da
---

# Fritekstsøgning

Tekstfeltet øverst til højre i SuperOffice CRM kan bruges til fritekstsøgninger. Her kan du søge i SuperOffice CRM efter tekst, som brugerne selv har lagt ind i databasen, for eksempel firmanavn, afdeling, information om personer og opfølgninger.

![Fritekstsøgning -screenshot][img1]

> [!NOTE]
> Hvis felterne for fritekstsøgning ikke vises i det øverste højre hjørne, er denne indstilling ikke aktiveret i Indstillinger og vedligeholdelse.

## Trin

1. Skriv den tekst, du vil søge efter (mindst tre bogstaver).

2. Tryk på **Enter** for at starte søgningen.

3. Skærmbilledet **Søgeresultater** åbnes og viser alle data, der indeholder søgeteksten grupperet i faner.

    * Klik på fanen for at få vist listen over søgeresultater.
    * Du kan gå til en post på resultatlisten ved at dobbeltklikke på den.

> [!TIP]
> Du kan få forhåndsvist poster i [sidepanelet][1]. Klik på listen øverst i sidepanelet, og vælg **Forhåndsvisning**. Klik på en post i søgeresultaterne for at få den forhåndsvist.

## Eksempler på søgninger

* Søgning efter "office" (kontor) vil også returnere SuperOffice.
* Hvis du staver et ord forkert, får du forslag. En søgning efter "ofice" (stavet forkert) vil også returnere "SuperOffice". Dette er også meget nyttigt, når du kan huske dele af den virksomheden eller person, du søger efter.
* Søgning efter "123" vil også returnere "SAP 123", fordi tal også er søgbart.
* Søgning efter "IBM" vil også returnere "I.B.M.", fordi indekseringsfunktionen også fjerner anførselstegn, punktummer og lignende tegn i indekset.

## Begrænsninger og ignorerede ord

Du kan søge efter tekst fra dialogboksen **Dokument**, men du kan ikke søge i det faktiske indhold af dokumenter. Der søges altid først efter tekst, som står i feltet **Vores ref.** i dialogboksen **Dokument**.

Enkelte ord ignoreres i en fritekstsøgning. Disse er defineret i Indstillinger og vedligeholdelse.

## Hvorfor får jeg ingen søgeresultater, når jeg ved, at de findes i databasen?

Hvis du ingen søgeresultater får på et søgeord, som findes i SuperOffice-databasen, skal du muligvis oprette indekset til fritekstsøgning i Indstillinger og vedligeholdelse.

## Relateret indhold

* [Brug skærmbilledet Søg][2]
* [Hurtigsøgning][3]
* [Historiklisten][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: index.md#fastsearcher
[4]: ../../learn/basics/history.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/freetext-search-find.png
