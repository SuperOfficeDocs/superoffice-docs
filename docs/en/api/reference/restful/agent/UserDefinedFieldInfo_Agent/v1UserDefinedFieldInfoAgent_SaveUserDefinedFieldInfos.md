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
      "UDefFieldId": 378,
      "ColumnId": 817,
      "FieldDefault": "officiis",
      "FieldHeight": 17,
      "FieldLabel": "qui",
      "FieldLeft": 2,
      "FieldTop": 986,
      "FieldType": "Checkbox",
      "FieldWidth": 721,
      "FormatMask": "deleniti",
      "HideLabel": false,
      "IsIndexed": true,
      "LabelHeight": 431,
      "LabelLeft": 55,
      "LabelTop": 406,
      "LabelWidth": 327,
      "LastVersionId": 513,
      "ListTableId": 327,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 893,
      "ProgId": "quidem",
      "IsReadOnly": false,
      "ShortLabel": "nesciunt",
      "TabOrder": 825,
      "TextLength": 57,
      "Tooltip": "ipsam",
      "UdefIdentity": 961,
      "UDListDefinitionId": 349,
      "Justification": "Center",
      "Version": 641,
      "TemplateVariableName": "Littel, Rosenbaum and Kessler",
      "HasBeenPublished": true,
      "MdoListName": "Harber, Schaden and Schamberger"
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