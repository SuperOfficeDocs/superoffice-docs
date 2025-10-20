---
uid: help-en-stopwords
title: Stopwords
description: Stopwords
keywords: free-text, search, stopword
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
redirect_from: /en/admin/options/learn/freetext-search/stopwords
---

# Stopwords

A stopword is a word that is not indexed (not included in a free-text search). Typically, this means words like *and*, *or*, *it* and *for*. The object of defining stopwords is to reduce the time required to search through the free-text index by excluding unnecessary words and to use less space in the database.

The words defined as stopwords for free-text searches are listed in the **Stopword list** table in the **Freetext search** tab of the Options screen.

## Before you begin

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. In onsite installations, make sure the **Enable freetext search** option is selected. In CRM Online, this option is always enabled.

> [!TIP]
> To apply stopword changes to existing content, you must [regenerate the free-text index][3]. Do this after you add stopwords, after the system suggests stopwords, or after importing a large quantity of text.

## Add stopword

1. Click the **Add** button below the stopword list.

1. In the **New Stopwords** dialog, enter one or more stopwords. Use any non-alphabetical character as a separator, except a full stop.

1. Click **Save**.

1. A message informs you that changes to the stopword list do not have a retroactive effect. In other words, new stopwords will not apply for text entered before the stopword was specified. Click **OK**.

## Suggest stopwords

Instead of entering stopwords manually, you can let the system suggest stopwords for you.

1. Click the **Suggest** button below the stopword list.

1. A message is displayed to the effect that it can take a long time for the system to traverse the glossary and the index to find possible stopwords. Click **OK**.

1. When the system has found possible stopwords, these are displayed in the **New Stopwords** dialog. The most frequently used words in the database are displayed at the top. Check the ones you want to include as stopwords. Hold down the **CTRL** key and click the relevant stopwords.

1. Click **Save**.

1. A message is displayed to remind you that changes in the stopword list do not have a retroactive effect, which means that new stopwords will not apply to fields that were created before the stopwords were defined. Click **OK**.

## Delete stopwords

The object of deleting stopwords is to include them in free-text searches after having excluded them. To delete a stopword from the list:

1. Select the required stopword.

1. Click the **Delete** button below the stopword list.

<!-- Referenced links -->
[3]: regenerate-index.md

<!-- Referenced images -->
