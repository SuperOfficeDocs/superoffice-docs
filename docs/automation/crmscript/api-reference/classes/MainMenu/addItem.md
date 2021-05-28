---
uid: crmscript_class_mainmenu_additem
title: MainMenu.addItem()
description: CRMScript method in class MainMenu that adds an item to the SuperOffice main menu (navigator)
intellisense: MainMenu.addItem
sortOrder: 513
keywords: addItem(String,String), addItem(String,String,Integer,Integer), addItem(String,String,Integer,Integer,String,String,String), addItem(String,String,Integer,Integer,String,String,String,String)
so.topic: reference
---

# Void addItem()

Adds an item to the main menu (navigator). By default, it appends an item to the last (bottom) group of the main menu.

> [!NOTE]
> The image is specified by the URL to the actual file.

You can optionally specify the exact position. This will shift the index of all subsequent items (if any). Thus, you should not make assumptions about which slot an item is in.

In addition, you can specify JavaScript to run when the item is clicked and set a custom icon.

## Methods

* MainMenu.addItem(String label, String url)
* MainMenu.addItem(String label, String url, Integer group, Integer position)
* MainMenu.addItem(String label, String url, Integer group, Integer position, String onClick, String itemId, String target)
* MainMenu.addItem(String label, String url, Integer group, Integer position, String onClick, String itemId, String target, String iconUrl)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| label | String | The label of the menu item |
| url | String | |
| group | Integer | Optional. Which header this item belongs to |
| position | Integer | Optional. The position inside the group of this item |
| onClick | String | Optional. JavaScript that is executed when clicking the item |
| itemId | String | Optional. A programmatic ID for the item |
| target | String | Optional. The target attribute of the link |
| iconUrl | String | Optional. URL of a custom icon |

## Examples

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("List equipment", getProgram(1) + "&action=listExtraTable&extraTable=y_equipment");
```

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("New unit", getProgram(1) + "&action=editExtraTableEntry&extraTable=y_equipment", 1, 1);
```
