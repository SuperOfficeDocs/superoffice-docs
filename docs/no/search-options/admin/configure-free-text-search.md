---
uid: help-no-settings-free-text-search
title: Konfigurer fritekstsøk
description: Konfigurer fritekstsøk
keywords: fritekstsøk
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
tier: starter
language: no
redirect_from:
  - /no/admin/options/learn/freetext-search/enable
  - /no/admin/options/learn/freetext-search/configure
  - /no/admin/options/learn/freetext-search/index
  - /no/search-options/admin/index
---

# Konfigurer fritekstsøk

Ved hjelp av funksjonen for fritekstsøk i SuperOffice CRM kan brukerne søke etter tekst i hele applikasjonen. Dette gjelder tekst de selv har lagt inn i databasen, for eksempel firmanavn, avdelinger og tekst fra bildene Person og Dokument.

Du kan definere nøyaktig hvordan dette skal fungere i SuperOffice CRM fra fanen **Fritekstsøk** i Innstillinger og vedlikehold.

## Angi søkekriterier for et fritekstsøk

Du kan angi søkekriterier for både enkeltord (for eksempel *Petter*) og fraser som består av flere ord (for eksempel *Ole Petter Nilsen*).

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Kontroller at fritekstsøk er aktivert.

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

## Relatert innhold

* [Legge til stoppord][3]

<!-- Referenced links -->
[3]: stopwords.md

<!-- Referenced images -->
