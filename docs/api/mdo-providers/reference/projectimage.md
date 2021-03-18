---
uid: projectimage
title: projectimage
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

# "projectimage" MDO List
Project images from the blob table



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectImageProvider">ProjectImageProvider</see> class.
The name of the MDO list is 'projectimage'.




## Sample Request

```http!
GET /api/v1/MDOList/projectimage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projectimage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|351|airplane.jpg|||
|387|airplane2.jpg|||
|334|annual.jpg|||
|318|apekatt.jpg|||
|356|applause.jpg|||
|433|bell.jpg|||
|372|build.jpg|||
|417|build2.jpg|||
|335|carrots.jpg|||
|397|climb.jpg|||
|421|climb2.jpg|||
|409|coffeebreak.jpg|||
|411|community.jpg|||
|362|Computer.jpg|||
|360|conference.jpg|||
|406|conference2.jpg|||
|398|contest.jpg|||
|355|contest2.jpg|||
|373|contest3.jpg|||
|432|contract.jpg|||
|436|control.jpg|||


## Related MDO Lists

* "projectimageheadings"
* "projectimageheadingswithallitem"
* "projectimageheadingswithallitemwithnoselection"
* "projectimageheadingswithnoselection"
* "projectimagewithallitem"
* "projectimagewithallitemwithnoselection"
* "projectimagewithnoselection"
