---
title: GET License/{moduleOwner}/{id}
id: v1License_GetThirdPartyLicenseAssignments
---

# GET License/{moduleOwner}/{id}

```http
GET /api/v1/License/{moduleOwner}/{associateId}
```

Get license assignments for an associate for licenses belonging to an other module owner than SuperOffice






| Path Part | Type | Description |
|-----------|------|-------------|
| associateId | int32 | User to get third party license assignments for **Required** |
| moduleOwner | string | Name of the module owner to get license assignments for **Required** |



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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Unrestricted | bool | Is this module license restricted or unrestricted |
| Total | int32 | The total number of module licenses. In other words the number of free license added to the number of licenses in use equals the total number of licenses |
| Tooltip | string | The tooltip to be shown in some gui with details on the module license |
| CanAssign | bool | Can a specific user assign this module license |
| Free | int32 | The number of licenses that are free to be assigned |
| InUse | int32 | The total number of licenses (of a given license module) that are occupied |
| IsHidden | bool | Is hidden from UI |
| Assigned | bool | Is the module license assigned to a given user? |
| ModuleLicenseId | int32 | The identifier of the module license |
| Name | string | The name of the module license |
| Description | string | The description of the module license |
| PrerequisiteModuleName | string | Name of module that must be active for this license to be used. |
| SortOrder | int32 | Sort order of licenses. |
| ExtraFlags | int32 | License flags. 1 = user plan |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/License/{moduleOwner}/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Unrestricted": true,
    "Total": 632,
    "Tooltip": "dolores",
    "CanAssign": false,
    "Free": 841,
    "InUse": 494,
    "IsHidden": true,
    "Assigned": false,
    "ModuleLicenseId": 166,
    "Name": "Corwin Inc and Sons",
    "Description": "Total contextually-based knowledge base",
    "PrerequisiteModuleName": "Collier, Klein and Schumm",
    "SortOrder": 473,
    "ExtraFlags": 289,
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
        "FieldType": "System.Int32",
        "FieldLength": 148
      }
    }
  }
]
```