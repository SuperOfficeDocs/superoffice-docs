---
# Mandatory fields.
title: archive_provider_metadata       # (Required) Very important for SEO.
description: Archive provider metadata  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Metadata

## Columns

A client can obtain a list of available columns from a provider like this:

`List<ArchiveColumnInfo> columns = provider.GetAvailableColumns();`

It can then populate a GUI based on the `DisplayName`, `DisplayTooltip`, and `IconHint` properties of each column info object, and let the user choose whatever set of columns to display. For each such column, it is the `Name` member that must be saved, since an array of these strings is the parameter to the necessary `SetDesiredColumn` call.

As mentioned above, the column list for some providers can be huge. Some columns are marked with `Visible=false`, which is a hint from the provider that the column should not be shown (for example, ID columns usually have this marking). In any case, it is the application's responsibility to have a filter list to exclude columns that should not be displayed to standard users. This should be done by filtering columns, not by having a list of columns to be shown. A filter list will let through any new columns added by partner- or user-defined extensions, while an allowed-columns list would not, thus breaking extensibility.

![filter columns][img1]

The list of columns in this dialog is driven by the result from `GetAvailableColumns()`. The application has performed some filtering, and also added the red style for a column it considers mandatory (the archive provider has no opinion on the matter).

There is another system, accessed as an MDO list, available to store and retrieve what columns have been selected for display, but as the storage of restrictions, this is an addition to the archive provider core system.

Available columns are a function of the provider and its sub-components. Many columns are hard-coded in the sense that there is code that explicitly declares a column and other code that explicitly (or through a base class) populates it with data. However, there is nothing in the architecture that prevents the dynamic generation of column metadata. In the case of Saint status monitors and user-defined fields, that is very much the case.

The only important contract is that once a column name appears in the return value from `GetAvailableFields`, the provider **must** handle references to the column in `SetDesiredFields`, `SetRestrictions`, and `SetOrderBy` (subject to `CanRestrictBy` and `CanOrderBy` limits) without crashing. A provider is thus prohibited from changing its mind about a column. If choices made by the client make a column irrelevant, an empty or null value should result, but there should be no crashes.

## Entities

The entities marked as mandatory (Optional = false) are always returned by an archive provider. However, the provider may choose to mark one or more entities as optional, and clients then have to ask for them using the `SetDesiredEntities` method.

`List<ArchiveEntityInfo> columns = provider.GetAvailableEntities();`

In 6.Web, optional entities cause checkboxes to be shown in the archive toolbar:

![archive toolbar][img2]

As with column names, the idea is that any extensions that add more optional entities will cause the GUI to automatically adapt. Entities that have Optional = false generally don't show up in the GUI, since they cannot be turned off in any case.

## Sort order

One of the properties of `ArchiveColumnInfo` is `CanOrderBy`. If this is set to true, then the archive provider will accept the column name as an argument to the `SetOrderBy` method, and honor the request (deliver the result set ordered by that column).

Clients can request ordering by multiple columns in priority order, with individual ascending or descending sorting.

> [!NOTE]
> The ordering is usually done in the database since archive providers look at data **one row at a time** with little or no inter-row context. It is therefore the database sort order that applies, and this will vary with the cultural setup of the database.

As a rule, columns that have a simple, direct mapping to database fields will offer `CanOrderBy`, and there exists base class functionality to make this happen automatically. However, an archive provider is free to implement sort algorithms for any columns. That is up to the designer of the individual provider. Of course, a column that contains the result of some complex calculation or concatenation of fields will be hard to "order by", but the architecture itself places no constraints.

## Restrictions

A **restriction** is a column that has the `CanRestrictBy` property set to true and a non-empty `RestrictionType` member in its `ArchiveColumnInfo`. When an archive provider defines a column in this way, it says to the world that the column can be used to restrict the rows in the result set. The column may or may not map to a database field. As with orderby, it is up to the provider to implement whatever functionality it deems proper.

In the standard providers in SuperOffice, most restriction columns do map to database fields. But sometimes there is more or less complicated functionality in between. This all comes back to the purpose of providers, to map between a database model and some simpler, flatter model that the outside world needs to see.

Base class functionality exists to automatically implement restriction-to-SQL mapping for simple columns of all the standard types. The `RestrictionType` of a column is important, as it defines what kinds of values and operators are valid for that column. As with other parts of the system, there is a set of classes that will provide helpful information, such as an operator list, or hints for values, given the restriction type. This system, since it works with restriction types and operators, will be available automatically to any column of any provider, as long as it stays within the known set of restriction types.

The restriction type does not have to be the same as the display type. For example, the display type might be an icon, while the restriction type is an integer or a string. In such cases, the provider needs to implement the required mappings, which might be on the display, restriction, or both.

A fundamental principle when setting restrictions is that each component of a provider examines the restrictions being set, and reacts to those it knows - indicating with a return value whether at least one restriction was recognized. Restrictions that are not recognized are just passed on since the archive providers are built up from reusable blocks that do not know about each other.

Restrictions are sometimes used as a **back channel** to pass in data to archive providers, not just restrict what is fetched from a database or other source. This trick is used extensively in the `Participants` provider, where a lot of state (unsaved participant in an unsaved, new appointment) is in-memory but needs to be combined with database data (such as person names). In such cases, the component that recognizes such special restrictions can also choose to remove them from the restriction set.

Another variant is used in the `SelectionMember` providers, where an outer component recognizes one restriction (`selection_id`), looks up the selection record, and then, if it is a dynamic selection, replaces the `selection_id` restriction with the actual, current criteria saved for the selection. This restriction set then gets passed on to the underlying member providers, which in this way don't have to know that they are working with a dynamic selection (the same code handles Find and Add/Remove members as well).

**Continue reading:** [Providers][1]

<!-- Referenced links -->
[1]: providers.md

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
