---
# Mandatory fields.
title: providers       # (Required) Very important for SEO.
description: Provider class # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: IArchiveProvider
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Providers

A provider is a class that implements the `IArchiveProvider` interface and is tagged with an `ArchiveProviderAttribute`.

## QueryProvider

Providers that get data from the database via NetServer can be made by implementing the `IArchiveQueryProvider` interface, which contains some additional properties. The "query" word in the interface name suggests that this is a provider whose execution results in **one single query** to the database, and one stream of data. Most of the standard NetServer providers implement this interface, for which there is a comprehensive base class. One of the core responsibilities of a QueryProvider is that it owns the **Select** object that constitutes the query, and indicates a primary table.

## MultiQueryProvider

Several of the important archives in SuperOffice show multiple data types. A classic example is the Activity Archive, which shows appointments, documents, and sales. These have different but overlapping sources and offer different but overlapping columns. For example, the **date**, **text**, and **icon** columns are common to all, while the source of data for each column is different for each row type.

This is solved using the concept defined by `IArchiveMultiQueryProvider`. The idea is simple: aggregate two or more independent sub-providers into one data stream. The set of available columns from the multi-provider is the union of available columns from all sub-providers, with duplicates removed. Entities are combined in the same way. When the client calls `SetDesiredColumns`, the call is passed to each sub-provider, which reacts to the columns it recognizes and ignores the others. Entities and restrictions are handled in the same way.

During execution, sub-providers that return a **false** result from `SetRestrictions` (indicating they did not understand any of the restrictions) are eliminated, and the rest are asked to provide one row each. The desired OrderBy is then used to pick one of these rows as the first to be returned; that provider is asked to fetch another, and the cycle repeats until all providers are exhausted or the correct number of rows (see SetPagingInfo) has been returned.

Any provider can be used as a sub-provider in a MultiQueryProvider, so one can compose providers in arbitrary deep trees. This is an extremely powerful paradigm, as it allows us to break apart complex, heterogenous systems into (mostly) independent parts.

**Continue reading:** [Extenders][1]

<!-- Referenced links -->
[1]: extenders.md
