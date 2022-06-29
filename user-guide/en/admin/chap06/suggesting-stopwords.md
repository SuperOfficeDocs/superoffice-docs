---
uid: help-en-suggesting-stopwords
title: Suggesting stopwords
description: Suggesting stopwords
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Suggest stopwords

To ask the system to suggest which stopwords to add:

> [!NOTE]
> You can also choose the stopwords manually. See [Add stopwords](Adding_stopwords.md).

1. Click the **Options** button in the Navigator (![icon](../media/Knapp_Systemvalg_liten.bmp)).

2. Select the **Free text search** tab.

3. Check that freetext search is enabled for SuperOffice CRM (see [Enable freetext search](Enabling_freetext_search.md)).

4. Click the **Suggest** button below the stopword list.

5. A message is displayed to the effect that it can take a long time for the system to traverse the glossary and the index to find possible stopwords. Click **OK**.

6. When the system has found possible stopwords, these are displayed in the **New Stopwords** dialog. The most frequently used words in the database are displayed at the top. Check the ones you want to include as stopwords. Hold down the **CTRL** key and click the relevant stopwords.

7. Click **Save**.

8. A message is displayed to remind you that changes in the stopword list do not have a retroactive effect, which means that new stopwords will not apply to fields that were created before the stopwords were defined. Click **OK**.

    > [!TIP]
    > If you want your changes to apply retroactively, you can generate a new freetext index. See [Regenerate a freetext index](Regenerating_a_freetext_index.md).
