---
# Mandatory fields.
title: get_selection_members      # (Required) Very important for SEO.
description: How to retrieve members of a specific selection  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: search,selectionmembers,selectionprovider
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to retrieve members of a specific selection

Members of a specific selection can be retrieved in 2 ways:

* Using the Selection Entity
* Using the SelectionProvider

## Example 1 (entity)

This first example shows how to retrieve a Members Collection using an instance of the `Selection` class.

[!code-csharp[CS](includes/get-members-entity.cs)]

An instance of the `Selection` class is created from `selection_id` 58. The instance is an entity object for the `selection` table in the database and the objects represent full entities with both the base table objects and all related objects. Using `GetFromIdxSelectionId()`, it creates a new instance of the `Selection` object by querying the database table via the index `IDXSelId`. The intention is to make it easy to use efficient queries that match the database index.

Once we have created the instance, we may access the `SelectionMembers` property of the `Selection` entity, which is of Rows data type, and manipulate its content. The output produced by the above code is as follows.

| SelectionId | ContactId | Name | NameDepartment |
|---|---|---|---|
|58 | 2   | StateZeroDatabase  | StateZeroDatabase |
|58 | 43  | Uniformeffekter AS | Uniformeffekter AS,UAvdeling |
|58 | 123 | Japanese Company   | Japanese Company, Tokyo |

## Example 2 (provider)

The next method of retrieving all members of a Selection is with the use of the `SelectionProvider` that is shown in the example below.

[!code-csharp[CS](includes/get-members-selectionprovider.cs)]

### SelectionProvider

[!code-csharp[CS](includes/get-members-selectionprovider.cs?range=7)]

We have used the `IArchiveProvider` interface to create an instance of the `SelectionProvider` class since `IArchiveProvider` is the external standard interface that aggregates the extensible and provider properties of all Archive provider class.

Once the provider is instantiated, the next is to manipulate the behavior of the provider with the use of Set methods.

### Set methods

All Set methods work in similar ways, the only difference is the number and type of parameters that should be pass into it. Here we look at the `SetRestriction` method as it is quite related to the current section of the document.

[!code-csharp[CS](includes/get-members-selectionprovider.cs?range=19)]

Here, we have restricted the number of rows selected by giving a `SelectionId` such that the related members would all belong tp the given ID.

Once the Rows have been selected with the `GetRows` method exposed in the `Provider` class, we may retrieve the rows that have been selected. Below is the output returned by the code segment above.

| SelectionId | ContactId | Name | NameDepartment |
|---|---|---|---|
| [I:58] | [I:127] | Ghost Rider, | entity dept |
| [I:58] | [I:126] | Frank Hardy | |
| [I:58] | [I:123] | Japanese Company,  Tokyo |
| [I:58] | [I:43]  | Uniformeffekter AS, UAvdeling |
