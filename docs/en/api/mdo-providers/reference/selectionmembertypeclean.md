---
uid: selectionmembertypeclean
title: selectionmembertypeclean
keywords: mdoprovider mdo provider selectionmembertypeclean
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "selectionmembertypeclean" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionMemberTypeClean">SelectionMemberTypeClean</see> class.
The name of the MDO list is 'selectionmembertypeclean'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionmembertypeclean
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selectionmembertypeclean", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|[SR_COMPANY_AND_PERSON]||contact|
|6|[SR_COMPANY_AND_PERSON]||person|
|9|[SR_SELECTION_FOLLOWUPS]||appointment|
|13|[SR_BULKUPDATE_PLURAL_SALES]||sale|
|11|[SR_BULKUPDATE_PLURAL_PROJECTS]||project|
|23|[SR_BULKUPDATE_PLURAL_SELECTIONS]||selection|
|10|[SR_BULKUPDATE_PLURAL_DOCUMENTS]||document|
|127|[SR_BULKUPDATE_PLURAL_PRODUCTS]||QuoteLine|
|262|[SR_PLURAL_TICKETS]||ticket|
|332|[SR_PL_CHAT_CONVERSATION]||chat_session|
|485|[SR_PL_FORM_SUBMISSION]||form_submission|
|334|[SR_PL_MAILINGS]||s_shipment|


## Related MDO Lists

* "selectionmembertypecleanheadings"
* "selectionmembertypecleanheadingswithallitem"
* "selectionmembertypecleanheadingswithallitemwithnoselection"
* "selectionmembertypecleanheadingswithnoselection"
* "selectionmembertypecleanwithallitem"
* "selectionmembertypecleanwithallitemwithnoselection"
* "selectionmembertypecleanwithnoselection"
