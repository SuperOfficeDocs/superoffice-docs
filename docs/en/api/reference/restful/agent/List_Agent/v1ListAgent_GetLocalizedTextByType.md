---
title: POST Agents/List/GetLocalizedTextByType
uid: v1ListAgent_GetLocalizedTextByType
generated: true
---

# POST Agents/List/GetLocalizedTextByType

```http
POST /api/v1/Agents/List/GetLocalizedTextByType
```

Returns a localized text based on the resource id for the selected language.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetLocalizedTextByType?$select=name,department,category/id
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

TextType, ResourceId, LanguageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TextType | String |  |
| ResourceId | Integer |  |
| LanguageId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: LocalizedText

| Property Name | Type |  Description |
|----------------|------|--------------|
| LanguageId | int32 | Language id as LCID value |
| ResourceId | int32 | Resource ID |
| Text | string | The text string itself |
| Type | string | The type of the text string, e.g. Field label, Udef label, etc. |
| LocalizedTextId | int32 | Primary key |
| IsBuiltIn | bool | 1 = this row is populated and maintained by SuperOffice |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/GetLocalizedTextByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TextType": "Column",
  "ResourceId": 402,
  "LanguageId": 478
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "LanguageId": 466,
  "ResourceId": 228,
  "Text": "ab",
  "Type": "Column",
  "LocalizedTextId": 314,
  "IsBuiltIn": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 257
    }
  }
}
```