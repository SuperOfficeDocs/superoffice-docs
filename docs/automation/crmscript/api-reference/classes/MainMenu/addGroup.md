---
uid: crmscript_ref_MainMenu_addGroup_String_label_String_image
title: MainMenu.addGroup(String label, String image)
intellisense: MainMenu.addGroup
sortOrder: 510
keywords: addGroup(String,String), addGroup(String,String,Integer), addGroup(String, String, Integer, String)
so.topic: reference
---

# Void addGroup(String label, String image)

Adds a group to the main menu (navigator)with the given label and image. By default, it appends the item to the bottom of the main menu.

> [!NOTE]
> The image is specified by the URL to the actual file.

You can optionally specify the exact position. This will shift the index of all subsequent groups. Thus, you should not make assumptions about which slot a group is in.

In addition, you can specify on-click JavaScript code. Use this to create clickable menu groups.

## Methods

* MainMenu.addGroup(String label, String image)
* MainMenu.addGroup(String label, String image, Integer position)
* MainMenu.addGroup(String label, String image, Integer position, String onClick)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| label | String | The label of the group |
| image | String | URL to the actual file |
| position | Integer | Optional. The position inside the menu of this group |
| onClick | String | Optional. JavaScript that is executed when clicking the group |

## Examples

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png");
```

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png, 3");
```

Add the following javascript code: `"window.location='http://www.superoffice.com'"`
