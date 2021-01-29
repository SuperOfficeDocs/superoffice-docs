---
title: Bulk Operations
description: How to insert, update and delete large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, bulk-update, mass-operations
---

# Bulk Operations

Bulk insert, update and delete operations are supported in all SuperOffice APIs. This capability does come in the following flavors:

* Bulk-Update
* Mass Operations

Bulk update is great for targeted changes, when data already exists in SuperOffice and a need arises to change one or more fields on one or more entities based on a specified criteria. A hypothetical example is when an organization changes a data policy that dictates a person title must conform to a certain format. For example, all people with the title "sales man" or "sales woman" must be redefined as "Sales Person". A Bulk-Update operation is used to perform such corrections.

Mass operations involve inserting, updating or deleting large datasets. All actions work towards one particular table at a time. This is an extremely fast and powerful API that is only accessible to system user accounts.
