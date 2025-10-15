---
uid: set-preferences-datalayer
title: Set preferences
description: How to set preferences using SoPreference at the data layer
keywords: preference, SoPreference
author: digitaldiina
date: 02.22.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: settings
topic: user preferences
language: en
redirect_from: /en/admin/user-preferences/howto/set-preferences-sopreference
---

# SetPreference

To find an overview of the available references, we may use methods such as `GetSections()` and `GetKeys()` exposed in the `SoPreference` class.

## Code

The following example shows how we can change the calendar start date (Sunday or Monday) for a given user.

```csharp
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
    SoPreference.SetPreference("Visual", "SundayFirstDay", true);
}
```

## Walk-through

Here we use the `SetPreference` method of the `SoPreference` class. The method provides four overloads depending on the input value, which could be either a string, int, DateTime, or bool value.

The first two parameters (preference section and the corresponding preference key) are always set and they are both of string types. Here, the last parameter is the new value used.

Once the code is executed the results can be seen through the application:

![Calendar -screenshot][img1]

The relevant section from the code that made the above change is:

```csharp
SoPreference.SetPreference("Visual", "SundayFirstDay", true);
```

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

See also: [intro to cache][1]

<!-- Referenced links -->
[1]: ../../../caching/index.md

<!-- Referenced images -->
[img1]: media/start-week-sunday.png
