---
title: sentry_plugins
description: Sentry plugins
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
so.envir: onsite
---

# Sentry plugins

Plugins are created using a `Factory` class based on the `IPlugin` interface and a plugin attribute. When creating a Sentry plugin, use the `ISentryPlugin` interface located in the `SuperOffice.CRM.Security` namespace.

A sentry plugin works out what information a particular user is allowed to see, and what the user can do with the information. A sentry plugin may rewrite the [OSQL queries][1] to get more information so it can make its decision.

A sentry plugin must look at the information available through the sentry’s lookup objects, and use these values to figure out whether the current user can see, edit or delete the data. In this way, a Sentry plugin should be stateless. The plugin may be called many times with different rows of information.

## When is Sentry plugin called?

![Sentry plugin sequence diagram][img1]

The diagram shows what happens when your client code causes a database access.

* The database access causes a Sentry and its plugins to be created, and the Sentry plugin gets a chance to modify the SELECT.

* After the data reader is returned, each row that is read is passed through the Sentry and each of its plugins to calculate the access rights.

## How to create and use your own Sentry plugin

* [Basic Sentry plugin with simplified data][2]
* [Sentry plugin with an extra (custom) table][3]

<!-- Referenced links -->
[1]: ../../osql/index.md
[2]: create-sentry-plugin.md
[3]: tutorial-sentry-plugin-with-ext-table.md

<!-- Referenced images -->
[img1]: media/sentry-plugin.png
