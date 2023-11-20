---
title: PUT PreferenceDescriptionLine/{id}
uid: v1PreferenceDescriptionLine_PutPreferenceDescriptionLine
generated: true
---

# PUT PreferenceDescriptionLine/{id}

```http
PUT /api/v1/PreferenceDescriptionLine/{id}
```

Updates the existing PreferenceDescriptionLine






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PreferenceDescriptionLine id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/PreferenceDescriptionLine/{id}?$select=name,department,category/id
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

## Request Body: entity 

The PreferenceDescriptionLine to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescLineId | Integer | Primary key |
| PrefDescId | Integer | Preference description (parent) |
| PrefValue | String | Possible value |
| PrefShowValue | String | Descriptive value, multilang-parsed, to put in list |
| Description | String | Description of preference value, multi-language parsed |
| IsBuiltin | Boolean | 1 = This row populated and maintained by SuperOffice |

## Response:

PreferenceDescriptionLine updated.

| Response | Description |
|----------------|-------------|
| 200 | PreferenceDescriptionLine updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: PreferenceDescriptionLineWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefDescLineId | int32 | Primary key |
| PrefDescId | int32 | Preference description (parent) |
| PrefValue | string | Possible value |
| PrefShowValue | string | Descriptive value, multilang-parsed, to put in list |
| Description | string | Description of preference value, multi-language parsed |
| IsBuiltin | bool | 1 = This row populated and maintained by SuperOffice |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/PreferenceDescriptionLine/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PrefDescLineId": 307,
  "PrefDescId": 549,
  "PrefValue": "ducimus",
  "PrefShowValue": "deserunt",
  "Description": "Customer-focused user-facing attitude",
  "IsBuiltin": false
}
```

## Sample response

```http_
HTTP/1.1 200 PreferenceDescriptionLine updated.
Content-Type: application/json; charset=utf-8

{
  "PrefDescLineId": 476,
  "PrefDescId": 170,
  "PrefValue": "qui",
  "PrefShowValue": "provident",
  "Description": "Progressive interactive challenge",
  "IsBuiltin": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 965
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```