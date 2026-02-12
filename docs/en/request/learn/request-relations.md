---
uid: help-en-request-relations
title: Request relations
description: Learn how to link related requests together using parent, child, and related relationships to better track and manage connected issues in SuperOffice Service.
keywords: request relations, link requests, parent request, child request, related requests, Add relation
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
category: service
topic: request
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Request relations

Request relations allow you to link requests together to show connections between issues. This is useful when multiple requests are related to the same problem, when one request depends on another, or when you need to track hierarchical relationships between requests.

> [!NOTE]
> Request relations are used to link requests to other requests. To define relationships between companies and contacts, see [Company and contact relations][4].

## Relation types

There are three types of request relations:

* **Related:** A non-hierarchical connection between requests.

* **Parent:** A request that has one or more child requests.

* **Child:** A request that is linked under a parent request. Each request can have only one parent.

## Use cases

Use **related** when requests are connected but do not have a hierarchy.

**Multiple customers reporting the same problem**
When different customers independently report the same issue, link the requests as related. This provides a flat view of all affected customers and helps ensure consistent communication.

**Requests containing multiple questions**
If a request contains unrelated questions, split it into separate requests for each department. Then link them as related to show they originate from the same context.

Use **parent and child** when requests have a hierarchical or dependency relationship.

**Incident management with root cause tracking**
Create a parent request to track the underlying issue. Link each customer report as a child request. A parent request can have multiple child requests, but each request can have only one parent.

**Managing dependencies**
When one request must be resolved before another can be completed, link them using a parent-child relationship to clearly show the dependency.

## View request relations

When a request has one or more relations, you can view them on the **Relations** tab of the Request screen.

### List view (archive)

The default view shows relations as a list with the following columns:

* Request ID
* Title
* Last changed date
* Owner
* Status
* Relation type

![Request relations in list view -screenshot][img1]

### Tree view

Click **Tree view** to display relations in a hierarchical structure, making parent-child relationships easier to visualize:

![Request relations in tree view -screenshot][img2]

> [!TIP]
> The **Relations** tab displays an orange indicator when the request has one or more relations, making it easy to identify linked requests at a glance.

### Different perspectives

Relations are bidirectional. Both requests in the relation display the connection:

* If Request A is a **parent** of Request B, then Request B will show Request A as its parent
* If Request A is **related** to Request B, then Request B will show it is related to Request A

![Same relation viewed from the related request -screenshot][img3]

## <a id="add"></a>Add request relation

You can add a relation from the following locations:

### From the Request screen

1. Open the request you want to link.

1. Select the **Relations** tab.

1. Click **New relation**.

1. In the **Relation type** field, select **Related**, **Parent**, or **Child**.

1. In the **Link to** section, select **Link to existing** (default).

1. Start typing in the search field to find the request you want to link. You can search by request ID, title, company, or contact.

1. Select the request from the list. You can hover over a request in the list to preview its details.

1. Optionally, add a comment explaining the relationship.

1. Click **Relate** to create the link.

### From the Requests section tab

1. Go to a Company, Contact, Sale, or Project screen.

1. Select the **Requests** section tab.

1. Right-click the request you want to create a relation from.

1. Select **Relations** from the context menu.

1. Follow steps 4-9 above to complete the relation.

![Context menu showing Relations option -screenshot][img4]

## Create new request as relation

Instead of linking to an existing request, you can create a new request while establishing the relation:

1. Follow the steps above to open the **Relations** dialog.

1. In the **Link to** section, select **Create new request**.

1. Fill in the request details.

1. Click **Relate** to create both the new request and the link simultaneously.

## <a id="delete"></a>Remove request relation

1. Open the request and select the **Relations** tab.

1. Find the relation you want to remove.

1. Click <i class="ph ph-x-circle" aria-label="Remove icon"></i> **Remove relation** at the bottom of the dialog, or right-click the relation and select **Remove relation**.

1. Confirm the deletion.

Removing a relation deletes only the link. The requests remain unchanged.

## Troubleshooting

### Remove relation button is not clickable

The **Remove relation** button is only active when you have selected exactly one relation. Make sure you have:

* Selected a single relation in the list
* Not selected multiple relations

### Cannot add parent or child relation

**Reason:** A request can only have one parent. If the request already has a parent, you cannot assign another parent relationship.

**Solution:** Remove the existing parent relation first, or use a **Related** relation type instead, which allows multiple connections.

### Cannot create relation

**Possible reasons:**

* **Duplicate relation:** The two requests are already linked. Check the **Relations** tab to see if the relation already exists.
* **Circular hierarchy:** You cannot create a parent-child relationship that would result in a circular reference (for example, Request A is the parent of Request B, and Request B is the parent of Request A).

**Solution:** Check existing relations and adjust your hierarchy structure to avoid circular dependencies.

## Related content

* [Split request][2]
* [Merge requests][1]
* [Requests section tab][3]
* [Company and contact relations][4]

<!-- Referenced links -->
[1]: merge.md
[2]: split-request.md
[3]: ../../learn/section-tabs/requests-tab.md
[4]: ../../learn/basics/relations.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/request-relations-archive.png
[img2]: ../../../media/loc/en/request/request-relations-tree.png
[img3]: ../../../media/loc/en/request/request-relations-perspective.png
[img4]: ../../../media/loc/en/request/request-relations-context-menu.png
