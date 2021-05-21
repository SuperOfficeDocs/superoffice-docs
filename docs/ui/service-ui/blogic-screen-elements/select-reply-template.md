---
title: Select reply template
uid: blogic_select_reply_template
description: Select reply template
author:
so.date:
keywords:
so.topic: reference
---

# Select reply template

This element is used to select a reply template or a reply template folder.

## Configuration

| Setting       | Description                             |
|:--------------|:----------------------------------------|
| onlyLeafNodes | Whether only leaf nodes can be selected |

## Functions

### getString()

Returns the ID of the selected node.

> [!NOTE]
> If it is a folder, the ID is prefixed with "folder.".<br>If it is a reply template, the returned string is just the ID.
