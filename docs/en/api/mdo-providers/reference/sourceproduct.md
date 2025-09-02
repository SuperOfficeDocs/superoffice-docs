---
uid: sourceproduct
title: sourceproduct
keywords: mdoprovider mdo provider sourceproduct
description: Products - Sales &amp; Marketing, Customer Service
generated: true
content_type: reference
envir: onsite, online
---

# "sourceproduct" MDO List
Products: Sales &amp; Marketing, Customer Service



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SourceListProvider">SourceListProvider</see> class.
The name of the MDO list is 'sourceproduct'.




## Sample Request

```http!
GET /api/v1/MDOList/sourceproduct
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("sourceproduct", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Sales & Marketing|||
|1|Customer Service|||


## Related MDO Lists

* "sourceproductheadings"
* "sourceproductheadingswithallitem"
* "sourceproductheadingswithallitemwithnoselection"
* "sourceproductheadingswithnoselection"
* "sourceproductwithallitem"
* "sourceproductwithallitemwithnoselection"
* "sourceproductwithnoselection"
