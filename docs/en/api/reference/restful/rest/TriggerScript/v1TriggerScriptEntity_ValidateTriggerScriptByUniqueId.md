---
title: GET TriggerScript/{id}/Validate
uid: v1TriggerScriptEntity_ValidateTriggerScriptByUniqueId
generated: true
---

# GET TriggerScript/{id}/Validate

```http
GET /api/v1/TriggerScript/{triggerScriptUniqueId}/Validate
```

Validate a Trigger CRMScript.


This will check that the syntax is correct, but not execute the script.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





| Path Part | Type | Description |
|-----------|------|-------------|
| triggerScriptUniqueId | string | The unique id of the CRMScript to validate **Required** |



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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CRMScriptResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| Valid | bool | True if the CRMScript was successfully validated. If false, see the error message for details |
| ErrorMessage | string | Deprecated, see ErrorInformation instead. Contains the error message for a non-valide CRMScript |
| LineNumber | int32 | Deprecated, see ErrorInformation instead. The line number containing the incorrect syntax, if available |
| ErrorInformation | CRMScriptErrorInfo | Contains error information if the validation failed |
| Transpiled | string | This will contain transpiled code. In case of Typescript, this will then contain the executable JavaScript |
| Includes | array | The unique ids of all depencies of this script (all resolved includes) |
| SourceMaps | array | Array of source maps showing where in the original code a specific line originated from |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/TriggerScript/{triggerScriptUniqueId}/Validate
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
  "ErrorMessage": "cupiditate",
  "LineNumber": 413,
  "ErrorInformation": null,
  "Transpiled": "eos",
  "Includes": [
    712,
    540
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 631,
      "LineNumberTo": 702,
      "Delta": 588,
      "IncludeId": "est",
      "IncludedFrom": [
        "ad",
        "architecto"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 166
    }
  }
}
```