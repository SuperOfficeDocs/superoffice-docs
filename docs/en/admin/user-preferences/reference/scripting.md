---
title: Scripting
uid: pref_scripting
description: Preference section Scripting
author: {github-id}
keywords: database
so.topic: reference
---

# Preference section Scripting

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Scripting'
```

| Preference | Description | Control type | Access |
|---|---|---|---|
| EnablePersonalScripts | Enable personal scripts | Number | Admin, Admin users, Wizard |
| EnableScripting | Enables scripting | Number | Admin, Admin users, Wizard |
