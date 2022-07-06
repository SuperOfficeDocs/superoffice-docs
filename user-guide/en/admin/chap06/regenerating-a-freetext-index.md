---
uid: help-en-regenerating-a-freetext-index
title: Regenerating a freetext index
description: Regenerating a freetext index
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
so.envir: onsite
---

# Regenerate a freetext index

This tab is only available if your SuperOffice installation is onsite. If you are using the online solution, your cannot make any changes to these settings. For SuperOffice Online, the freetext index is regenerated every 7 days by default.

When you add or delete new stopwords (see [Add stopwords](Adding-stopwords.md), [Suggest stopwords](Suggesting-stopwords.md) and [Delete stopwords](Deleting-stopwords.md)), your changes do not have a retroactive effect. This means that if you enter *and* as a stopword and already have many occurrences of *and* in the database, they will not be automatically removed from the freetext index. The change will only apply to any occurrences of *and* that you add from then on. In some cases it may be appropriate to update the freetext index, so that all stopwords are removed from it.

To regenerate the freetext index:

1. Click the **Options** button in the Navigator (![icon](../media/Knapp-Systemvalg-liten.bmp)).
2. Select the **Free text search** tab.
3. Check that freetext search is enabled for SuperOffice CRM (see [Enable freetext search](Enabling-freetext-search.md)).
4. Click the **Regenerate Freetext Index** button.
5. A message is displayed to the effect that it can take a long time to generate a new index and that users will not be able to access the freetext search function during this period. Click **OK**. A window opens showing the progress of the regeneration process. When this disappears, the new freetext index is ready.

> [!NOTE]
> To regenerate a freetext index you must belong to the **User level 0** role (or equivalent). On Oracle databases, you need to be the user who is the database owner.
