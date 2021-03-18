---
uid: saleguidestage
title: saleguidestage
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

# "saleguidestage" MDO List
MDO provider for the stage list, customized for the sale guide stage button row

AdditionalInfo is a name/value string, and can be either sale_id=&lt;id&gt; or saletype_id=&lt;id&gt;. If sale_id is given,
then you get back all the stages valid for this sale, with stylehint currentStage for the current one; if saletype_id is given,
you get back all stages valid for this sale type, but (obviously) with no current indication.
<br />
If no additionalInfo is given, all stages are returned. The 'special' stages Open, Lost and Sold are <b>not</b> included in this
provider; use the SaleStage provider for those.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleGuideStage">SaleGuideStage</see> class.
The name of the MDO list is 'saleguidestage'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Sale to get stages for| sale_id|1234|
|Sale Type to get stages for| saletype_id|234|
|Sale Stage id| prob_id|234|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/saleguidestage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saleguidestage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|Første møte|||
|1|Sendt tilbud|||
|5|Andre møte|||
|2|Sluttforhandlinger|||
|3|Muntlig aksept|||


## Related MDO Lists

* "saleguidestageheadings"
* "saleguidestageheadingswithallitem"
* "saleguidestageheadingswithallitemwithnoselection"
* "saleguidestageheadingswithnoselection"
* "saleguidestagewithallitem"
* "saleguidestagewithallitemwithnoselection"
* "saleguidestagewithnoselection"
