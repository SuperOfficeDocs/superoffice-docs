---
uid: crmscript_quotes
title: Quotes
description: Working with quotes in CRMScript
author: Bergfrid Dias
so.date: 02.04.2022
keywords: sale, quote, quoteconnection
so.topic: concept
---

# Quotes

For you as a CRMScript developer, working with quotes means that:

* you won't have to worry about miscalculating
* the sales details can be automatically updated

## Find available quote connections

```crmscript!
SearchEngine se;
se.addFields("QuoteConnection", "quoteconnection_id,DisplayName,Rank");
print(se.executeTextTable());
```
