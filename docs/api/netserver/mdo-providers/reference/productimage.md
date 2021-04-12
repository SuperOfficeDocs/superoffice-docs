---
uid: productimage
title: productimage
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "productimage"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "productimage" MDO List
Return product images from the blob table



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProductImageProvider">ProductImageProvider</see> class.
The name of the MDO list is 'productimage'.




## Sample Request

```http!
GET /api/v1/MDOList/productimage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("productimage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|623|623|||
|624|624|||
|625|625|||
|626|626|||
|627|627|||
|628|628|||
|629|629|||
|630|630|||
|631|631|||
|632|632|||
|633|633|||
|634|634|||
|635|635|||
|636|636|||
|637|637|||
|638|638|||
|639|639|||
|640|640|||
|641|641|||
|642|642|||
|643|643|||


## Related MDO Lists

* "productimageheadings"
* "productimageheadingswithallitem"
* "productimageheadingswithallitemwithnoselection"
* "productimageheadingswithnoselection"
* "productimagewithallitem"
* "productimagewithallitemwithnoselection"
* "productimagewithnoselection"
