---
title: so_protocol_query_strings
description: SoProtocol query strings
author:
so.date:
keywords:
so.topic: reference
---

# Query strings (what)

The **query string** is what comes behind the question mark (?) in the URL. Separate the whats with an ampersand `&`.

You can use the primary keys to specify what to open:

* contact_id
* person_id
* appointment_id
* sale_id
* project_id
* selection_id
* document_id

For example, to go to sale 42:

`superoffice:sale?sale_id=42`

To go to a specific company card, set the active archive, and open an appointment:

`superoffice:contact.main.activityarchive.appointment?contact_id=2&appointment_id=1`

<!-- Referenced links -->
