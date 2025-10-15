---
uid: get-preferences-ws
title: Get preferences using services
description: How to get preferences using services
keywords: preference, PreferenceSpec, PreferenceAgent
author: digitaldiina
date: 02.22.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: settings
topic: user preferences
language: en
redirect_from: /en/admin/user-preferences/howto/get-preferences-preferenceagent
---

# Get the current value of a given preference

We may need to see what values are set to certain preferences like the first day of the week. The example below retrieves the value for `SundayFirstDay` for the logged-in user.

## Code

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

## Walk-through

Here we have created an array of `PreferenceSpec` objects which is the carrier object of `PreferenceSpec` services. In the `UserPreferenceString` class, we can find strings describing values for sections and keys. Here we need to retrieve the value of the `SundayFirstDay”` key in the `Visual` section. The key refers to a boolean value that specifies whether to set Sunday or Monday as the first day of the week.

In the latter part of this example, we are retrieving the preferences via a `PreferenceAgent` using its `GetPreferences` method. This method returns preferences based on a set of specifications. The value of the `SundayFirstDay` key is stored in the `RawValue` variable.

If you use the asterisk (\*) for the key, it implies all keys within the given section. Similarly, if you use the asterisk for the section, then all preferences in all sections for your associate will be returned since an agent is capable of returning multiple preferences from a single database call.
