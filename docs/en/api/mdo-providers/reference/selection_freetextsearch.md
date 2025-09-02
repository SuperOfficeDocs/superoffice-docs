---
uid: selection_freetextsearch
title: selection_freetextsearch
keywords: mdoprovider mdo provider selection_freetextsearch
description: Provider for selecting a Selection. Does keyword matching and scoring across multiple string fields. Checks name, description, soundex fields.
generated: true
content_type: reference
envir: onsite, online
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
|73|A﻿rchived reports made with reporter||dynamic|
|1|Atvaalg-AAAdmAllKam||static|
|2|Uffaaff-AAAdmMedKon||static|
|3|Ukkaakk-AAAdmGruPri||static|
|4|Uppaapp-AAAdmAllFas||static|
|5|Utvuulg-AAAdmAll||static|
|6|Ubbaabb-BBSalAllKam||static|
|7|Uggaagg-BBSalMedKon||static|
|8|Ullaall-BBSalGruPri||static|
|9|Uqqaaqq-BBSalAllFas||static|
|10|Uvvaavv-BBSalAll||static|
|16|Uddaadd-DDSerAllKam||static|
|17|Itviilg-DDSerMedKon||static|
|18|Unnaann-DDSerGruPri||static|
|19|Ussaass-DDSerAllFas||static|
|20|Uxxaaxx-DDSerAll||static|
|11|Uccaacc-FFTjeAllKam||static|
|12|Uhhaahh-FFTjeMedKon||static|
|13|Ummaamm-FFTjeGruPri||static|
|14|Urraarr-FFTjeAllFas||static|
|15|Uwwaaww-FFTjeAll||static|


## Related MDO Lists

* "selection_freetextsearchheadings"
* "selection_freetextsearchheadingswithallitem"
* "selection_freetextsearchheadingswithallitemwithnoselection"
* "selection_freetextsearchheadingswithnoselection"
* "selection_freetextsearchwithallitem"
* "selection_freetextsearchwithallitemwithnoselection"
* "selection_freetextsearchwithnoselection"
