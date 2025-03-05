---
uid: help-da-selection-combined
title: Kombinerede udvalg
description: Kombinerede udvalg
author: SuperOffice RnD
date: 06.29.2022
keywords: selection
topic: concept
language: da
---

# Kombinerede udvalg

Et kombinationsudvalg er en kombination af to eksisterende udvalg.

Kombinationsudvalget kan indeholde poster, som er fælles for de to eksisterende udvalg, poster som er forskellige, poster, som kun findes i et af udvalgene og alle poster i de to udvalg.

Der er dog begrænsninger for, hvad der kan kombineres:

* Hvis du vælger at oprette et kombinationsudvalg, som består af firmaer, bliver alle typer udvalg tilgængelige.
* Hvis du derimod vælger at oprette et kombinationsudvalg, som består af salg, projekter, dokumenter, opfølgninger eller produkter, bliver kun den valgte type udvalg tilgængelige.

De to udvalg, der kombineres, kan være statiske eller dynamiske. Når du har oprettet et kombinationsudvalg, kan du vælge at ændre det til et statisk udvalg.

## Hvordan kombineres de to udvalg?

Du kan vælge, hvilke poster du vil medtage i kombinationsudvalget. Disse indstillinger er tilgængelige:

[!include[Options for combining selections](includes/table-selection-combinations.md)]

## Eksempler på kombinationsudvalg

### Firmaer og salg

1. Opret et kombinationsudvalg for firmaer/personer på grundlag af to eksisterende udvalg: "Kunder i Sverige" (udvalg 1) og "Gennemførte salg sidste år" (udvalg 2).
2. Vælg kombinationstypen **Kun i udvalg 1**. Resultatet vil indeholde kunder i Sverige, som der ikke blev solgt noget til sidste år.
3. Gem resultatet som et statisk udvalg under navnet "Kunder i Sverige uden salg", og giv en af sælgerne ansvaret for at følge op på disse kunder.

### Opfølgninger

1. Opret et kombinationsudvalg for opfølgninger på grundlag af to eksisterende udvalg: "Opfølgninger knyttet til mine kunder" (udvalg 1) og "Planlagte opfølgninger i næste måned" (udvalg 2).
2. Vælg kombinationstypen **Fælles**. Resultatet er en liste over opfølgninger, du skal gennemføre næste måned. Disse kan du for eksempel eksportere til en fil ved hjælp af opgaven **Eksporter til fil**.

> [!NOTE]
> Hvis du kun vil sammenligne de firmaer, der er knyttet til disse to udvalg, skal du markere **Sammenlign kun firmaer**.

## Relateret indhold

* [Oprettelse af kombinationsudvalg][1]

<!-- Referenced links -->
[1]: create/combine.md

<!-- Referenced images -->
