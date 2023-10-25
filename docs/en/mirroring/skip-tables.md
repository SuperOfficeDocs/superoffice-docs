---
title: Add tables to skip mirroring
uid: skip_tables
description: Add tables to skip mirroring
author: {github-id}
keywords:
so.date: 12.22.2022
so.topic: howto
so.envir: cloud
so.client: online
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

## Managing preferences

If you require a UI for managing user preferences, consider creating a section that appears in SuperOffice Settings and Maintenance (Admin client).

![imageq9fi.png -screenshot][img1]

### Add a preference section

Adding a preference **section** makes it available as a selectable list item in the **Preferences** settings.

1. Add a new record in the `PREFDESC` table, using the `PreferenceDescription` data type.
2. Set the section property to "Mirroring".
3. Set the key as a period character (".").

![imagei34k8.png -screenshot][img2]

**REST:**

```http
POST https://sod.superoffice.com/Cust12345/api/v1/PreferenceDescription HTTP/1.1
Authorization: Bearer 8A:Cust12345.AWd...brevity...4xr
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Section": "Mirroring",
  "Key": ".",
  "Name": "US:\"Database Mirroring Settings\";GE:\"Einstellungen für den Datenbankspiegel\"",
  "ValueType": "Unknown",
  "MaxLevel": "Database",
  "SysMaxLevel": "Database",
  "AccessFlags": "adminGUI",
  "IsBuiltin": false
}
```

**SOAP proxies:**

```csharp
using (PreferenceAgent prefAgent = new PreferenceAgent())
{
    var preference = prefAgent.CreateDefaultPreferenceDescription();
    preference.AccessFlags = SuperOffice.Data.PrefDescAccessFlags.adminGUI;
    preference.Section = "Mirroring";
    preference.Key = ".";
    preference.Name = "US:\"Database Mirroring Settings\";GE:\"Einstellungen für den Datenbankspiegel\"";
    preference.Description = "";
    preference.IsBuiltin = false;
    preference.MaxLevel = SuperOffice.Data.PreferenceLevel.Group;
    preference.SysMaxLevel = SuperOffice.Data.PreferenceLevel.Group;
    preference.ValueType = SuperOffice.Data.PrefDescValueType.Unknown;

    var prefDescr = prefAgent.SavePreferenceDescription(preference);
}
```

### Add preference setting

Adding a preference **setting** makes it available as an optional setting under the Database Mirroring Settings **Preferences**. The procedure is similar to adding a preference *section*.

1. Add a new record in the `PREFDESC` table, using the `PreferenceDescription` data type.
2. Set the setting section name equal to the preference section name "Mirroring".
3. Set the key to "SkipTable".

![image03q27.png -screenshot][img3]

**REST:**

```http
POST https://sod.superoffice.com/Cust12345/api/v1/PreferenceDescription HTTP/1.1
Authorization: Bearer 8A:Cust12345.AW...brevity...xr
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Section": "Mirroring",
  "Key": "SkipTable",
  "Name": "US:\"Tables to skip\"",
  "ValueType": "Text",
  "MaxLevel": "Database",
  "SysMaxLevel": "Database",
  "AccessFlags": "adminGUI",
  "Description": "US:\"Comma-separated list of tables that are NOT sent to database mirror.\";",
  "IsBuiltin": false
}
```

**SOAP proxies:**

```csharp
using (PreferenceAgent prefAgent = new PreferenceAgent())
{
    var preference = prefAgent.CreateDefaultPreferenceDescription();
    preference.AccessFlags = SuperOffice.Data.PrefDescAccessFlags.adminGUI;
    preference.Section = "Mirroring";
    preference.Key = "SkipTable";
    preference.Name = "US:\"Tables to skip\";GE:\"Tabellen überspringen\"";
    preference.Description = "";
    preference.IsBuiltin = false;
    preference.MaxLevel = SuperOffice.Data.PreferenceLevel.Database;
    preference.SysMaxLevel = SuperOffice.Data.PreferenceLevel.Database;
    preference.ValueType = SuperOffice.Data.PrefDescValueType.Text;

    var prefDescr = prefAgent.SavePreferenceDescription(preference);
}
```

To add and edit the **SkipTable** preference, click **Add** in the **Active settings** panel.

![imagebfi1k.png -screenshot][img4]

Alternatively, use the code in the previous section to programmatically add the user preference.

<!-- Referenced links -->
[1]: blocked-tables.md

<!-- Referenced images -->
[img1]: media/imageq9fi.png
[img2]: media/imagei34k8.png
[img3]: media/image03q27.png
[img4]: media/imagebfi1k.png
