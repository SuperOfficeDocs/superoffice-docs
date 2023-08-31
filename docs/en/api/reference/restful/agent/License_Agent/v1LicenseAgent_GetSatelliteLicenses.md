---
title: POST Agents/License/GetSatelliteLicenses
uid: v1LicenseAgent_GetSatelliteLicenses
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/License/GetSatelliteLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 455
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Gusikowski, Legros and Kunze",
    "Description": "User-friendly background frame",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 489,
        "Tooltip": "quo",
        "CanAssign": false,
        "Free": 43,
        "InUse": 384,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 362,
        "Name": "Jerde, Hodkiewicz and Bradtke",
        "Description": "Automated national access",
        "PrerequisiteModuleName": "West, Beier and Lakin",
        "SortOrder": 957,
        "ExtraFlags": 327,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 682
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 462,
        "Tooltip": "quia",
        "CanAssign": false,
        "Free": 735,
        "InUse": 592,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 943,
        "Name": "Murray, Auer and Stroman",
        "Description": "Self-enabling intangible frame",
        "PrerequisiteModuleName": "Tromp, Rogahn and Aufderhar",
        "SortOrder": 192,
        "ExtraFlags": 688,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 901
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 633
      }
    }
  },
  {
    "Name": "Gusikowski, Legros and Kunze",
    "Description": "User-friendly background frame",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 489,
        "Tooltip": "quo",
        "CanAssign": false,
        "Free": 43,
        "InUse": 384,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 362,
        "Name": "Jerde, Hodkiewicz and Bradtke",
        "Description": "Automated national access",
        "PrerequisiteModuleName": "West, Beier and Lakin",
        "SortOrder": 957,
        "ExtraFlags": 327,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 682
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 462,
        "Tooltip": "quia",
        "CanAssign": false,
        "Free": 735,
        "InUse": 592,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 943,
        "Name": "Murray, Auer and Stroman",
        "Description": "Self-enabling intangible frame",
        "PrerequisiteModuleName": "Tromp, Rogahn and Aufderhar",
        "SortOrder": 192,
        "ExtraFlags": 688,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 901
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 633
      }
    }
  }
]
```