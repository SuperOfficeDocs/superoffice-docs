---
title: Add tables to skip mirroring
uid: skip_tables
description: Add tables to skip mirroring
author: SuperOffice Product and Engineering
keywords:
date: 12.18.2025
content_type: howto
deployment: online
platform: web
---

# Add tables to skip mirroring OBSOLETE from 10.1.8

Our database mirroring service has a pre-defined [list of tables][1] not replicated during the mirroring process. What if, however, you want to add more tables to the blocked list?

To add tables to the mirroring service blocked list, create a user preference with:

* `prefSection`: Mirroring
* `prefKey`: SkipTables

The `prefValue` is where you store a comma-separated string of table names that are added to the blocked list during the replication phase.

Adding a user preference **affects all database mirroring jobs for that tenant**. If another application also using mirroring, it too will be affected by this setting.

## Adding a user preference

You must use the API to add a user preference. There is no built-in **Preference** section for managing settings for database mirroring.

### REST API

```http
POST https://sod.superoffice.com/Cust12345/api/v1/Preference/Mirroring/SkipTables HTTP/1.1
Authorization: Bearer 8A:Cust12345.ARE...brevity...H8
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "RawValue": "ej_message,y_table",
}
```

### SOAP proxies

```csharp
using (PreferenceAgent prefAgent = new PreferenceAgent())
{
  var preference = prefAgent.CreateDefaultPreference();
  preference.Specification = new PreferenceSpec()
  {
    Section = "Mirroring",
    Key = "SkipTable"
  };
  preference.Level = SuperOffice.Data.PreferenceLevel.Database;
  // Comma-separated list of table names
  preference.RawValue = "ej_message,y_table";
  return prefAgent.SavePreferenceEntity(preference, true);
}
```

<!-- Referenced links -->
[1]: blocked-tables.md
