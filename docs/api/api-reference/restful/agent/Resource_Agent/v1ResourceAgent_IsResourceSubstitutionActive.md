---
title: POST Agents/Resource/IsResourceSubstitutionActive
id: v1ResourceAgent_IsResourceSubstitutionActive
---

# POST Agents/Resource/IsResourceSubstitutionActive

```http
POST /api/v1/Agents/Resource/IsResourceSubstitutionActive
```

Determine if resource substitution/override is active, globally or for a subset of resources/cultures







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Resource/IsResourceSubstitutionActive?$select=name,department,category/id
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

ResourceNames, Culture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceNames | array |  |
| Culture | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceName | string | The name of the resource, without any brackets or braces - example: SR_CONTACT |
| ResourceValue | string | The value of the resource in the given culture |
| Culture | string | .NET-style culture code, such as NB-NO or EN-UK |
| IsActive | bool | Is this override active |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Resource/IsResourceSubstitutionActive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ResourceNames": [
    "Rippin, Rutherford and Greenfelder",
    "Powlowski LLC"
  ],
  "Culture": "esse"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ResourceName": "Jast-Deckow",
    "ResourceValue": "maiores",
    "Culture": "quo",
    "IsActive": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 488
      }
    }
  },
  {
    "ResourceName": "Jast-Deckow",
    "ResourceValue": "maiores",
    "Culture": "quo",
    "IsActive": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 488
      }
    }
  }
]
```