---
# Mandatory fields.
title: override_sentry_com       # (Required) Very important for SEO.
description: Setting data-rights with sentry and user-preferences COM # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 02.06.2007
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Setting data-rights with sentry and user-preferences - COM

The Database component can be used to create preferences.

By default, the `Preferences` object manipulates the preferences for the currently logged-in user, but you can set global or group-wide preferences by adding an optional parameter to the `Set` command.

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
