---
title: PUT List/Country/Items/{id}
uid: v1CountryList_PutCountry
generated: true
---

# PUT List/Country/Items/{id}

```http
PUT /api/v1/List/Country/Items/{id}
```

Updates the existing Country


Calls the List agent service SaveCountry.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of Country to be saved. **Required** |



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

## Request Body: entity 

The details of Country to be saved. 

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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/List/Country/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CountryId": 279,
  "Name": "Waelchi Group",
  "CurrencyId": 606,
  "EnglishName": "Greenholt, Swift and Aufderhar",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Enterprise-wide composite benchmark",
  "OrgNrText": "1758870",
  "InterAreaPrefix": "quod",
  "DialInPrefix": "libero",
  "ZipPrefix": "error",
  "DomainName": "Stanton, Krajcik and Roberts",
  "AddressLayoutId": 101,
  "DomesticAddressLayoutId": 400,
  "ForeignAddressLayoutId": 586,
  "Rank": 175,
  "Tooltip": "accusamus",
  "Deleted": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 26,
  "Name": "King, Pfannerstill and Upton",
  "CurrencyId": 186,
  "EnglishName": "Stamm-Feil",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Business-focused bottom-line concept",
  "OrgNrText": "1078048",
  "InterAreaPrefix": "ex",
  "DialInPrefix": "quaerat",
  "ZipPrefix": "ex",
  "DomainName": "Macejkovic Group",
  "AddressLayoutId": 457,
  "DomesticAddressLayoutId": 325,
  "ForeignAddressLayoutId": 524,
  "Rank": 209,
  "Tooltip": "natus",
  "Deleted": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 249
    }
  }
}
```