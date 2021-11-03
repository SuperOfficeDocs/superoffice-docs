---
title: Add columns to archive providers
uid: add_columns
description: Add columns to archive providers
author: Tony Yates
so.date: 08.03.2017
keywords: NetServer, archive provider
so.topic: howto
so.envir: cloud
so.client: online
---

# Add columns to archive providers

How to extend an archive provider with an `ArchiveExtenderExtender`.

This article demonstrates how easy it is to add columns of related data to existing archive extenders throughout SuperOffice without the complexity of creating multiple extenders and base extenders previously required before SuperOffice CRM version 8.

Prior to NetServer version 8, it was possible to extend archive providers by either the addition of new entity rows to an existing provider or adding extenders to add columns to existing row types.

While the "add-an-extender" model works reasonably well, it is fairly complicated to use. If interested, read about [how the archive providers work][1].

The complication stems from the fact that a new extender is tagged with the `ArchiveExtender` attribute that specifies the name of the provider to extend. This works OK when adding columns to one particular provider, but not when the desired effect is to add columns to a particular table or other well-defined entity.

For instance, adding extra columns to a person that should be present in all contexts where person information is shown (Find, Contact archive under company card, Activity archive, Selection members, Shadow selection members, etc) would require a lot of coding and overriding; as well as a fair amount of reverse-engineering to find out how the providers are actually structured. In the case of Find and Selection this can be a Big Deal.

![x][img1]

## Add columns to related archive, wherever!

Enter the new dimension: An ExtenderExtender! This is actually just a small tweak to the `ArchiveProviderFactory`, where it searches for a new attribute during the construction of an archive provider. The attribute is called `ArchiveExtenderExtender` and takes the type of an existing `ArchiveExtender` as its parameter.

During construction, the Factory recursively traverses all extenders that are part of the provider being built. Whenever it finds an extender that `IsAssignable` from the type specified in the attribute, it will instantiate and add the new component.

As an example, consider the following declaration:

```csharp
[ArchiveExtenderExtender("PersonArchiveExtension", typeof(PersonExtenderBase), int.MaxValue / 2)]
public class PersonArchiveExtension : TableExtenderBase<TableInfo>
```

The type parameter to the attribute is `typeof(PersonExtenderBase)`, so the factory will attach a new instance of `PersonArchiveExtension` to every extender that is derived from `PersonExtenderBase`, in every provider it constructs.

The implementation of the `PersonArchiveExtension` can safely assume that Parent.`TableToExtend` is an instance of `PersonTableInfo`, since the factory will attach it to `PersonExtenderBase` instances, and the `PersonExtenderBase` will always have a `PersonTableInfo` as its `TableToExtend`.

In short, we can do things like:

```csharp
protected override TableInfo SetJoin()
{
    var parentPersonInfo = Parent.TableToExtend as PersonTableInfo;
    SetLeftOuterOrInnerJoin(
        parentPersonInfo.PersonId.Equal(_info.ForeignKeyInfo.RecordId),
        _info.ForeignKeyInfo.TableId.Equal(parentPersonInfo.Definition.TableNumber)
        .And(_info.ForeignKeyInfo.ForeigndeviceId.Equal(_info.ForeignDeviceId)));
}
```

Here, we join the parent `Person` table to `ForeignKey`, because there is something interesting there that we’d like to fetch and show as columns related to persons – everywhere a person is shown.

This is an extremely powerful mechanism and a big simplification. Columns exposed by this extender will appear in every context where a Person appears – all the archives mentioned above.

Rather than appearing under the entity fields, the new columns are available under the new menu item "Other" - as seen in the **Find dialog** image above.

If these columns are searchable then they can immediately be used as criteria in dynamic and static selections, you can filter on them in archives, and generally do everything you can with the «native» person columns.

## Example code

Here is the example code used to demonstrate how easy it is to show the new Sale columns anywhere:

[!code-csharp[Add sale column](includes/add-column.cs)]

## Key takeaways

* Use an ExtenderExtender to easily expose new columns anywhere.
* Use the same techniques as before to:
  * automate the detection of columns declared with \_col prefix.
  * use SetJoin to expand existing table joins, or add criteria
  * use ForceRestriction to invoke InnerModifyQuery to add return fields, or change an existing query
  * use InnerPopulateRowFromReader to access reader and add column data to ArchiveRow output

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
[img1]: media/extenderextender.png
