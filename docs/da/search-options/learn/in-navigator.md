---
uid: help-da-fastsearcher-navigator
title: Brug af hurtigsøgning i navigatoren
description: Brug af hurtigsøgning i navigatoren
author: Bergfrid Dias
date: 06.29.2022
keywords: søge, FastSearcher, navigator
topic: howto
language: da
---

# Brug af hurtigsøgning i navigatoren

1. Klik på ordet **Firma**, **Person**, **Salg**, **Projekt** eller **Udvalg** i navigatoren til venstre i vinduet. Der vises et tomt felt øverst. nedenunder dette er der en [liste over poster, du tidligere har arbejdet med][1].

    ![Hurtigsøgning -screenshot][img1]

2. I feltet skal du indtaste navnet på posten, der skal søges efter. Mens du indtaster, viser listen nedenunder alle de poster, der matcher.

3. Klik på den nødvendige post for at åbne den.

## How it works

The Navigator FastSearcher runs two parallel searches:

* A standard *begins-with* search with optional wildcard (%). In a phrase, the longest word is looked up first.

* An *exact-match* *sounds-like* ([SoundEx][2]) search. If the phrase contains short words, multiple words are needed before look-up starts. The result is shown only if the standard search has 0 matches.

## Eksempler

* Du kan søge efter et salg ved at indtaste navnet på salget eller navnet på et firma, der er knyttet til salget, i hurtigsøgningsfeltet for **Salg** i navigatoren.

* Du kan søge efter en person i hurtigsøgningsfeltet for **Firma** i navigatoren.

<!-- Referenced links -->
[1]: ../../learn/basics/history.md
[2]: ../../../en/api/osql/soundx.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/search-find-fastsearcher.png
