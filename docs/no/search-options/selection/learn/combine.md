---
uid: help-no-selection-combine
title: Opprett et kombinasjonsutvalg
description: I denne veiledningen lærer du hvordan du lager et kombinasjonsutvalg.
keywords: utvalg
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Opprett et kombinasjonsutvalg

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

<!-- Referenced links -->
[1]: create.md
[3]: update/index.md
[2]: ../../../learn/basics/fav.md
