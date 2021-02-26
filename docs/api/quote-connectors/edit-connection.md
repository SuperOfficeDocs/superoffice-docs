---
title: quote_connectors_update
description: How to update a quote connector
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote
so.topic: howto
---

# Editing a connection

When editing a connection, the admin client will call `Initialize` first, so that lists that depend on talking to a web service URL that is configured as part of the fields are more likely to work.

![05][img1]

When editing a connection, the connection values are loaded from the database and passed to the connector before the connection is used. This makes it possible to try to use the config values during the editing of the config values.

> [!NOTE]
> The connection is not initialized again until the connection is saved, so you will not get a live updating of lists as you edit each field.

The connection values are stored in the SuperOffice database, not in the connector.

<!-- Referenced images -->
[img1]: media/image005.jpg
