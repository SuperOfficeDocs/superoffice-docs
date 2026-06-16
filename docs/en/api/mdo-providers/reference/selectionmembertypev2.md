---
uid: selectionmembertypev2
title: selectionmembertypev2
keywords: mdoprovider mdo provider selectionmembertypev2
description: MDO provider for the selection archive providers types. The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern; [TableName]Selection. If the prefix is a known table, the tablename will be added to list with the TableNumber as the ID.
generated: true
content_type: reference
envir: onsite, online
---

# "selectionmembertypev2" MDO List
MDO provider for the selection archive providers types.
The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern;
[TableName]Selection. If the prefix is a known table, the tablename will be added to list with the
TableNumber as the ID.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionMemberTypeListV2">SelectionMemberTypeListV2</see> class.
The name of the MDO list is 'selectionmembertypev2'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionmembertypev2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selectionmembertypev2", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|[SR_FIND_COMPANY]||contact|
|6|[SR_FIND_PERSON]||person|
|9|[SR_FIND_APPOINTMENT]||appointment|
|13|[SR_FIND_SALE]||sale|
|11|[SR_FIND_PROJECT]||project|
|23|[SR_FIND_SELECTION]||selection|
|10|[SR_FIND_DOCUMENT]||document|
|127|[SR_FIND_QUOTELINE]||QuoteLine|
|262|[SR_FIND_TICKET]||ticket|
|332|[SR_FIND_CHAT_CONVERSATION]||chat_session|
|485|[SR_FIND_FORM_SUBMISSION]||form_submission|
|334|[SR_FIND_MAILING]||s_shipment|


## Related MDO Lists

* "selectionmembertypev2headings"
* "selectionmembertypev2headingswithallitem"
* "selectionmembertypev2headingswithallitemwithnoselection"
* "selectionmembertypev2headingswithnoselection"
* "selectionmembertypev2withallitem"
* "selectionmembertypev2withallitemwithnoselection"
* "selectionmembertypev2withnoselection"
