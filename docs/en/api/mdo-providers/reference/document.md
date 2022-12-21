---
uid: document
title: document
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "document"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "document" MDO List

MDO list provider for documents.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentListProvider">DocumentListProvider</see> class.
The name of the MDO list is 'document'.

## Sample Request

```http!
GET /api/v1/MDOList/document
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("document", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|53|"Brev"BB||53|
|19|"Brev"BB||19|
|20|?Brev?BB||20|
|8|=Brev=AA||8|
|21|0Notat0BB||21|
|31|1Notat1DD||31|
|41|2Notat2FF||41|
|51|3Notat3HH||51|
|10|4Notat4AA||10|
|52|8Notat8HH||52|
|11|9Notat9AA||11|
|1|ABrevAAA||1|
|17|ÆNotatÆBB||17|
|38|ÅNotatÅFF||38|
|12|BBrevBBB||12|
|30|'Brev'DD||30|
|23|CBrevCDD||23|
|70|Document for Fish company||70|
|69|Document for Fish company||69|
|13|GBrevGBB||13|
|24|HBrevHDD||24|

## Related MDO Lists

* "documentheadings"
* "documentheadingswithallitem"
* "documentheadingswithallitemwithnoselection"
* "documentheadingswithnoselection"
* "documentwithallitem"
* "documentwithallitemwithnoselection"
* "documentwithnoselection"
