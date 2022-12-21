---
title: POST Agents/License/GetModuleLicenseFromDB
uid: v1LicenseAgent_GetModuleLicenseFromDB
---

# POST Agents/License/GetModuleLicenseFromDB

```http
POST /api/v1/Agents/License/GetModuleLicenseFromDB
```

Get license information for one particular license module.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetModuleLicenseFromDB?$select=name,department,category/id
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

OwnerName, ModuleName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerName | string |  |
| ModuleName | string |  |


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
POST /api/v1/Agents/License/GetModuleLicenseFromDB
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Lowe, Boyer and Ryan",
  "ModuleName": "Lockman LLC"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Hansen, Crooks and Collier",
  "ModuleName": "Crist-Ryan",
  "ModuleDescription": "Universal disintermediate internet solution",
  "ModuleTooltip": "enim",
  "ModuleVersion": "eius",
  "LicenseType": "SatelliteLicense",
  "Unrestricted": true,
  "AllowedUserType": "AnonymousAssociate",
  "NumberOfLicenses": 192,
  "ExtraFlags": 925,
  "ExtraInfo": "suscipit",
  "SortOrder": 314,
  "IsHidden": false,
  "PrerequisiteModuleName": "Rogahn, Crist and Schuppe",
  "Signature": "vel"
}
```