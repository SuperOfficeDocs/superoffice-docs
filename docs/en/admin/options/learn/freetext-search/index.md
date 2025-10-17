---
uid: help-en-settings-free-text-search
title: Free-text search
description: Free-text search
keywords: free-text, search
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
redirect_from:
  - /en/admin/options/learn/freetext-search/enable.html
  - /en/admin/options/learn/freetext-search/configure.html
---
 
# Configure free-text search

Using the free-text search function in SuperOffice CRM, users can search for text throughout the application. This applies to text which they themselves have added to the database, for example, company names, departments, and text from the Contact and Document screens.

You can define exactly how this will work in SuperOffice CRM using this tab in Settings and maintenance. Free-text search can only be deactivated for onsite solutions, not for online/cloud versions

## Enable free-text search

1. [!include[Go to free-text search tab](includes/goto-freetext.md)]

1. Check **Enable freetext search**.

By default, free-text search is enabled, but if your organization wishes to avoid the system overheads in time and space caused by the free-text index update when new entries are added to the database, you can uncheck **Enable freetext search**. This disables the free-text search field in SuperOffice CRM onsite.

## Specify search criteria for a free-text search

You can specify search criteria for both individual words (for example *Peter*) and phrases consisting of several words (for example *Oliver Peter Nielsen*).

1. [!include[Go to free-text search tab](includes/goto-freetext.md)]

1. Check that free-text search is enabled.

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

## Related content

* [Add stopwords][3]
* [Regenerate a free-text index][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
