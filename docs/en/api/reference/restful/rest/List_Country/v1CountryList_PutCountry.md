---
title: PUT List/Country/Items/{id}
uid: v1CountryList_PutCountry
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Country/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CountryId": 916,
  "Name": "Windler-Mertz",
  "CurrencyId": 858,
  "EnglishName": "Waters LLC",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Centralized user-facing database",
  "OrgNrText": "710208",
  "InterAreaPrefix": "rerum",
  "DialInPrefix": "repellat",
  "ZipPrefix": "sit",
  "DomainName": "Kessler, Watsica and Volkman",
  "AddressLayoutId": 347,
  "DomesticAddressLayoutId": 848,
  "ForeignAddressLayoutId": 30,
  "Rank": 363,
  "Tooltip": "reprehenderit",
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 91,
  "Name": "Boyer Group",
  "CurrencyId": 285,
  "EnglishName": "Treutel Inc and Sons",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Ameliorated logistical circuit",
  "OrgNrText": "1436625",
  "InterAreaPrefix": "porro",
  "DialInPrefix": "deserunt",
  "ZipPrefix": "fuga",
  "DomainName": "Bradtke LLC",
  "AddressLayoutId": 514,
  "DomesticAddressLayoutId": 747,
  "ForeignAddressLayoutId": 854,
  "Rank": 485,
  "Tooltip": "id",
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 210
    }
  }
}
```