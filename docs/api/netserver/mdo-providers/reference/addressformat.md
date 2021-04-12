---
uid: addressformat
title: addressformat
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "addressformat"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "addressformat" MDO List
MDO list provider for AddressFormats Id returned is the layout_id, not the addressformat_id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AddressFormatListProvider">AddressFormatListProvider</see> class.
The name of the MDO list is 'addressformat'.




## Sample Request

```http!
GET /api/v1/MDOList/addressformat
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("addressformat", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|13|Australian||13|
|5|Canadian||5|
|10|Caribbean||10|
|15|Denmark||15|
|1|European||1|
|9|European no postprefix||9|
|4|German||4|
|11|German small||11|
|12|German with title||12|
|6|Japanese||6|
|14|Netherlands||14|
|7|Other||7|
|8|Spain||8|
|3|United Kingdom||3|
|2|United States||2|
|16|United States street and postal||16|


## Related MDO Lists

* "addressformatheadings"
* "addressformatheadingswithallitem"
* "addressformatheadingswithallitemwithnoselection"
* "addressformatheadingswithnoselection"
* "addressformatwithallitem"
* "addressformatwithallitemwithnoselection"
* "addressformatwithnoselection"
