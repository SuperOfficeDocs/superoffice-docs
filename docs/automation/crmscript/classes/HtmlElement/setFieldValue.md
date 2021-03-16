---
title: Void setFieldValue(String name, Map map)
path: /EJScript/Classes/HtmlElement/Member functions/Void setFieldValue(String name, Map map)
intellisense: 1
classref: 1
sortOrder: 391
keywords: setFieldValue(String,Map)
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
