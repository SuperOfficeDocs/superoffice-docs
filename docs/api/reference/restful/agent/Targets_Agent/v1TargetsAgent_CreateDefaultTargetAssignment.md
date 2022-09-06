---
title: POST Agents/Targets/CreateDefaultTargetAssignment
uid: v1TargetsAgent_CreateDefaultTargetAssignment
---

# POST Agents/Targets/CreateDefaultTargetAssignment

```http
POST /api/v1/Agents/Targets/CreateDefaultTargetAssignment
```

Set default values into a new TargetAssignment.

NetServer calculates default values on the entity, which is required when creating/storing a new instance

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Targets/CreateDefaultTargetAssignment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TargetAssignmentInfoId": 949,
  "Values": [
    940,
    306
  ],
  "Locked": false,
  "TargetAssociate": null,
  "TargetContact": null,
  "TargetUserGroup": null,
  "Currency": null,
  "DimensionListItem": 550,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 355
    }
  }
}
```
