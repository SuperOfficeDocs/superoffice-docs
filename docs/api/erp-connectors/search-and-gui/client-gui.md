---
# Mandatory fields.
title: erp_sync_client_gui       # (Required) Very important for SEO.
description: ERP sync client GUI # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept    # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# ERP sync client GUI

Erp Sync will also require a GUI in the SuperOffice client, to allow the user to create and link SuperOffice entities to ERP actors, and to take advantage of the *Show In ERP Tab* functionality where an ERP field may be retrieved on demand and shown in its corresponding SuperOffice entity.

GUI operations are beyond the scope here, but for understanding’s sake, we have included a few figures.

* All Erp Sync functionality will be located on a separate tab on its appropriate entity (contact, person, project, etc).

  ![ALT][img1]

* The ERP tab on a contact entity after pressing the Edit button. We see three separate ERP connections, and the user has the choice to connect the contact in any one of them.

  ![ALT][img2]

* When connecting a CRM entity to an ERP actor, the user gets an opportunity to select what data to keep and what to throw away (for fields that don’t have matching values on both sides). Below that, we can also see the [default value][1] functionality, where the user can set values on an ERP Actor without needing the fields to be mapped and synced.

  ![ALT][img3]

* Once an actor is connected to an actor at a sync connection, the user can see real-time values fetched directly from the connection. These are the fields that are set up as "Show on ERP tab" through the mapping screen.

  ![ALT][img4]

<!-- Referenced links -->
[1]: ../default-values.md

<!-- Referenced images -->
[img1]: media/image011.png
[img2]: media/image012.png
[img3]: media/image013.png
[img4]: media/image014.png
