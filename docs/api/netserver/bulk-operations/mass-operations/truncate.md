---
title: Truncate table
description: How to truncate a table.
author: AnthonyYates
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
so.topic: howto
---

# Working with Truncate

This method is used to remove all records in a table. All records afterward are irrecoverable. It is extremely fast, dependent on table size.

> [!WARNING]
> This will truncate the whole table, but won't delete the table itself.

## Truncate Examples

### [Agent RESTful API](#tab/truncate-1)

[!code-csharp[CS](../includes/mass-operation-truncate-agent.cs)]

### [Core API](#tab/truncate-2)

[!code-csharp[CS](../includes/mass-operation-truncate-core.cs)]
***
