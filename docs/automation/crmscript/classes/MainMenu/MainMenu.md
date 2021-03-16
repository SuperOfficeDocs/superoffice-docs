---
title: crmscript_main_menu
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

### Integer getNumGroups()

Returns the current number of groups in the main menu.

```crmscript
MainMenu menu = getMainMenu();
Integer nGroups = menu.getNumGroups();
```

### Integer getGroupIndex(String)

Returns the position of a specific group in the main menu given its label (ID)

```crmscript
MainMenu menu = getMainMenu();
Integer pos = menu.getGroupIndex("my MITs");
```

> [!TIP]
> Remember that the index starts at 0.

### String getGroupId(Integer group)

Returns the label (ID) of a group in the main menu given its position.

```crmscript
MainMenu menu = getMainMenu();
String label = menu.getGroupId(4);
```

### Void addGroup(String label, String image)

Appends a group to the end of the main menu.

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png");
```

> [!NOTE]
> The image is specified by the URL to the actual file.

### Void addGroup(String label, String image, Integer position)

A variant of `addGroup()` that lets you specify the exact position.

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png, 3");
```

> [!NOTE]
> This will shift the index of all subsequent groups. Thus, you should not make assumptions about which slot a group is in.

### Void addGroup(String label, String image, Integer position, String onClick)

A variant of `addGroup()` that lets you specify on-click JavaScript code. Use this to create clickable menu-groups.

Add the following javascript code: `"window.location='http://www.superoffice.com'"`

### Void deleteGroup(Integer position)

Removes the group at the given index from the main menu.

> [!TIP]
> Verify that you're removing the correct group by checking with `getGroupId()` what's in that slot first.

```crmscript
Integer pos = 3;
MainMenu menu = getMainMenu();
if (menu.getGroupId(pos) == "my label") {
  menu.deleteGroup(pos);
}
```

## Items

Items are the level-2 entries of the menu.

### Integer getNumItems(Integer group)

Returns the current number of items in the group.

```crmscript
MainMenu menu = getMainMenu();
Integer nItems = menu.getNumItems(2);
```

### Integer getItemIndex(Integer group, String label)

Returns the position of a specific item in the group given its label (ID)

```crmscript
MainMenu menu = getMainMenu();
Integer pos = menu.getItemIndex(2,"secret company");
```

> [!TIP]
> Remember that the index starts at 0.

### String getItemId(Integer group, Integer pos)

Returns the label (ID) of an item in a group given its position.

```crmscript
MainMenu menu = getMainMenu();
String label = menu.getItemId(4,1);
```

### Void addItem(String label, String url)

Appends an item to the last (bottom) group of the main menu.

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("List equipment", getProgram(1) + "&action=listExtraTable&extraTable=y_equipment");
```

> [!NOTE]
> The image is specified by the URL to the actual file.

### Void addItem(String label, String url, Integer group, Integer position)

A variant of `addItem()` that lets you specify the exact position.

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("New unit", getProgram(1) + "&action=editExtraTableEntry&extraTable=y_equipment", 1, 1);
```

> [!NOTE]
> This will shift the index of all subsequent items (if any). Thus, you should not make assumptions about which slot an item is in.

### Void addItem(String label, String url, Integer group, Integer position, String onClick, String itemId, String target)

A variant of `addItem()` that lets you specify JavaScript to run when the item is clicked.

### Void addItem(String label, String url, Integer group, Integer position, String onClick, String itemId, String target, String iconUrl)

A variant of `addItem()` that additionally lets you set a custom icon.

### Void deleteItem(Integer group, Integer index)

Removes the item at the given index from the group.

## Void clear()

Empties the main menu. Useful if you want to build your menu from scratch.

## Reference

### Group parameters

| Parameter | Description                           |
|:----------|:--------------------------------------|
| label     | UI label (ID)                         |
| image     | Location (URL)                        |
| position  | Within the main menu                  |
| onClick   | JavaScript run when clicking the item |

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
