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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Infos": [
    {
      "UDefFieldId": 736,
      "ColumnId": 38,
      "FieldDefault": "perferendis",
      "FieldHeight": 449,
      "FieldLabel": "temporibus",
      "FieldLeft": 11,
      "FieldTop": 319,
      "FieldType": "Checkbox",
      "FieldWidth": 779,
      "FormatMask": "esse",
      "HideLabel": false,
      "IsIndexed": false,
      "LabelHeight": 270,
      "LabelLeft": 634,
      "LabelTop": 898,
      "LabelWidth": 861,
      "LastVersionId": 416,
      "ListTableId": 427,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 887,
      "ProgId": "velit",
      "IsReadOnly": false,
      "ShortLabel": "nostrum",
      "TabOrder": 726,
      "TextLength": 295,
      "Tooltip": "sequi",
      "UdefIdentity": 2,
      "UDListDefinitionId": 481,
      "Justification": "Center",
      "Version": 291,
      "TemplateVariableName": "Leuschke Inc and Sons",
      "HasBeenPublished": false,
      "MdoListName": "Morar-Krajcik"
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