---
# Mandatory fields.
title: erp_setup_defaults      # (Required) Very important for SEO.
description: Setting up ERP Sync defaults # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Setting up default values

[Default values][1] are used when Erp Sync creates a new [actor][2] in the ERP system.

![x][img1]

The user clicks the **DEFAULTS** button to set up what values the user needs to fill in when creating new actors in the ERP system.

If the connector has marked the field as *Mandatory*, the bottom checkbox will always be selected and disabled.

The `GetSupportedActorTypes` method was called when the connection is saved. The list of fields for the actor types is cached in the SuperOffice database - so this does not trigger any further calls to the connector.

The list of ERP fields is from the result of the `GetSupportedActorTypeFields` made when the connection was saved.

## List items

If you select a list field, then the connector's `GetList` method fills the dropdown with list items.

When you save the default for the list field, this will trigger one additional call: `GetListTems()`

The admin client wants to know the display value for the list item, so it asks the connector directly for the text of list item 3.

<!-- Referenced links -->
[1]: default-values.md
[2]: api/erp-actor-carrier.md

<!-- Referenced images -->
[img1]: media/image006.png
