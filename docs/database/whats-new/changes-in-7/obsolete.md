---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_obsolete_fields_and_tables       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - Obsolete fields and tables # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Obsolete fields and tables

We had a number of obsolete tables... that have either become obsolete, or that were designed but never taken into use.
There were also some obsolete fields which has been removed. This changes the field id’s (we had to change reporter priming data), but has no other ill consequences.

The obsolete tables have been replaced by new tables, as far as possible (there were more obsolete tables than new tables in Seven). The remainders are single-field tables in the dictionary, but they are not physically created in the db. This keeps the table numbers unchanged

Keeping the table numbers unchanged is important to avoid breaking or remapping relations.
From 7.5 on, we won’t add tables or fields until we know for sure that we need them, what you see in the database is actually all in use.
