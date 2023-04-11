---
title: POST Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos
uid: v1UserDefinedFieldInfoAgent_SaveUserDefinedFieldInfos
---

# POST Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos

```http
POST /api/v1/Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos
```

Save an array of user defined fields.


This will update the unpublished layout.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

Infos 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Infos | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Infos": [
    {
      "UDefFieldId": 281,
      "ColumnId": 67,
      "FieldDefault": "sed",
      "FieldHeight": 418,
      "FieldLabel": "animi",
      "FieldLeft": 384,
      "FieldTop": 706,
      "FieldType": "Checkbox",
      "FieldWidth": 392,
      "FormatMask": "quia",
      "HideLabel": false,
      "IsIndexed": false,
      "LabelHeight": 775,
      "LabelLeft": 815,
      "LabelTop": 330,
      "LabelWidth": 1000,
      "LastVersionId": 574,
      "ListTableId": 254,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 652,
      "ProgId": "et",
      "IsReadOnly": false,
      "ShortLabel": "culpa",
      "TabOrder": 934,
      "TextLength": 576,
      "Tooltip": "odio",
      "UdefIdentity": 554,
      "UDListDefinitionId": 199,
      "Justification": "Center",
      "Version": 861,
      "TemplateVariableName": "Fisher, Rogahn and Bergstrom",
      "HasBeenPublished": false,
      "MdoListName": "Sanford Group"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```