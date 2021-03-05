---
title: add_row_click_actions
description: How to add row click actions
author: Steffan Alte
so.date: 2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# How to add row click actions

This article discusses how to add an action when a user single or double clicks an archive row.

![Archive row click action][img1]

All archive row click actions are defined in the *SoArchiveControlLinkInfoTypes.config* file. Similar to context-menus, click events are entity-specific.

First, let's review. What is an archive row? An archive row is a combined set of fields from one or more tables that represent a known entity. Whether it is a document, sale, or person, a row is a single line in an archive control that represents that entity.

Different rows clicked, potentially different entities, cause different reactions by the application. For example, when an appointment entity row is double-clicked, the appointment dialog is shown. When a person entity row is double-clicked, the person dialog is shown.

When a new entity is introduced via a custom archive provider, or a custom behavior is desired, changes must be made to the *SoArchiveControlLinkInfoTypes.config* file.

Each `linkinfo` element in the code below handles the click events for the person entity.

* **type:** corresponds to the entity
* **subtype:** corresponds to the click type
* **baseurl:** defines the Javascript method for the corresponding click event

```xml
<linkinfos>
  <linkinfo type="person" subtype="click">
    <baseurl>javascript:PageUpdate('soprotocol:?person_id={person_id}','');</baseurl>
    <target></target>
  </linkinfo>
    <linkinfo type="person" subtype="dblclick">
    <baseurl>javascript:Dialog.open('Person','person[dialog=stop].main?person_id={person_id}','RefreshContactAndPersonCurrent()');</baseurl>
    <target></target>
  </linkinfo>
```

## Link hint prefix

It's common for integrations to perform different actions for a given entity. In fact, SuperOffice does this in many places.

The way to differentiate actions for the same entity in different SoArchiveControls is to use a `linkhint-prefix`.

A linkhint prefix specifies a name followed by a colon.

``` xml
<control id="ContactPersonArchive" type="SoArchiveControl">
...
  <config>
    <providername>person</providername>
...
    <linkhint-prefix>personarchive:</linkhint-prefix>
...
  </config>
</control>
```

A linkhint prefix is then used in the `linkinfo` element, prefixing the type with the given linkhint-prefix name. Below are just a few real examples where a `linkhint-prefix` is used to create different actions for the same entity type.

[!code-xml[XML](includes/linkinfo.xml)]

## Override linkinfo settings

An SoArchiveControl config setting can override a `double-click` event defined in *SoArchiveControlLinkInfoTypes.config*.

The override must be defined in the `dblclick-action` element in the SoArchiveControl's `config` element.

There is **no** override capability for the single-click event. Single click actions generally only update the current id of the corresponding entity.

``` xml
<control id="ContactPersonArchive" type="SoArchiveControl">
  ...
  <config>
    <providername>person</providername>
   ...
    <dblclick-action>javascript:Dialog.open('Person','person[dialog=stop].main[mode=edit;new=true]?person_id=0','ContactPersonArchiveArchiveControl.RefreshList()');</dblclick-action>
  </config>
</control>
```

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/web-archive-row-click-action.png
