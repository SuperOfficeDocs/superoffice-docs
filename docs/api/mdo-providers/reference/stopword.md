---
uid: stopword
title: stopword
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

# "stopword" MDO List
List of stop words. i.e. words which will not be included in the free-text index.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.StopWordProvider">StopWordProvider</see> class.
The name of the MDO list is 'stopword'.




## Sample Request

```http!
GET /api/v1/MDOList/stopword
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("stopword", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|1999|||
|2|2000|||
|3|2001|||
|4|AKKURAT|||
|5|ALDRI|||
|6|ALENE|||
|7|ALL|||
|8|ALLE|||
|9|ALLEREDE|||
|10|ALLTID|||
|11|ALT|||
|12|ALTSÅ|||
|13|ANDRE|||
|14|ANNEN|||
|15|ANNET|||
|16|ANSIKT|||
|17|APRIL|||
|18|ARBEID|||
|19|ARBEIDET|||
|20|AUGUST|||
|21|BAK|||


## Related MDO Lists

* "stopwordheadings"
* "stopwordheadingswithallitem"
* "stopwordheadingswithallitemwithnoselection"
* "stopwordheadingswithnoselection"
* "stopwordwithallitem"
* "stopwordwithallitemwithnoselection"
* "stopwordwithnoselection"
