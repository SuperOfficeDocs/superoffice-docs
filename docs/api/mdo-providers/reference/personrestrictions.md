---
uid: personrestrictions
title: personrestrictions
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

# "personrestrictions" MDO List
Implements a person mdolist provider that uses the conflicts detector to append information on
conflicts



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonListRestrictionsProvider">PersonListRestrictionsProvider</see> class.
The name of the MDO list is 'personrestrictions'.




## Sample Request

```http!
GET /api/v1/MDOList/personrestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("personrestrictions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|147|Adm0|||
|148|Adm1|||
|149|Adm2|||
|150|Adm3|||
|151|Adm4|||
|152|Adm5|||
|223|Adm6|||
|9|Admin Adminson|||
|183|AdmNS02 NetServer|||
|126|Ænnhild Ænesen|||
|124|Ænvald Ærbe|||
|123|Ærling Ærestad|||
|125|Æse Ærvelid|||
|131|Åge Ågesen|||
|141|Älve Äström|||
|132|Åmund Ås|||
|140|Änners Ännurlunda|||
|221|Another Kitty|||
|22|Arjan Abelsen|||
|139|Ärle Älström|||
|19|Arne Arnesen|||


## Related MDO Lists

* "personrestrictionsheadings"
* "personrestrictionsheadingswithallitem"
* "personrestrictionsheadingswithallitemwithnoselection"
* "personrestrictionsheadingswithnoselection"
* "personrestrictionswithallitem"
* "personrestrictionswithallitemwithnoselection"
* "personrestrictionswithnoselection"
