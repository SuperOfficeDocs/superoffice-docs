---
title: POST Agents/License/GetModuleLicenseFromDB
uid: v1LicenseAgent_GetModuleLicenseFromDB
generated: true
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
| OwnerName | String |  |
| ModuleName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TimeZoneData

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Dickinson LLC",
  "ModuleName": "Marks-Crist"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Rosenbaum, Parker and Purdy",
  "ModuleName": "Spencer Inc and Sons",
  "ModuleDescription": "Virtual content-based collaboration",
  "ModuleTooltip": "minima",
  "ModuleVersion": "sequi",
  "LicenseType": "SatelliteLicense",
  "Unrestricted": true,
  "AllowedUserType": "AnonymousAssociate",
  "NumberOfLicenses": 698,
  "ExtraFlags": 639,
  "ExtraInfo": "expedita",
  "SortOrder": 191,
  "IsHidden": false,
  "PrerequisiteModuleName": "Deckow, Morissette and Davis",
  "Signature": "et"
}
```