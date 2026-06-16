---
uid: dashboardentity
title: dashboardentity
keywords: mdoprovider mdo provider dashboardentity
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "dashboardentity" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashboardEntityList">DashboardEntityList</see> class.
The name of the MDO list is 'dashboardentity'.




## Sample Request

```http!
GET /api/v1/MDOList/dashboardentity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashboardentity", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|[SR_COMMON_CONTACT]||contact|
|6|[SR_COMMON_PERSON]||person|
|9|[FTS_TYPE_APPNT]||appointment|
|13|[SR_COMMON_SALE]||sale|
|11|[SR_COMMON_PROJECT]||project|
|10|[SR_COMMON_DOCUMENT]||document|
|127|[SR_SINGULAR_PRODUCT]||QuoteLine|
|262|[SR_SINGULAR_TICKET]||ticket|
|332|[SR_SINGULAR_CHAT_CONVERSATION]||chat_session|
|485|[SR_SINGULAR_FORMSUBMISSION]||form_submission|
|334|[SR_SINGULAR_MAILING]||s_shipment|


## Related MDO Lists

* "dashboardentityheadings"
* "dashboardentityheadingswithallitem"
* "dashboardentityheadingswithallitemwithnoselection"
* "dashboardentityheadingswithnoselection"
* "dashboardentitywithallitem"
* "dashboardentitywithallitemwithnoselection"
* "dashboardentitywithnoselection"
