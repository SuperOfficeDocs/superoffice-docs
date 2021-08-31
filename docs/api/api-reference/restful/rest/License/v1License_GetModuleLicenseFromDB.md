---
title: GET License/{ownerName}/{moduleName}
id: v1License_GetModuleLicenseFromDB
---

# GET License/{ownerName}/{moduleName}

```http
GET /api/v1/License/{ownerName}/{moduleName}
```

Get license information for one particular license module.






| Path Part | Type | Description |
|-----------|------|-------------|
| ownerName | string | Name of the module owner. **Required** |
| moduleName | string | Name of the license module. **Required** |



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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerName | string |  |
| ModuleName | string |  |
| ModuleDescription | string |  |
| ModuleTooltip | string |  |
| ModuleVersion | string |  |
| LicenseType | string |  |
| Unrestricted | bool |  |
| AllowedUserType | string |  |
| NumberOfLicenses | int32 |  |
| ExtraFlags | int32 |  |
| ExtraInfo | string |  |
| SortOrder | int32 |  |
| IsHidden | bool |  |
| PrerequisiteModuleName | string |  |
| Signature | string |  |

## Sample Request

```http!
GET /api/v1/License/{ownerName}/{moduleName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "West Inc and Sons",
  "ModuleName": "Bogan Group",
  "ModuleDescription": "Configurable stable support",
  "ModuleTooltip": "magnam",
  "ModuleVersion": "iusto",
  "LicenseType": "SatelliteLicense",
  "Unrestricted": false,
  "AllowedUserType": "AnonymousAssociate",
  "NumberOfLicenses": 348,
  "ExtraFlags": 351,
  "ExtraInfo": "aut",
  "SortOrder": 46,
  "IsHidden": false,
  "PrerequisiteModuleName": "Stiedemann LLC",
  "Signature": "exercitationem"
}
```