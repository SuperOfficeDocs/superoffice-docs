---
uid: locateperson
title: locateperson
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "locateperson"
so.generated: true
so.date: 19.03.2021
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
|3136|Aaron Ophélie Austin (Kessler, Huels and Roberts)|||
|15428|Aaron Black (Stim Corp)|||
|4783|Aaron Hélèna Bryant (明美郜 Corp)|||
|2869|Aaron Marie-noël Carr (O'Connell Group)|||
|14715|Aaron Collins (Pollich-Erdman)|||
|14719|Aaron Daniels (Devbug Inc)|||
|10794|Aaron Annotés Diaz (Harvey-Lehner)|||
|10049|Aaron Fields (Morissette Inc)|||
|15713|Aaron Garcia (Zemlak-Senger)|||
|14102|Aaron Gonzales (Gerlach, Nolan and Abbott AS)|||
|14740|Aaron Gonzales (Yú Nicholas Patterson & Partners)|||
|3718|Aaron Séréna Graham (Von, Ryan and Cartwright)|||
|10344|Aaron Mahélie Green (Bitwolf Corp)|||
|10285|Aaron Hawkins (Veribet Corp)|||
|3826|Aaron Maïlys James (Mat Lam Tam Corp)|||
|14469|Aaron Johnson ( Kenneth Ford & Partners)|||
|3398|Aaron Johnston (Padberg-Hudson)|||
|14251|Aaron Lewis (尹智姬 Corp)|||
|1738|Aaron Faîtes Medina (Goodwin, Dibbert and Mayer)|||
|11707|Aaron Miller (晧宇印 Corp)|||
|11274|Aaron Moore (Eamia Inc)|||


## Related MDO Lists

* "locatepersonheadings"
* "locatepersonheadingswithallitem"
* "locatepersonheadingswithallitemwithnoselection"
* "locatepersonheadingswithnoselection"
* "locatepersonwithallitem"
* "locatepersonwithallitemwithnoselection"
* "locatepersonwithnoselection"
