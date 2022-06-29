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

> [!NOTE]
> Some functions in this topic require a separate licence (external users and anonymous users). See [Licences](../chap03/Licences_screen.md).

Using role-based security in SuperOffice CRM, you can customise roles for different access levels in the company.

A role describes two things:

* Which <!-- Fix reuse ID=a2 -->(companies, contacts, projects, project members, selections, sales, follow-ups, documents, relations, stakeholders and dashboards) are to be made <!-- Fix reuse ID=a3 -->(accessibility is specified using rights: none, read, create, update and delete) for the users who have this role.
* Which <!-- Fix reuse ID=a4 -->(e.g. administrator access in Settings and maintenance, allow bulk update, quote approval, mail merge, exporting selections and publishing)  are to be made accessible to users with this role.

A number of predefined roles are included with SuperOffice CRM. The **User levels 0–5** roles correspond to the user levels from previous versions of SuperOffice, where user level 0 is an administrator. You can edit these roles at will.

<!-- Fix reuse ID=a1 -->

<table style=" margin-top:5px; margin-bottom:5px; margin-left:5px; width:100%; max-width:79.498%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>Role</p></td>
<td><p>Explanation</p></td>
</tr>
<tr>
<td><p>User level 0</p></td>
<td><p>Administrator: Has full access to all data. Can maintain all parts of the system.</p></td>
</tr>
<tr>
<td><p>User level 1</p></td>
<td><p>Superuser: Has full access to data, but cannot maintain the system.</p></td>
</tr>
<tr>
<td><p>User level 2</p></td>
<td><p>Has full access within own user group, but limited access beyond that.</p></td>
</tr>
<tr>
<td><p>User level 3</p></td>
<td><p>Has full access to own data and can read data within own user group, but limited access beyond that.</p></td>
</tr>
<tr>
<td><p>User level 4</p></td>
<td><p>Has full access to own data, but limited access within own user group and beyond that.</p></td>
</tr>
<tr>
<td><p>User level 5</p></td>
<td><p>Has read access to most data, but limited access to others' data. Can create activities.</p></td>
</tr>
<tr>
<td><p>List administrator</p></td>
<td><p>Has full access to data in the SuperOffice CRM client. Can use Settings and maintenance to edit lists in the system (e.g. of document templates and categories).</p></td>
</tr>
<tr>
<td><p>User administrator</p></td>
<td><p>Has full access to data. Can use Settings and maintenance to create and edit users in the system.</p></td>
</tr>
<tr>
<td><p>Local user</p></td>
<td><p>Has full access to own data, but no access to data belonging to users linked to other companies.</p></td>
</tr>
<tr>
<td><p>External user</p></td>
<td><p>Consultant or partner with limited access to company and project data. Only has access to data which has been published.</p></td>
</tr>
<tr>
<td><p>Anonymous user</p></td>
<td><p>Anonymous user</p></td>
</tr>
<tr>
<td><p>System user</p></td>
<td><p>System integration user. Overrides all security controls. This role is not visible and cannot be edited.</p></td>
</tr>
</tbody>
</table>

## What would you like to do now?

[Create a role](Create_role.md)

[Edit a role](Editing_a_role.md)

[Set data rights for a role](Set_data_rights_for_role.md)

[Edit rights for anonymous users](Edit_rights_for_anonymous_users.md)

[Delete a role](Deleting_a_role.md)
