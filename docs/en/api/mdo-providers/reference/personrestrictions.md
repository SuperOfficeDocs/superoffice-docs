---
uid: personrestrictions
title: personrestrictions
keywords: mdoprovider mdo provider personrestrictions
description: Implements a person mdolist provider that uses the conflicts detector to append information on conflicts
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("personrestrictions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|147|Adm0||associate_id=11&contact_id=2|
|148|Adm1||associate_id=12&contact_id=2|
|149|Adm2||associate_id=13&contact_id=2|
|150|Adm3||associate_id=14&contact_id=2|
|151|Adm4||associate_id=15&contact_id=2|
|152|Adm5||associate_id=16&contact_id=2|
|223|Adm6||associate_id=106&contact_id=2|
|9|Admin Adminson||associate_id=1&contact_id=2|
|183|AdmNS02 NetServer||associate_id=63&contact_id=2|
|126|Ænnhild Ænesen||contact_id=56|
|124|Ænvald Ærbe||contact_id=55|
|123|Ærling Ærestad||contact_id=55|
|125|Æse Ærvelid||contact_id=56|
|131|Åge Ågesen||contact_id=59|
|141|Älve Äström||contact_id=62|
|132|Åmund Ås||contact_id=59|
|140|Änners Ännurlunda||contact_id=61|
|221|Another Kitty||contact_id=125|
|22|Arjan Abelsen||associate_id=90&contact_id=4|
|139|Ärle Älström||contact_id=61|
|19|Arne Arnesen||contact_id=3|


## Related MDO Lists

* "personrestrictionsheadings"
* "personrestrictionsheadingswithallitem"
* "personrestrictionsheadingswithallitemwithnoselection"
* "personrestrictionsheadingswithnoselection"
* "personrestrictionswithallitem"
* "personrestrictionswithallitemwithnoselection"
* "personrestrictionswithnoselection"
