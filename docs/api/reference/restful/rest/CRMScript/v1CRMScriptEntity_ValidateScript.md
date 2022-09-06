---
title: GET CRMScript/{id}/Validate
uid: v1CRMScriptEntity_ValidateScript
---

# GET CRMScript/{id}/Validate

```http
GET /api/v1/CRMScript/{cRMScriptId}/Validate
```

Validate a CRMScript.

This will check that the syntax is correct

## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered

| Path Part | Type | Description |
|-----------|------|-------------|
| cRMScriptId | int32 | The id of the CRMScript to execute **Required** |

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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Valid | bool | True if the CRMScript was successfully validated. If false, see the error message for details |
| ErrorMessage | string | Contains the error message for a non-valide CRMScript |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/CRMScript/{cRMScriptId}/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": false,
  "ErrorMessage": "qui",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 429
    }
  }
}
```
