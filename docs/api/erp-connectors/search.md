---
# Mandatory fields.
title: erp_search       # (Required) Very important for SEO.
description: ERP connector search # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: find
so.topic: concept     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Search in ERP

There are 2 ways of searching for ERP actors:

* A *simple search* that is driven by a search string and returns a set of fields
* A *criteria-driven search* where the user is present with a **Find Dialog** where various criteria – offered by the connector – can be filled in

The search functionality is used when connecting a SuperOffice CRM entity to an ERP Actor the first time (you cannot simply create new ERP Actors without first checking if a candidate already exists), and for mass imports from ERP to CRM.

When connecting a CRM Entity to an ERP Actor, a simple search is performed automatically as the connect dialog is opened, using the name from the CRM side as the search string. If this search proves unsatisfactory, the user can click the Magnifier symbol and get the **Find Dialog** in which any criteria provided by the connector can be used to do a more advanced, structured search.

The advanced search is performed in 2 steps:

1. The `GetSearchableFields` method is called, and the connector replies with the field keys of those fields it is prepared to accept as search criteria.
2. The `SearchActorsAdvanced` method is called to perform the search.

Each criterion selected by the user is sent as a `SearchRestrictionInfo` object, which contains a field key, an operator, and a value. For the BETWEEN and IN operators, multiple values are included. The connector should perform the search and return the results, including those fields that have been specified as result fields in the call.

![x][img1]

The connector can also choose to offer an advanced search by exposing one or more field names through `GetSearchableFields` (fields are exposed per actor type).

If advanced search is supported, the connector will have to support all required search operators and a few "special" search keys.

## The SearchRestrictionInfo class

Describes a search restriction using 3 properties:

| Property | Type | Description |
|---|---|---|
| FieldKey | string | Describes which field should be searched (will always be one of the fields the connector exposes through `GetSearchableFields`). |
| Operator | string | Describes which operator to use for the search. See SearchOperators below. |
| Values | string[] | The values to search for. This array will usually only have a single value unless the operator describes otherwise (`OneOf` and `NotOneOf`)<br>These values will be encoded in the same way as normal [field values][2] elsewhere |

Each field type will require supporting a different set of search operators (equals, not equals, one of, contains, and so on). These operators are conveniently available as string constants in the following classes in the `SuperOffice.ErpSync.Contract` assembly:

* StringOperators
* IntOperators
* DoubleOperators
* BoolOperators
* DateTimeOperators
* ListOperators

For a complete list, see the [operator reference][1].

## SpecialSearchKeys

In addition to the required operators, there are a couple of special values that need to be supported for the **FieldKey** property of a **SearchRestrictionInfo** object. These special keys are available as constants in the SpecialSearchKeys class in the Contract assembly.

| FieldKey value | Search for |
|---|---|
| "ParentErpKey" / const string PARENT_ERPKEY | only actors with a specified parent actor key |
| "ParentActorType" / const string PARENT_ACTORTYPE | only actors with a specified parent actor type |

<!-- Referenced links -->
[1]: search-operators.md
[2]: api/field-value-formats-and-conventions.md

<!-- Referenced images -->
[img1]: media/image002.png
