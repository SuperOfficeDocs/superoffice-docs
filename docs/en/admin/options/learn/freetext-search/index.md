---
uid: help-en-settings-freetext-search
title: Freetext search
description: Freetext search
keywords: free-text, search
author: Bergfrid Dias
date: 10.31.2024
version: 10
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from:
  - /en/admin/options/learn/freetext-search/enable.html
  - /en/admin/options/learn/freetext-search/configure.html
---
 
# Freetext search

Using the freetext search function in SuperOffice CRM, users can search for text throughout the application. This applies to text which they themselves have added to the database, for example, company names, departments, and text from the Contact and Document screens.

You can define exactly how this will work in SuperOffice CRM using this tab in Settings and maintenance. Freetext search can only be deactivated for onsite solutions, not for online/cloud versions

## Enable freetext search

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Check **Enable freetext search**.

By default, freetext search is enabled, but if your organization wishes to avoid the system overheads in time and space caused by the freetext index update when new entries are added to the database, you can uncheck **Enable freetext search**. This disables the freetext search field in SuperOffice CRM onsite.

## Specify search criteria for a freetext search

You can specify search criteria for both individual words (for example *Peter*) and phrases consisting of several words (for example *Oliver Peter Nielsen*).

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Check that freetext search is enabled.

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

## What would you like to do now?

* [Add stopwords][3]
* [Regenerate a freetext index][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
