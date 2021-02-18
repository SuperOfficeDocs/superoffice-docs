---
# Mandatory fields.
title: iarchiveagent 
description: IArchiveAgent
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: concept                # article, howto, reference, concept, guide
so.date:
so.category:
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# IArchiveAgent

`IArchiveAgent` is the common interface for the `ArchiveAgent`.

## Methods

Following is a list of methods provided by the agent that helps us to manipulate the content of the Archives.

| Method |Description |
|---|---|
| GetActivityFilter | Retrieves the `ActivityFilter` for a specified list. |
| GetArchiveConfiguration | Retrieves the configuration for the given Archive. The configuration is keyed by a combination of an Archive provider name and GUI name. The Archive provider name should match an Archive provider plugin and the GUI name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in the GUI. |
| GetArchiveList | Retrieves a page of data. The columns will be those set as chosen columns. |
| GetArchiveListByColumns | Retrieves a page of results for an archive list, explicitly specifying the restrictions, order by, and chosen columns. |
| SetActivityFilter | Sets the `ActivityFilter` for a specified list. |
| SetChosenColumns | Sets the chosen columns for the given GUI name/provider name combination. This service corresponds to the Sets elected() method of the `SelectableMDOList` service for a list called `ArchiveColumns` and the Archive provider name and GUI name as its additional info. |
| SetChosenEntities | Selects the Entities for a given GUI name/provider name combination. This service corresponds to the Sets elected() method of the `SelectableMDOList` service, for a list called `ArchiveEntities` plus the Archive provider name and GUI name as its additional info. |
| SetColumnWidths | Sets the column widths for the given set of columns and GUI name. |

**Activity filters** are restrictions that help place restrictions on the output returned.

## Example

The example below shows us how we may make use of the `IArchiveAgent` interface and its methods.

[!code-csharp[CS](includes/iarchiveagent-person.cs)]

### GetArchiveListByColumns()

The method call itself is a simple statement. The difficult part is to create the parameters that should be passed to it.

[!code-csharp[CS](includes/iarchiveagent-person.cs?range=37)]

The `GetArchiveListByColumns` method requires 7 parameters.

* **archiveProviderName** - the name of the provider that will be used to retrieve the required information. In the example, the person provider will be created using the `ArchiveProviderFactory` from a plugin.

  [!code-csharp[CS](includes/iarchiveagent-person.cs?range=11)]

* **archiveColumns** - the list of columns that needs to be returned by the method. The list is an array of string which can be declared as follows.

  [!code-csharp[CS](includes/iarchiveagent-person.cs?range=14)]

  > [!NOTE]
  > The names of the columns differ from the names that have been given in the database. Use the `IArchiveProver` to retrieve the columns that are available under a particular column.

  ```csharp
  IArchiveProviderpersonArchive = new PersonProvider( true );
  List<ArchiveColumnInfo> availableColumns = personArchive.GetAvailableColumns();
  List<ArchiveEntityInfo> availableEntities = personArchive.GetAvailableEntities();
  ```

* **archiveSrtOrd** - the sort order in which the returned data should be sorted. Can be null, which indicates no particular order.

  [!code-csharp[CS](includes/iarchiveagent-person.cs?range=17-18)]

  `ArchiveOrderByInfo` is defined in `SuperOffice.CRM.ArchiveLists`.

* **archiveRest** - an array of `ArchiveRestrictionInfo` that contains the restriction on which the retrieved archive list is based on.

  [!code-csharp[CS](includes/iarchiveagent-person.cs?range=21-22)]

  The archives will generally throw an exception if no restrictions are set. If you don't want any restriction, pass in an empty array, but remember that you may end up fetching the first page of millions of rows.

* **desiredEntities** - tells the method to include only the details of all the entities given in the array. Can be null, which indicates that all entities will be included.

  [!code-csharp[CS](includes/iarchiveagent-person.cs?range=25)]

* **page** and **pageSize** - page (number) 0 is the first page; pageSize is the number of rows that should be contained in a page

  [!code-csharp[CS](includes/iarchiveagent-person.cs?range=28,31)]

### Result

Once all parameters have been created we may use them with the `GetArchiveListByColumns` method which returns an array of `ArchiveListItem`.

[!code-csharp[CS](includes/iarchiveagent-person.cs?range=45-48)]

What is done by the above code segments is that for each column type which is a Key/Value pair it writes the key of it. Since this segment is used inside the If-statement the code piece will be executed only when the loop is run for the first time. The intended purpose of the above is to display the column headings.

The `archiveRow.ColumnData` is a dictionary of column data items. Each column data item contains a display value, a tooltip hint, a link hint, and an ordinary value. The display values are encoded by the `CultureDataFormatter` and can be decoded/localized by that class. All other values are optional.

Tooltip hints can be passed into the `TooltipProvider` (Tooltip service) to be translated into an actual tooltip.
<!-- This is the one-stop shop for asynchronous tooltips. This class takes in a tooltip hint and through the static method converts it into a tooltip. -->

The second for-loop is the one that actually retrieves the data from the database.

[!code-csharp[CS](includes/iarchiveagent-person.cs?range=54-57)]

Here we make use of the `ArchiveRow.ColumnData`’s `DisplayValue` property, which is the visible display value for an archive cell. This is always a String and any other data type should be converted to it according to the invariant culture.

#### Output

```text
personId  firstName contactId    personNumber  academic  position  fullName
[I:192]         User      [I:2]        10195                           User Local
[I:191]         Useradm   [I:2]        10194                           Useradm Useradm
[I:190]         Listadm   [I:2]        10193                           Listadm Listadm
[I:188]    SuperBuilder   [I:2]        10191                           SuperBuilder SuperBuilder
[I:187]         RevNS03   [I:2]        10188                           RevNS03 NetServer
[I:186]         SalNS05   [I:2]        10187                           SalNS05 NetServer
[I:185]         TjeNS04   [I:2]        10186                           TjeNS04 NetServer
[I:184]         SerNS03   [I:2]        10185                           SerNS03 NetServer
[I:183]         AdmNS02   [I:2]        10184                           AdmNS02 NetServer
[I:182]         MarNS01   [I:2]        10183                           MarNS01 NetServer
```
