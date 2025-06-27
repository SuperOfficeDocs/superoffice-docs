---
uid: help-en-freetext-search-configure
title: Specifying search criteria
description: Specifying search criteria
author: Bergfrid Dias
date: 03.24.2023
keywords: free-text, search
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Specify search criteria for a freetext search

You can specify search criteria for both individual words (for example *Peter*) and phrases consisting of several words (for example *Oliver Peter Nielsen*).

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Check that [freetext search is enabled][1].

1. Choose one of the following for **Single-word search operator**:

    * **Starts with**: a search for *pet* returns *Peter* and *Peterson* as hits.
    * **Contains**: a search for *eter* returns *Peter* and *Peterson* as hits.
    * **Exact match**: a search for *Peter* only returns *Peter* as a hit.

    > [!NOTE]
    > The **Exact match** option is the least resource-intensive when searching, while the **Contains** option is the most resource-intensive.

1. Choose one of the following for **Multi-word search operator**:
    * **Starts with**: a search for *pet* returns *Peter Nielsen* as a hit.
    * **Contains**: a search for *pet* returns *Oliver Peter Nielsen* and *Alan Peterson* as hits.
    * **Exact match**: only a search for *Oliver Peter Nielsen* returns *Oliver Peter Nielsen* as a hit.

    > [!NOTE]
    > When searching for phrases consisting of several words, a search is made for all the words together.

<!-- Referenced links -->
[1]: enable.md

<!-- Referenced images -->
