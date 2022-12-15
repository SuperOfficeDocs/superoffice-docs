---
title: GET License/Site/{id}
uid: v1License_GetSatelliteLicenses
---

# GET License/Site/{id}

```http
GET /api/v1/License/Site/{satelliteId}
```

Obtain information about satellite module licenses






| Path Part | Type | Description |
|-----------|------|-------------|
| satelliteId | int32 | Satellite id to check for satellite module licenses **Required** |



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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The name of the license owner |
| Description | string |  |
| RestrictedModuleLicenses | array |  |
| UnrestrictedModuleLicenses | array | The unrestricted module licenses that this license owner |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/License/Site/{satelliteId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Walsh LLC",
    "Description": "Proactive heuristic help-desk",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 324,
        "Tooltip": "ut",
        "CanAssign": true,
        "Free": 492,
        "InUse": 739,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 41,
        "Name": "Lehner, Harvey and Dickinson",
        "Description": "Stand-alone stable definition",
        "PrerequisiteModuleName": "Orn Group",
        "SortOrder": 831,
        "ExtraFlags": 38,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 63
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 749,
        "Tooltip": "libero",
        "CanAssign": false,
        "Free": 515,
        "InUse": 126,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 773,
        "Name": "Heaney, Harvey and Cummings",
        "Description": "Ameliorated client-driven internet solution",
        "PrerequisiteModuleName": "Schaden Group",
        "SortOrder": 770,
        "ExtraFlags": 590,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 44
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 4
      }
    }
  },
  {
    "Name": "Walsh LLC",
    "Description": "Proactive heuristic help-desk",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 324,
        "Tooltip": "ut",
        "CanAssign": true,
        "Free": 492,
        "InUse": 739,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 41,
        "Name": "Lehner, Harvey and Dickinson",
        "Description": "Stand-alone stable definition",
        "PrerequisiteModuleName": "Orn Group",
        "SortOrder": 831,
        "ExtraFlags": 38,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 63
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 749,
        "Tooltip": "libero",
        "CanAssign": false,
        "Free": 515,
        "InUse": 126,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 773,
        "Name": "Heaney, Harvey and Cummings",
        "Description": "Ameliorated client-driven internet solution",
        "PrerequisiteModuleName": "Schaden Group",
        "SortOrder": 770,
        "ExtraFlags": 590,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 44
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 4
      }
    }
  }
]
```