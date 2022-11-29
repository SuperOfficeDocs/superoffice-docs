---
title: GET License/User/{id}
uid: v1License_GetUserLicenses
---

# GET License/User/{id}

```http
GET /api/v1/License/User/{associateId}
```

Obtain information about associate module licenses






| Path Part | Type | Description |
|-----------|------|-------------|
| associateId | int32 | Associate id to check for associate module licenses **Required** |



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
GET /api/v1/License/User/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Bosco, Moen and Kautzer",
    "Description": "Advanced didactic structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 58,
        "Tooltip": "asperiores",
        "CanAssign": false,
        "Free": 659,
        "InUse": 983,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 445,
        "Name": "Ankunding Inc and Sons",
        "Description": "Progressive mission-critical capacity",
        "PrerequisiteModuleName": "Kreiger, Goodwin and Konopelski",
        "SortOrder": 400,
        "ExtraFlags": 773,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 413
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 647,
        "Tooltip": "eaque",
        "CanAssign": false,
        "Free": 507,
        "InUse": 679,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 479,
        "Name": "Morissette Group",
        "Description": "Reduced bottom-line local area network",
        "PrerequisiteModuleName": "Toy-Greenfelder",
        "SortOrder": 304,
        "ExtraFlags": 732,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 605
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 789
      }
    }
  },
  {
    "Name": "Bosco, Moen and Kautzer",
    "Description": "Advanced didactic structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 58,
        "Tooltip": "asperiores",
        "CanAssign": false,
        "Free": 659,
        "InUse": 983,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 445,
        "Name": "Ankunding Inc and Sons",
        "Description": "Progressive mission-critical capacity",
        "PrerequisiteModuleName": "Kreiger, Goodwin and Konopelski",
        "SortOrder": 400,
        "ExtraFlags": 773,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 413
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 647,
        "Tooltip": "eaque",
        "CanAssign": false,
        "Free": 507,
        "InUse": 679,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 479,
        "Name": "Morissette Group",
        "Description": "Reduced bottom-line local area network",
        "PrerequisiteModuleName": "Toy-Greenfelder",
        "SortOrder": 304,
        "ExtraFlags": 732,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 605
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 789
      }
    }
  }
]
```