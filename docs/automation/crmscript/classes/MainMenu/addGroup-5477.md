---
title: Void addGroup(String label, String image, Integer position)
path: /EJScript/Classes/MainMenu/Member functions/Void addGroup(String label, String image, Integer position)
intellisense: 1
classref: 1
sortOrder: 511
keywords: addGroup(String,String,Integer)
---

# Void addGroup(String label, String image, Integer position)

A variant of `addGroup()` that lets you specify the exact position.

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png, 3");
```

> [!NOTE]
> This will shift the index of all subsequent groups. Thus, you should not make assumptions about which slot a group is in.
