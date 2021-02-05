---
title: lists       
description: Lists (SoListProviders)
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Lists (SoListProviders)

This section will expose the **NetServer List layer** which can be used to access and use the various lists in NetServer in your own applications. It will give you an idea about different list providers and places where each of them becomes important.

We have categorized lists according to the different providers present in the NetServer List layer since the output varies with the list provider.

These lists are provided under the `SuperOffice.CRM.Lists` namespace, and you can use the `SoListProviderFactory` to retrieve various types of lists.

There are several different types of SoListProviders. Any list can be retrieved by varying the parameters passed to the `Create` method of the `SoListProviderFactory`. In the rest of this section, we will be explaining with examples, how to retrieve various types of Lists.

## Why use a list

When developing applications, it is necessary to provide lists so that the users can be allowed to select items with ease. Using the lists provided by the NetServer list providers it is possible to add lists to your application.

There are different types of lists provided by the `SoListProviderFactory`. They can be categorized as follows:

* [Typed list][2] (TypedMDOProviders)
* [User-defined list][3] (UserDefinedListProvider)
* [Group view][4] (GroupViewProviders)
* [Generic list][5] (GenericMDOProviders)

<!-- Referenced links -->
[2]: typed-list.md
[3]: udef-list.md
[4]: group-view.md
[5]: generic-list.md
