---
# Mandatory fields.
title: archive_provider_classes       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Archive provider data classes # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Data classes

There are several other classes not listed in the [interface diagram][1] that constitute essential parts of the system. These are the types that carry data into and out of providers.

## ArchiveColumnInfo

This is the class that describes one column. It is part of the metadata for a provider. Each column that a provider knows about has its own instance of this class, and a call to the `GetAvailabaleColumns` method will return a list of all the columns known to the particular provider.

| Property | Description |
|---|---|
| Name | code-friendly ID (a string that does not change with language) |
| Display name | generally contain resource tags |
| Tooltip | generally contain resource tags |
| Display type | what kind of value this column contains |
| Restriction type | whether this column can be used as a search column (restriction), and if so of what type |

If a provider has been built up of a hierarchy of sub-providers and extenders, the `GetAvailableColumns` method will return the union of all contributions.

The rationale is that the content of `ArchiveColumnInfo` should be enough to completely drive a "choose what columns you want to display" kind of GUI.

> [!NOTE]
> Most providers will offer a large number of columns. Thus, it is often reasonable to filter the column list before presenting it to a user. But that is the application's responsibility.

A client requests columns by using the `SetDesiredColumns` method.

## ArchiveEntityInfo

An entity is the same as a row type, and every provider must define at least 1 row type. The `ArchiveEntityInfo` class contains:

* a programmatic name
* a display name
* a tooltip
* whether the entity is optional

The idea is that optional entities can be shown as checkboxes in a flexible GUI - or they can be ignored. But that is the application's responsibility. The `GetAvailableEntities` method will return the complete set of entities offered by a provider.

By using the `SetDesiredEntities` method, clients can signal what entities they want in the result.

## ArchiveRestrictionInfo

To specify a search restriction, we need to (at least) define the column and operator, and usually also at least one value.

At the interface level, archive providers are **not bound to the database** - isolation from the database is part of their purpose. Search criteria, called **restrictions**, are therefore defined in terms of columns, and operators in terms of restriction types. None of these have a necessary direct relationship to the database. In practice, most archive providers do access the database and there are base and helper classes that handle all standard mappings. However, the isolation is the reason why the archive provider system defines its own column/operator/value system.

An `ArchiveRestrictionInfo` can contain an array of values, and it can contain sub-restrictions. So far, sub-restrictions are used only in the Saint system. There is a separate subsystem in NetServer that can be used to obtain complete metadata to drive a search GUI for any provider, as well as save and retrieve sets of restrictions on a per-user/per-provider basis. The **Find** and **Dynamic Selection** systems use this functionality, which is independent of the actual providers (and thus automatically adapts to any new provider as well).

## ArchiveRow

An `ArchiveRow` is what you ultimately want from an archive provider. It represents one single row of data and contains some fixed items as well as a dictionary of `ArchiveColumnData` items. The fixed items include:

* the entity name and primary key (unique across the set of results from one archive provider run)
* a link hint for navigation
* security information for the row

## ArchiveColumnData

One cell `ArchiveColumnData` instance. This class contains:

* a column name (matches one of the `GetAvailableColumns` instances)
* a display text, formatted by the `CultureDataFormatter` to surmount cultural problems with converting data types to string and back
* tooltip
* link (navigation) hints

If you are working directly with NetServer, you can also get raw data (for instance, a real Int32 or System.DateTime).

## Common features

All of the above classes have lots of instance and static methods that help with their management:

* converting arrays into indexed dictionaries
* finding one instance within a collection
* other common tasks

They also have `ToString` methods that have been overridden to help with debugging.

**Continue reading:** [Client usage scenarios][2]

<!-- Referenced links -->
[1]: interfaces.md
[2]: scenarios.md
