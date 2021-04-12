---
# Mandatory fields.
title: archive_provider_scenarios       # (Required) Very important for SEO.
description: Archive provider scenarios  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: IArchiveProvider
so.topic: concept             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Client usage scenarios

The `IArchiveProvider` interface defines a fairly simple yet very powerful interaction model between the client and the archive provider.

> [!NOTE]
> The term *client* here is used loosely: the client can be a real GUI, but it can just as well be some hard-coded internal process that just happens to use an archive provider to fetch a load of data it then uses for some other processing. Simply put, whoever calls an archive provider is a client in this context.

## Basic rules

There are 5 phases in the interaction between a client and an archive provider, and one of them is optional. The basic sequence is:

1. Create a provider instance. `ArchiveProviderFactory` is the common creation point for all providers.
2. (Optional) Retrieve metadata from the provider about what it **can** do.
3. Tell the provider what you **want** it to do - columns, entities, restrictions, orderby, paging - hard-coded or somehow configurable according to application needs.
4. Fetch data, by iterating over the `ArchiveRow` enumerator you get from `GetRows()`.
5. Close the provider to release all resources held by it.

> [!NOTE]
> An archive provider **instance is a single-use object**, valid for one (1) of these cycles. A client cannot re-use an existing provider instance, and those who implement providers don't need to take re-use into account.

## Simple scenario - known data

In this scenario, the client knows what it wants, and simply needs to get it with minimum fuss. For example, suppose we want to get the `position`, `firstname`, and `lastname` columns from the `Person` provider, skipping retired persons, where `lastName` contains the letters "vo". For the moment, never mind how we know all these names...

```csharp
IArchiveProvider provider = ArchiveProviderFactory.Create( "Person" );

provider.SetDesiredColumns( "position", "lastName", "firstName" );
provider.SetDesiredEntities( "person" );
provider.SetPagingInfo( int.MaxValue, 0 );

ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[1];
restrictions[0] = new ArchiveRestrictionInfo( "lastName", "contains", "vo");
provider.SetRestrictions( restrictions );

foreach( ArchiveRow row in provider.GetRows() )
{
  //process row data, for example like this:
  string positionText = row.ColumnData["position"].DisplayText;
  string lastNameText = row.ColumnData["lastName"].DisplayText;
  string firstNameText = row.ColumnData["firstName"].DisplayText;
}

provider.Close(); // remember to close the provider to release resources
```

In the first line, we call on the factory to create the proper provider. Given that the provider system is extensible and consists of an unknown number of plugins, the preferred way of instantiating objects is a factory mechanism. That way you are sure to pick up all available overrides and extensions. We then tell the provider what columns we want, the entity we want, and how many rows (in this case, all available as one continuous stream).

A restriction is always needed. Most standard providers offer a **getAll** virtual column, which you can use as a restriction to say "I want everything". If you give no restrictions, an empty result is entered. This is to guard against inadvertently trying to fetch the whole database... Here we make a simple restriction since we know that `contains` is a valid operator for restriction type `string`, which is the restriction type for the `lastName` column.

The `GetRows` method returns an iterator, not a collection. This is an important feature because it means that data streams from the database, through the provider (one row at a time), and to the client. The amount of storage consumed is thus more or less independent of the amount of data fetched, which is a design requirement. One consequence is that all processing is done one row at a time, and thus business logic that depends on a global overview must be implemented separately - either outside the provider or inside by using the `InMemoryProvider` base class. In that case, storage requirements are linear with data fetched, and one should take potential result set sizes into account before using this strategy.

**Continue reading:** [Metadata][1]

<!-- Referenced links -->
[1]: metadata.md
