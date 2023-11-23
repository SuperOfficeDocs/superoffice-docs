---
title: POST Agents/Targets/GetTargetAssignmentForYearAndDimension
uid: v1TargetsAgent_GetTargetAssignmentForYearAndDimension
generated: true
---

# POST Agents/Targets/GetTargetAssignmentForYearAndDimension

```http
POST /api/v1/Agents/Targets/GetTargetAssignmentForYearAndDimension
```

Returns the target assignment for the specified year, entity type and dimension.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Targets/GetTargetAssignmentForYearAndDimension?$select=name,department,category/id
```


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

## Request Body: request 

TargetYear, EntityType, TargetLevel, Id, DimensionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetYear | Integer |  |
| EntityType | String |  |
| TargetLevel | String |  |
| Id | Integer |  |
| DimensionId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TargetAssignment

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetAssignmentInfoId | int32 | Primary key |
| Values | array | Values of the target; all periods; in ascending order. |
| Locked | bool | Locked, should not be editable |
| TargetAssociate | Associate | The associate this target is set for. Only one of TargetAssociate, TargetContact and TargetUserGroup will be set for a target. |
| TargetContact | Contact | The contact this target is set for. Only one of TargetAssociate, TargetContact and TargetUserGroup will be set for a target. |
| TargetUserGroup | UserGroup | The usergroup this target is set for. Only one of TargetAssociate, TargetContact and TargetUserGroup will be set for a target. |
| Currency | Currency | The currency of the target.  <para>Use MDO List name "currency" to get list items.</para> |
| DimensionListItem | int32 | Id of the dimension list item this assignement is for |
| DimensionListItemDisplayName | string | Display name of the dimension list item this assignement is for. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Targets/GetTargetAssignmentForYearAndDimension
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TargetYear": 348,
  "EntityType": "None",
  "TargetLevel": "Associate",
  "Id": 3,
  "DimensionId": 728
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TargetAssignmentInfoId": 86,
  "Values": [
    629,
    115
  ],
  "Locked": false,
  "TargetAssociate": null,
  "TargetContact": null,
  "TargetUserGroup": null,
  "Currency": null,
  "DimensionListItem": 267,
  "DimensionListItemDisplayName": "Grimes, Streich and Marquardt",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 34
    }
  }
}
```