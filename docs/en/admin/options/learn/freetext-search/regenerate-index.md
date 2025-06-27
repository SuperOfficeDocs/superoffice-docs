---
uid: help-en-freetext-index-regen
title: Regenerating a freetext index
description: Regenerating a freetext index
author: Bergfrid Dias
date: 03.24.2023
keywords: free-text, search index
content_type: howto
language: en
envir: onsite
---

# Regenerate a freetext index (onsite)

> [!NOTE]
> This tab is available only if your SuperOffice installation is onsite. If you are using the online solution, your cannot make any changes to these settings. For SuperOffice Online, the freetext index is regenerated every 7 days by default.

When you [add or delete new stopwords][1], your changes do not have a retroactive effect. This means that if you enter *and* as a stopword and already have many occurrences of *and* in the database, they will not be automatically removed from the freetext index. The change applies only to occurrences of *and* that you add from then on. In some cases it may be appropriate to update the freetext index, so that all stopwords are removed from it.

## To regenerate the freetext index

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Check that [freetext search is enabled][4].

1. Click the **Regenerate Freetext Index** button.

1. A message is displayed to the effect that it can take a long time to generate a new index and that users cannot access the freetext search function during this period. Click **OK**. A window opens showing the progress of the regeneration process. When this disappears, the new freetext index is ready.

> [!NOTE]
> To regenerate a freetext index you must belong to the **User level 0** role (or equivalent). On Oracle databases, you must be the user who is the database owner.

<!-- Referenced links -->
[1]: stopwords.md
[4]: enable.md

<!-- Referenced images -->
