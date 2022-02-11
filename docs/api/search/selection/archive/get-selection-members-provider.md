---
title: Retrieve members of a specific selection
uid: get_selection_members_provider
description: How to retrieve members of a specific selection using archive provider
author: {github-id}
so.date: 05.11.2016
keywords: search,selectionprovider
so.topic: howto
# so.envir:
# so.client:
---

# How to retrieve members of a specific selection using archive provider

This method of retrieving all members of a Selection is with the use of the `SelectionProvider` that is shown in the example below.

[!code-csharp[CS](includes/get-members-selectionprovider.cs)]

## SelectionProvider

[!code-csharp[CS](includes/get-members-selectionprovider.cs?range=7)]

We have used the `IArchiveProvider` interface to create an instance of the `SelectionProvider` class since `IArchiveProvider` is the external standard interface that aggregates the extensible and provider properties of all Archive provider class.

Once the provider is instantiated, the next is to manipulate the behavior of the provider with the use of Set methods.

## Set methods

All Set methods work in similar ways, the only difference is the number and type of parameters that should be pass into it. Here we look at the `SetRestriction` method as it is quite related to the current section of the document.

[!code-csharp[CS](includes/get-members-selectionprovider.cs?range=19)]

Here, we have restricted the number of rows selected by giving a `SelectionId` such that the related members would all belong to the given ID.

Once the Rows have been selected with the `GetRows` method exposed in the `Provider` class, we may retrieve the rows that have been selected. Below is the output returned by the code segment above.

| SelectionId | ContactId | Name | NameDepartment |
|---|---|---|---|
| [I:58] | [I:127] | Ghost Rider, | entity dept |
| [I:58] | [I:126] | Frank Hardy | |
| [I:58] | [I:123] | Japanese Company,  Tokyo |
| [I:58] | [I:43]  | Uniformeffekter AS, UAvdeling |
