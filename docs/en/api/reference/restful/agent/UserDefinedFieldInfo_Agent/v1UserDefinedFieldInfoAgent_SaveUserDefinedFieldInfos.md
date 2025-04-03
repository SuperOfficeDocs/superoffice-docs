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
      "UDefFieldId": 307,
      "ColumnId": 224,
      "FieldDefault": "maiores",
      "FieldHeight": 172,
      "FieldLabel": "at",
      "FieldLeft": 349,
      "FieldTop": 461,
      "FieldType": "Checkbox",
      "FieldWidth": 33,
      "FormatMask": "autem",
      "HideLabel": false,
      "IsIndexed": false,
      "LabelHeight": 42,
      "LabelLeft": 8,
      "LabelTop": 15,
      "LabelWidth": 997,
      "LastVersionId": 552,
      "ListTableId": 41,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 846,
      "ProgId": "a",
      "IsReadOnly": false,
      "ShortLabel": "est",
      "TabOrder": 234,
      "TextLength": 644,
      "Tooltip": "quo",
      "UdefIdentity": 127,
      "UDListDefinitionId": 538,
      "Justification": "Center",
      "Version": 206,
      "TemplateVariableName": "Sanford-Blanda",
      "HasBeenPublished": true,
      "MdoListName": "Wilderman-Emmerich"
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