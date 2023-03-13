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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 498
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Hauck-Fahey",
    "Description": "Synergistic cohesive circuit",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 642,
        "Tooltip": "beatae",
        "CanAssign": true,
        "Free": 190,
        "InUse": 818,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 58,
        "Name": "Hartmann, Rohan and Dare",
        "Description": "Balanced holistic hub",
        "PrerequisiteModuleName": "Buckridge, Haag and Dibbert",
        "SortOrder": 689,
        "ExtraFlags": 765,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 680
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 326,
        "Tooltip": "sint",
        "CanAssign": true,
        "Free": 12,
        "InUse": 708,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 885,
        "Name": "Roob LLC",
        "Description": "Intuitive directional customer loyalty",
        "PrerequisiteModuleName": "McDermott-Weimann",
        "SortOrder": 528,
        "ExtraFlags": 945,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 165
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 375
      }
    }
  },
  {
    "Name": "Hauck-Fahey",
    "Description": "Synergistic cohesive circuit",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 642,
        "Tooltip": "beatae",
        "CanAssign": true,
        "Free": 190,
        "InUse": 818,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 58,
        "Name": "Hartmann, Rohan and Dare",
        "Description": "Balanced holistic hub",
        "PrerequisiteModuleName": "Buckridge, Haag and Dibbert",
        "SortOrder": 689,
        "ExtraFlags": 765,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 680
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 326,
        "Tooltip": "sint",
        "CanAssign": true,
        "Free": 12,
        "InUse": 708,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 885,
        "Name": "Roob LLC",
        "Description": "Intuitive directional customer loyalty",
        "PrerequisiteModuleName": "McDermott-Weimann",
        "SortOrder": 528,
        "ExtraFlags": 945,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 165
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 375
      }
    }
  }
]
```