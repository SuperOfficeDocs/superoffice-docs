---
uid: help-en-search-freetext
title: Free-text search
description: How to use the free-text search to find any text that users have entered into SuperOffice.
keywords: free-text, search
author: Bergfrid dias
date: 01.20.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Freetext search

The search field at the upper right in SuperOffice CRM is used for freetext searches. This lets you search in SuperOffice for any text that users have entered into the database, such as company name, department, information about contacts, and follow-ups.

![Freetext search -screenshot][img1]

> [!NOTE]
> If the freetext search field is not visible in the upper-right corner, this option has not been activated in Settings and maintenance.

## Steps

1. Type in the text to search for, entering at least three letters.

2. Press **ENTER** to start the search.

3. The **Search results** screen opens, showing all data containing the search text grouped in tabs.

    * To display the list of search results, click a tab.
    * To go to a record shown in the list, double-click it.

> [!TIP]
> You can preview records in the [side panel][1]. Click the list at the top of the side panel and select **Preview**. Click a record in the search results to preview it.

## Examples

* Searching for "office" will also return SuperOffice.
* If you misspell a word, you will get suggestions. A search for "ofice" (misspelled) will also return "SuperOffice". This is also very useful when you remember parts of the company or contact you are searching for.
* Searching for "123" will also return "SAP 123", because numbers are also indexed.
* Searching for "IBM" will also return "I.B.M.", because the indexer also removes quotes, full stops and similar characters in the index.

## Limitations and ignored words

* You can search for text from the **Document** dialog, but you cannot search the actual contents of documents. A search is always made first on text that is in the **Our Ref** field in the **Document** dialog.

* Certain words are ignored in the freetext search. These are defined in Settings and maintenance.

## Why am I getting no hits for a search word that I know is in the database?

If you get no hits for a search word that is in the SuperOffice database, this may be because you need to build the free-text search index in Settings and maintenance.

## Related topics

* [The Find screen][2]
* [FastSearcher][3]
* [The History list][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: index.md#fastsearcher
[4]: ../../learn/basics/history.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/freetext-search-box.png
