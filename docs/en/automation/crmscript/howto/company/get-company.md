---
uid: crmscript-get-company
title: Get company info
description: How to get company info with CRMScript.
keywords: CRMScript, company, organization, contact
author: Bergfrid Skaara Dias
date: 02.21.2022
version: 10
topic: howto
---

# Get company info

You can access a company in three ways. Each will return **false** if the company is unknown.

## Bool load(Integer id)

Brings up the company with the given ID. This is always the 1st step when you want to do anything with an existing company.

```crmscript
Company c;
c.load(2);
```

## Bool loadFromAgentAndKey(Integer agent, String key)

Brings up the company owned by the agent and matching the external key.

> [!CAUTION]
> `loadFromAgentAndKey()` might overwrite existing values!

## Bool findFromDomain(String domain)

Brings up the company based on its domain.

```crmscript
Company c;
c.findFromDomain("superoffice.com");
```

## String getValue(String colName)

Fetches the value from a named field.

```crmscript!
Company c;
c.load(2);
print(c.getValue("name"));
```

<!-- Referenced links -->
