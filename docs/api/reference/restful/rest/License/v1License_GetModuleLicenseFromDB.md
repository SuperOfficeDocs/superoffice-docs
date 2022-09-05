---
title: GET License/{ownerName}/{moduleName}
uid: v1License_GetModuleLicenseFromDB
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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

## Sample request

```http!
GET /api/v1/License/{ownerName}/{moduleName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Grant-Kub",
  "ModuleName": "Ondricka, Terry and Balistreri",
  "ModuleDescription": "Implemented cohesive frame",
  "ModuleTooltip": "vitae",
  "ModuleVersion": "assumenda",
  "LicenseType": "SatelliteLicense",
  "Unrestricted": true,
  "AllowedUserType": "AnonymousAssociate",
  "NumberOfLicenses": 458,
  "ExtraFlags": 752,
  "ExtraInfo": "similique",
  "SortOrder": 742,
  "IsHidden": false,
  "PrerequisiteModuleName": "Ziemann-Johnson",
  "Signature": "repellendus"
}
```