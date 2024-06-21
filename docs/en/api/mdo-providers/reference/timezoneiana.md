---
uid: timezoneiana
title: timezoneiana
keywords: mdoprovider mdo provider timezoneiana
description: Provides the timezone list. The extrainfo contains the IANA-id of the timezone. The iconhint follows the structure 'Flag_[country_name]'.
generated: true
topic: reference
envir: onsite, online
---

# "timezoneiana" MDO List
Provides the timezone list.
The extrainfo contains the IANA-id of the timezone.
The iconhint follows the structure 'Flag_[country_name]'.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TimeZoneIANAProvider">TimeZoneIANAProvider</see> class.
The name of the MDO list is 'timezoneiana'.




## Sample Request

```http!
GET /api/v1/MDOList/timezoneiana
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("timezoneiana", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|UTC/GMT (GMT+00.00)||countryId=0&locationCode=UTC&isActive=True&IANA=UTC|
|36|Australian Capital Territory (GMT+10.00)||countryId=36&locationCode=AU-ACT&isActive=True&IANA=Australia/Canberra|
|37|Broken Hill (GMT+09.30)||countryId=36&locationCode=AU3&isActive=True&IANA=Australia/Broken_Hill|
|38|Lord Howe Island (GMT+10.30)||countryId=36&locationCode=AU1&isActive=True&IANA=Australia/Lord_Howe|
|39|New South Wales (GMT+10.00)||countryId=36&locationCode=AU-NSW&isActive=True&IANA=Australia/Sydney|
|40|Northern Territory (GMT+09.30)||countryId=36&locationCode=AU-NT&isActive=True&IANA=Australia/Darwin|
|41|Queensland (GMT+10.00)||countryId=36&locationCode=AU-QLD&isActive=True&IANA=Australia/Brisbane|
|42|South Australia (GMT+09.30)||countryId=36&locationCode=AU-SA&isActive=True&IANA=Australia/Adelaide|
|43|Tasmania (GMT+10.00)||countryId=36&locationCode=AU-TAS&isActive=True&IANA=Australia/Hobart|
|44|Victoria (GMT+10.00)||countryId=36&locationCode=AU-VIC&isActive=True&IANA=Australia/Melbourne|
|45|Western Australia (GMT+08.00)||countryId=36&locationCode=AU-WA&isActive=True&IANA=Australia/Perth|
|46|Austria (GMT+01.00)||countryId=40&locationCode=AT&isActive=True&IANA=Europe/Vienna|
|53|Belgium (GMT+01.00)||countryId=56&locationCode=BE&isActive=True&IANA=Europe/Brussels|
|81|Rio de Janeiro (GMT-03.00)||countryId=76&locationCode=BR-RJ&isActive=True&IANA=America/Sao_Paulo|
|96|Alberta (GMT-07.00)||countryId=124&locationCode=CA-AB&isActive=True&IANA=America/Edmonton|
|97|British Columbia (GMT-08.00)||countryId=124&locationCode=CA-BC&isActive=True&IANA=America/Vancouver|
|98|British Columbia (exception 1) (GMT-07.00)||countryId=124&locationCode=CA-BC1&isActive=True&IANA=America/Dawson_Creek|
|99|British Columbia (exception 2) (GMT-07.00)||countryId=124&locationCode=CA-BC2&isActive=True&IANA=America/Vancouver|
|100|Labrador (GMT-04.00)||countryId=124&locationCode=CA2&isActive=True&IANA=America/Goose_Bay|
|101|Labrador (exception) (GMT-03.30)||countryId=124&locationCode=CA2A&isActive=True&IANA=America/St_Johns|
|102|Manitoba (GMT-06.00)||countryId=124&locationCode=CA-MB&isActive=True&IANA=America/Winnipeg|


## Related MDO Lists

* "timezoneianaheadings"
* "timezoneianaheadingswithallitem"
* "timezoneianaheadingswithallitemwithnoselection"
* "timezoneianaheadingswithnoselection"
* "timezoneianawithallitem"
* "timezoneianawithallitemwithnoselection"
* "timezoneianawithnoselection"
