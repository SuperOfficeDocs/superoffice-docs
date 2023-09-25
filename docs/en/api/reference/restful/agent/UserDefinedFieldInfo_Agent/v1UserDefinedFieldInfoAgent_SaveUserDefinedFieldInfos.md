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
      "UDefFieldId": 973,
      "ColumnId": 217,
      "FieldDefault": "nemo",
      "FieldHeight": 628,
      "FieldLabel": "sint",
      "FieldLeft": 334,
      "FieldTop": 370,
      "FieldType": "Checkbox",
      "FieldWidth": 775,
      "FormatMask": "amet",
      "HideLabel": true,
      "IsIndexed": true,
      "LabelHeight": 637,
      "LabelLeft": 357,
      "LabelTop": 85,
      "LabelWidth": 225,
      "LastVersionId": 917,
      "ListTableId": 564,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 283,
      "ProgId": "doloremque",
      "IsReadOnly": false,
      "ShortLabel": "nostrum",
      "TabOrder": 741,
      "TextLength": 125,
      "Tooltip": "a",
      "UdefIdentity": 463,
      "UDListDefinitionId": 796,
      "Justification": "Center",
      "Version": 617,
      "TemplateVariableName": "Wehner Group",
      "HasBeenPublished": true,
      "MdoListName": "Kautzer LLC"
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