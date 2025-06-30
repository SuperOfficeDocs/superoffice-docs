---
uid: help-nl-fastsearcher-navigator
title: De functie Snel zoeken gebruiken in de navigator
description: De functie Snel zoeken gebruiken 
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
keywords: zoeken, Snel zoeken, navigator
content_type: howto
language: nl
---

# Snel zoeken gebruiken in de navigator

1. Klik op het woord **Bedrijf**, **Persoon**, **Verkoop**, **Project** of **Selectie** in de navigator (links in het venster). Bovenin het venster wordt een leeg veld weergegeven. Onder het veld staat een [lijst met records waarmee u eerder hebt gewerkt][1].

    ![Snel zoeken -screenshot][img1]

2. Voer in het vak de naam van de record in waarnaar moet worden gezocht. Terwijl u typt, worden in de onderstaande lijst alle overeenkomende records weergegeven.

3. Klik op de gewenste record om deze te openen.

## How it works

The Navigator FastSearcher runs two parallel searches:

* A standard *begins-with* search with optional wildcard (%). In a phrase, the longest word is looked up first.

* An *exact-match* *sounds-like* ([SoundEx][2]) search. If the phrase contains short words, multiple words are needed before look-up starts. The result is shown only if the standard search has 0 matches

## Voorbeelden

* U kunt zoeken naar een verkoop door de naam van de verkoop of de naam van een bedrijf dat aan de verkoop is gekoppeld in te voeren in het veld Snel zoeken voor **Verkoop** in de navigator.

* U kunt zoeken naar een contactpersoon in het veld Snel zoeken voor **Bedrijven** in de navigator.

<!-- Referenced links -->
[1]: ../../learn/basics/history.md
[2]: ../../../en/api/osql/soundx.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/search-find-fastsearcher.png
