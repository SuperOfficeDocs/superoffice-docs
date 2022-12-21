---
title: Terminology
description: Common terms and concepts pertaining to selections
author: {AnthonyYates}
keywords: NewSelection, Selection, Find
so.topic: reference
# so.envir:
so.client: web
---

# Common terms and concepts

| Term | Description |
|---|---|
| Selection | A Find search kept for subsequent reference and/or analysis. |
| ArchiveColumn | Datatype that represents a single field in an Archive Row. Contains field data and properties about the field. |
| ArchiveProvider | Data source used to populate table-based controls. |
| ArchiveRow | Datatype that returns a row with 1 or more `ArchiveColumn` data fields. |
| ArchiveRestrictionInfo | A filter criterion. |
| ArchiveRestrictionGroup | A group of filter criteria including an array of `ArchiveRestrictionInfo`. |
| Criteria | The plural form of criterion, a standard for evaluating and selecting an item. |
| CriteriaGroup | An array of `ArchiveRestrictionInfo` implicitly joined by AND operator. |
| CriteriaGroups | An array of `ArchiveRestrictionGroup` implicitly joined by OR operator. |
| Criterion | A standard on which a judgment or decision is based. |
| Default criteria | Each entity has a predefined set of criteria that is retrieved when a criteria provider cannot find a user defined set of criteria or when you reset search criteria. |
| Entity | Refers to a SuperOffice business object, such as Company, Contact, Document, or Project.|
| Last find criteria | The last set of criteria specified by the user on the filter screen. There are separate sets of criteria saved for each entity. |
| MDO List | Multi-Department Organization list of related information, such as a list of categories. |
| MDO Provider | Data source that returns a list of items. Some lists contain child list properties. |
| Online Template Library | The Azure-online service that stores the latest typical searches to the clients. Database data will not be updated by priming (but likely on upgrade) as well as by some updating service. |
| Restriction | Used to specify a condition or filter that affects an archive provider result set. |
| Shadow Archive Provider | Alternative data source related to a parent archive provider. |
| Typical search | Predefined search to get started with search and selections more easily.|
| User | A person with login rights, more specifically the record in the associate table. |

<!-- Referenced links -->
