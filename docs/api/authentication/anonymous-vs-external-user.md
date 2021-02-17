---
# Mandatory fields.
title: anonumous_vs_external_user       # (Required) Very important for SEO.
description: External vs. anonymous users  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# External vs. anonymous users

We can have 2 different types of users known as external and anonymous, but we need to obtain a separate license to activate them. These 2 users have different types of rights.

* We can use anonymous users when we have decided to make all our data public. If we allow the anonymous anyone can log in to the system and view our data.
* We can use external users when we have decided to make our data not so public. We can use this user type when we are working with partners or customers.

## Who are anonymous users

An anonymous user is used when you **call a service agent without authenticating**. We must configure the anonymous user in the database and the config file.

The anonymous user has a very limited number of data rights. It is only allowed to view data in the database. The SOAdmin can set more data rights to anonymous users. And we mainly create anonymous users in SoAdmin.

These explicit anonymous users authenticate just as internal users do. Learn [how to configure the anonymous users][1] in the config file.

> [!NOTE]
> If authentication fails, an exception will be thrown because the services layer behaves differently than the database layer.

## Who are external users

These users are configured by internal users (associates) with the functional right to create external users. External users are contact persons registered on contacts in the database that has been given a username and password as an external person. Therefore they are represented in the `person` table. Since they are given usernames and passwords they also get an associate row in the `associate` table.

We can [enable external users][2] in the config file.

Like anonymous users, external users are also restricted in what they can edit and create. An external user can be authenticated just as we authenticate an internal user, but they can only use NetServer applications. They cannot use the SuperOffice client.

<!-- Referenced links -->
[1]: config-anonymous-user.md
[1]: config-external-user.md
