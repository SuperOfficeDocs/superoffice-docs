---
title: Setting up mapping of fields
uid: erp_setup_mapping
description: Setting up ERP Sync field mapping
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Setting up mapping of fields

Click the **Mapping** button to set up the mapping between SuperOffice entity fields and the corresponding ERP actor fields.

![x][img1]

The list of *Company fields* comes from the connector's `GetAvailableActorFields` method.

> [!NOTE]
> The connector will not be asked to store information about the field configuration done in SuperOffice. It will however be required to supply a list of fields, and to recognize its own field keys when actors are requested or received for retrieval and saving.

## Sequence diagram

The diagram details the process of retrieving available actor types, available fields for a given actor type, and then configuring each ERP field.

![05][img2]

The `GetSupportedActorTypes` method was called when the connection is saved. The list of supported actor types determines which tabs show up in the field configuration dialog. The types must be a subset of a predefined list of types (customer/supplier, person, project), meaning **the connector can't define its own actor types**.

For each supported actor type, SuperOffice will call `GetSupportedActorTypeFields` and `GetSearchableFields`.

## Supported actor type fields

```csharp
FieldMetadataInfoArrayPluginResponse GetSupportedActorTypeFields(Guid connectionId, string actorType)
```

Example call:

```csharp
FieldMetadataInfoArrayPluginResponse response = GetSupportedActorTypeFields( {3aef3af6-8642-4fc1-8dc9-4e08bd76a6bf} , "Supplier" );
```

The returned FieldMetadataInfo objects could look something like this:

```csharp
[0] = { Rank = 1,
         FieldKey = "NAME", FieldType = Text,
         DisplayName = "Supplier Name",
         DisplayDescription = "This is the tooltip" }
 [1] = { Rank = 2,
         FieldKey = "NUMBER1", FieldType = Integer,
         DisplayName = "Supplier Code" }
 [2] = { Rank = 3,
         FieldKey = "SUPPLIERLIMIT", FieldType = Text,
         DisplayName = "Credit Limit" }
 [3] = { Rank = 5,
         FieldKey = "STDTERMS", FieldType = List,
         ListName = "TermList",
         DisplayName = "Standard Terms" }
```

The configuration describes the ERP fields. SuperOffice will attempt to do [automatically map fields based on the FieldKey][1].

ERP fields can be typed as text, integers, checkboxes, numbers, and so on. The admin client will restrict the SuperOffice fields that can be mapped to the ERP field based on these types, so if you have a checkbox field, you can't have bi-directional sync to a text field, since the information would be lost in one direction.

## Searchable fields

Some of the ERP fields may be searchable - these are specified here. This lets SuperOffice know that it can use these fields in the **Advanced Search** dialog.

```csharp
StringArrayPluginResponse GetSearchableFields(Guid connectionId, string actorType)
```

With the same input as above, the items could look like this:

`[0] = "NAME", [1] = "NUMBER1", [2] = "SUPPLIERLIMIT"`

This tells SuperOffice that field searches can be done on NAME, NUMBER1, and SUPPLIERLIMIT fields in the ERP system. This will happen through the `SearchActorsAdvanced` method.

<!-- Referenced links -->
[1]: automatic-field-mapping.md

<!-- Referenced images -->
[img1]: media/image007.png
[img2]: media/image005.png
