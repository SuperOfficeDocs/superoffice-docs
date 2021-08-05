---
uid: selection
title: selection
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selection"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selection" MDO List
Provider for selecting a selection.
Supported additionalInfo:
kind=static or kind=dynamic to restrict to static or dynamic selections only. Otherwise you'll get both kinds.
membertype=[tablename|tablenumber] to restrict to one kind of entities. Both tableNumber and table name can be used.
Any combination of these are supported.

Sentry rights are honoured; if you do not have Read acces the selection will not be listed here. Additionally,
selections with empty names are not listed; such selections are the result of bugs and are not visible anywhere else
either.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionProvider">SelectionProvider</see> class.
The name of the MDO list is 'selection'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Comma separated list of selection type (Static, dynamic, combined)| kind|Static|
|Filter according to type of selection members (table id or name)| membertype|contact|
|Filter out non-editable selections| onlywriteable|true|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/selection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selection", forceFlatList: true);
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
|1|Atvaalg-AAAdmAllKam||static|
|52|Ätväälg-GGTjeAll||static|
|29|Åtvåålg-GGTjeAll||static|
|55|Customers||dynamic|
|21|Etveelg-HHMarAllKam||static|
|17|Itviilg-DDSerMedKon||static|
|30|Ötvöölg-GGTjeAll||static|
|28|Øtvøølg-GGTjeAll||static|
|23|Otvoolg-HHMarGruPri||static|
|54|Selection for creation of external users||static|
|33|'Tv''lg-GGTjeAll||static|


## Related MDO Lists

* "selectionheadings"
* "selectionheadingswithallitem"
* "selectionheadingswithallitemwithnoselection"
* "selectionheadingswithnoselection"
* "selectionwithallitem"
* "selectionwithallitemwithnoselection"
* "selectionwithnoselection"
