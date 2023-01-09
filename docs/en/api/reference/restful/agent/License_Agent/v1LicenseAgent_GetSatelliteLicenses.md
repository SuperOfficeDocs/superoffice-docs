---
title: POST Agents/License/GetSatelliteLicenses
uid: v1LicenseAgent_GetSatelliteLicenses
---

# POST Agents/License/GetSatelliteLicenses

```http
POST /api/v1/Agents/License/GetSatelliteLicenses
```

Obtain information about satellite module licenses







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetSatelliteLicenses?$select=name,department,category/id
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

SatelliteId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SatelliteId | Integer |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/License/GetSatelliteLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 970
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Lowe Group",
    "Description": "Managed mission-critical productivity",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 342,
        "Tooltip": "accusamus",
        "CanAssign": false,
        "Free": 739,
        "InUse": 923,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 188,
        "Name": "Littel, Bernhard and Howe",
        "Description": "De-engineered fresh-thinking encoding",
        "PrerequisiteModuleName": "Kilback-Kunze",
        "SortOrder": 877,
        "ExtraFlags": 311,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 532
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 701,
        "Tooltip": "repellendus",
        "CanAssign": false,
        "Free": 453,
        "InUse": 475,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 787,
        "Name": "Koelpin, Davis and Heller",
        "Description": "Future-proofed real-time encryption",
        "PrerequisiteModuleName": "Welch, Walter and Rempel",
        "SortOrder": 368,
        "ExtraFlags": 868,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 354
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 406
      }
    }
  },
  {
    "Name": "Lowe Group",
    "Description": "Managed mission-critical productivity",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 342,
        "Tooltip": "accusamus",
        "CanAssign": false,
        "Free": 739,
        "InUse": 923,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 188,
        "Name": "Littel, Bernhard and Howe",
        "Description": "De-engineered fresh-thinking encoding",
        "PrerequisiteModuleName": "Kilback-Kunze",
        "SortOrder": 877,
        "ExtraFlags": 311,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 532
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 701,
        "Tooltip": "repellendus",
        "CanAssign": false,
        "Free": 453,
        "InUse": 475,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 787,
        "Name": "Koelpin, Davis and Heller",
        "Description": "Future-proofed real-time encryption",
        "PrerequisiteModuleName": "Welch, Walter and Rempel",
        "SortOrder": 368,
        "ExtraFlags": 868,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 354
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 406
      }
    }
  }
]
```