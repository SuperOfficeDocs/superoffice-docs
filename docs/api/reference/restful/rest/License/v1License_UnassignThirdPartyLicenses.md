---
title: DEL License/{moduleOwner}/{id}
id: v1License_UnassignThirdPartyLicenses
---

# DEL License/{moduleOwner}/{id}

```http
DELETE /api/v1/License/{moduleOwner}/{associateId}
```

Unassign (remove) third party licenses






| Path Part | Type | Description |
|-----------|------|-------------|
| associateId | int32 | User to unassign third party licenses for **Required** |
| moduleOwner | string | Name of the module owner to unassign license for **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: moduleLicenseNames  

Name of module licenses to unassign (remove) 



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
DELETE /api/v1/License/{moduleOwner}/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Unrestricted": true,
    "Total": 366,
    "Tooltip": "ex",
    "CanAssign": false,
    "Free": 293,
    "InUse": 738,
    "IsHidden": true,
    "Assigned": false,
    "ModuleLicenseId": 526,
    "Name": "Kuhn, Gerhold and Ullrich",
    "Description": "Multi-channelled leading edge internet solution",
    "PrerequisiteModuleName": "Kutch, Heathcote and Hackett",
    "SortOrder": 119,
    "ExtraFlags": 963,
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
        "FieldLength": 113
      }
    }
  }
]
```