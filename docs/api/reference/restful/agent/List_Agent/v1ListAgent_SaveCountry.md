---
title: POST Agents/List/SaveCountry
id: v1ListAgent_SaveCountry
---

# POST Agents/List/SaveCountry

```http
POST /api/v1/Agents/List/SaveCountry
```

Saves a country

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveCountry?$select=name,department,category/id
```

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

## Request Body: request

Country

| Property Name | Type |  Description |
|----------------|------|--------------|
| Country |  | Carrier object for Country. Services for the Country Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |

## Response: object

Carrier object for Country.
Services for the Country Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/SaveCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Country": {
    "CountryId": 449,
    "Name": "McKenzie-Brown",
    "CurrencyId": 945,
    "EnglishName": "Hettinger, Murphy and D'Amore",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Assimilated intermediate process improvement",
    "OrgNrText": "552891",
    "InterAreaPrefix": "et",
    "DialInPrefix": "magni",
    "ZipPrefix": "et",
    "DomainName": "Wolf, Grady and Dare",
    "AddressLayoutId": 517,
    "DomesticAddressLayoutId": 368,
    "ForeignAddressLayoutId": 554,
    "Rank": 712,
    "Tooltip": "eos",
    "Deleted": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 201,
  "Name": "Hintz LLC",
  "CurrencyId": 237,
  "EnglishName": "Larkin LLC",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Adaptive analyzing installation",
  "OrgNrText": "934525",
  "InterAreaPrefix": "vero",
  "DialInPrefix": "nobis",
  "ZipPrefix": "ut",
  "DomainName": "Barrows, Christiansen and Bradtke",
  "AddressLayoutId": 431,
  "DomesticAddressLayoutId": 179,
  "ForeignAddressLayoutId": 980,
  "Rank": 284,
  "Tooltip": "est",
  "Deleted": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "transform killer action-items"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 71
    }
  }
}
```
