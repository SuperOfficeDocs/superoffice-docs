---
uid: help-no-settings-freetext-search
title: Fritekstsøk
description: Fritekstsøk
keywords: fritekst, søk
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
redirect_from:
  - /no/admin/options/learn/freetext-search/enable.html
  - /no/admin/options/learn/freetext-search/configure.html
---

# Konfigurer fritekstsøk

Ved hjelp av funksjonen for fritekstsøk i SuperOffice CRM kan brukerne søke etter tekst i hele applikasjonen. Dette gjelder tekst de selv har lagt inn i databasen, for eksempel firmanavn, avdelinger og tekst fra bildene Person og Dokument.

Du kan definere nøyaktig hvordan dette skal fungere i SuperOffice CRM fra denne fanen i Innstillinger og vedlikehold. Merk: fritekstsøk kan bare deaktiveres for onsite-løsninger, ikke for online-/cloud-versjoner.

## Aktivere fritekstsøk

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Merk av for **Aktiver fritekstsøk**.

Fritekstsøk er aktivert som standard, men hvis din organisasjon ønsker å unngå at det brukes tid og plass på systemet til å oppdatere fritekstindeksen hver gang det lagres noe nytt i databasen, kan man fjerne avmerkingen på **Gjør fritekstsøk tilgjengelig**. I så fall deaktiveres feltet for fritekstsøk i SuperOffice CRM onsite.

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
