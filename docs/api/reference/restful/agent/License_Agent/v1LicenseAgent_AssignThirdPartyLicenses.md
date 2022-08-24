---
title: POST Agents/License/AssignThirdPartyLicenses
id: v1LicenseAgent_AssignThirdPartyLicenses
---

# POST Agents/License/AssignThirdPartyLicenses

```http
POST /api/v1/Agents/License/AssignThirdPartyLicenses
```

Assign third party licenses

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/AssignThirdPartyLicenses?$select=name,department,category/id
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

AssociateId, ModuleOwner, ModuleLicenseNames

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 |  |
| ModuleOwner | string |  |
| ModuleLicenseNames | array |  |

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
POST /api/v1/Agents/License/AssignThirdPartyLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 946,
  "ModuleOwner": "libero",
  "ModuleLicenseNames": [
    "Hartmann, Rodriguez and Hermiston",
    "Lockman-Thiel"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Unrestricted": false,
    "Total": 160,
    "Tooltip": "ut",
    "CanAssign": true,
    "Free": 795,
    "InUse": 32,
    "IsHidden": false,
    "Assigned": false,
    "ModuleLicenseId": 463,
    "Name": "Boyer, Greenholt and Heller",
    "Description": "Multi-tiered mobile solution",
    "PrerequisiteModuleName": "Schulist-Gusikowski",
    "SortOrder": 362,
    "ExtraFlags": 662,
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
        "FieldLength": 24
      }
    }
  }
]
```
