---
uid: documentcompleted
title: documentcompleted
keywords: mdoprovider mdo provider documentcompleted
description: Document completed status list - Not done, Done.
generated: true
content_type: reference
envir: onsite, online
---

# "documentcompleted" MDO List
Document completed status list: Not done, Done.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentCompletedProvider">DocumentCompletedProvider</see> class.
The name of the MDO list is 'documentcompleted'.




## Sample Request

```http!
GET /api/v1/MDOList/documentcompleted
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documentcompleted", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Not done|||
|1|Completed|||


## Related MDO Lists

* "documentcompletedheadings"
* "documentcompletedheadingswithallitem"
* "documentcompletedheadingswithallitemwithnoselection"
* "documentcompletedheadingswithnoselection"
* "documentcompletedwithallitem"
* "documentcompletedwithallitemwithnoselection"
* "documentcompletedwithnoselection"
