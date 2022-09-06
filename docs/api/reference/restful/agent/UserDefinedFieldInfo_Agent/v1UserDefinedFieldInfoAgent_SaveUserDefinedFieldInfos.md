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
| Infos | array |  |

## Response

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body:

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
      "UDefFieldId": 892,
      "ColumnId": 424,
      "FieldDefault": "ut",
      "FieldHeight": 220,
      "FieldLabel": "maiores",
      "FieldLeft": 96,
      "FieldTop": 811,
      "FieldType": "Checkbox",
      "FieldWidth": 472,
      "FormatMask": "et",
      "HideLabel": true,
      "IsIndexed": true,
      "LabelHeight": 761,
      "LabelLeft": 512,
      "LabelTop": 964,
      "LabelWidth": 827,
      "LastVersionId": 570,
      "ListTableId": 744,
      "IsMandatory": true,
      "Type": "Appointment",
      "Page1LineNo": 781,
      "ProgId": "praesentium",
      "IsReadOnly": false,
      "ShortLabel": "cumque",
      "TabOrder": 715,
      "TextLength": 786,
      "Tooltip": "et",
      "UdefIdentity": 293,
      "UDListDefinitionId": 68,
      "Justification": "Center",
      "Version": 994,
      "TemplateVariableName": "Stokes LLC",
      "HasBeenPublished": true,
      "MdoListName": "Harber, Yost and Weissnat"
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
