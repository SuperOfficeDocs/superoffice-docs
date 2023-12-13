---
uid: screen-assign-layout
title:  Assign a layout
description: How to assign a layout to a group, sale type, or project type using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: ui, screen, customization
so.topic: howto
so.envir:
so.client:
---

# Assign layout to group, sale type, or project type

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

> [!NOTE]
> The default layout can't be assigned.

If you delete a layout, user groups assigned to it, will go back to the default layout.

1. Open the Screen Designer.
2. At the top, select a screen: Company, Contact, Sale, Project, or Request.
3. Select a layout in the list on the left side.
4. Click the **Used by** field. Your options depend on the selected screen.

    * Company, contact, and request: Select one or more user groups.
    * Sale: First select assignment method (user group or sale type), then select the specific groups or types.
    * Project: First select assignment method (user group or project type), then select the specific groups or types.
    * Request: First select assignment method (user group or request type), then select the specific groups or types.

    > [!NOTE]
    > A user group can only be assigned to one layout per screen.

<!-- Referenced links -->

<!-- Referenced images -->
