---
uid: help-en-free-text-index-regen
title: Regenerating a free-text index
description: Regenerating a free-text index
keywords: free-text, search index
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
deployment: onsite
redirect_from: /en/admin/options/learn/freetext-search/regenerate-index
---

# Regenerate a free-text index (onsite)

> [!NOTE]
> This tab is available only if your SuperOffice installation is onsite. If you are using the online solution, your cannot make any changes to these settings. For SuperOffice Online, the free-text index is regenerated every 7 days by default.
>
> To regenerate a free-text index you must belong to the **User level 0** role (or equivalent). On Oracle databases, you must be the user who is the database owner.

When you [add or delete new stopwords][1], your changes do not have a retroactive effect. This means that if you enter *and* as a stopword and already have many occurrences of *and* in the database, they will not be automatically removed from the free-text index. The change applies only to occurrences of *and* that you add from then on. In some cases it may be appropriate to update the free-text index, so that all stopwords are removed from it.

## To regenerate the free-text index

1. [!include[Go to free-text search tab](includes/goto-freetext.md)]

1. Make sure the **Enable freetext search** option is selected.

1. Click the **Regenerate Freetext Index** button.

1. A message is displayed to the effect that it can take a long time to generate a new index and that users cannot access the free-text search function during this period. Click **OK**. A window opens showing the progress of the regeneration process. When this disappears, the new free-text index is ready.

<!-- Referenced links -->
[1]: stopwords.md

<!-- Referenced images -->
