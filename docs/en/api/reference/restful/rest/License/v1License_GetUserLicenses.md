---
title: GET License/User/{id}
uid: v1License_GetUserLicenses
generated: true
content_type: reference
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/License/User/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Torp Group",
    "Description": "Networked homogeneous product",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 80,
        "Tooltip": "quae",
        "CanAssign": false,
        "Free": 745,
        "InUse": 526,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 779,
        "Name": "Strosin Group",
        "Description": "Streamlined asynchronous hub",
        "PrerequisiteModuleName": "Herman-Koch",
        "SortOrder": 83,
        "ExtraFlags": 433,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 369
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 495,
        "Tooltip": "nisi",
        "CanAssign": false,
        "Free": 663,
        "InUse": 169,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 255,
        "Name": "Lehner, Mosciski and Schuster",
        "Description": "Reactive executive implementation",
        "PrerequisiteModuleName": "Yundt, Walsh and Rempel",
        "SortOrder": 103,
        "ExtraFlags": 21,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 647
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 85
      }
    }
  },
  {
    "Name": "Torp Group",
    "Description": "Networked homogeneous product",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 80,
        "Tooltip": "quae",
        "CanAssign": false,
        "Free": 745,
        "InUse": 526,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 779,
        "Name": "Strosin Group",
        "Description": "Streamlined asynchronous hub",
        "PrerequisiteModuleName": "Herman-Koch",
        "SortOrder": 83,
        "ExtraFlags": 433,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 369
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 495,
        "Tooltip": "nisi",
        "CanAssign": false,
        "Free": 663,
        "InUse": 169,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 255,
        "Name": "Lehner, Mosciski and Schuster",
        "Description": "Reactive executive implementation",
        "PrerequisiteModuleName": "Yundt, Walsh and Rempel",
        "SortOrder": 103,
        "ExtraFlags": 21,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 647
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 85
      }
    }
  }
]
```