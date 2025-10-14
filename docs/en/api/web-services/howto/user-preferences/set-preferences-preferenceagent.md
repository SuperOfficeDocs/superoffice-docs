---
uid: set-preferences-ws
title: Set preferences using services
description: How to set preferences using services
keywords: preference, PreferenceSpec, PreferenceAgent
author: digitaldiina
date: 02.22.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: settings
topic: user preferences
language: en
redirect_from: /en/admin/user-preferences/howto/set-preferences-preferenceagent
---

# Set preference

The following example shows how to set preferences for the visual section of the diary.

## Code

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Services.Util;
using SuperOffice.CRM;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve the configuration agent
  using(PreferenceAgent agent = new PreferenceAgent())
  {
    //Create an array of preferences
    Preference[] preferences = new Preference[] { new Preference() };

    //Setting the preferences
    preferences[0].Specification = new PreferenceSpec();

    //Set the appearance of the Interface
    preferences[0].Specification.Section = UserPreferenceStrings.Visual.Section;

    //Make these preferences valid for all the users
    preferences[0].Level = UserPreferenceStrings.PreferenceLevel.Database;

    //Marking Monday as the first day of the week instead of Sunday
    preferences[0].Specification.Key = UserPreferenceStrings.Visual.SundayFirstDay;
    preferences[0].RawValue = "False";

    //Save the changes in the database
    agent.SavePreferences(preferences);
  }
}
```

## Walk-through

Here we create an instance of the `Preference` class and set certain specifications of it and have set the `RawValue` of the `Visual` section and the `NSundayFirstDay` key as *false* so that the Sunday will be displayed as the first day of the week.

Through the `PreferenceAgent`, we can save these changes in the database. Since the `PreferenceLevel` is set to the Database level, these changes are visible to all the users. The `prefdesc` table holds the names and descriptions of the preferences visible in SuperOffice. The preference values are stored in the `userpreference` table.
