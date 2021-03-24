---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_cripple       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Cripple # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite               # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Cripple

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Cripple'
```

> [!NOTE]
> This section applies to SuperOffice versions 5 and lower. It is obsolete from version 6 and replaced by corresponding FunctionRights on Role.

| Preference | Description | Control type | Access |
|---|---|---|---|
| Application | Removes all external applications and user-defined buttons. | Bool | Wizard |
| Appointment | Removes the **Follow-ups** dialog.<br>Follow-ups will still be visible in lists, but it will be impossible to add or edit appointments, tasks, and sales. | Bool | Wizard |
| Contact | Removes the **Company** screen (and Navigator button).<br>Company names will still be visible in dialogs etc., but it will be impossible to edit companies. | Bool | Wizard
| Diary | Removes the **Diary** screen.<br>All diary-related functionality will be removed. | Bool | Wizard |
| Document | Removes the **Document** dialog.<br>Documents will still be visible in lists, but it will be impossible to create or edit documents. | Bool | Wizard |
| Email | Removes the entire **Email** screen. All email functionality will be removed. | Bool | Wizard |
| Person | Removes the **Contact** screen. Contact names will still be visible in lists, but it will be impossible to add or edit contacts. | Bool | Wizard |
| Project | Removes the entire **Project** screen(and Navigator button).<br> Project names will still be visible in dialogs and lists, but it will be impossible to edit projects. | Bool | Wizard |
| Relation | Removes the **Relations** section tab from the **Company** screen | Bool | Wizard |
| Reporter | Removes the **Reports** button and the **Reports** screen. Print buttons will still be available at various points. | Bool | Wizard |
| Sale | Removes the **Sale** dialog. Sales will still be visible in lists, but it will be impossible to add or edit sales. | Bool | Wizard |
| Selection | Removes the entire **Selection** screen. All selection-related functionality will be removed. | Bool | Wizard |
| Travel | Removes all Travel functionality. | Bool | Wizard |
