---
title: Edit entity menu
uid: blogic_edit_entity_menu
description: Edit entity menu
author:
so.date:
keywords:
so.topic: reference
---

# Edit entity menu

This element adds an entity menu to a screen. Entity menus contain items that allow you to edit an entity, create a new entity, merge the entity with others.

## Configuration

| Setting    | Description |
|:-----------|:------------|
| label      | UI label    |
| entity     | Entity      |
| entityMenu | Entity      |
| width      | Width       |

**Entities:**

* customer / person
* company / contact
* ticket

These must contain corresponding values for the default configuration of the menu to be added to a screen.

### Example

```crmscript
entity = customer
entityMenu = customer
```

## Functions

### setFieldValue(String action, Map values)

You can add to the default configuration or create an entirely new menu by setting field values.

To create a new menu, exclude the simple values from the configuration.

| Action         | Map keys                                                       | Description           |
|:---------------|:---------------------------------------------------------------|:----------------------|
| addMenu        | label<br>iconUrl<br>url<br>target<be/>appendId (true/false)                      |  |
| addAnchor      | label<br>iconUrl<br>url<br>target<br>appendId (true/false)                      |  |
| addModificator | label<br>field<br>width<br>options.length<br>options.n.name<br>options.n.value |  |

> [!NOTE]
> `appendId` (v.8.4R07) will append the ID of the current entity to the URL for the anchor or menu.

## Example maps

```crmscript
Map m;
m.insert("label", "VG");
m.insert("iconUrl", "");
m.insert("url", "http://www.vg.no");
m.insert("target", "");

Map m3;
m3.insert("options.length", "2");
m3.insert("label", "Modificator");
m3.insert("field", "2");
m3.insert("options.0.name", "Option1");
m3.insert("options.0.value", "");
m3.insert("options.1.name", "Option2");
m3.insert("options.1.value", "");
```
