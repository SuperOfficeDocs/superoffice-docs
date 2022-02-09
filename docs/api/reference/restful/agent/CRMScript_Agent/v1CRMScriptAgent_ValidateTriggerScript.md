---
title: POST Agents/CRMScript/ValidateTriggerScript
id: v1CRMScriptAgent_ValidateTriggerScript
---

# POST Agents/CRMScript/ValidateTriggerScript

```http
POST /api/v1/Agents/CRMScript/ValidateTriggerScript
```

Validate a Trigger CRMScript.

This will check that the syntax is correct, but not execute the script.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/ValidateTriggerScript?$select=name,department,category/id
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

TriggerScriptId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TriggerScriptId | int32 |  |


## Response: object

Object for returning information when validating a CRMScript



Carrier object for CRMScriptResult.
Services for the CRMScriptResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICRMScriptAgent">CRMScript Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Valid | bool | True if the CRMScript was successfully validated. If false, see the error message for details |
| ErrorMessage | string | Contains the error message for a non-valide CRMScript |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CRMScript/ValidateTriggerScript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TriggerScriptId": 568
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": true,
  "ErrorMessage": "iusto",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "envisioneer end-to-end paradigms"
      },
      "FieldType": "System.Int32",
      "FieldLength": 60
    }
  }
}
```