---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.
uid: users_and_associates
title: Users and Associates       
description: Users and associates 
author: {github-id}
keywords: database
so.topic: concept              
# so.envir:
# so.client:
---

# Users and associates

Users are stored in the `Associate` table in the database.

There are several different types of users.

* Internal users (a.k.a. employees) have type=0. These users can log in to the client. They have a diary that contains their appointments. An internal user is always linked to a person belonging to a contact listed in the [ownercontactlink][1] table.

* External users have type=4. These users cannot log in to the client and do not have diaries containing appointments. They can log in to NetServer and access information there, but their access is usually restricted to their own company and to projects that they are members of. External users have access to published information - in other words, the internal users determine what the external users can see.

* Anonymous users (are **obsolete since v9**) have type=7. Anonymous users can be anyone. They cannot log into the client. They must use the NetServer API to access the database. The site must have an Expander Collaboration license to enable anonymous users.

* System users have type=13. System users are used for integrating different systems. System users cannot log in to the client. They must use the NetServer API. System users by-pass the security checks, allowing full access to all data in SuperOffice. The site must have an Expander Collaboration license.

```SQL
SELECT * FROM associate
```

![AssocTable][img1]

The reserved field contains the password and license information. This information is encrypted and can only be edited using the SuperOffice APIs.

The name field contains the login ID - a corresponding database login is created for each internal user when the user is created in the SuperOffice Admin tool, to allow database admins more detailed logs of user activity.

The person-id field points to the user's corresponding person. This is where the user's full name, title, and phone number information is stored.

## Usergroups

Internal Users are members of one or more usergroups.

![UserGroupLinkDiag][img2]

External users, anonymous and system users do not have usergroup memberships. The `associate.group_id` field should be 0 for these types.

```SQL
SELECT * FROM usergroup
```

![UserGroup][img3]

```SQL
SELECT * FROM usergrouplink
```

![UserGroupLink][img4]

The `usergrouplink` table contains one entry for each user-group an associate is member of.

The primary user-group is the user-group-id that is stored on the associate record in the `associate.groupd_id` field. The primary usergroup is used in the SuperOffice role and security system to determine a user's access to information.

## Ownership

The major tables in the database (Contact, Person, Project, Appointment, Sale, Relation) have an associate + group ID field on them. These fields are used to determine who owns and controls a particular piece of information. The relationship between the logged in user and the owner along with the logged-in user's role determines what sort access the logged in user has to the information.

![AssociateLinks][img5]

The `group_id` field stores the associate's primary group at the time the `associate-id` value was set.

This is to ensure that an appointment is still visible to the other members of the group if the associate moves to a new group or is deleted.

When setting the `associate_id` field on something, you must make sure to also update the `group_id` field.

## Resources

Resources are also stored in the `Associate` table.

The reason for this is that resources can also be meeting participants, and thus have diaries that can be viewed in the CRM client.

Resources have type=1, while internal users have type=0.

```SQL
SELECT * FROM associate WHERE type = 1
```

![assoc-resources][img6]

Resources do not have logins or usergroup membership.

<!-- Referenced links -->
[1]: ../../../database/docs/tables/ownercontactlink.md

<!-- Referenced images -->
[img1]: media/assoc-table.png
[img2]: media/usergrouplink-diag.png
[img3]: media/usergroup.png
[img4]: media/usergrouplink.png
[img5]: media/associate-links.png
[img6]: media/assoc-resources.png
