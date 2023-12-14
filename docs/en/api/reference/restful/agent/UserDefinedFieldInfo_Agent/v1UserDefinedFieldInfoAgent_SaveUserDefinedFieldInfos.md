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
      "UDefFieldId": 876,
      "ColumnId": 344,
      "FieldDefault": "earum",
      "FieldHeight": 905,
      "FieldLabel": "ratione",
      "FieldLeft": 3,
      "FieldTop": 574,
      "FieldType": "Checkbox",
      "FieldWidth": 520,
      "FormatMask": "debitis",
      "HideLabel": false,
      "IsIndexed": false,
      "LabelHeight": 297,
      "LabelLeft": 315,
      "LabelTop": 150,
      "LabelWidth": 667,
      "LastVersionId": 255,
      "ListTableId": 56,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 464,
      "ProgId": "culpa",
      "IsReadOnly": false,
      "ShortLabel": "quis",
      "TabOrder": 347,
      "TextLength": 974,
      "Tooltip": "quam",
      "UdefIdentity": 756,
      "UDListDefinitionId": 718,
      "Justification": "Center",
      "Version": 290,
      "TemplateVariableName": "Hackett-Johnson",
      "HasBeenPublished": false,
      "MdoListName": "Borer, Borer and Stracke"
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