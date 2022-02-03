---
title: Create a custom archive control
uid: create_custom_archive_controls
description: Create custom archive controls
author: Steffan Alte
so.date: 2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# Create a custom archive control

Archive controls display rows of data to users and enables interactions with the user by clicking a row, selecting one or more rows and using right-click context menus, or selecting a row and invoking an action button.

![Archive control][img1]

This 4-step tutorial demonstrates how to add an Archive control to the web client, establish settings that determine the data source, as well demonstrates context menu and action button settings.

1. [Add an Archive control][1]
2. [Add archive row context menu][2]
3. [Add row click actions][3]
4. [Add an archive action button][4]

> [!NOTE]
> Caching works for all configuration files **except system files**. These are cached during application start-up and held in memory.

Any changes to the following files do require an IIS reset:

* SoApplicationConfiguration.config
* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoObjectMapping.config
* SoArchiveColumnList.config
* SoArchiveControlLinkInfoTypes.config
* SoArchiveCriteriaList.config

> [!WARNING]
> Any changes to the `archive` configuration will not be observed in the client until the corresponding records in the database are purged.

Once an archive provider is initialized with column definitions in an `archive` element, the column definitions are persisted like preferences in the `SUPERLISTCOLUMNSIZE` table of the database.

To delete rows from the `SUPERLISTCOLUMNSIZE` table, use the `archive` attribute guiname value as the key with the following delete query.

```SQL
-- replace [guiname] with the real archive guiname
DELETE * FROM [CRM7].[DATABASENAME].[SUPERLISTCOLUMNSIZE]
WHERE listOwner = '[guiname]'
```

<!-- Referenced links -->
[1]: 1-add-archive-control.md
[2]: 2-add-archive-row-context-menu.md
[3]: 3-add-row-click-actions.md
[4]: 4-add-archive-action-button.md

<!-- Referenced images -->
[img1]: media/web-archive-control.png
