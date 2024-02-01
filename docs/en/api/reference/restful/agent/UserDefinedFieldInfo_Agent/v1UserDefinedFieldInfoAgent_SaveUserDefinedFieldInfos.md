---
title: POST Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos
uid: v1UserDefinedFieldInfoAgent_SaveUserDefinedFieldInfos
generated: true
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
      "UDefFieldId": 329,
      "ColumnId": 839,
      "FieldDefault": "qui",
      "FieldHeight": 448,
      "FieldLabel": "assumenda",
      "FieldLeft": 871,
      "FieldTop": 168,
      "FieldType": "Checkbox",
      "FieldWidth": 934,
      "FormatMask": "quae",
      "HideLabel": false,
      "IsIndexed": true,
      "LabelHeight": 115,
      "LabelLeft": 523,
      "LabelTop": 387,
      "LabelWidth": 883,
      "LastVersionId": 33,
      "ListTableId": 294,
      "IsMandatory": true,
      "Type": "Appointment",
      "Page1LineNo": 516,
      "ProgId": "saepe",
      "IsReadOnly": false,
      "ShortLabel": "et",
      "TabOrder": 163,
      "TextLength": 973,
      "Tooltip": "eos",
      "UdefIdentity": 115,
      "UDListDefinitionId": 108,
      "Justification": "Center",
      "Version": 183,
      "TemplateVariableName": "Morissette, Aufderhar and Jenkins",
      "HasBeenPublished": false,
      "MdoListName": "Parker-Luettgen"
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