---
title: POST Agents/List/SaveRelationDefinitionEntity
id: v1ListAgent_SaveRelationDefinitionEntity
---

# POST Agents/List/SaveRelationDefinitionEntity

```http
POST /api/v1/Agents/List/SaveRelationDefinitionEntity
```

Updates the existing RelationDefinitionEntity or creates a new RelationDefinitionEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity  

The RelationDefinitionEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReldefId | int32 | Primary key |
| Name | string | Active text |
| Tooltip | string | Tooltip or other description |
| PassiveText | string | Text used in passive direction |
| Deleted | bool | True if deleted |
| Rank | int32 | Rank order |
| Source | string | The source of the relation |
| Destination | string | The destination of the relation |


## Response: object

A relation definition entity with source and destination tables



Carrier object for RelationDefinitionEntity.
Services for the RelationDefinitionEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReldefId | int32 | Primary key |
| Name | string | Active text |
| Tooltip | string | Tooltip or other description |
| PassiveText | string | Text used in passive direction |
| Deleted | bool | True if deleted |
| Rank | int32 | Rank order |
| Source | string | The source of the relation |
| Destination | string | The destination of the relation |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/SaveRelationDefinitionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 175,
  "Name": "Trantow-Bogan",
  "Tooltip": "sapiente",
  "PassiveText": "modi",
  "Deleted": false,
  "Rank": 757,
  "Source": "Both",
  "Destination": "Both"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 271,
  "Name": "Pouros-Kihn",
  "Tooltip": "fugiat",
  "PassiveText": "molestiae",
  "Deleted": false,
  "Rank": 473,
  "Source": "Both",
  "Destination": "Both",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 746
    }
  }
}
```