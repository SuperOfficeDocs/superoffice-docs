---
uid: timezone
title: timezone
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "timezone"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "timezone" MDO List
Provides the timezone list.
If no search value is passed in the list is restricted to 'available' timezones

AdditionalInfo = "[all]" returns all timezones

AdditionalInfo = "123" returns all active timezones and the specific location

AdditionalInfo = "locationId=123" returns only the given location.


Implemented by the <see cref="T:SuperOffice.CRM.Lists.TimeZoneProvider">TimeZoneProvider</see> class.
The name of the MDO list is 'timezone'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Get all timezones| |[all]|
|Get all active timezones and the given location| |1234|
|Get the specific Timezone location| locationId|1234|





## Sample Request

```http!
GET /api/v1/MDOList/timezone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("timezone", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|UTC/GMT (GMT+00.00)||0|
|36|Australian Capital Territory (GMT+10.00)||36|
|37|Broken Hill (GMT+09.30)||36|
|38|Lord Howe Island (GMT+10.30)||36|
|39|New South Wales (GMT+10.00)||36|
|40|Northern Territory (GMT+09.30)||36|
|41|Queensland (GMT+10.00)||36|
|42|South Australia (GMT+09.30)||36|
|43|Tasmania (GMT+10.00)||36|
|44|Victoria (GMT+10.00)||36|
|45|Western Australia (GMT+08.00)||36|
|46|Austria (GMT+01.00)||40|
|53|Belgium (GMT+01.00)||56|
|81|Rio de Janeiro (GMT-03.00)||76|
|96|Alberta (GMT-07.00)||124|
|97|British Columbia (GMT-08.00)||124|
|98|British Columbia (exception 1) (GMT-07.00)||124|
|99|British Columbia (exception 2) (GMT-07.00)||124|
|100|Labrador (GMT-04.00)||124|
|101|Labrador (exception) (GMT-03.30)||124|
|102|Manitoba (GMT-06.00)||124|


## Related MDO Lists

* "timezoneheadings"
* "timezoneheadingswithallitem"
* "timezoneheadingswithallitemwithnoselection"
* "timezoneheadingswithnoselection"
* "timezonewithallitem"
* "timezonewithallitemwithnoselection"
* "timezonewithnoselection"
