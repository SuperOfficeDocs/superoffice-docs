---
uid: crmscript_ref_HtmlElement_setFieldValue_String_name_Map_map
title: HtmlElement.setFieldValue(String name, Map map)
intellisense: HtmlElement.setFieldValue
sortOrder: 391
keywords: setFieldValue(String,Map)
so.topic: reference
---

# Void setFieldValue(String name, Map map)

Sets 1 or more field values on an element.

```crmscript
HtmlElement formPage;

Map m;
m.insert("name", "superButton");
m.insert("label", "Click me!");
m.insert("style", "StyleGreen");

formPage.setFieldValue("addButton", m);
```

## Parameters

* String: the name of the field
* Map of values
