---
uid: selection_freetextsearch
title: selection_freetextsearch
keywords: mdoprovider mdo provider selection_freetextsearch
description: Provider for selecting a Selection. Does keyword matching and scoring across multiple string fields. Checks name, description, soundex fields.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "selection_freetextsearch" MDO List
Provider for selecting a Selection.
Does keyword matching and scoring across multiple
string fields. Checks name, description, soundex fields.

User's own selections, recently added + modified selections, selections modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.


Returns selection items only: Id = selection-id, Name = Selection name, Type = "Selection", IconHint="deleted_item", ExtraInfo= static/dynamic


Completed/Done selections are marked with stylehint = "deleted_item" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionListFreetextSearchProvider">SelectionListFreetextSearchProvider</see> class.
The name of the MDO list is 'selection_freetextsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/selection_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selection_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|32|"Tv""lg-GGTjeAll||static|
|35|#Tv##lg-GGTjeAll||static|
|36|%Tv%%lg-GGTjeAll||static|
|37|&Tv&&lg-GGTjeAll||static|
|34|*Tv**lg-GGTjeAll||static|
|39|?Tv??lg-GGTjeAll||static|
|40|<Tv<<lg-GGTjeAll||static|
|38|=Tv==lg-GGTjeAll||static|
|41|>Tv>>lg-GGTjeAll||static|
|27|Ætvæælg-GGTjeAll||static|
|73|A﻿rchived reports made with reporter||dynamic|
|1|Atvaalg-AAAdmAllKam||static|
|29|Åtvåålg-GGTjeAll||static|
|52|Ätväälg-GGTjeAll||static|
|55|Customers||dynamic|
|21|Etveelg-HHMarAllKam||static|
|17|Itviilg-DDSerMedKon||static|
|30|Ötvöölg-GGTjeAll||static|
|28|Øtvøølg-GGTjeAll||static|
|23|Otvoolg-HHMarGruPri||static|
|54|Selection for creation of external users||static|


## Related MDO Lists

* "selection_freetextsearchheadings"
* "selection_freetextsearchheadingswithallitem"
* "selection_freetextsearchheadingswithallitemwithnoselection"
* "selection_freetextsearchheadingswithnoselection"
* "selection_freetextsearchwithallitem"
* "selection_freetextsearchwithallitemwithnoselection"
* "selection_freetextsearchwithnoselection"
