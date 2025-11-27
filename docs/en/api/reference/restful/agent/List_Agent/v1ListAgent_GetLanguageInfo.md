---
title: POST Agents/List/GetLanguageInfo
uid: v1ListAgent_GetLanguageInfo
generated: true
content_type: reference
---

# POST Agents/List/GetLanguageInfo

```http
POST /api/v1/Agents/List/GetLanguageInfo
```

Gets a LanguageInfo object.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| languageInfoId | int32 | **Required** The identifier of the LanguageInfo object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetLanguageInfo?languageInfoId=287
POST /api/v1/Agents/List/GetLanguageInfo?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: LanguageInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| LanguageInfoId | int32 | Primary key |
| LCID | int32 | Language/culture id as a numeric .NET code |
| EnglishName | string | English name of this language (Norwegian) |
| NativeName | string | The native name of this language (Norsk Bokmål) |
| ThreeLetterISOLanguageName | string | ISO 3-letter abbreviation |
| TwoLetterISOLanguageName | string | ISO 2-letter abbreviation |
| IsBuiltIn | bool | Has this row been inserted by SuperOffice priming data |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1ListAgent_GetLanguageInfo.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_GetLanguageInfo.md)]