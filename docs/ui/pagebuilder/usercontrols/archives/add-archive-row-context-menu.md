---
title: add_archive_row_context_menu
description: Add Archive row context menu
author: Tony Yates
so.date: 04.16.2018
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to add an Archive row context menu

![web-archive-control-row-context-menu][img1]

An archive row is a combined set of fields from one or more tables that represent a known entity. Whether it is a document, sale, or person, a row is a single line in an archive control that represents that entity.

The context menu shown when a user right-clicks a row is defined as a `menu` element in the *SoMenuConfiguration.config* file. A context menu element must contain the `context` attribute value *"archivelist"*.

The `subcontext` attribute is the name of an entity provided by the archive provider.

For example, the `DiaryActivity` archive provider supplies the `document`, `appointment` and `todo` entities, while the Person archive provider supplies the `person` and `retiredPerson` entities.

With this format, regardless of what archive provider an archive control uses, each row entity will have the same menu item.

``` xml
<!-- 
context = "archivelist" to mark this menu as an archivecontrol rows context menu 

subcontext = "entityname" of the entity defined in the archive provider
-->
<menu context="archivelist" subcontext="person" id="0" position="belowcursor" group="archive" displayaccesskeys="false">
  <menuitems>
    <menuitem id="arelnew" type="normal">
      <caption>[SR_MENU_LIST_NEW]</caption>
        <url>javascript:Dialog.open('Person','person[dialog=stop].main[new=true]?current_id=0','ContactPersonArchiveArchiveControl.RefreshList();');</url>
      <icon></icon>
      <sentry-rights>
        <sentry-right tableright="HasInsert" type="disable">relation</sentry-right>
      </sentry-rights>
    </menuitem>
    <!— Remaining default context menu items removed for brevity-->
  </menuitems>
</menu>
```

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/web-archive-control-row-context-menu.png
