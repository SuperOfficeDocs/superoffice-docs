---
uid: selectioncriteriamembertype
title: selectioncriteriamembertype
keywords: mdoprovider mdo provider selectioncriteriamembertype
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "selectioncriteriamembertype" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionCriteriaMemberType">SelectionCriteriaMemberType</see> class.
The name of the MDO list is 'selectioncriteriamembertype'.




## Sample Request

```http!
GET /api/v1/MDOList/selectioncriteriamembertype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selectioncriteriamembertype", forceFlatList: true);
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
|23|[FTS_TYPE_SELECTION]||selection|
|10|[SR_COMMON_DOCUMENT]||document|
|127|[SR_SINGULAR_PRODUCT]||QuoteLine|
|262|[SR_SINGULAR_TICKET]||ticket|
|332|[SR_SINGULAR_CHAT_CONVERSATION]||chat_session|
|485|[SR_SINGULAR_FORMSUBMISSION]||form_submission|
|334|[SR_SINGULAR_MAILING]||s_shipment|


## Related MDO Lists

* "selectioncriteriamembertypeheadings"
* "selectioncriteriamembertypeheadingswithallitem"
* "selectioncriteriamembertypeheadingswithallitemwithnoselection"
* "selectioncriteriamembertypeheadingswithnoselection"
* "selectioncriteriamembertypewithallitem"
* "selectioncriteriamembertypewithallitemwithnoselection"
* "selectioncriteriamembertypewithnoselection"
