---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: renew_ticket       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Ticket renewal # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
keywords: authentication,usec
so.topic: howto                     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Ticket renewal

The ticket stub is timestamped in the database and **valid for 6 hours**. Every time a ticket is used, NetServer logs how it was used (client name), and then it is renewed for another 6 hours.

Tickets are cached, thereby eliminating the need to re-issue new ones each time one is requested. This keeps the number of tickets at a manageable level.

Expired tickets are not renewed. They are deleted on a background thread the next time a valid ticket is created.
