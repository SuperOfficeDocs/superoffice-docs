---
title: GET List/Country/Items
uid: v1CountryList_GetAllCountry
generated: true
---

# GET List/Country/Items

```http
GET /api/v1/List/Country/Items
```

Gets a list of all Country list items.


Calls the List agent service GetAllCountry.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| includeDeleted | bool |   |

```http
GET /api/v1/List/Country/Items?includeDeleted=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| CountryId | int32 | Primary key |
| Name | string | Name of country in installed language |
| CurrencyId | int32 | Default currency for this country |
| EnglishName | string | Name of country in english |
| TwoLetterISOCountry | string | Two-letter country-code according to ISO3166 |
| ThreeLetterISOCountry | string | Three-letter country-code according to ISO3166 |
| ImageDescription | string | Description of the country's flag image. (This is the country flag that is displayed in the CRM client) |
| OrgNrText | string | Lead text for organisation field |
| InterAreaPrefix | string | International prefix |
| DialInPrefix | string | Dial in prefix |
| ZipPrefix | string | Post prefix |
| DomainName | string | Domain name of the country |
| AddressLayoutId | int32 | Address layout of the country |
| DomesticAddressLayoutId | int32 | Domestic address layout of the country |
| ForeignAddressLayoutId | int32 | Foreign address layout of the country |
| Rank | int32 | The rank of the country |
| Tooltip | string | The tooltip of the country |
| Deleted | bool | true if the country is deleted |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/List/Country/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "CountryId": 771,
    "Name": "Lemke LLC",
    "CurrencyId": 739,
    "EnglishName": "Herzog, Lubowitz and Olson",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Synergized systemic emulation",
    "OrgNrText": "87254",
    "InterAreaPrefix": "est",
    "DialInPrefix": "doloribus",
    "ZipPrefix": "sint",
    "DomainName": "Swaniawski-Wilderman",
    "AddressLayoutId": 866,
    "DomesticAddressLayoutId": 298,
    "ForeignAddressLayoutId": 405,
    "Rank": 654,
    "Tooltip": "commodi",
    "Deleted": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 958
      }
    }
  }
]
```