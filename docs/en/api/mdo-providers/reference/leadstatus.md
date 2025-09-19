---
uid: leadstatus
title: leadstatus
keywords: mdoprovider mdo provider leadstatus
description: List provider for LeadStatus
generated: true
content_type: reference
envir: onsite, online
---

# "leadstatus" MDO List
List provider for LeadStatus



Implemented by the <see cref="T:SuperOffice.CRM.Lists.LeadStatusListProvider">LeadStatusListProvider</see> class.
The name of the MDO list is 'leadstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/leadstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("leadstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Open|||
|2|Contacting|||
|3|Disqualified|||
|4|Re-nurture|||
|5|Qualified|||


## Related MDO Lists

* "leadstatusheadings"
* "leadstatusheadingswithallitem"
* "leadstatusheadingswithallitemwithnoselection"
* "leadstatusheadingswithnoselection"
* "leadstatuswithallitem"
* "leadstatuswithallitemwithnoselection"
* "leadstatuswithnoselection"
