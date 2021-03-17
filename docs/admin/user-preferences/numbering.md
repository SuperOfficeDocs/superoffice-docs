---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_numbering       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Numbering # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Numbering

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Numbering'
```

Numbering - how new numbers are allocated, and how the user is allowed to edit these numbers.

| Preference | Description | Control type | Access |
|---|---|---|---|
| DefaultAllocate | Automatic allocation of a new number when a new document is created | Bool | Wizard |
| DefaultAllowBlank | Whether blank values are permitted for new counters | Bool | Wizard |
| DefaultReadOnly | Whether numbers allocated to a document or documents of a given template type may be amended (write-protected) | Bool | Wizard |
| DefaultSatPrefix | Default prefix for new counters on Satellite databases | Number | Wizard |
| DefaultTravelPrefix | Default prefix for new counters on Travel databases | Number | Wizard |
| DefaultUnique | Numbers with a new counter must be unique. | Bool | Wizard |
| NumberEachTemplate | If Yes, separate counters are maintained for each document template | Bool | Wizard |
