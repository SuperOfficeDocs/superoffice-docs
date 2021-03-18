---
uid: saleprobability
title: saleprobability
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "saleprobability" MDO List
MDO list provider for the probability list of the Sale dialog. This list extends the basic <see cref="!:ProbRow" /> list with a leading
'lost' and a trailing 'sold' item, and specialized icons. It also adds the probability as part of the text, and again
in the extraInfo field.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleProbability">SaleProbability</see> class.
The name of the MDO list is 'saleprobability'.




## Sample Request

```http!
GET /api/v1/MDOList/saleprobability
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saleprobability", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|Lost||0|
|5|Andre møte (50%)||50|
|4|Første møte (20%)||20|
|3|Muntlig aksept (90%)||90|
|1|Sendt tilbud (30%)||30|
|2|Sluttforhandlinger (80%)||80|
|-2|Sold||100|


## Related MDO Lists

* "saleprobabilityheadings"
* "saleprobabilityheadingswithallitem"
* "saleprobabilityheadingswithallitemwithnoselection"
* "saleprobabilityheadingswithnoselection"
* "saleprobabilitywithallitem"
* "saleprobabilitywithallitemwithnoselection"
* "saleprobabilitywithnoselection"
