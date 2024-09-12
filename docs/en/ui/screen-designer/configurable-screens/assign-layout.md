---
uid: screen-assign-layout
title: Assign a layout to group or type
description: How to assign a layout to a group, sale type, project type, or request type using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
date: 09.12.2024
version: 10.2.11
keywords: ui, screen, customization, layout, used by, assign to, assign layout
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
---

# Assign layout to group or type

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

## Steps

1. Open the Screen Designer.
1. At the top, select a screen: Company, Contact, Sale, Project, Request, or Follow-up.
1. Select assignment method (if not set): click the text next to **Assign layouts to**, and choose group or type.

    * Company and contact: user group only
    * Sale: user group or sale type
    * Project: user group or project type
    * Request: user group or request type
    * Follow-up: user group or follow-up type

1. Select a layout in the list on the left side.
1. Click the **Assign to** field and select a group or type. Your options depend on the selected screen.

## Restrictions

* The default layout can't be assigned.
* A user group can only be assigned to one layout per screen.
* If you delete a layout, user groups assigned to it, will go back to the default layout.

<!-- Referenced links -->

<!-- Referenced images -->
