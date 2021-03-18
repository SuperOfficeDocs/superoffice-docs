---
uid: salutation
title: salutation
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

# "salutation" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'salutation'.




## Sample Request

```http!
GET /api/v1/MDOList/salutation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("salutation", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Bachelor of Law|||
|2|Bachelor of Medicine|||
|3|Bachelor of Science|||
|5|Bedriftsøkonom|||
|19|Diplomingeniør|||
|20|Diplomøkonom|||
|21|Doctor rerum politicarum|||
|22|Dr. Agric.|||
|23|Dr. Art.|||
|24|Dr. H. C.|||
|25|Dr. Ing.|||
|26|Dr. Jur.|||
|27|Dr. Med.|||
|28|Dr. Med. Vet.|||
|31|Dr. Philos.|||
|32|Dr. Polit.|||
|33|Dr. Scient.|||
|34|Dr. Techn.|||
|35|Dr. Theol.|||
|41|Sivilingeniør|||


## Related MDO Lists

* "salutationheadings"
* "salutationheadingswithallitem"
* "salutationheadingswithallitemwithnoselection"
* "salutationheadingswithnoselection"
* "salutationwithallitem"
* "salutationwithallitemwithnoselection"
* "salutationwithnoselection"
