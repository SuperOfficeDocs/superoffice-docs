---
uid: crmscript-find-customer
title: Look up customers
description: How to look up customers with CRMScript
keywords: CRMScript, customer, person, contact
author: Bergfrid Skaara Dias
date: 15.02.2021
version: 10
topic: howto
---

# Look up customers

## Bool findFromEmail(String email)

Looks up a customer in the primary database based on an email address.

```crmscript
Customer c;
printLine(c.findFromEmail("jean-luc@superoffice.com").toString());
```

## Bool findExternallyFromEmail(String email)

Same as `findFromEmail()`, but looks in external data sources.

## Bool findExternallyFromEmail(String email, Integer extTable)

A variant of `findExternallyFromEmail()` that limits the look-up to 1 specific source.

## Bool findFromCellphone(String cellphone)

Looks up a customer in the primary database based on a cellphone number.

```crmscript
Customer c;
printLine(c.findFromCellphone("12345678").toString());
```

## Integer findExternallyFromKey(Integer table, String key)

Looks up a customer in an external data source (`ext_table.id`) based on its primary key.

* If a match is found in the local proxy, the customer is loaded.
* Otherwise, if a match is found externally, a proxy is created and saved.

## Integer findFromAgentAndKey(Integer agent, String key)

Looks up a customer that is owned by the agent and matches the external key.

Returns the ID of the customer from the database, or -1 if not found.

<!-- Referenced links -->
