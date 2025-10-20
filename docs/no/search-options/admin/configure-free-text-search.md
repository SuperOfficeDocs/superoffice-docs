---
uid: help-no-settings-free-text-search
title: Konfigurer fritekstsøk
description: Konfigurer fritekstsøk
keywords: fritekstsøk
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
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

## Deaktiver fritekstsøk (onsite)

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Fjern avmerkingen for **Aktiver fritekstsøk**.

Fritekstsøk er aktivert som standard, men hvis organisasjonen ønsker å spare systemressurser som brukes til å oppdatere fritekstindeksen ved nye data, kan du fjerne avmerkingen på **Gjør fritekstsøk tilgjengelig**. Da deaktiveres feltet for fritekstsøk i SuperOffice CRM onsite. Merk: fritekstsøk kan ikke deaktiveres for online-/cloud-versjoner.

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
* [Bygge fritekstindeks][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
