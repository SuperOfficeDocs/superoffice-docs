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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Infos": [
    {
      "UDefFieldId": 337,
      "ColumnId": 339,
      "FieldDefault": "repudiandae",
      "FieldHeight": 117,
      "FieldLabel": "voluptas",
      "FieldLeft": 671,
      "FieldTop": 943,
      "FieldType": "Checkbox",
      "FieldWidth": 18,
      "FormatMask": "voluptas",
      "HideLabel": true,
      "IsIndexed": true,
      "LabelHeight": 940,
      "LabelLeft": 400,
      "LabelTop": 292,
      "LabelWidth": 309,
      "LastVersionId": 430,
      "ListTableId": 586,
      "IsMandatory": true,
      "Type": "Appointment",
      "Page1LineNo": 894,
      "ProgId": "et",
      "IsReadOnly": false,
      "ShortLabel": "molestiae",
      "TabOrder": 987,
      "TextLength": 905,
      "Tooltip": "excepturi",
      "UdefIdentity": 438,
      "UDListDefinitionId": 573,
      "Justification": "Center",
      "Version": 957,
      "TemplateVariableName": "Nienow LLC",
      "HasBeenPublished": true,
      "MdoListName": "Sawayn Inc and Sons"
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