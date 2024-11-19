---
uid: help-en-company-add-relation
title: Add relation
description: Add relation
keywords: company
author: SuperOffice RnD
date: 10.29.2024
version: 10.3.11
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Add a relation (Company screen)

A relation must always have two parties, one active and one passive, for example: Company A owns Company B, while Company B is owned by Company A.

Relationship **types** are defined in Settings and maintenance.

## Steps

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Select the **Relations** section tab.

1. Click **Add**.

    ![Relations dialog -screenshot][img2]

1. In the **Relation** dialog, specify the **Active part**:

    * Company: Select the company from the dropdown or start typing to search. This is mandatory.
    * Contact: Optionally, specify a contact for the active company (for example, if the contact is a representative, has a specific role, or is a former colleague of a contact in Company B).

1. Specify the **Passive part**:

    * Company: Select the company for the passive role, using the same method as for the active part.
    * Contact: Optionally, specify a contact for the passive company.

1. Choose a relationship type from the **Relation** list, for example, "owns". The available options depend on whether the relationship is between two companies, between a company and a contact, or between two contacts.

1. Optionally, enter extra details in the **Description field**.

1. The **Result** field will auto-update based on the chosen relationship.

1. Click **Save**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../media/loc/en/company/relation.png
