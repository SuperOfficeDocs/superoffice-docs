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
|5|Company||contact|
|6|Contact||person|
|9|Follow-up||appointment|
|13|Sale||sale|
|11|Project||project|
|10|Document||document|
|127|Product||QuoteLine|
|262|Request||ticket|
|332|Chat conversation||chat_session|
|485|Form submission||form_submission|
|334|Mailing||s_shipment|


## Related MDO Lists

* "dashboardentityheadings"
* "dashboardentityheadingswithallitem"
* "dashboardentityheadingswithallitemwithnoselection"
* "dashboardentityheadingswithnoselection"
* "dashboardentitywithallitem"
* "dashboardentitywithallitemwithnoselection"
* "dashboardentitywithnoselection"
