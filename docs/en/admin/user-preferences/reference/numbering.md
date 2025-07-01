---
title: Numbering
uid: pref_numbering
description: Preference section Numbering
author: SuperOffice Product and Engineering
keywords: database
topic: reference
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
