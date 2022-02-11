---
title: Bulk Operations
description: How to insert, update and delete large numbers of records in bulk.
author: AnthonyYates
so.date: 02.29.2021
keywords: data-access, bulk-update, mass-operations
---

# Bulk Operations

Bulk insert, update and delete operations are supported in all SuperOffice APIs. These capabilities exists as:

* [Bulk-Updates][1]
* [Mass Operations][2]

Bulk update is great for targeted changes; when data already exists in SuperOffice and a need arises to change one or more fields, on one or more entities, based on a specified criteria. A hypothetical bulk-update example is an organization that changes a data policy where a person title must conform to a certain format. For example, all contacts with the title "sales man" or "sales woman" must be redefined as "Sales Person". A Bulk-Update operation is useful to perform such changes. Users must be assigned the bulk-update functional right.

Mass operations are different in that they involve inserting, updating or deleting large datasets. All actions work towards one particular table at a time. This is an extremely fast and powerful API that is only accessible to system user accounts.

<!-- Referenced links -->
[1]: bulk-update/index.md
[2]: mass-operations/index.md