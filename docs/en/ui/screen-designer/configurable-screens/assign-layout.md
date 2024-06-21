---
uid: screen-assign-layout
title:  Assign a layout
description: How to assign a layout to a group, sale type, project type, or request type using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
date: 01.03.2024
version: 10.2.11
keywords: ui, screen, customization, layout, used by
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
---

# Assign layout to group or sale/project/request type

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

## Steps

1. Open the Screen Designer.
2. At the top, select a screen: Company, Contact, Sale, Project, Request, or Follow-up.
3. Select a layout in the list on the left side.
4. Click the **Used by** field. Your options depend on the selected screen.

    * Company and contact: Select one or more user groups.
    * Sale: First select assignment method (user group or sale type), then select the specific groups or types.
    * Project: First select assignment method (user group or project type), then select the specific groups or types.
    * Request: First select assignment method (user group or request type), then select the specific groups or types.

## Restrictions

* The default layout can't be assigned.
* A user group can only be assigned to one layout per screen.
* If you delete a layout, user groups assigned to it, will go back to the default layout.

<!-- Referenced links -->

<!-- Referenced images -->
