---
uid: mergedocument
title: mergedocument
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mergedocument"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mergedocument", forceFlatList: true);
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
|10|4Notat4AA||10|
|52|8Notat8HH||52|
|7|ÄBrevÄAA||7|
|30|'Brev'DD||30|
|2|FBrevFAA||2|
|13|GBrevGBB||13|
|24|HBrevHDD||24|
|44|JFaksJHH||44|
|35|NFaksNFF||35|
|28|ØNotatØ||28|
|4|PFaksPAA||4|
|6|ZNotatZAA||6|


## Related MDO Lists

* "mergedocumentheadings"
* "mergedocumentheadingswithallitem"
* "mergedocumentheadingswithallitemwithnoselection"
* "mergedocumentheadingswithnoselection"
* "mergedocumentwithallitem"
* "mergedocumentwithallitemwithnoselection"
* "mergedocumentwithnoselection"
