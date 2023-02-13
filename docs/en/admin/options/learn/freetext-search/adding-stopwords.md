---
uid: help-en-adding-stopwords
title: Adding stopwords
description: Adding stopwords
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add stopword

> [!NOTE]
> Instead of entering stopwords manually, you can let the system suggest stopwords for you. See [Suggest stopwords][1].

[!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Check that freetext search is enabled for SuperOffice CRM (see [Enable freetext search][2]).

1. Click the **Add** button below the stopword list.

1. In the **New Stopwords** dialog, type in one or more stopwords you want to include. As a separator, use any non-alphabetical character, except a full stop.

1. Click **Save**.

1. A message informs you that changes to the stopword list do not have a retroactive effect. In other words, new stopwords will not apply for text entered before the stopword was specified. Click **OK**.

    > [!TIP]
    > If you want your changes to have a retroactive effect, you must [regenerate the freetext index][3]. Do this after you add stopwords, after the system suggests stopwords, or after importing a large quantity of text.

<!-- Referenced links -->
[1]: suggesting-stopwords.md
[2]: enable.md
[3]: regenerating-freetext-index.md

<!-- Referenced images -->
