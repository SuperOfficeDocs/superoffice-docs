---
uid: mergedocument
title: mergedocument
keywords: mdoprovider mdo provider mergedocument
description: MDO list provider for documents marked as type <see cref="F:SuperOffice.Data.TaskType.MailMergeDraft" />.
generated: true
content_type: reference
envir: onsite, online
---

# "mergedocument" MDO List
MDO list provider for documents marked as type <see cref="F:SuperOffice.Data.TaskType.MailMergeDraft" />.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MergeDocumentListProvider">MergeDocumentListProvider</see> class.
The name of the MDO list is 'mergedocument'.




## Sample Request

```http!
GET /api/v1/MDOList/mergedocument
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mergedocument", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|19|"Brev"BB||19|
|53|"Brev"BB||53|
|8|=Brev=AA||8|
|21|0Notat0BB||21|
|10|4Notat4AA||10|
|52|8Notat8HH||52|
|17|ÆNotatÆBB||17|
|30|'Brev'DD||30|
|13|GBrevGBB||13|
|24|HBrevHDD||24|
|44|JFaksJHH||44|
|35|NFaksNFF||35|
|28|ØNotatØ||28|
|4|PFaksPAA||4|


## Related MDO Lists

* "mergedocumentheadings"
* "mergedocumentheadingswithallitem"
* "mergedocumentheadingswithallitemwithnoselection"
* "mergedocumentheadingswithnoselection"
* "mergedocumentwithallitem"
* "mergedocumentwithallitemwithnoselection"
* "mergedocumentwithnoselection"
