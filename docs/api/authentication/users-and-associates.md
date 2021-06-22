---
uid: users_and_associates
title: Users and associates
description: Users and associates 
author: {github-id}
keywords: database
so.topic: concept
# so.envir:
# so.client:
---

# Users and associates

Users are stored in the `associate` table in the database.

```SQL
SELECT * FROM associate
```

![associate database table][img1]

The `reserved` field contains the password and license information. This information is encrypted and can only be edited using the SuperOffice APIs.

The `name` field contains the login ID - a corresponding database login is created for each internal user when the user is created in the SuperOffice Admin tool, to allow database admins more detailed logs of user activity.

The `person-id` field points to the user's corresponding person. This is where the user's full name, title, and phone number information is stored.

## User types

There are several different types of users.

| User | Type | Can sign in | Has diary | Has user group | Must use NetServer API | Requires Expander Services | Supported by CRM Online |
|---|---|---|---|---|---|---|---|
| Internal  |  0 | x | x | x |   |   | x |
| Resource  |  1 |   | x |   | x |   | x |
| External  |  4 |   |   |   | x |   |   |
| Anonymous |  7 |   |   |   | x | x |   |
| System    | 13 |   |   |   | x | x | x |

### Internal users (type 0)

Internal users (employees) are the only type that can sign in to the client.

An internal user is always linked to a person belonging to a contact listed in the [ownercontactlink][1] table.

### External users (type 4)

**External users** can log in to NetServer and access information there, but their access is usually restricted to their own company and to projects that they are members of. We can use external users when we have decided to make our data not so public. We can use this user type when we are working with partners or customers.

These users are configured by internal users (associates) with the functional right to create external users. External users are contact persons registered on contacts in the database that has been given a username and password as an external person. Therefore they are represented in the `person` table. Since they are given usernames and passwords they also get an associate row in the `associate` table.

We can [enable external users][1] in the config file.

Like anonymous users, external users are also restricted in what they can edit and create. An external user can be authenticated just as we authenticate an internal user, but they can only use NetServer applications. They cannot use the SuperOffice client.

They have access to published information - in other words, the internal users determine what the external users can see.

### Anonymous users (type 7)

> [!CAUTION]
> Anonymous users are **obsolete since version 9**.

Anonymous users can be anyone. We can use anonymous users when we have decided to make all our data public. If we allow the anonymous anyone can log in to the system and view our data.

An anonymous user is used when you **call a service agent without authenticating**. We must configure the anonymous user in the database and the config file.

The anonymous user has a very limited number of data rights. It is only allowed to view data in the database. The SOAdmin can set more data rights to anonymous users. And we mainly create anonymous users in SoAdmin.

These explicit anonymous users authenticate just as internal users do. Learn [how to configure the anonymous users][2] in the config file.

> [!NOTE]
> If authentication fails, an exception will be thrown because the services layer behaves differently than the database layer.

### System users (type 13)

System users are used for integrating different systems.

They bypass the security checks, allowing full access to all data in SuperOffice.

### Resources (type 1)

Resources are also stored in the `associate` table. The reason for this is that resources can also be meeting participants, and thus **have diaries** that can be viewed in the CRM client.

```SQL
SELECT * FROM associate WHERE type = 1
```

![assoc-resources][img6]

## User groups

**Internal users** are members of one or more user groups.

![UserGroupLink diagram][img2]

**External users**, anonymous and system users do not have user-group memberships. The `associate.group_id` field should be 0 for these types.

```SQL
SELECT * FROM usergroup
```

![UserGroup][img3]

```SQL
SELECT * FROM usergrouplink
```

![UserGroupLink][img4]

The `usergrouplink` table contains 1 entry for each user group an associate is a member of.

The **primary user group** is the user-group ID that is stored on the associate record in the `associate.groupd_id` field. It is used in the SuperOffice role and security system to determine a user's access to information.

## Ownership

The major tables in the database (contact, person, project, appointment, sale, relation) have an associate + group ID field on them. These fields are used to determine who owns and controls a particular piece of information. The relationship between the logged-in user and the owner along with the logged-in user's role determines what sort of access the logged-in user has to the information.

![AssociateLinks][img5]

The `group_id` field stores the associate's primary group at the time the `associate-id` value was set. This is to ensure that an appointment is still visible to the other members of the group if the associate moves to a new group or is deleted.

> [!NOTE]
> When setting the `associate_id` field on something, you must make sure to also update the `group_id` field.

<!-- Referenced links -->
[1]: ../../../database/docs/tables/ownercontactlink.md
[2]: onsite/config-anonymous-user.md
[3]: onsite/config-external-user.md

<!-- Referenced images -->
[img1]: media/assoc-table.png
[img2]: media/usergrouplink-diag.png
[img3]: media/usergroup.png
[img4]: media/usergrouplink.png
[img5]: media/associate-links.png
[img6]: media/assoc-resources.png
