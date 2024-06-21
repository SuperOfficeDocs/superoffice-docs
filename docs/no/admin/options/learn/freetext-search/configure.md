---
uid: help-no-freetext-search-configure
title: Angi søkekriterier
description: Angi søkekriterier
author: Bergfrid Dias
date: 03.24.2023
keywords: fritekst, søk
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Angi søkekriterier for et fritekstsøk

Du kan angi søkekriterier for både enkeltord (for eksempel *Petter*) og fraser som består av flere ord (for eksempel *Ole Petter Nilsen*).

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller at [fritekstsøk er aktivert][1].

1. For **Søkekriterium ved enkeltord** velger du ett av følgende:

    * **Begynner med**: Her kan for eksempel søk på *pett* gi *Petter* og *Pettersen* som treff.
    * **Inneholder**: Her kan for eksempel søk på *ette* gi *Petter* og *Pettersen* som treff.
    * **Er nøyaktig lik**: Her må du søke på *Petter* for å få *Petter* som treff.

    > [!NOTE]
    > Det er alternativet **Er nøyaktig lik** som er det minst ressurskrevende under søking, mens alternativet **Inneholder** er det mest ressurskrevende.

1. For **Søkekriterium ved flere ord** velger du ett av følgende:
    * **Begynner med**: Her kan for eksempel søk på *pett* gi *Petter Nilsen* som treff.
    * **Inneholder**: Her kan for eksempel søk på *pett* gi *Ole Petter Nilsen* og *Arne Pettersen* som treff.
    * **Er nøyaktig lik**: Her må du søke på *Ole Petter Nilsen* for å få *Ole Petter Nilsen* som treff.

    > [!NOTE]
    > Ved søk på fraser som består av flere ord, søkes det etter alle ordene samtidig.

<!-- Referenced links -->
[1]: enable.md

<!-- Referenced images -->
