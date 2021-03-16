---
title: MainMenu
path: /EJScript/Classes/MainMenu
intellisense: 1
classref: 1
sortOrder: 502
description: MainMenu
author:
so.date:
keywords:
so.topic:
---

# MainMenu

The CRMScript **MainMenu** class is used to control the main (left-side) menu of SuperOffice CRM.
Customizing the main menu means modifying the corresponding **trigger**.

## How the main menu is organized

Each block in the main menu, hereafter called a **group**, has a label and an image.

Each group contains 1 or more **items**, which have their own label and a URL. The URL determines which content is shown when someone clicks the button. Without the URL, the main menu would be nothing but a 2-level list of labels (and icons).

### Position

The groups are listed top to bottom based on a **zero-based index**. Items within a group have their own index, starting at 0.

## Create a main menu trigger script

If you see a script with MainMenu in its name, you can either **open** that for further customization, or **create a new** trigger script.

1. Sign in to the SuperOffice Admin client.
2. Open the **CRMScript** page and select the **Triggers** tab.
3. Click **New trigger(script)**.
4. Type `main` in the search field and then select the **Main menu** trigger.
5. Enter your script code and save.
6. Refresh your browser to make sure the new menu is loaded.

> [!NOTE]
> Objects of type `MainMenu` are useful only when returned by `getMainMenu()`.

## Groups

Groups are the level-1 entries of the menu.

* Integer [getNumGroups()][1]
* Integer [getGroupIndex(String)][2]
* String [getGroupId(Integer group)][3]
* Void [addGroup(String label, String image)][4]
* Void [addGroup(String label, String image, Integer position)][5]
* Void [addGroup(String label, String image, Integer position, String onClick)][6]
* Void [deleteGroup(Integer position)][7]

### Group parameters

| Parameter | Description                           |
|:----------|:--------------------------------------|
| label     | UI label (ID)                         |
| image     | Location (URL)                        |
| position  | Within the main menu                  |
| onClick   | JavaScript run when clicking the item |

## Items

Items are the level-2 entries of the menu.

* Integer [getNumItems(Integer group)][8]
* Integer [getItemIndex(Integer group, String label)][9]
* String [getItemId(Integer group, Integer pos)][10]
* Void [addItem(String label, String url)][11]
* Void [addItem(String label, String url, Integer group, Integer position)][12]
* Void [addItem(String label, String url, Integer group, Integer position, String onClick, String itemId, String target)][13]
* Void [addItem(String label, String url, Integer group, Integer position, String onClick, String itemId, String target, String iconUrl)][14]
* Void [deleteItem(Integer group, Integer index)][15]

### Item parameters

| Parameter | Description                           |
|:----------|:--------------------------------------|
| label     | UI label (ID) the menu item           |
| url       | Action                                |
| group     | The group this item belongs to        |
| position  | Within the group                      |
| onClick   | JavaScript run when clicking the item |
| itemId    | A programmatic ID                     |
| target    | The target attribute of the link      |
| iconUrl   | Location of a custom icon             |

## Void clear()

Empties the main menu. Useful if you want to build your menu from scratch.

<!-- Referenced links -->
[1]: getnumgroups.md
[2]: getgroupindex.md
[3]: getgroupid.md
[4]: addgroup.md
[5]: addgroup-5477.md
[6]: addgroup-4176.md
[7]: deletegroup.md
[8]: getnumitems.md
[9]: getitemindex.md
[10]: getitemid.md
[11]: additem.md
[12]: additem-6558.md
[13]: additem-10733.md
[14]: additem-12204.md
[15]: deleteitem.md
