---
uid: help-en-search-freetext
title: Freetext search
description: Freetext search
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Freetext search

> [!NOTE]
> If the freetext search fields is not visible in the upper right corner, this option has not been activated in SuperOffice Settings and maintenance.

The text field at the top right in SuperOffice CRM is used for freetext searches.

This lets you search for any text in SuperOffice CRM which users have entered in the database, such as company name, department, information about contacts and follow-ups. You can search for text from the **Document** dialog, but you cannot search the actual contents of documents.

![Freetext search -screenshot][img1]

> [!NOTE]
> Certain words are ignored in a freetext search. These are defined in SuperOffice Settings and maintenance.

## Freetext searched from the text field

1. Type in the text to search for, entering at least three letters.
2. Press **ENTER** to start the search.
    > [!NOTE]
    > A search is always made first on text that is in the **Our Ref** field in the **Document** dialog.
3. The **Search results** screen opens with the results of the search. It shows all data containing the search text. The search results are grouped in tabs. Click the required tab to display the list of search results.

To go to a record shown in the hit list, double-click it.

You can preview records in the [side panel][1]. Click the list at the top of the side panel and select **Preview**. Click a record in the search results to preview it.

## Why am I getting no hits for a search word that I know is in the database?

If you get no hits for a search word that is in the SuperOffice database, this may be because you need to build the freetext search index in SuperOffice Settings and maintenance.

## Related topics

* [Use the Find screen][2]
* [FastSearcher][3]
* [The History list][4]

<!-- Referenced links -->
[1]: ../getting-started/side-panel.md
[2]: find-dialog.md
[3]: using-fastsearcher.md
[4]: using-history-list.md

<!-- Referenced images -->
[img1]: media/freetext.bmp
