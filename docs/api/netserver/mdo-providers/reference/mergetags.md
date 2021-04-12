---
uid: mergetags
title: mergetags
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mergetags"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "mergetags" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.MergeTagsProvider">MergeTagsProvider</see> class.
The name of the MDO list is 'mergetags'.




## Sample Request

```http!
GET /api/v1/MDOList/mergetags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mergetags", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Name||[[customer.name]]|
|2|First name||[[customer.firstname]]|
|3|Last name||[[customer.lastname]]|
|4|Salutation||[[makeSalutation(customer.id)]]|
|5|E-mail||[[customer.email]]|
|6|Title||[[customer.title]]|
|7|Mobile phone||[[customer.cellphone]]|
|8|Direct phone||[[customer.direct]]|
|9|Category||[[customer.category]]|
|10|Business||[[customer.business]]|
|11|Number||[[customer.number]]|
|12|Position||[[customer.position]]|
|13|Name||[[company.name]]|
|14|Department||[[company.department]]|
|15|Country||[[company.country]]|
|16|Phone||[[company.phone]]|
|17|Web page||[[company.url]]|
|18|Category||[[company.category]]|
|19|Business||[[company.business]]|
|20|Number||[[company.number2]]|
|21|City||[[company.city]]|


## Related MDO Lists

* "mergetagsheadings"
* "mergetagsheadingswithallitem"
* "mergetagsheadingswithallitemwithnoselection"
* "mergetagsheadingswithnoselection"
* "mergetagswithallitem"
* "mergetagswithallitemwithnoselection"
* "mergetagswithnoselection"
