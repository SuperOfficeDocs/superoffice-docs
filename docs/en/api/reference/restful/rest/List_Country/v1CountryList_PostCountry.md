---
title: POST List/Country/Items
uid: v1CountryList_PostCountry
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "CountryId": 341,
  "Name": "Kohler LLC",
  "CurrencyId": 967,
  "EnglishName": "Moore-Wehner",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Distributed demand-driven hierarchy",
  "OrgNrText": "1347931",
  "InterAreaPrefix": "totam",
  "DialInPrefix": "voluptatem",
  "ZipPrefix": "ad",
  "DomainName": "Keeling, Koelpin and Kerluke",
  "AddressLayoutId": 304,
  "DomesticAddressLayoutId": 670,
  "ForeignAddressLayoutId": 741,
  "Rank": 144,
  "Tooltip": "sed",
  "Deleted": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 804,
  "Name": "Toy-Rempel",
  "CurrencyId": 295,
  "EnglishName": "Schultz, Boyer and Herman",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Progressive national Graphical User Interface",
  "OrgNrText": "586812",
  "InterAreaPrefix": "eaque",
  "DialInPrefix": "maiores",
  "ZipPrefix": "qui",
  "DomainName": "Streich-Boyle",
  "AddressLayoutId": 487,
  "DomesticAddressLayoutId": 183,
  "ForeignAddressLayoutId": 129,
  "Rank": 836,
  "Tooltip": "aut",
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 123
    }
  }
}
```