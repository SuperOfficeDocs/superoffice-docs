---
title: GET User/CustomField
id: v1User_GetCustomFieldInfoList
---

# GET User/CustomField

```http
GET /api/v1/User/CustomField
```

Custom fields meta-data (published user defined + extra fields) on User.

Excludes standard fields.






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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| FieldType | string | What sort of data does this field contain. 1 = int, 2 = short text, ... |
| FieldName | string | Database name or prog-id: 'x_foobar' or 'SuperOffice:2'. |
| DisplayName | string | Label for field. May be multi-lang string encoded. |
| Description | string | Optional tooltip text for this field |
| ShortLabel | string | Short name to be used in Archive headings and on page 1. If blank, the fieldLabel will be used everywhere. |
| HideLabel | bool | Hide the label if 1 |
| HideField | bool | Hide the field from the UI. Only allow API access. |
| IsIndexed | bool | Is this field indexed? 0 if no, index no. if yes |
| IsMandatory | bool | 0 = no, 1 = yes (field must be filled out) |
| IsReadOnly | bool | 0 = read/write, 1 = readonly (don't combine with mandatory  8-) ) |
| IsExternal | bool | Should this field be shown to external users via customer center? |
| Rank | int32 | Tab order, ranking within the custom fields. |
| TemplateVariableName | string | Template variable name: 'cs01', 'cl02' etc. Null for extra fields. |

## Sample Request

```http!
GET /api/v1/User/CustomField
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "FieldType": "Attachment",
    "FieldName": "Haley, Ortiz and Corkery",
    "DisplayName": "Stokes Group",
    "Description": "Fully-configurable well-modulated Graphic Interface",
    "ShortLabel": "repellat",
    "HideLabel": false,
    "HideField": true,
    "IsIndexed": false,
    "IsMandatory": false,
    "IsReadOnly": false,
    "IsExternal": false,
    "Rank": 438,
    "TemplateVariableName": "Hills-Homenick"
  }
]
```