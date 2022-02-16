---
uid: crmscript-get-user
title: Get user info
description: How to get user information with CRMScript.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, ejuser, user, user account
so.topic: howto
---

# Get user info

## Bool load(Integer id)

Brings up the user with the given ID. This is always the 1st step when you want to do anything with an existing user.

```crmscript
User u;
u.load(9);
```

## Bool loadFromAgentAndKey(Integer id, String Key)

Brings up the user that is owned by the agent and matches the external key.

> [!CAUTION]
> `loadFromAgentAndKey()` might overwrite existing values!

## String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
User u;
u.load(8);
printLine(u.getValue("firstname"));
```

<!-- Referenced links -->
