---
uid: relateddatafields
title: relateddatafields
keywords: mdoprovider mdo provider relateddatafields
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "relateddatafields" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelatedDataFieldsProvider">RelatedDataFieldsProvider</see> class.
The name of the MDO list is 'relateddatafields'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|The name of the table to analyze for related fields| table|ticket|
|The recursion depth, default=1| depth||





## Sample Request

```http!
GET /api/v1/MDOList/relateddatafields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("relateddatafields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |

