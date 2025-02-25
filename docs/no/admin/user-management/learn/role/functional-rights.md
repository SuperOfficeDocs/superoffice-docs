---
uid: help-no-functional-right 
title: Functional rights in SuperOffice
description: What are all available functional rights in SuperOffice and what each of them mean?
keywords: user management, role, access, rights
author: Philip Yates, Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: reference
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Functional rights in SuperOffice

Using [role-based security][3], we can [customize roles][2] to give access to different functions of SuperOffice CRM.

<!-- Sort alphabetical -->
| Functional right | Description | Comment |
|---|---|---|
| Administrate FAQ | The user may publish FAQ entries. | They will also be notified of unpublished and expired FAQ entries. |
| Allow bulk update | The user may bulk update fields on selected entities and selection members. | |
| Can approve quotes | The user may approve quotes. | |
| Can copy a selection | The user may copy the members of a selection to another selection. | |
| Can create and delete tables in the database | Grants access to the Dictionary SDK. The user may create and delete tables in the database. The CREATE TABLE privilege in the database must be assigned to this user, or to a database user defined in the Replication screen. | **Obsolete** |
| Can create tasks for a selection | The user may create new follow-ups for all members of a selection. | |
| Can delete selection members | The user may delete the companies that are members of a selection. | All contacts belonging to each company will also be deleted. |
| Can edit flow content | The user may view flows and open a flow to add/edit flow content emails. | |
| Can export data to file | The user may export company and contact information to a file. | |
| Can lock and unlock targets | The user may lock and unlock sale targets. | |
| Can manage (move and merge) entities | The user may move, merge, and copy contacts, companies, and so on. | |
| Can modify interests for selection members | The user may modify the interests for all members of a selection. | |
| Can override consent in mailings | The user may override the consent check when sending mailings. | |
| Can override read-only fields | The user may modify read-only user-defined fields. | |
| Can run Mail Merge | The user may perform a mail merge against a selection or a project. | |
| Can run custom tasks on selections | The user may run custom programs on selections. | **Obsolete** |
| Can see users belonging to other companies | The user may see users outside their own organization and data owned by these users, such as follow-ups and projects. | |
| Can send email to selection members | The user may email all members of a selection. | |
| Can update consent for contact | The user may update the consent on behalf of a person. | |
| Category administration | The user may administrate categories in Service. | |
| Change own profile | The user may change their profile. This controls which data fields they may view. | **Legacy Service client only** |
| Change own properties | The user may change their own properties. | **Legacy Service client only** |
| Create new tags directly | The user may create tags directly, without using SuperOffice Settings and maintenance. | |
| Create selections | The user may create and edit selections. | **Legacy Service client only** |
| Dashboard administrator | The user may pin dashboards to other associates. | |
| Edit FAQ entries | The user may create and edit FAQ entries. | |
| Edit all requests | The user may edit all requests. | |
| Edit own synchronization settings | Grants limited access to SuperOffice Intellisync Server Maintenance. The user may change own settings only. | **Obsolete** |
| Edit requests in own categories | The user may edit all requests in categories they are a member of. | |
| Edit tables | The user may edit the contents of extra tables. | |
| Facebook | The user may post copies of requests and messages to Facebook. | **Obsolete** |
| Field Administrator | Grants limited access to Settings and maintenance. The user may modify user-defined fields in the Company, Contact, and Project screens. | |
| Flow administrator | The user may create and update flows; create, update, and delete flow content; run and cancel flows. | |
| General Administrator | Grants full access to Settings and maintenance. The user may create users, edit lists, modify user-defined fields, maintain Travel and replication, import data. | |
| Hide Company screen | Do not display the Company button and screen and company-related fields. | |
| Hide Inbox screen | Do not display the Inbox button and screen. | |
| Hide Marketing screen | Do not display the Marketing button and screen. | |
| Hide Project screen | Do not display the Project button and screen or project-related fields. | |
| Hide Reports screen | Do not display the Reports button and screen. | (ONSITE ONLY) |
| Hide Sale screen | Do not display the Sale button and screen. | |
| Hide Selection screen | Do not display the Selection button and screen. | |
| Hide Service screen | Do not display the Service button and screen. | |
| Import Administrator | Grants limited access to Settings and maintenance. The user may load information from text files into the database. | |
| Knowledge Base | Grants access to the knowledge base. | |
| List Administrator | Grants limited access to Settings and maintenance. The user may modify lists (category, businesses, interests, document templates, and so on). | |
| List all requests | The user may list all requests. | |
| List requests in own categories | The user may list all requests in categories they are a member of. | |
| List tables | The user may list the contents of extra tables. | |
| Preferences Administrator | Grants limited access to Settings and maintenance. The user may modify user preferences. | |
| Quote administrator | The user may administrate quotes and products. | |
| Read all requests | The user may read all requests. | |
| Read requests in own categories | The user may read all requests in categories they are a member of. | |
| Replication administrator | Grants limited access to Settings and maintenance. The user may create, delete and edit roles. The user may create, delete, and edit Travel users, prototypes, areas, and satellites. | **Obsolete** |
| Role Administrator | Grants limited access to Settings and maintenance. The user may create, delete, and edit roles. | |
| Script Administrator | Grants limited access to Settings and maintenance. The user may enable/disable scripts. | **Obsolete** |
| Service administration | The user may administrate the Service system setup. | |
| Status Monitor Administrator (counters) | Grants limited access to Settings and maintenance. The user may run the counter and status regeneration tasks | These tasks can take a long time on large databases. |
| Status Monitor Administrator (statuses) | Grants limited access to Settings and maintenance. The user may add, edit, and delete statuses. | This right also implies the right to regenerate statuses, but not the underlying counters. |
| SuperOffice Intellisync Server Maintenance | Grants full access to SuperOffice Intellisync Server Maintenance. The user may add and remove users, and set default values for all users, groups, and individual users. | **Obsolete** |
| Targets administrator | Grants limited access to Settings and maintenance. The user may add, edit, and remove sale target types. | |
| User Administrator | Grants limited access to Settings and maintenance. The user may create, modify, and delete users. | |
| View selections | The user may view selections. | **Legacy Service client only** |
| View statistics | Grants access to the statistics module. | **Legacy Service client only** |
| Workflow administrator | Grants limited access to Settings and maintenance. The user may edit workflow (sales or project guide). | To edit lists, the user must also have rights to edit lists or be a general administrator. |

## Related information

* [Create role][1]
* [Set data rights for a role][2]

<!-- Referenced links -->
[1]: create-role.md
[2]: set-data-rights-for-role.md
[3]: index.md

<!-- Referenced images -->
