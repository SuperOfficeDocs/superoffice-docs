---
uid: appointment
title: appointment
keywords: mdoprovider mdo provider appointment
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "appointment" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentListProvider">AppointmentListProvider</see> class.
The name of the MDO list is 'appointment'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return all appointments instead of only mother appointments.| anyAppointment|1|





## Sample Request

```http!
GET /api/v1/MDOList/appointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointment", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|58|AMøte inneABB|||
|59|BTelefon utBBB|||
|61|IMøte inneIBB|||
|60|EMøte inneEBB|||
|62|MMøte inneMBB|||
|63|PPrivatPBB|||
|64|QMøte inneQBB|||
|65|TPrivatTBB|||
|66|XPrivatXBB|||
|67|ØPrivatØBB|||
|68|ÜTilbudÜBB|||
|69|ÄPrivatÄBB|||
|70|2Tilbud2BB|||
|71|6Tilbud6BB|||
|73|&Telefon ut&BB|||
|74|=Tilbud=BB|||
|75|*Møte inne*BB|||
|76|CTilbudCCC|||
|77|FTelefon utFCC|||
|78|GTilbudGCC|||
|79|JTelefon utJCC|||


## Related MDO Lists

* "appointmentheadings"
* "appointmentheadingswithallitem"
* "appointmentheadingswithallitemwithnoselection"
* "appointmentheadingswithnoselection"
* "appointmentwithallitem"
* "appointmentwithallitemwithnoselection"
* "appointmentwithnoselection"
