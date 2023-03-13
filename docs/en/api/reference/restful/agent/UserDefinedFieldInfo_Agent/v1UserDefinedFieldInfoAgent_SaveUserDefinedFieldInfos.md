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

### Response body: TableRight


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
      "UDefFieldId": 713,
      "ColumnId": 471,
      "FieldDefault": "doloribus",
      "FieldHeight": 110,
      "FieldLabel": "in",
      "FieldLeft": 887,
      "FieldTop": 280,
      "FieldType": "Checkbox",
      "FieldWidth": 741,
      "FormatMask": "facere",
      "HideLabel": false,
      "IsIndexed": false,
      "LabelHeight": 75,
      "LabelLeft": 982,
      "LabelTop": 41,
      "LabelWidth": 999,
      "LastVersionId": 474,
      "ListTableId": 990,
      "IsMandatory": true,
      "Type": "Appointment",
      "Page1LineNo": 513,
      "ProgId": "aut",
      "IsReadOnly": false,
      "ShortLabel": "est",
      "TabOrder": 835,
      "TextLength": 234,
      "Tooltip": "corrupti",
      "UdefIdentity": 254,
      "UDListDefinitionId": 373,
      "Justification": "Center",
      "Version": 251,
      "TemplateVariableName": "Herzog, Kertzmann and Wuckert",
      "HasBeenPublished": true,
      "MdoListName": "Bosco-Blick"
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