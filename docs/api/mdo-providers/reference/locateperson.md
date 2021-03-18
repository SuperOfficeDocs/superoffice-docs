---
uid: locateperson
title: locateperson
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

# "locateperson" MDO List
Person list with contact name.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.LocatePersonProvider">LocatePersonProvider</see> class.
The name of the MDO list is 'locateperson'.




## Sample Request

```http!
GET /api/v1/MDOList/locateperson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("locateperson", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|147|Adm0 (statezerodatabase)|||
|148|Adm1 (statezerodatabase)|||
|149|Adm2 (statezerodatabase)|||
|150|Adm3 (statezerodatabase)|||
|151|Adm4 (statezerodatabase)|||
|152|Adm5 (statezerodatabase)|||
|223|Adm6 (statezerodatabase)|||
|9|Admin Adminson (statezerodatabase)|||
|183|AdmNS02 NetServer (statezerodatabase)|||
|126|Ænnhild Ænesen (Ærlighet Varer Lengst ASA)|||
|124|Ænvald Ærbe (Ære Og Berømmelse AS)|||
|123|Ærling Ærestad (Ære Og Berømmelse AS)|||
|125|Æse Ærvelid (Ærlighet Varer Lengst ASA)|||
|131|Åge Ågesen (Åndalsnes Delikatessebutikk AS)|||
|141|Älve Äström (Älvsjö)|||
|132|Åmund Ås (Åndalsnes Delikatessebutikk AS)|||
|140|Änners Ännurlunda (Älvhult AB)|||
|221|Another Kitty (German Cats)|||
|22|Arjan Abelsen (Arne'S Kebab)|||
|139|Ärle Älström (Älvhult AB)|||
|19|Arne Arnesen (Amadeus AS)|||


## Related MDO Lists

* "locatepersonheadings"
* "locatepersonheadingswithallitem"
* "locatepersonheadingswithallitemwithnoselection"
* "locatepersonheadingswithnoselection"
* "locatepersonwithallitem"
* "locatepersonwithallitemwithnoselection"
* "locatepersonwithnoselection"
