---
title: POST Agents/CRMScript/ValidateScriptByString
uid: v1CRMScriptAgent_ValidateScriptByString
generated: true
---

# POST Agents/CRMScript/ValidateScriptByString

```http
POST /api/v1/Agents/CRMScript/ValidateScriptByString
```

Validate a CRMScript 2 (JavaScript).


This will check that the syntax is correct


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/ValidateScriptByString?$select=name,department,category/id
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

Script 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Script | String |  |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CRMScript/ValidateScriptByString
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Script": "dolor"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": true,
  "ErrorMessage": "dolor",
  "LineNumber": 789,
  "ErrorInformation": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 35
    }
  }
}
```