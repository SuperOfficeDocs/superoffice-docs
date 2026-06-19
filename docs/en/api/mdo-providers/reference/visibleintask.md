---
uid: visibleintask
title: visibleintask
keywords: mdoprovider mdo provider visibleintask
description: Visible in list for tasks - places where task button can appear.
generated: true
content_type: reference
envir: onsite, online
---

# "visibleintask" MDO List
Visible in list for tasks: places where task button can appear.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleInTaskProvider">VisibleInTaskProvider</see> class.
The name of the MDO list is 'visibleintask'.




## Sample Request

```http!
GET /api/v1/MDOList/visibleintask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("visibleintask", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|14|[SR_TASKS_TARGET_SELECTION_CONTACT]|||
|59|[SR_TASKS_TARGET_SELECTION_CONTACT_MAILINGS]|||
|40|[SR_TASKS_TARGET_SELECTION_CONTACT_EXTERNAL]|||
|16|[SR_TASKS_TARGET_SELECTION_SALE_MAIN]|||
|31|[SR_TASKS_TARGET_SELECTION_SALE_SHADOW]|||
|61|[SR_TASKS_TARGET_SELECTION_SALE_MAILINGS]|||
|42|[SR_TASKS_TARGET_SELECTION_SALE_EXTERNAL]|||
|18|[SR_TASKS_TARGET_SELECTION_PROJECT_MAIN]|||
|33|[SR_TASKS_TARGET_SELECTION_PROJECT_SHADOW]|||
|63|[SR_TASKS_TARGET_SELECTION_PROJECT_MAILINGS]|||
|44|[SR_TASKS_TARGET_SELECTION_PROJECT_EXTERNAL]|||
|15|[SR_TASKS_TARGET_SELECTION_APPOINTMENT_MAIN]|||
|30|[SR_TASKS_TARGET_SELECTION_APPOINTMENT_SHADOW]|||
|60|[SR_TASKS_TARGET_SELECTION_APPOINTMENT_MAILINGS]|||
|41|[SR_TASKS_TARGET_SELECTION_APPOINTMENT_EXTERNAL]|||
|17|[SR_TASKS_TARGET_SELECTION_DOCUMENT_MAIN]|||
|32|[SR_TASKS_TARGET_SELECTION_DOCUMENT_SHADOW]|||
|62|[SR_TASKS_TARGET_SELECTION_DOCUMENT_MAILINGS]|||
|43|[SR_TASKS_TARGET_SELECTION_DOCUMENT_EXTERNAL]|||
|53|[SR_TASKS_TARGET_SELECTION_QUOTELINE_MAIN]|||
|54|[SR_TASKS_TARGET_SELECTION_QUOTELINE_SHADOW]|||


## Related MDO Lists

* "visibleintaskheadings"
* "visibleintaskheadingswithallitem"
* "visibleintaskheadingswithallitemwithnoselection"
* "visibleintaskheadingswithnoselection"
* "visibleintaskwithallitem"
* "visibleintaskwithallitemwithnoselection"
* "visibleintaskwithnoselection"
