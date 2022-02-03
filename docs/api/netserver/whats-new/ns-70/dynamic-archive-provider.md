---
title: Dynamic archive provider
uid: whats_new_70_dynamic_archive_provider
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# Dynamic archive provider

The **dynamic** archive provider supports searches across the relationships defined in the dictionary without having to do any programming. Each field name specifies the query – the table relationships to traverse to read the field.

You can fetch the name and department properties on the contact table like this:

```csharp
string[] archiveColumns = new string[] {
  "contact.name", "contact.department" };
```

Fetching the name of the contact’s business (MDO List item) is done by traversing the `business_idx` field on contact:

```csharp
string[] archiveColumns = new string[] {
  "contact.name", "contact.business_idx.name"
};
```

Fetching the contact’s associate’s person’s name:

```csharp
string[] archiveColumns = new string[] {
  "contact.name",
  "contact.associate_id.name",
  "contact.associate_id.person_id.firstname" };
```

The dot uses left-outer-joins by default. To force an inner-join, use a colon instead of a dot:

```csharp
string[] archiveColumns = new string[] {
   "contact.name", "contact:business_idx.name" };
```

This will inner-join contact and business – so contacts without a business value will be skipped.

Right-outer joins can also be constructed:

```csharp
string[] archiveColumns = new string[] {
  "contact.(url->contact_id).description" };
```

You can also use these dot-syntax fields in the restrictions:

```csharp
string[] archiveColumns = new string[] {
  "contact.name",
  "contact:associate_id:person_id.firstname",
  "contact.(url->contact_id).url_address1" };
ArchiveRestrictionInfo restriction =
  new ArchiveRestrictionInfo(
  "contact:associate_id:person_id.firstname", "begins", "A");
```
