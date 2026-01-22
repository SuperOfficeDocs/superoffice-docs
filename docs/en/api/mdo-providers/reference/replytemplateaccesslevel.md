---
uid: replytemplateaccesslevel
title: replytemplateaccesslevel
keywords: mdoprovider mdo provider replytemplateaccesslevel
description: MDO provider for the ReplyTemplateAccessLevel enum
generated: true
content_type: reference
envir: onsite, online
---

# "replytemplateaccesslevel" MDO List
MDO provider for the ReplyTemplateAccessLevel enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ReplyTemplateAccessLevelProvider">ReplyTemplateAccessLevelProvider</see> class.
The name of the MDO list is 'replytemplateaccesslevel'.




## Sample Request

```http!
GET /api/v1/MDOList/replytemplateaccesslevel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("replytemplateaccesslevel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Everyone can read and edit||Full|
|2|Everyone can read, but only you can edit||Read|
|3|Only you can read or edit||None|


## Related MDO Lists

* "replytemplateaccesslevelheadings"
* "replytemplateaccesslevelheadingswithallitem"
* "replytemplateaccesslevelheadingswithallitemwithnoselection"
* "replytemplateaccesslevelheadingswithnoselection"
* "replytemplateaccesslevelwithallitem"
* "replytemplateaccesslevelwithallitemwithnoselection"
* "replytemplateaccesslevelwithnoselection"
