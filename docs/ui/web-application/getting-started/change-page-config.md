---
title: change_page_config
description: How to alter page configuration files
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.envir: onsite
so.client: web
---

# How to alter page configuration files

While element placement might not be important for system configuration files, modifying elements in a page or dialog must be structured accordingly. A page contains cards, and cards contain views, and views contain controlgroups, and so on, and knowing how to structure a merge definition is critical to successfully deploying a change.

## Adding a new page

When making a new page, you can [split the configuration into several fragments][1] for reuse and readability.

You can place the files in any folder as long as it is placed in the [custom path folder][2]. The only requirement is to use the correct naming convention. This allows you to group your configuration fragments as you wish.

Example contact page defined in ApplicationConfiguration:

```xml
<page id="contact" type="mainpage" function-right="hide-company" />
```

The file name must then be: So**Contact**Page.config. The postfix "page" must be the same as the root element name. The name a fragment of a controlgroup would look like this *SoMyCGFragControlGroup.config*.

## Customize an existing page

When customizing an existing page you have to change or add sections of the configuration. It is important to ease the trouble of upgrading and other partners operating on the same pages. You can accomplish this by making use of merge files.

You can remove, replace, and add sections of configuration XML with [merge files][3]. The merge is ID-based making it durable between minor version upgrades and even major upgrades if the page only has small changes. It uses ID attribute to pinpoint location of merge.

> [!NOTE]
> Fragments and references cannot be used in the merge files since the merge filter is executed after the fragment resolving.

<!-- Referenced links -->
[1]: ../pagebuilder/config/soml.md
[2]: set-up-custom-folder.md
[3]: ../pagebuilder/config/merge-files-and-actions.md

<!-- Referenced images -->
