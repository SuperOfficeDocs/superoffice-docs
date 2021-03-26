---
title: PUT List/Country/Items/{id}
id: v1CountryList_PutCountry
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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/List/Country/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "CountryId": 823,
  "Name": "Rath-Murray",
  "CurrencyId": 798,
  "EnglishName": "Wilderman-Hauck",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Digitized zero administration attitude",
  "OrgNrText": "244480",
  "InterAreaPrefix": "consequuntur",
  "DialInPrefix": "commodi",
  "ZipPrefix": "blanditiis",
  "DomainName": "Dare, Schimmel and Corwin",
  "AddressLayoutId": 154,
  "DomesticAddressLayoutId": 350,
  "ForeignAddressLayoutId": 639,
  "Rank": 482,
  "Tooltip": "dicta",
  "Deleted": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CountryId": 465,
  "Name": "Gorczany-Swaniawski",
  "CurrencyId": 421,
  "EnglishName": "Ruecker-Sanford",
  "TwoLetterISOCountry": "Sokovia",
  "ThreeLetterISOCountry": "Sokovia",
  "ImageDescription": "Persistent context-sensitive productivity",
  "OrgNrText": "1219273",
  "InterAreaPrefix": "voluptatem",
  "DialInPrefix": "ut",
  "ZipPrefix": "sed",
  "DomainName": "Robel, Kunde and Champlin",
  "AddressLayoutId": 479,
  "DomesticAddressLayoutId": 172,
  "ForeignAddressLayoutId": 661,
  "Rank": 937,
  "Tooltip": "tempora",
  "Deleted": true,
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
      "FieldType": "System.String",
      "FieldLength": 737
    }
  }
}
```