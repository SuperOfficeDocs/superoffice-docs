---
uid: appointmenttextid
title: appointmenttextid
keywords: mdoprovider mdo provider appointmenttextid
description: Special case of appointment list where we get the id value from the Text table. For use when we want to represent an appointment with the text.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "appointmenttextid" MDO List
Special case of appointment list where we get the id value from the Text table. For use when we want
to represent an appointment with the text.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentListTextIdProvider">AppointmentListTextIdProvider</see> class.
The name of the MDO list is 'appointmenttextid'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmenttextid
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointmenttextid", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|8|AMøte inneABB|||
|9|BTelefon utBBB|||
|10|IMøte inneIBB|||
|11|EMøte inneEBB|||
|12|MMøte inneMBB|||
|13|PPrivatPBB|||
|14|QMøte inneQBB|||
|15|TPrivatTBB|||
|16|XPrivatXBB|||
|17|ØPrivatØBB|||
|18|ÜTilbudÜBB|||
|19|ÄPrivatÄBB|||
|20|2Tilbud2BB|||
|21|6Tilbud6BB|||
|23|&Telefon ut&BB|||
|24|=Tilbud=BB|||
|25|*Møte inne*BB|||
|26|CTilbudCCC|||
|27|FTelefon utFCC|||
|28|GTilbudGCC|||
|29|JTelefon utJCC|||


## Related MDO Lists

* "appointmenttextidheadings"
* "appointmenttextidheadingswithallitem"
* "appointmenttextidheadingswithallitemwithnoselection"
* "appointmenttextidheadingswithnoselection"
* "appointmenttextidwithallitem"
* "appointmenttextidwithallitemwithnoselection"
* "appointmenttextidwithnoselection"
