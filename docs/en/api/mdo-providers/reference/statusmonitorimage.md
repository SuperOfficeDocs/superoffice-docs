---
uid: statusmonitorimage
title: statusmonitorimage
keywords: mdoprovider mdo provider statusmonitorimage
description: List of images for status monitors in the blob table.
generated: true
content_type: reference
envir: onsite, online
---

# "statusmonitorimage" MDO List
List of images for status monitors in the blob table.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.StatusMonitorImageProvider">StatusMonitorImageProvider</see> class.
The name of the MDO list is 'statusmonitorimage'.




## Sample Request

```http!
GET /api/v1/MDOList/statusmonitorimage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("statusmonitorimage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|306|clementin.bmp|||
|445|elefant.jpg|||
|307|unhappydemon.jpg|||


## Related MDO Lists

* "statusmonitorimageheadings"
* "statusmonitorimageheadingswithallitem"
* "statusmonitorimageheadingswithallitemwithnoselection"
* "statusmonitorimageheadingswithnoselection"
* "statusmonitorimagewithallitem"
* "statusmonitorimagewithallitemwithnoselection"
* "statusmonitorimagewithnoselection"
