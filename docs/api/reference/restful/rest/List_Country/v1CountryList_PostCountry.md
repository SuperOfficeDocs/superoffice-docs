---
title: POST List/Country/Items
id: v1CountryList_PostCountry
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
POST /api/v1/List/Country/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CountryId": 334,
  "Name": "Gerlach Group",
  "CurrencyId": 743,
  "EnglishName": "Johnson, Marks and Beer",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Re-contextualized 6th generation capacity",
  "OrgNrText": "1003530",
  "InterAreaPrefix": "quia",
  "DialInPrefix": "provident",
  "ZipPrefix": "a",
  "DomainName": "Volkman-Grady",
  "AddressLayoutId": 612,
  "DomesticAddressLayoutId": 369,
  "ForeignAddressLayoutId": 318,
  "Rank": 593,
  "Tooltip": "consequuntur",
  "Deleted": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 976,
  "Name": "Denesik-Weimann",
  "CurrencyId": 236,
  "EnglishName": "Williamson-Brekke",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Configurable mobile secured line",
  "OrgNrText": "1296372",
  "InterAreaPrefix": "aut",
  "DialInPrefix": "deserunt",
  "ZipPrefix": "aperiam",
  "DomainName": "Towne-Parker",
  "AddressLayoutId": 328,
  "DomesticAddressLayoutId": 774,
  "ForeignAddressLayoutId": 295,
  "Rank": 273,
  "Tooltip": "qui",
  "Deleted": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 374
    }
  }
}
```