---
# Mandatory fields.
title: saint       # (Required) Very important for SEO.
description: Saint
author: {github-id}             # Your GitHub alias.
keywords: sale
so.date: 05.11.2016
so.topic: concept               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# SAINT

SAINT **values** are stored in the `statusvalue` table. They are simple binary values in either on or off state. These values determine the look and feel of the company and project cards.

The `isSignalled` field determines whether to display an image in the background of the contact card or not. The image displayed in the contact card is defined in the `statusdef` table. According to the `StatusDef_id` in the `statusvalue` table, the `statusdef` table is referred and the background image in the contact card varies accordingly. The actual image is found via the blob link table.

SAINT **counters** are used to keep track of certain actions and SAINT requires a separate license. The `countervalue` table maintains SAINT counters. When SAINT is enabled, whenever a contact or project is created a set of rows are added to the `countervalue` table.

There is always a row in the `countervalue` table corresponding to appointment, document, or sale. The respective counter rows in the `countervalue` table will be updated whenever an appointment, document, or sale is created.
