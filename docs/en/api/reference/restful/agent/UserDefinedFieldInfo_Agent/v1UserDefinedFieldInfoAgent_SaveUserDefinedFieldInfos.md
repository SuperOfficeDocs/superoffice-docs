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
      "UDefFieldId": 671,
      "ColumnId": 932,
      "FieldDefault": "possimus",
      "FieldHeight": 830,
      "FieldLabel": "voluptas",
      "FieldLeft": 889,
      "FieldTop": 92,
      "FieldType": "Checkbox",
      "FieldWidth": 131,
      "FormatMask": "hic",
      "HideLabel": false,
      "IsIndexed": true,
      "LabelHeight": 40,
      "LabelLeft": 368,
      "LabelTop": 886,
      "LabelWidth": 25,
      "LastVersionId": 672,
      "ListTableId": 591,
      "IsMandatory": true,
      "Type": "Appointment",
      "Page1LineNo": 94,
      "ProgId": "voluptas",
      "IsReadOnly": false,
      "ShortLabel": "pariatur",
      "TabOrder": 624,
      "TextLength": 489,
      "Tooltip": "quos",
      "UdefIdentity": 98,
      "UDListDefinitionId": 840,
      "Justification": "Center",
      "Version": 685,
      "TemplateVariableName": "Quigley, Ebert and Corwin",
      "HasBeenPublished": true,
      "MdoListName": "Williamson, Braun and Predovic"
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