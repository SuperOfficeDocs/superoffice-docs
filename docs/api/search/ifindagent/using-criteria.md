---
# Mandatory fields.
title: ifindagent_multi_criteria
description: How to use multiple criteria with the IFindAgent
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: howto                # article, howto, reference, concept, guide
so.date:
so.category: 
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to use multiple criteria with the IFindAgent

Unlike the [ArchiveAgent][1], the `FindAgent` supports saved restrictions and also handles some behind-the-scenes translation related to reporter criteria that the archive agent does not need to worry about.

The example below shows the use of the `SaveRestrictions` method exposed through the `FindAgent`.

[!code-csharp[CS](includes/ifindagent-person.cs)]

The intention is to store and restore a set of restrictions that could be used later as search criteria. The first thing we do is to get the `FindAgent` instance, which contains the method that we use. Once the initialization is done, we declare the variable that we would need to pass to the different methods we use.

## storageType

The storage type specification of the restriction, which could be "Criteria" or "Reporter" or any possible extension.

## providerName

This is the name of the archive provider which is intended to use the restriction.

## storageKey

This is to be interpreted by the restriction storage provider when it fetches the criteria for the search.

## staticColumns

This is an array of restrictions that are to be excluded from the `CriteriaArchiveRows` part of the result.

In the **Find** dialog that corresponds to the "static fields", this variable is used to avoid duplication in the **Match also** criteria list. In place, this variable is used it could be stated as `null`, which indicates that all restrictions should be included in the criteria list.

For example, if you have a criteria such as person/firstname="John" then all matches on this field will contain the same value "John" and the column can be excluded from the result making more room for the useful information.

## handledColumns

[!code-csharp[CS](includes/ifindagent-person.cs?range=22)]

This is an array of restrictions that are to be excluded from the `CriteriaArchiveRows` part of the result. In the **Find** dialog, that corresponds to the "static fields" this variable is used to avoid duplication in the "Match also" criteria list. In places, this variable is used it could be stated as `null` which indicates that all restrictions should be included in the criteria list.

When retrieving the list of columns for the variable we have made use of the `GetAvailableRestrictionColumns` method, which requires the `storageType` and `providerName` as the input parameters. It returns a list of column names corresponding to the available restrictions for the passed in `providerName` and `storageType`.

[!code-csharp[CS](includes/ifindagent-person.cs?range=26)]

With the execution of the above code, we have retrieved criteria information from a set of saved criteria, for specific set columns. The results are contained in two forms. Namely,  fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. All columns specified in the call will be present in the results. The method requires 5 parameters to produce the output. The parameters have been explained above.

The next step is to create a variable that could be used to store the restrictions.

[!code-csharp[CS](includes/ifindagent-person.cs?range=29)]

Here we have made use of the `Dictionary` class located in the `System.Collection.Generic` namespace, which will store the restrictions as a key-value pair. The key is of string type and the values are of `ArchiveRestrictionInfo` type, which is a class that carries information such as `contact_id = 2` which could be used in a query of an `ArchiveProvider`.

Once this is done, we may create and assign different restrictions. The example shows how to assign restrictions to multiple types of data as well as user-defined fields.

> [!NOTE]
> When executing the code for a user, an error might occur based on the state of their database since they may not have some or all of the user-defined fields shown in the example. In such a case, the code will be executable once the user-defined fields have been commented out or removed.

Once all the required restrictions have been added, the created restriction may be saved with the execution of the following statement.

[!code-csharp[CS](includes/ifindagent-person.cs?range=63)]

With the use of the `SaveRestriction` method exposed in the `IFindAgent` interface, the restriction will be saved so that it could later be used as a search criteron including dynamic search and find statements. The method requires the parameters:

* storageType
* providerName
* storageKey
* an array of ArchiveRestrictionInfo

Here we have made use of the `CollectionsOps` class exposed in the `SuperOffice.Util` class to convert between various collections of data. In this case, from `Dictionary` type to an array of `ArchiveRestrictionInfo` type.

<!-- Referenced links -->
[1]: ../iarchiveagent/using-criteria.md
