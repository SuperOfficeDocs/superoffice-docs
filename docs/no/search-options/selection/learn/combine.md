---
uid: help-no-selection-combine
title: Opprett et kombinasjonsutvalg
description: I denne veiledningen lærer du hvordan du lager et kombinasjonsutvalg.
keywords: kombiner utvalg, kombinasjonsutvalg, utvalg
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: /no/search-options/selection/learn/create/combine
---

# Opprett et kombinasjonsutvalg

De to utvalgene som kombineres, kan være statiske eller dynamiske. Det er imidlertid visse begrensninger for hva som kan kombineres:

* Hvis du velger å opprette et kombinasjonsutvalg som består av firmaer, er alle typer utvalg tilgjengelig.
* Hvis du derimot velger å opprette et kombinasjonsutvalg som består av salg, prosjekter, dokumenter, oppfølginger eller produkter, blir bare utvalg av den valgte typen tilgjengelig.

## Finn dataen

1. Åpne ett av utvalgene du vil kombinere.

1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), og velg **Kombiner utvalg med**. Et nytt skjermbilde for utvalg åpnes.

1. Skriv inn navnet på det nye utvalget i feltet som inneholder *Utvalgsnavn*. Dette feltet er obligatorisk.

1. I feltet **Utvalg av** velger du hva utvalget skal inneholde. Valgene her er begrenset til **Firma/person** og den typen utvalg du har valgt. Du kan ikke endre dette når det er lagret i databasen.

1. I feltet **Utvalget er**, er **Kombinert** valgt som standard.

1. Under **Utvalg 2** velger du de to utvalgene du vil kombinere.

    > [!NOTE]
    > Hvis du valgte **Firmaer/personer** under **Utvalg av**, kan du velge blant alle typer utvalg her (et salgsutvalg inneholder også firmaer/personer knyttet til salget). Men hvis kombinasjonsutvalget omfatter Salg, Prosjekter, Dokumenter, Oppfølginger, Saker, Skjemainnsendinger, Chatsamtaler, Utsendelser eller Produkter, må du velge samme type utvalg for **utvalg 1** og **utvalg 2**.

1. Under **Sammenlign**, velger du hvilke oppføringer fra de to utvalgene som skal inkluderes i kombinasjonsutvalget.

| Ikon | Alternativ | Beskrivelse |
|:-:|---|---|
| <i class="ph ph-subtract" aria-label="Only in one selection icon"></i> | Bare i utvalg 1/Bare i utvalg 2 | Viser oppføringer som finnes i utvalg 1 eller utvalg 2, og ekskluderer oppføringer som finnes i både utvalg 1 og 2. |
| <i class="ph ph-intersect" aria-label="Common entries icon"></i> | Felles | Viser bare oppføringer som finnes i både utvalg 1 og 2. |
| <i class="ph ph-exclude" aria-label="Difference icon"></i> | Forskjell | Viser bare oppføringer som finnes enten i utvalg 1 eller i utvalg 2. |
| <i class="ph ph-unite" aria-label="All entries icon"></i> | Alle | Viser alle oppføringer i både utvalg 1 og 2. |

## Velg detaljer

Angi egenskaper ved å følge instruksjonene i trinn 2 i opplæringen [Opprett utvalg][1].

## Fullfør

1. Klikk eventuelt på stjerneikonet (<i class="ph ph-star" aria-hidden="true"></i>) for å legge utvalget til [favorittene dine][2].

1. Klikk på **Lagre**.

Når du har lagret utvalget, kan du [redigere det][3] for å endre både kombinasjonstypen og hvilke utvalg som kombineres. Men det er ikke mulig å endre feltet **Utvalg av**.

## Eksempler på kombinasjonsutvalg

### Firmaer og salg

1. Opprett et kombinasjonsutvalg for firmaer/personer basert på to eksisterende utvalg: "Kunder i Sverige" (utvalg 1) og "Gjennomførte salg i fjor" (utvalg 2).
2. Velg kombinasjonstypen **Kun i utvalg 1**. Resultatet vil inneholde kunder i Sverige som dere ikke solgte noe til i fjor.
3. Lagre resultatet som et statisk utvalg med navnet "Kunder i Sverige uten salg", og gi en av selgerne ansvaret for å følge opp disse kundene.

### Oppfølginger

1. Opprett et kombinasjonsutvalg for oppfølginger basert på to eksisterende utvalg: "Oppfølginger knyttet til mine kunder" (utvalg 1) og "Planlagte oppfølginger i neste måned" (utvalg 2).
2. Velg kombinasjonstypen **Felles**. Resultatet er en liste over oppfølginger du må håndtere neste måned. Disse kan du for eksempel eksportere til en fil ved hjelp av oppgaven **Eksporter til fil**.

> [!NOTE]
> Dersom du bare vil sammenligne firmaer som er knyttet mot disse to utvalgene, merker du av for **Sammenligne bare firmaer**.

<!-- Referenced links -->
[1]: create.md
[3]: update/index.md
[2]: ../../../learn/basics/fav.md
