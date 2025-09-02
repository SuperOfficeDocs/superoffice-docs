---
uid: consentsource
title: consentsource
keywords: mdoprovider mdo provider consentsource
description: MDO list provider for Consent source
generated: true
content_type: reference
envir: onsite, online
---

# "consentsource" MDO List
MDO list provider for Consent source



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ConsentSourceListProvider">ConsentSourceListProvider</see> class.
The name of the MDO list is 'consentsource'.




## Sample Request

```http!
GET /api/v1/MDOList/consentsource
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("consentsource", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Created by user||0|
|2|E-mail||0|
|3|Incoming request||0|
|4|Chat||0|
|5|Web form||0|
|6|Customer portal||0|
|7|Import||0|
|8|Other integration||0|
|9|Unknown||0|


## Related MDO Lists

* "consentsourceheadings"
* "consentsourceheadingswithallitem"
* "consentsourceheadingswithallitemwithnoselection"
* "consentsourceheadingswithnoselection"
* "consentsourcewithallitem"
* "consentsourcewithallitemwithnoselection"
* "consentsourcewithnoselection"
