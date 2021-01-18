---
title: blogic_form_page
description: Form page
author:
so.date:
keywords:
so.topic: reference
---

# Form page

This element is a standard root frame used in a lot of screens.

## Configuration

| Setting | Description                    |
|:--------|:-------------------------------|
| label   | User-friendly name of the form |
| iconUrl | Custom icon to use             |

## Functions

### setFieldValue(String action, Map values)

| Action    | Map keys               | Description                             |
|:----------|:-----------------------|:----------------------------------------|
| addButton | name<br>label<br>style<br>warning | Adds a button to the form |

#### Styles

* StyleNormal
* StyleSmall
* StyleIconOnly
* StyleBlue
* StyleLargeBlue
* StyleGreen
* StyleLargeGreen
* StyleRed

## Example

```crmscript
Map m;
m.insert("name", "testButton");
m.insert("label", "Button");
m.insert("style", "StyleGreen");
m.insert("warning", "Are you sure?");

fp.setFieldValue("addButton", m);
```
