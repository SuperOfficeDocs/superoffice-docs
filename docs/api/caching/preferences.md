---
title: caching_preferences
description: Caching preferences
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Preferences

The `PreferenceCache` stores information about what the user prefers. The aim of this is to make the application more user friendly. For example, by adding default values for a document or appointment.

Another aspect of this is that it may define how your application looks. For example, whether the calendar starts on Sunday or Monday.

The classes that can be grouped as preference caches include:

* DataRightsCache
* FunctionRightsCache
* OwnerContactCache
* RefCountsPermissionCache
* SentryPreferanceCache
* UserGroupCahce

However, programmers can create their own preferences to the database that controls their application.

To find an overview of the available references, we may use methods such as `GetSections()` and `GetKeys()` exposed in the `SoPreference` class.

## Example

The example below shows how we may change the calendar start date (Sunday or Monday) for a given user.

```csharp
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
    SoPreference.SetPreference("Visual", "SundayFirstDay", true);
}
```

Once the code is executed the results can be see through the application:

![01][img1]

The relevant section from the code that made the above change is:

```csharp
SoPreference.SetPreference("Visual", "SundayFirstDay", true);
```

The parameters that have been passed to it include the name of the preference section, the key, and the new value used.

See also: [how to get and set preferences at the data layer][1] | [and using services][2]

<!-- Referenced links -->
[1]: get-set-preferences-sopreference.md
[2]: get-set-preferences-preferenceagent.md

<!-- Referenced images -->
[img1]: media/image001.jpg
