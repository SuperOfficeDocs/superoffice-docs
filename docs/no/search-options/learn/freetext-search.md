---
uid: help-no-search-freetext
title: Fritekstsøk
description: Fritekstsøk
author: SuperOffice RnD
date: 06.29.2022
keywords: fritekst, søk
topic: howto
language: no
---

# Fritekstsøk

Tekstfeltet øverst til høyre i SuperOffice CRM brukes til fritekstsøk. Da kan du søke i SuperOffice CRM etter tekst som brukere har lagt inn i databasen, for eksempel firmanavn, avdeling, informasjon om personer og oppfølginger.

![Fritekstsøk -screenshot][img1]

> [!NOTE]
> Hvis søkefeltene for fritekst ikke vises øverst til høyre, er ikke dette alternativet aktivert i Innstillinger og vedlikehold.

## Steg for steg

1. Skriv inn teksten du vil søke etter, minst tre bokstaver.

2. Trykk på **ENTER** for å starte søket.

3. Skjermbildet **Søkeresultater** åpnes, og viser alle data som inneholder søketeksten, gruppert i faner.

    * Klikk på en fane for å vise listen over søkeresultater.
    * Du kan gå til en post som vises i trefflisten ved å dobbeltklikke på den.

> [!TIP]
> Du kan forhåndsvise oppføringer i [sidepanelet][1]. Klikk på listen øverst i sidepanel og velg **Forhåndsvisning**. Klikk på en post i søkeresultatene for å forhåndsvise den.

## Eksempler på søk

* Søk etter "office" vil også vise SuperOffice.
* Hvis du feilstaver et ord, vil du få forslag. Et søk på "ofice" (feilstavet) vil også vise "SuperOffice". Dette er også svært nyttig når du husker deler av firmanavnet eller navnet på personen du søker etter.
* Søk etter "123" vil også vise resultater for "SAP 123", fordi tall også er indeksert.
* Hvis du søker etter "IBM", vises også resultater for "I.B.M.", fordi indekseren også fjerner anførselstegn, punktum og lignende tegn i indeksen.

## Begrensninger og ignorerte ord

* Du kan søke etter tekst fra dialogboksen **Dokumenter**, men du kan ikke søke i det faktiske innholdet av dokumenter. Det søkes alltid først etter tekst som står i feltet **Vår ref** i dialogboksen **Dokument**.

* Enkelte ord ignoreres i et fritekstsøk. Disse er definert i Innstillinger og vedlikehold.

## Hvorfor får jeg ikke noen treff på søkeord som jeg vet finnes i databasen?

Hvis du ikke får treff på et søkeord som ligger i SuperOffice-databasen, kan det skyldes at du må bygge indeksen for fritekstsøk i Innstillinger og vedlikehold.

## Aktuelle emner

* [Bruke Finn-bildet][2]
* [Hurtigsøk][3]
* [Historikklisten][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: index.md#fastsearcher
[4]: ../../learn/basics/history.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/freetext-search-find.png
