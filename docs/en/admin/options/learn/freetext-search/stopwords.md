---
uid: help-en-stopwords
title: Stopwords
description: Stopwords
author: Bergfrid Dias
date: 03.21.2023
keywords: free-text, search, stopword
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Stopwords

A stopword is a word that is not indexed (not included in a freetext search). Typically, this means words like *and*, *or*, *it* and *for*. The object of defining stopwords is to reduce the time required to search through the freetext index by excluding unnecessary words and to use less space in the database.

The words defined as stopwords for freetext searches are listed in the **Stopword list** table in the **Freetext search** tab of the Options screen.

> [!TIP]
> If you want your changes to have a retroactive effect, you must [regenerate the freetext index][3]. Do this after you add stopwords, after the system suggests stopwords, or after importing a large quantity of text.

## Add stopword

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Check that [freetext search is enabled][2].

1. Click the **Add** button below the stopword list.

1. In the **New Stopwords** dialog, type in one or more stopwords you want to include. As a separator, use any non-alphabetical character, except a full stop.

1. Click **Save**.

1. A message informs you that changes to the stopword list do not have a retroactive effect. In other words, new stopwords will not apply for text entered before the stopword was specified. Click **OK**.

## Suggest stopwords

Instead of entering stopwords manually, you can let the system suggest stopwords for you.

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Check that [freetext search is enabled][2].

1. Click the **Suggest** button below the stopword list.

1. A message is displayed to the effect that it can take a long time for the system to traverse the glossary and the index to find possible stopwords. Click **OK**.

1. When the system has found possible stopwords, these are displayed in the **New Stopwords** dialog. The most frequently used words in the database are displayed at the top. Check the ones you want to include as stopwords. Hold down the **CTRL** key and click the relevant stopwords.

1. Click **Save**.

1. A message is displayed to remind you that changes in the stopword list do not have a retroactive effect, which means that new stopwords will not apply to fields that were created before the stopwords were defined. Click **OK**.

## Delete stopwords

The object of deleting stopwords is to include them in freetext searches after having excluded them. To delete a stopword from the list:

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Check that [freetext search is enabled][2].

1. Select the required stopword.

1. Click the **Delete** button below the stopword list.

<!-- Referenced links -->
[2]: enable.md
[3]: regenerate-index.md

<!-- Referenced images -->
