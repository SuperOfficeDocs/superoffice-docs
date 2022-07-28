---
uid: help-en-deleting-stopwords
title: Deleting stopwords
description: Deleting stopwords
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Delete stopwords

The object of deleting stopwords is to include them in freetext searches after having excluded them. To delete a stopword from the list:

1. Click the **Options** button in the Navigator (![icon][img1]).

2. Select the **Free text search** tab.

3. Check that freetext search is enabled for SuperOffice CRM (see [Enable freetext search][1]).

4. Select the required stopword.

5. Click the **Delete** button below the stopword list.

    > [!NOTE]
    > Changes to the stopword list do not have a retroactive effect, i.e. deleted stopwords will still function as stopwords for fields that were created before you deleted them. If you want your changes to apply retroactively, you can generate a new freetext index.

<!-- Referenced links -->
[1]: enabling-freetext-search.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/knapp-systemvalg-liten.bmp
