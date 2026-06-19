---
uid: taskmenudestination
title: taskmenudestination
keywords: mdoprovider mdo provider taskmenudestination
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "taskmenudestination" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TaskMenuDestinationProvider">TaskMenuDestinationProvider</see> class.
The name of the MDO list is 'taskmenudestination'.




## Sample Request

```http!
GET /api/v1/MDOList/taskmenudestination
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("taskmenudestination", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_CONTACT]||contact|
|2|[SR_PERSON]||person|
|3|[SR_SINGULAR_SALE]||sale|
|4|[SR_PROJECT]||project|
|5|[SR_SINGULAR_ACTIVITY]||appointment|
|6|[SR_COMMON_DOCUMENT]||document|
|7|[SR_QUOTE_SINGULAR_QUOTE]||Quote|
|8|[SR_SINGULAR_TICKET]||ticket|
|9|[SR_FORMS_FIELD_TICKETMESSAGE]||ej_message|


## Related MDO Lists

* "taskmenudestinationheadings"
* "taskmenudestinationheadingswithallitem"
* "taskmenudestinationheadingswithallitemwithnoselection"
* "taskmenudestinationheadingswithnoselection"
* "taskmenudestinationwithallitem"
* "taskmenudestinationwithallitemwithnoselection"
* "taskmenudestinationwithnoselection"
