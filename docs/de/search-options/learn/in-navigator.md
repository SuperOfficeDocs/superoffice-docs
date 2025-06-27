---
uid: help-de-fastsearcher-navigator
title: Schnellsuche im Navigator verwenden
description: Schnellsuche im Navigator verwenden im SuperOffice
author: Bergfrid Dias
date: 05.25.2023
keywords: suche, Schnellsuche
content_type: howto
language: de
---

# Schnellsuche im Navigator verwenden

1. Klicken Sie im links im Fenster angezeigten Navigator auf **Firma**, **Person**, **Verkauf**, **Projekt**, **Selektion**, oder **Anfrage**. Oben wird ein leeres Feld eingeblendet. Darunter befindet sich eine [Liste der Datensätze, mit denen Sie bereits gearbeitet haben][1].

    ![Schnellsuche -screenshot][img1]

2. Geben Sie im Feld den Namen des zu suchenden Datensatzes ein. Während der Eingabe werden in der folgenden Liste alle übereinstimmenden Datensätze angezeigt.

3. Klicken Sie zum Öffnen auf den gewünschten Datensatz.

## How it works

The Navigator FastSearcher runs two parallel searches:

* A standard *begins-with* search with optional wildcard (%). In a phrase, the longest word is looked up first.

* An *exact-match* *sounds-like* ([SoundEx][2]) search. If the phrase contains short words, multiple words are needed before look-up starts. The result is shown only if the standard search has 0 matches.

## Beispiele

* Sie können nach einem Verkauf suchen, indem Sie den Namen des Verkaufs oder den Namen einer Firma, die mit dem Verkauf verknüpft ist, in das Schnellsuchfeld für **Verkäufe** im Navigator eingeben.

* Sie können im Schnellsuchfeld für **Firmen** im Navigator nach einer Person suchen.

<!-- Referenced links -->
[1]: ../../learn/basics/history.md
[2]: ../../../en/api/osql/soundx.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/search-find-fastsearcher.png
