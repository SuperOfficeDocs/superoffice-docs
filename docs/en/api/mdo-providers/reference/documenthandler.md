---
uid: documenthandler
title: documenthandler
keywords: mdoprovider mdo provider documenthandler
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "documenthandler" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentHandlerProvider">DocumentHandlerProvider</see> class.
The name of the MDO list is 'documenthandler'.




## Sample Request

```http!
GET /api/v1/MDOList/documenthandler
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documenthandler", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Use SuperOffice WebTools|||
|1|Manually uploading and downloading files|||


## Related MDO Lists

* "documenthandlerheadings"
* "documenthandlerheadingswithallitem"
* "documenthandlerheadingswithallitemwithnoselection"
* "documenthandlerheadingswithnoselection"
* "documenthandlerwithallitem"
* "documenthandlerwithallitemwithnoselection"
* "documenthandlerwithnoselection"
