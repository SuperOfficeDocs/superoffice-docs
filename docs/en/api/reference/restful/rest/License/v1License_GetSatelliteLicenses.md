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
    "Name": "Hagenes, Boyle and McDermott",
    "Description": "Quality-focused 4th generation Graphical User Interface",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 907,
        "Tooltip": "qui",
        "CanAssign": false,
        "Free": 27,
        "InUse": 978,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 792,
        "Name": "Pollich LLC",
        "Description": "Switchable executive infrastructure",
        "PrerequisiteModuleName": "Pouros, Crist and Gleason",
        "SortOrder": 204,
        "ExtraFlags": 188,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 748
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 189,
        "Tooltip": "itaque",
        "CanAssign": false,
        "Free": 424,
        "InUse": 858,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 331,
        "Name": "Treutel, Friesen and Barton",
        "Description": "Balanced zero defect open system",
        "PrerequisiteModuleName": "Batz LLC",
        "SortOrder": 188,
        "ExtraFlags": 730,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 950
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 91
      }
    }
  },
  {
    "Name": "Hagenes, Boyle and McDermott",
    "Description": "Quality-focused 4th generation Graphical User Interface",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 907,
        "Tooltip": "qui",
        "CanAssign": false,
        "Free": 27,
        "InUse": 978,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 792,
        "Name": "Pollich LLC",
        "Description": "Switchable executive infrastructure",
        "PrerequisiteModuleName": "Pouros, Crist and Gleason",
        "SortOrder": 204,
        "ExtraFlags": 188,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 748
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 189,
        "Tooltip": "itaque",
        "CanAssign": false,
        "Free": 424,
        "InUse": 858,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 331,
        "Name": "Treutel, Friesen and Barton",
        "Description": "Balanced zero defect open system",
        "PrerequisiteModuleName": "Batz LLC",
        "SortOrder": 188,
        "ExtraFlags": 730,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 950
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 91
      }
    }
  }
]
```