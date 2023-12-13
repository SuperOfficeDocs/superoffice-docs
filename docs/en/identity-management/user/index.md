---
title: User accounts and role-based access control
uid: user_accounts_roles
description: SuperOffice CRM Online enforces role-based access control, and each user must have a unique ID to sign in.
author: {frodeb@superoffice.com}
keywords:
so.topic: concept
---

# User accounts and role-based access control

SuperOffice CRM Online enforces role-based access control, and each user must have a unique ID to sign in.

> [!NOTE]
In SuperOffice CRM Online, a user is called an **associate**.

* A user belongs to a company registered in the CRM
* A user may be assigned a license
* A user belongs to one or more groups
* A user has a role

A user must be marked as active (and have a valid license) to be able to sign in.

By default, we also store the following information about a user:

* User ID - the assigned username
* First and last name

## User ID

The administrator can choose to enter a **username** or use the automatically generated ID.

* Username must be unique
* Username may contain any character
* Username should be short enough to fit into the display columns

## Password

The administrator can set an initial password if the tenant uses basic authentication.

If the tenant uses an identity provider, you will see the label **AD user** instead of **Password**, and you can't enter an initial password.

## Groups

Group membership determines **which data a user has access to**, but not what the user may do with that data. Data here means for example contacts, diary follow-ups, projects, and sales.

Each user will have a primary group, but they may also be members of other groups.

## Role

A role determines **what a user may do with the data** the groups grant access to and also a set of [functional rights][1].

What a user can do follows an accumulative CRUD pattern. Functional rights pertain to actions such as exporting selections and opening the Admin client.

We have defined a [set of default roles][2] that you can change and expand to tailor the access control to the needs of your organization. The roles named **User level 0–5** cover the range from full access (0) to read-only access (5).

<!-- Referenced links -->
[1]: ../../admin/user-management/learn/role/functional-rights.md
[2]: ../../admin/user-management/learn/role/index.md
