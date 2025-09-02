---
uid: attachment
title: attachment
keywords: mdoprovider mdo provider attachment
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "attachment" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.AttachmentListProvider">AttachmentListProvider</see> class.
The name of the MDO list is 'attachment'.




## Sample Request

```http!
GET /api/v1/MDOList/attachment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("attachment", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|compactMode|||
|12|Macro foundations|||
|13|Split request screens|||
|14|System screens|||
|15|CompanyDetails.ejr|||
|16|CompanyList.ejr|||
|17|ContactsList.ejr|||
|18|TicketList.ejr|||
|19|TicketWeekDaysGraph.ejr|||
|20|DuplicateCompanyDomain.ejr|||
|21|DuplicateCompanyName.ejr|||
|22|DuplicateCustomerEmail.ejr|||
|23|DuplicateCustomerName.ejr|||
|24|ShipmentDetails.ejr|||
|25|TestAttachment.txt|||
|26|SZ Extra|||
|27|SZ Extra|||
|28|SZ Extra|||
|29|SZ Extra|||


## Related MDO Lists

* "attachmentheadings"
* "attachmentheadingswithallitem"
* "attachmentheadingswithallitemwithnoselection"
* "attachmentheadingswithnoselection"
* "attachmentwithallitem"
* "attachmentwithallitemwithnoselection"
* "attachmentwithnoselection"
