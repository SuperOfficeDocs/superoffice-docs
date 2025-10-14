---
title: POST Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos
uid: v1UserDefinedFieldInfoAgent_SaveUserDefinedFieldInfos
generated: true
content_type: reference
---

# POST Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos

```http
POST /api/v1/Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfos
```

Save an array of user defined fields.


This will update the unpublished layout.
NsApiSlow threshold: 5000 ms.






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
      "UDefFieldId": 480,
      "ColumnId": 245,
      "FieldDefault": "hic",
      "FieldHeight": 231,
      "FieldLabel": "minus",
      "FieldLeft": 111,
      "FieldTop": 310,
      "FieldType": "Checkbox",
      "FieldWidth": 577,
      "FormatMask": "enim",
      "HideLabel": false,
      "IsIndexed": false,
      "LabelHeight": 482,
      "LabelLeft": 454,
      "LabelTop": 517,
      "LabelWidth": 295,
      "LastVersionId": 40,
      "ListTableId": 794,
      "IsMandatory": true,
      "Type": "Appointment",
      "Page1LineNo": 391,
      "ProgId": "placeat",
      "IsReadOnly": false,
      "ShortLabel": "aut",
      "TabOrder": 163,
      "TextLength": 345,
      "Tooltip": "quo",
      "UdefIdentity": 226,
      "UDListDefinitionId": 774,
      "Justification": "Center",
      "Version": 363,
      "TemplateVariableName": "Adams-McClure",
      "HasBeenPublished": false,
      "MdoListName": "West, Altenwerth and Runte"
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