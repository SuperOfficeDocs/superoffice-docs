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
      "UDefFieldId": 359,
      "ColumnId": 672,
      "FieldDefault": "architecto",
      "FieldHeight": 54,
      "FieldLabel": "dolore",
      "FieldLeft": 535,
      "FieldTop": 541,
      "FieldType": "Checkbox",
      "FieldWidth": 644,
      "FormatMask": "nesciunt",
      "HideLabel": true,
      "IsIndexed": true,
      "LabelHeight": 58,
      "LabelLeft": 565,
      "LabelTop": 767,
      "LabelWidth": 974,
      "LastVersionId": 70,
      "ListTableId": 264,
      "IsMandatory": false,
      "Type": "Appointment",
      "Page1LineNo": 388,
      "ProgId": "adipisci",
      "IsReadOnly": false,
      "ShortLabel": "quo",
      "TabOrder": 842,
      "TextLength": 516,
      "Tooltip": "delectus",
      "UdefIdentity": 446,
      "UDListDefinitionId": 710,
      "Justification": "Center",
      "Version": 300,
      "TemplateVariableName": "Morar, Feeney and Effertz",
      "HasBeenPublished": false,
      "MdoListName": "Carroll Group"
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