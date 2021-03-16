---
title: blogic_tree_explorer
description: Tree explorer
author:
so.date:
keywords:
so.topic: reference
---

# Tree explorer

This element lists information in a tree view. You can expand and collapse the tree.

## Configuration

| Setting | Description |
|:--------|:------------|
| label   | UI label    |

Use `setFieldValue()` for all other config.

## Example

```crmscript
HtmlElement folder;
Map m;

m.insert("id", "1");
m.insert("onclick", "alert('test');");
m.insert("href", "https://community.superoffice.com/en/");
m.insert("name", "Community");
m.insert("tooltip", "Super tooltip");
m.insert("target", "_blank");
m.insert("order", "desc");
m.insert("leaf", "true");
m.insert("icon", "false");

Map link;
link.insert("href", "https://www.superoffice.com//");
link.insert("target", "_blank");
link.insert("tooltip", "SuperOffice");

folder.setFieldValue("addEntry", m);
folder.setFieldValue("addLink", link);

m.clear();

m.insert("id", "2");
m.insert("href", "https://community.superoffice.com/en/customer/");
m.insert("name", "Customer");
m.insert("target", "_blank");
m.insert("leaf", "true");
m.insert("parent.id", "1");

folder.setFieldValue("addEntry", m);

// settings
m.clear();
m.insert("sortbyName", "true");
m.insert("expandId", "1");
m.insert("pruneEmptyFolders", "true");
folder.setFieldValue("set", m);
```

## Functions

### setFieldValue(String action, Map values)

| Action    | Map keys                                                                    | Description                             |
|:----------|:----------------------------------------------------------------------------|:----------------------------------------|
| add2Entry | id<br>parent.id<br>onclick<br>href<br>name<br>tooltip<br>target<br>order<br>leaf<br>icon<br>icon.contentType<br>icon.filename | Adds an entry to the tree |
| addLink   | href<br>target<br>tooltip<br>icon<br>icon.contentType<br>icon.filename | Adds a new link to the last added entry |
| set       | sortbyName<br>expandId<br>pruneEmptyFolders                               | Sets various fields                     |
