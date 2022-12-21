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


## Response: 

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
      "UDefFieldId": 598,
      "ColumnId": 914,
      "FieldDefault": "ad",
      "FieldHeight": 738,
      "FieldLabel": "ut",
      "FieldLeft": 703,
      "FieldTop": 621,
      "FieldType": "Checkbox",
      "FieldWidth": 881,
      "FormatMask": "fugiat",
      "HideLabel": false,
      "IsIndexed": true,
      "LabelHeight": 704,
      "LabelLeft": 925,
      "LabelTop": 176,
      "LabelWidth": 902,
      "LastVersionId": 869,
      "ListTableId": 953,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 381,
      "ProgId": "nihil",
      "IsReadOnly": false,
      "ShortLabel": "nisi",
      "TabOrder": 474,
      "TextLength": 123,
      "Tooltip": "autem",
      "UdefIdentity": 847,
      "UDListDefinitionId": 933,
      "Justification": "Center",
      "Version": 720,
      "TemplateVariableName": "Jacobson, Simonis and Jaskolski",
      "HasBeenPublished": false,
      "MdoListName": "Bode, Oberbrunner and Johns"
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