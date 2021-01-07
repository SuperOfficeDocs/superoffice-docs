---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mirroring_scenarios       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Database mirroring scenarios # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Database mirroring scenarios

The mirroring system is to a large extent self-bootstrapping.

## Scenarios that are handled

| Action | Online | Partner |
|--------|--------|---------|
| New customer | Change tracking is enabled when each table is mirrored.<br>All rows considered changed. | The table created when each schema is received.<br>All rows populated. |
| Mirror restored from backup. | Ordinary mirroring. | LSN is part of the restored backup.<br> All changes done after restore will be retransmitted automatically. |
| Online restored from backup | Manual intervention needed to wipe the mirror.<br>It can be forced by turning off change tracking in the restored database. | Mirror wiped and repopulated remotely. |
| Writing to mirror fails | Ordinary mirroring next cycle. | LSN is updated only when a commit is successful. | All changes done after the last successful cycle will be transmitted. |
| Mirroring service is down for more than 7 days. | The mirror is automatically wiped and repopulated. | The mirror is automatically wiped and repopulated. |
| Incompatible schema change. | The error returned from the client-side causes retry with wipe/repopulate (not implemented in beta). | Schema change fails: the table is dropped and an error returned (not implemented in beta). |
