---
uid: help-da-selection-combine
title: Oprettelse af kombinationsudvalg
description: I denne vejledning lærer du, hvordan du opretter et kombinationsudvalg.
keywords: kombinere udvalg, kombinationsudvalg, udvalg, 
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from: /da/search-options/selection/learn/create/combine
---

# Oprettelse af kombinationsudvalg

De to udvalg, der kombineres, kan være statiske eller dynamiske. Der er dog begrænsninger for, hvad der kan kombineres:

* Hvis du vælger at oprette et kombinationsudvalg, som består af firmaer, bliver alle typer udvalg tilgængelige.
* Hvis du derimod vælger at oprette et kombinationsudvalg, som består af salg, projekter, dokumenter, opfølgninger eller produkter, bliver kun den valgte type udvalg tilgængelige.

## Find dataene

1. Åbn et af de udvalg, du vil kombinere.

1. Klik på knappen **Opgave** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), og vælg **Kombiner udvalg med**. Et nyt udvalgsskærmbillede åbnes.

1. Indtast navnet på det nye udvalg i feltet, hvor der står *Udvalgsnavn*. Dette felt er obligatorisk.

1. I feltet **Udvalg af** vælger du, hvad udvalget skal indeholde. Valgmulighederne her er begrænsede til **Firma/person** og den type udvalg, du har valgt. Du kan ikke ændre dette, efter at det er gemt i databasen.

1. I feltet **Udvalg er** er **Kombination** valgt som standard.

1. Under **Udvalg 2**vælger du det andet udvalg, som du vil kombinere.

    > [!NOTE]
    > Hvis du har valgt **Firmaer/personer** under **Udvalg af**, kan du vælge mellem alle typer af udvalg her (et salgsudvalg indeholder også firmaer/personer knyttet til salg). Hvis kombinationsudvalget derimod består af Salg, Projekter, Dokumenter, Opfølgninger, Sager, Formularindsendelser, Chatsamtaler, Udsendelser eller Produkter, skal du vælge den samme type udvalg for **Udvalg 1** og **Udvalg 2**.

1. Under **Sammenlign** skal du vælge, hvilke poster fra de to udvalg du vil medtage i kombinationsudvalget.

| Ikon | Mulighed | Beskrivelse |
|:-:|---|---|
| <i class="ph ph-subtract" aria-label="Only in one selection icon"></i> | Kun i udvalg 1/Kun i udvalg 2 | Viser poster, som findes i udvalg 1 eller 2, og medtager ikke poster, som findes i både udvalg 1 og 2. |
| <i class="ph ph-intersect" aria-label="Common entries icon"></i> | Fælles | Viser kun poster, som findes i både udvalg 1 og 2. |
| <i class="ph ph-exclude" aria-label="Difference icon"></i> | Forskel | Viser kun poster, som findes enten i udvalg 1 eller i udvalg 2. |
| <i class="ph ph-unite" aria-label="All entries icon"></i> | Alle | Viser alle poster i både udvalg 1 og 2. |

## Vælg detaljer

Angiv egenskaber ved at følge vejledningen i trin 2 i [Opret et udvalg][1].

## Fuldfør

1. Klik på stjerneikonet (<i class="ph ph-star" aria-hidden="true"></i>) for eventuelt at føje udvalget til [dine favoritter][2].

1. Klik på **Gem**.

Når udvalget er gemt, kan du [redigere det][3] for at ændre både kombinationstypen og hvilke udvalg, der skal kombineres. Det er dog ikke muligt at ændre feltet **Udvalg af**.

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

<!-- Referenced links -->
[1]: create.md
[3]: update/index.md
[2]: ../../../learn/basics/fav.md
