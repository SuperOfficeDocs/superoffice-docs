---
title: get_set_preferences_ws
description: Get and set preferences using services
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords:
so.topic: howto
---

# Get and set preferences using services

Preferences are used to personalize SuperOffice.

> [!NOTE]
> All preferences are stored in the `UserPreference` table.

We store information on default values the user has set, different visual settings and you may even store preferences for your own application. For example, we can set the size of the calendar, starting time of the calendar, or the end time of an all-day event. In NetServer, we can either retrieve the current values of these preferences or set our own.

## Get the current value of a given preference

We may need to see what values are set to certain preferences like the first day of the week. The example below retrieves the value for `SundayFirstDay` for the logged-in user.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Services.Util;
using SuperOffice.CRM;
using SuperOffice;

using (SoSession newSession = SoSession.Authenticate("tje3", "tje3"))
{
  //Create an array of specifications
  PreferenceSpec[] specifications = new PreferenceSpec[] { new PreferenceSpec() };

  //Set specifications
  specifications[0].Section = UserPreferenceStrings.Visual.Section;
  specifications[0].Key = UserPreferenceStrings.Visual.SundayFirstDay;

  using (PreferenceAgent agent = new PreferenceAgent())
  {
    Preference[] carrier = agent.GetPreferences(specifications);
    string rowValue = carrier[0].RawValue;
    UserPreferenceStrings.PreferenceLevel level = carrier[0].Level;

    //Displaying the obtained values
    Console.WriteLine("Row value = " + rowValue);
    Console.WriteLine("Level = " + level);
  }
}
```

**Output:**

```text
Row value = 1
Level = Undefined
```

Here we have created an array of `PreferenceSpec` objects which is the carrier object of `PreferenceSpec` services. In the `UserPreferenceString` class, we can find strings describing values for sections and keys. Here we need to retrieve the value of the `SundayFirstDay”` key in the `Visual` section. The key refers to a boolean value that specifies whether to set Sunday or Monday as the first day of the week.

In the latter part of this example, we are retrieving the preferences via a `PreferenceAgent` using its `GetPreferences` method. This method returns preferences based on a set of specifications. The value of the `SundayFirstDay` key is stored in the `RawValue` variable.

If you use the asterisk (\*) for the key, it implies all keys within the given section. Similarly, if you use the asterisk for the section, then all preferences in all sections for your associate will be returned since an agent is capable of returning multiple preferences from a single database call.

## SetPreference

The following example shows how to set preferences for the visual section of the diary.

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

Here we create an instance of the `Preference` class and set certain specifications of it and have set the `RawValue` of the `Visual` section and the `NSundayFirstDay` key as *false* so that the Sunday will be displayed as the first day of the week.

Through the `PreferenceAgent`, we can save these changes in the database. Since the `PreferenceLevel` is set to the Database level, these changes are visible to all the users. The `prefdesc` table holds the names and descriptions of the preferences visible in SuperOffice. The preference values are stored in the `userpreference` table.
