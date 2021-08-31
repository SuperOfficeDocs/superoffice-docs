---
title: GetLanguageInfoList
id: v1ListAgent_GetLanguageInfoList
---

# GetLanguageInfoList

```http
POST /api/v1/Agents/List/GetLanguageInfoList
```

Gets an array of LanguageInfo objects.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetLanguageInfoList?$select=name,department,category/id
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

## Request Body: languageInfoIds  

The primary keys. 



## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| LanguageInfoId | int32 | Primary key |
| LCID | int32 | Language/culture id as a numeric .NET code |
| EnglishName | string | English name of this language (Norwegian) |
| NativeName | string | The native name of this language (Norsk Bokmål) |
| ThreeLetterISOLanguageName | string | ISO 3-letter abbreviation |
| TwoLetterISOLanguageName | string | ISO 2-letter abbreviation |
| IsBuiltIn | bool | Has this row been inserted by SuperOffice priming data |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/GetLanguageInfoList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "LanguageInfoId": 47,
    "LCID": 686,
    "EnglishName": "Champlin, Cormier and Kovacek",
    "NativeName": "Gottlieb Group",
    "ThreeLetterISOLanguageName": "Muller, Ankunding and Upton",
    "TwoLetterISOLanguageName": "Daniel-Padberg",
    "IsBuiltIn": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "architect out-of-the-box deliverables"
        },
        "FieldType": "System.Int32",
        "FieldLength": 283
      }
    }
  }
]
```