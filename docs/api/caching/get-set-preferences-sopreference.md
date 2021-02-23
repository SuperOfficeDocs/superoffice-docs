---
title: get_set_preferences_datalayer
description: Get and set preferences using SoPreferene at the data layer
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: howto
---

# Get and set preferences

Preferences keep track of an associate’s likes and dislike such as calendar size, calendar starting date, and default appointment text. In NetServer, these preferences are kept track of using the `SoPreference` class located in the `SuperOffice.Data` namespace.

> [!NOTE]
> All preferences are stored in the `UserPreference` table.

The following example shows how we may change the calendar start date, i.e. whether it is going to be Monday or Sunday.

```csharp
using SuperOffice;
using SuperOffice.Data;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  SoPreference.SetPreference("Visual", "SundayFirstDay", true);
}
```

When the above code is executed wherever in the application a calendar is displayed, its starting date will be Sunday:

![01][img1]

## SetPreference

The code responsible for the above change is this:

```csharp
SoPreference.SetPreference("Visual", "SundayFirstDay", true);
```

Here we use the `SetPreference` method of the `SoPreference` class. The method provides 4 overloads depending on the input value, which could be either a string, int, DateTime, or bool value.

The first 2 parameters (preference section and the corresponding preference key) are always set and they are both of string types.

## GetSections

When setting preferences, we may need to know what sections are already found in the database. To get the available sections, we may call `GetSections()`. The method will return an array of all sections defined for the current associate from the cache if possible or from the database. However, it is possible to add your own preference sections to the application.

```csharp
string[] test2 = SoPreference.GetSections();
```

## GetKeys

Once we have figured out which section to use, the next is to get the specific key, which relates to the part that we are planning to change. For this, we use the `GetKeys` method. The method gets all available keys within a section from the cache or the database.

```csharp
string[] test = SoPreference.GetKeys("Visual");
```

Through the above code segment, we get the available keys, which are within the section called *Visual*.

## Get the current value of a given preference

The `SetPreference` method has 4 overloads depending on the value passed (string, int, bool, or DateTime). The `SoPreference` class provides 4 corresponding methods to retrieve the current value of a given preference.

```csharp
using SuperOffice;
using SuperOffice.Data;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  bool value = SoPreference.GetBool("Visual", "SundayFirstDay", false);
}
```

The example above retrieves whether the calendar for the signed-in user begins with Sunday or Monday. In this case, since `GetBool()` requires 3 parameters, the default value of the key should also be passed in. The default value parameter should be passed in only when using the `GetBool` method.

See also: [intro to cache][1]

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
[img1]: media/image001.jpg
