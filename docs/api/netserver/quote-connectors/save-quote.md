---
title: quote_connectors_save_quote
description: Saving the quote
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote
so.topic: howto
---

# Saving the quote

![18][img1]

The sale is updated with the preferred alternative’s total amount when the **Quote** dialog is closed.

After the sale and quote have been written to the database, the `OnAfterSaveQuote` is called for each alternative in turn. The method cannot edit the quote – it is intended for the connector to update the ERP with any interesting changes (for keeping the ERP system up to date regarding the SuperOffice quote).

[Sending Quotes][1]

<!-- Referenced links -->
[1]: send-quote.md

<!-- Referenced images -->
[img1]: media/image018.jpg
