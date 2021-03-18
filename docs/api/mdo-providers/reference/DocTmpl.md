---
uid: doctmpl
title: doctmpl
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

# "doctmpl" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'doctmpl'.




## Sample Request

```http!
GET /api/v1/MDOList/doctmpl
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("doctmpl", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Brev|||
|4|Brev - Internasjonal|||
|20|Confirmation - Contact added|||
|6|E-post|||
|7|E-post SV:|||
|8|E-post VS:|||
|3|Faks|||
|5|Faks - Internasjonal|||
|12|Innk. dok.|||
|11|Innk. E-post|||
|2|Notat|||
|9|Send dok.pr E-post|||
|10|Send dok.pr Faks|||
|13|StateZero Word Simple|||
|14|StateZero Word Simple Czech|||
|19|Order confirmation e-mail|||
|18|Order confirmation|||
|16|Quote - detailed|||
|17|Quote e-mail|||
|15|Quote|||


## Related MDO Lists

* "doctmplheadings"
* "doctmplheadingswithallitem"
* "doctmplheadingswithallitemwithnoselection"
* "doctmplheadingswithnoselection"
* "doctmplwithallitem"
* "doctmplwithallitemwithnoselection"
* "doctmplwithnoselection"
