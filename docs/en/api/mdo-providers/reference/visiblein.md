---
uid: visiblein
title: visiblein
keywords: mdoprovider mdo provider visiblein
description: Visible in list for web panels.
generated: true
content_type: reference
envir: onsite, online
---

# "visiblein" MDO List
Visible in list for web panels.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleInProvider">VisibleInProvider</see> class.
The name of the MDO list is 'visiblein'.




## Sample Request

```http!
GET /api/v1/MDOList/visiblein
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("visiblein", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|19|[SR_ADMIN_LIST_MINICARD]|||
|23|[SR_ADMIN_LIST_WWW_TOOLBAR]|||
|2|[SR_ADMIN_LIST_SHOW_NAVBUTTON]|||
|5|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_CONTACTCARD]|||
|10|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_PERSONCARD]|||
|7|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_PROJECTCARD]|||
|9|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_SALEDIALOG]|||
|46|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_SELECTIONCARD]|||
|13|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_BROWSERPANEL]|||
|6|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_CONTACTARCHIVE]|||
|67|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_PERSONARCHIVE]|||
|8|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_PROJECTARCHIVE]|||
|29|[SR_PANEL] - [SR_ADMIN_LIST_SHOW_SALEARCHIVE]|||
|11|[SR_DIALOG] - [SR_ADMIN_LIST_SHOW_ACTIVITYDIALOG]|||
|12|[SR_DIALOG] - [SR_ADMIN_LIST_SHOW_DOCUMENTDIALOG]|||
|48|[SR_DIALOG] - [SR_TASKS_TARGET_QUOTEDIALOG]|||
|52|[SR_DIALOG] - [SR_TASKS_TARGET_QUOTELINEDIALOG]|||
|1|[SR_MENU] - [SR_ADMIN_LIST_SHOW_TOOLBOX]|||
|3|[SR_MENU] - [SR_ADMIN_LIST_SHOW_MENU]|||


## Related MDO Lists

* "visibleinheadings"
* "visibleinheadingswithallitem"
* "visibleinheadingswithallitemwithnoselection"
* "visibleinheadingswithnoselection"
* "visibleinwithallitem"
* "visibleinwithallitemwithnoselection"
* "visibleinwithnoselection"
