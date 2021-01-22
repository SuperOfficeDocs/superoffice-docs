---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: main_db_tables       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: The Main Tables # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# The main tables

The main tables in the system are:

| Table | Contains |
|---|---|
| [Contact][1] | The companies |
| [Person][2] | The contact persons |
| [Associate][3] | The users - these are linked to contact persons |
| [Appointment][4] | Meetings, to-do activities |
| [Document][5] | Document activities |
| [Sale][6] | Sale activities |
| [Project][7] | Projects |
| [ProjectMember][8] | Persons who are part of a project |
| [Selection][9] | Selections |
| [SelectionMember][10] | Link table for Contact+Person who are selection members |
| [Ticket][11] | Service tickets |

> [!NOTE]
> The [Company][12] table is used to store the ID of the company that owns the license. It has nothing to do with the company display in the user interface.

Unfortunately, not all table names and UI labels match. If in doubt, [refer to our mapping][13].

<!-- Referenced links -->
[1]: ../tables/contact.md
[2]: ../tables/person.md
[3]: ../tables/associate.md
[4]: ../tables/appointment.md
[5]: ../tables/document.md
[6]: ../tables/sale.md
[7]: ../tables/project.md
[8]: ../tables/projectmember.md
[9]: ../tables/selection.md
[10]: ../tables/selectionmember.md
[11]: ../tables/ticket.md
[12]: ../tables/company.md
[13]: so-view-of-the-world.md
