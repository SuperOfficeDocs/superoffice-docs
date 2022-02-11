---
title: Setting data-rights with sentry and user-preferences - COM
uid: override_sentry_com
description: Setting data-rights with sentry and user-preferences COM
author: {github-id}
so.date: 02.06.2007
keywords:
so.topic: howto
so.envir: onsite
# so.client:
---

# Setting data-rights with sentry and user-preferences - COM

The Database component can be used to create preferences.

By default, the `Preferences` object manipulates the preferences for the currently logged-in user, but you can set global or group-wide preferences by adding an optional parameter to the `Set` command.

> [!TIP]
> You may copy and save the code as *.vbs.

## Example 1

```vb
Set db = CreateObject("SuperOfficeDB.Database")

isOk = db.Login("name", "password")

If isOk Then

' this sets contacts read-only for everyone in this user's group

    db.Preferences.Set "Rights-contact", "Table", "17, You are only allowed read-only access to contacts", enPLGroup

' Only this person is allowed to edit projects:

    db.Preferences.Set "Rights-project", "Table", "5", enPLSystemWide

    db.Preferences.Set "Rights-project", "Table", "63", enPLIndividual

' Disable editing of personal address information

    db.Preferences.Set "Rights-person", "Address.Address1", "1, Addresses are read-only"

    db.Preferences.Set "Rights-person", "Address.Address2", "1, Addresses are read-only"

    db.Preferences.Set "Rights-person", "Address.City", "1, The city field is read-only"

EndIf
```

## Example 2

The following **field-level sentry** makes the department field read-only. The number 5 at the end refers to the [preference level][1].

```vb
set soApp = CreateObject("superoffice.application")
soApp.database.preferences.set "Rights-contact-Existing", "contact.department", "1, The department field is read-only on all existing contacts", 5
MsgBox "Read-only preference added for logged-in user: " & soApp.Database.UserName
```

## Example 3

The following **table sentry** removes update rights on existing projects.

```vb
set soApp = CreateObject("superoffice.application")
soApp.database.preferences.set "Rights-project-Existing", "Table", "17, You may not change existing projects", 5
MsgBox "Read-only preference to projects added for logged-in user: " & soApp.Database.UserName
```

<!-- Referenced links -->
[1]: ../overrides.md
