---
uid: help-en-role
title: Role
description: Role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Roles

[!include[Requirement](../includes/note-anon-req.md)]

Using role-based security in SuperOffice CRM, you can customise roles for different access levels in the company.

A role describes two things:

* Which <!-- Fix reuse ID=a2 -->(companies, contacts, projects, project members, selections, sales, follow-ups, documents, relations, stakeholders and dashboards) are to be made <!-- Fix reuse ID=a3 -->(accessibility is specified using rights: none, read, create, update and delete) for the users who have this role.
* Which <!-- Fix reuse ID=a4 -->(e.g. administrator access in Settings and maintenance, allow bulk update, quote approval, mail merge, exporting selections and publishing)  are to be made accessible to users with this role.

A number of predefined roles are included with SuperOffice CRM. The **User levels 0–5** roles correspond to the user levels from previous versions of SuperOffice, where user level 0 is an administrator. You can edit these roles at will.

<!-- Fix reuse ID=a1 -->

| Role | Explanation |
|---|---|
| User level 0 | Administrator: Has full access to all data. Can maintain all parts of the system. |
| User level 1 | Superuser: Has full access to data, but cannot maintain the system. |
| User level 2 | Has full access within own user group, but limited access beyond that. |
| User level 3 | Has full access to own data and can read data within own user group, but limited access beyond that. |
| User level 4 | Has full access to own data, but limited access within own user group and beyond that. |
| User level 5 | Has read access to most data, but limited access to others' data. Can create activities. |
| List administrator | Has full access to data in the SuperOffice CRM client. Can use Settings and maintenance to edit lists in the system (e.g. of document templates and categories). |
| User administrator | Has full access to data. Can use Settings and maintenance to create and edit users in the system. |
| Local user | Has full access to own data, but no access to data belonging to users linked to other companies. |
| External user | Consultant or partner with limited access to company and project data. Only has access to data which has been published. |
| Anonymous user | Anonymous user |
| System user | System integration user. Overrides all security controls. This role is not visible and cannot be edited. |

## What would you like to do now?

[Create a role](Create-role.md)

[Edit a role](Editing-role.md)

[Set data rights for a role](Set-data-rights-for-role.md)

[Edit rights for anonymous users](Edit-rights-for-anonymous-users.md)

[Delete a role](Deleting-role.md)
