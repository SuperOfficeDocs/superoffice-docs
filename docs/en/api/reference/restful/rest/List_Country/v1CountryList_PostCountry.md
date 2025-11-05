---
title: POST List/Country/Items
uid: v1CountryList_PostCountry
generated: true
content_type: reference
---

# POST List/Country/Items

```http
POST /api/v1/List/Country/Items
```

Create a new Country list item


Calls the List agent service SaveCountry.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: newEntity 

The Country to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CountryId | Integer | Primary key |
| Name | String | Name of country in installed language |
| CurrencyId | Integer | Default currency for this country |
| EnglishName | String | Name of country in english |
| TwoLetterISOCountry | String | Two-letter country-code according to ISO3166 |
| ThreeLetterISOCountry | String | Three-letter country-code according to ISO3166 |
| ImageDescription | String | Description of the country's flag image. (This is the country flag that is displayed in the CRM client) |
| OrgNrText | String | Lead text for organisation field |
| InterAreaPrefix | String | International prefix |
| DialInPrefix | String | Dial in prefix |
| ZipPrefix | String | Post prefix |
| DomainName | String | Domain name of the country |
| AddressLayoutId | Integer | Address layout of the country |
| DomesticAddressLayoutId | Integer | Domestic address layout of the country |
| ForeignAddressLayoutId | Integer | Foreign address layout of the country |
| Rank | Integer | The rank of the country |
| Tooltip | String | The tooltip of the country |
| Deleted | Boolean | true if the country is deleted |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Country

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
POST /api/v1/List/Country/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CountryId": 321,
  "Name": "Treutel, Luettgen and Grimes",
  "CurrencyId": 862,
  "EnglishName": "Langworth LLC",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Monitored optimal approach",
  "OrgNrText": "510027",
  "InterAreaPrefix": "aut",
  "DialInPrefix": "ut",
  "ZipPrefix": "ut",
  "DomainName": "O'Keefe, Cummerata and Conroy",
  "AddressLayoutId": 815,
  "DomesticAddressLayoutId": 737,
  "ForeignAddressLayoutId": 445,
  "Rank": 983,
  "Tooltip": "qui",
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 840,
  "Name": "Zulauf-Klein",
  "CurrencyId": 10,
  "EnglishName": "Pfeffer, Hamill and Ratke",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Innovative coherent capacity",
  "OrgNrText": "585878",
  "InterAreaPrefix": "unde",
  "DialInPrefix": "culpa",
  "ZipPrefix": "ipsam",
  "DomainName": "O'Keefe-Emmerich",
  "AddressLayoutId": 649,
  "DomesticAddressLayoutId": 341,
  "ForeignAddressLayoutId": 549,
  "Rank": 829,
  "Tooltip": "officiis",
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 280
    }
  }
}
```