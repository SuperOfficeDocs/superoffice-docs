---
title: POST Agents/Resource/GetResourceSubstitutions
uid: v1ResourceAgent_GetResourceSubstitutions
generated: true
---

# POST Agents/Resource/GetResourceSubstitutions

```http
POST /api/v1/Agents/Resource/GetResourceSubstitutions
```

Get substitutions for some or all resources for one culture







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Resource/GetResourceSubstitutions?$select=name,department,category/id
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

ResourceNames, Culture, ActiveOnly 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceNames | Array |  |
| Culture | String |  |
| ActiveOnly | Boolean |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceName | string | The name of the resource, without any brackets or braces - example: SR_CONTACT |
| ResourceValue | string | The value of the resource in the given culture |
| Culture | string | .NET-style culture code, such as NB-NO or EN-UK |
| IsActive | bool | Is this override active |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Resource/GetResourceSubstitutions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ResourceNames": [
    "Trantow, Ondricka and Braun",
    "Abernathy, Ernser and Schmidt"
  ],
  "Culture": "animi",
  "ActiveOnly": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ResourceName": "Will Group",
    "ResourceValue": "voluptatem",
    "Culture": "quod",
    "IsActive": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 335
      }
    }
  },
  {
    "ResourceName": "Will Group",
    "ResourceValue": "voluptatem",
    "Culture": "quod",
    "IsActive": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 335
      }
    }
  }
]
```