---
uid: crmscript-get-customer
title: Get customer info
description: How to get customer info with CRMScript
keywords: CRMScript, customer, person, contact
author: Bergfrid Skaara Dias
date: 15.02.2021
version: 10
topic: howto
---

# Get customer info

## Bool load(Integer id)

Brings up the customer with the given ID. This is always the 1st step when you want to do anything with an existing customer.

```crmscript
Customer c;
c.load(2);
```

## Bool loadFromAgentAndKey(Integer agent, String key)

Brings up the customer that is owned by the agent and matches the external key.

> [!CAUTION]
> `loadFromAgentAndKey()` might overwrite existing values!

## String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
Customer c;
c.load(7);
print(c.getValue("firstname"));
```

<!-- Referenced links -->
