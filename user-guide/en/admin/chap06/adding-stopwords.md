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

# Add stopwords

To add a stopword manually:

> [!NOTE]
> Instead of entering stopwords manually, you can let the system suggest stopwords for you. See [Suggest stopwords](Suggesting_stopwords.md).

1. Click the **Options** button in the Navigator (![icon](../media/Knapp_Systemvalg_liten.bmp)).

2. Select the **Free text search** tab.

3. Check that freetext search is enabled for SuperOffice CRM (see [Enable freetext search](Enabling_freetext_search.md)).

4. Click the **Add** button below the stopword list.

5. In the **New Stopwords** dialog, type in one or more stopwords you want to include. As a separator, use any non-alphabetical character, except a full stop.

6. Click **Save**.

7. A message informs you that changes to the stopword list do not have a retroactive effect. In other words, new stopwords will not apply for text entered before the stopword was specified. Click **OK**.

    > [!TIP]
    > If you want your changes to have a retroactive effect, you need to regenerate the freetext index. This should be done after you have added stopwords, after the system has suggested stopwords or after importing a large quantity of text. See [Regenerate a freetext index](Regenerating_a_freetext_index.md).
