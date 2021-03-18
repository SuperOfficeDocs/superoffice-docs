---
uid: person
title: person
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

# "person" MDO List
List of persons from the Archive provider



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonListProvider">PersonListProvider</see> class.
The name of the MDO list is 'person'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Restrict results to selection memebers.| selection_id|23|





## Sample Request

```http!
GET /api/v1/MDOList/person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("person", forceFlatList: true);
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

* "personheadings"
* "personheadingswithallitem"
* "personheadingswithallitemwithnoselection"
* "personheadingswithnoselection"
* "personwithallitem"
* "personwithallitemwithnoselection"
* "personwithnoselection"
