---
uid: help-en-fastsearcher-navigator
title: FastSearcher in Navigator
description: How to use FastSearcher in the Navigator in SuperOffice
keywords: search, FastSearcher
author: Bergfrid Dias
date: 01.20.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Using FastSearcher in the Navigator

1. Click the word **Company**, **Contact**, **Sale**, **Project**, **Request**, or **Selection** in the Navigator on the left of the window. An empty field is displayed at the top. Below this is a [list of records you have previously worked with][1].

    ![FastSearcher -screenshot][img1]

2. In the box, enter the name of the record to search for. While you type, the list below displays all matching records.

3. Click the required record to open it.

## How it works

The Navigator FastSearcher runs two parallel searches:

* A standard *begins-with* search with optional wildcard (%). In a phrase, the longest word is looked up first.

* An *exact-match* *sounds-like* ([SoundEx][2]) search. If the phrase contains short words, multiple words are needed before look-up starts. The result is shown only if the standard search has 0 matches.

## Examples

* You can search for a sale by entering the name of the sale or the name of a company linked to the sale, in the FastSearcher field for **Sales** in the Navigator.

* You can search for a contact in the FastSearcher field for **Companies** in the Navigator.

<!-- Referenced links -->
[1]: ../../learn/basics/history.md
[2]: ../../../en/api/osql/soundx.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/search-find-fastsearcher.png
