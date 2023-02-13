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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The name of the license owner |
| Description | string |  |
| RestrictedModuleLicenses | array |  |
| UnrestrictedModuleLicenses | array | The unrestricted module licenses that this license owner |
| TableRight | RecurrenceInfo |  |
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
    "Name": "Osinski LLC",
    "Description": "Seamless multi-state circuit",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 916,
        "Tooltip": "provident",
        "CanAssign": false,
        "Free": 82,
        "InUse": 731,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 8,
        "Name": "Pollich, Willms and Nicolas",
        "Description": "Enhanced neutral ability",
        "PrerequisiteModuleName": "Bosco-Wisoky",
        "SortOrder": 792,
        "ExtraFlags": 847,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 956
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 165,
        "Tooltip": "neque",
        "CanAssign": true,
        "Free": 884,
        "InUse": 413,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 234,
        "Name": "Rosenbaum, O'Conner and Wehner",
        "Description": "Multi-lateral next generation capacity",
        "PrerequisiteModuleName": "Funk-Monahan",
        "SortOrder": 283,
        "ExtraFlags": 377,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 366
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 974
      }
    }
  },
  {
    "Name": "Osinski LLC",
    "Description": "Seamless multi-state circuit",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 916,
        "Tooltip": "provident",
        "CanAssign": false,
        "Free": 82,
        "InUse": 731,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 8,
        "Name": "Pollich, Willms and Nicolas",
        "Description": "Enhanced neutral ability",
        "PrerequisiteModuleName": "Bosco-Wisoky",
        "SortOrder": 792,
        "ExtraFlags": 847,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 956
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 165,
        "Tooltip": "neque",
        "CanAssign": true,
        "Free": 884,
        "InUse": 413,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 234,
        "Name": "Rosenbaum, O'Conner and Wehner",
        "Description": "Multi-lateral next generation capacity",
        "PrerequisiteModuleName": "Funk-Monahan",
        "SortOrder": 283,
        "ExtraFlags": 377,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 366
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 974
      }
    }
  }
]
```