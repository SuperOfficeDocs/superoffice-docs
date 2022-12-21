---
title: POST Agents/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension
uid: v1TargetsAgent_CreateDefaultTargetAssignmentForCompanyWithYearAndDimension
---

# POST Agents/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension

```http
POST /api/v1/Agents/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension
```

Returns a default target assignment for the owner company, for the specified year and dimension.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension?$select=name,department,category/id
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

Year, TargetDimensionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Year | int32 |  |
| TargetDimensionId | int32 |  |


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetAssignmentInfoId | int32 | Primary key |
| Values | array | Values of the target; all periods; in ascending order. |
| Locked | bool | Locked, should not be editable |
| TargetAssociate |  | The associate this target is set for. Only one of TargetAssociate, TargetContact and TargetUserGroup will be set for a target. |
| TargetContact |  | The contact this target is set for. Only one of TargetAssociate, TargetContact and TargetUserGroup will be set for a target. |
| TargetUserGroup |  | The usergroup this target is set for. Only one of TargetAssociate, TargetContact and TargetUserGroup will be set for a target. |
| Currency |  | The currency of the target.  <para>Use MDO List name "currency" to get list items.</para> |
| DimensionListItem | int32 | Id of the dimension list item this assignement is for |
| DimensionListItemDisplayName | string | Display name of the dimension list item this assignement is for. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Targets/CreateDefaultTargetAssignmentForCompanyWithYearAndDimension
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Year": 146,
  "TargetDimensionId": 258
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TargetAssignmentInfoId": 877,
    "Values": [
      234,
      578
    ],
    "Locked": false,
    "TargetAssociate": null,
    "TargetContact": null,
    "TargetUserGroup": null,
    "Currency": null,
    "DimensionListItem": 795,
    "DimensionListItemDisplayName": "Koch-Parisian",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 3
      }
    }
  }
]
```