---
uid: extapp
title: extapp
keywords: mdoprovider mdo provider extapp
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "extapp" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'extapp'.




## Sample Request

```http!
GET /api/v1/MDOList/extapp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("extapp", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Create External Users|||
|1|Notepad|||
|2|Echo|||


## Related MDO Lists

* "extappheadings"
* "extappheadingswithallitem"
* "extappheadingswithallitemwithnoselection"
* "extappheadingswithnoselection"
* "extappwithallitem"
* "extappwithallitemwithnoselection"
* "extappwithnoselection"
