---
uid: help-no-stopwords
title: Stoppord
description: Stoppord
author: Bergfrid Dias
date: 03.21.2023
keywords: fritekst, søk, stoppord
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Stoppord

Et stoppord er et ord som ikke indekseres (ikke inkluderes i fritekstsøk). Dette kan for eksempel gjelde ord som *og*, *eller*, *det* og *for*. Hensikten med å definere stoppord er at det skal ta mindre tid å søke gjennom fritekstindeksen ved at unødvendige ord utelates, og at indeksen skal ta opp mindre plass i databasen.

De ordene som er definert som stoppord for fritekstsøk, vises i tabellen under **Stoppordliste** i fanen **Fritekstsøk** i Systemvalg-bildet.

> [!TIP]
> Hvis du vil at endringene dine skal ha tilbakevirkende kraft, må du [generere fritekstindeksen på nytt][3]. Gjør dette etter at du har lagt til stoppord, etter at systemet har foreslått stoppord, eller etter at du har importert en stor mengde tekst.

## Legge til stoppord

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller at [fritekstsøk er aktivert][2].

1. Klikk på **Legg til**-knappen under stoppordlisten.

1. I dialogboksen **Nye stoppord** skriver du inn ett eller flere stoppord du vil ha med. Alle tegn bortsett fra punktum kan brukes som skilletegn.

1. Klikk på **Lagre**.

1. Du får en melding om at endringer i stoppordlisten ikke har tilbakevirkende kraft. Det vil si at nye stoppord ikke vil gjelde for tekst som ble registrert før stoppordene ble definert. Klikk på **OK**.

## Foreslå stoppord

I stedet for å skrive inn stoppordene manuelt, kan du la systemet foreslå stoppord for deg.

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller at [fritekstsøk er aktivert][2].

1. Klikk på **Foreslå**-knappen under stoppordlisten.

1. Du får en melding om at det kan ta lang tid å gå gjennom ordlisten og indeksen for å finne frem til mulige stoppord. Klikk på **OK**.

1. Når systemet har funnet frem til mulige stoppord, vises disse i dialogboksen **Nye stoppord**. De mest brukte ordene i databasen vises øverst. Merk av for hvilke du vil ta med som stoppord. Hold nede **CTRL**-tasten, og klikk på de aktuelle stoppordene.

1. Klikk på **Lagre**.

1. Du får en melding om at endringer i stoppordlisten ikke har tilbakevirkende kraft, noe som betyr at nye stoppord ikke vil gjelde for felt som ble registrert før stoppordene. Klikk på **OK**.

## Slette stoppord

Hensikten med å slette stoppord er å inkludere dem i fritekstsøk likevel, etter at de har blitt ekskludert. Slik sletter du et stoppord fra listen:

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller at [fritekstsøk er aktivert][2].

1. Merk ønsket stoppord.

1. Klikk på **Slett**-knappen under stoppordlisten.

<!-- Referenced links -->
[2]: enable.md
[3]: regenerate-index.md

<!-- Referenced images -->
