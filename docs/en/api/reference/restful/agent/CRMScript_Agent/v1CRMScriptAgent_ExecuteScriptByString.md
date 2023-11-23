---
title: POST Agents/CRMScript/ExecuteScriptByString
uid: v1CRMScriptAgent_ExecuteScriptByString
generated: true
---

# POST Agents/CRMScript/ExecuteScriptByString

```http
POST /api/v1/Agents/CRMScript/ExecuteScriptByString
```

Execute a CRMScript 2 (JavaScript), returning the printed output value.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/ExecuteScriptByString?$select=name,department,category/id
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

Script, Parameters, EventData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Script | String |  |
| Parameters | PersonEntity |  |
| EventData | EventData | EventData containing data related to event handlers <para /> Carrier object for EventData. Services for the EventData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CRMScriptRunResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| Output | string | The output from the script, normally from a print or printLine statement |
| Parameters | object | The parameters/variables that might have been modified by the script |
| TraceRun | CRMScriptTraceRun | Contains the trace information from the script execution |
| Eventdata | EventData | The EventData instance after script execution with output values |
| Success | bool | Indicates if the script was executed successfully, or if it failed. In case of failing, the error members will contain more information |
| ErrorInformation | CRMScriptErrorInfo | Contains error information if the execution failed |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CRMScript/ExecuteScriptByString
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Script": "maxime",
  "Parameters": {
    "Parameters1": "quo",
    "Parameters2": "similique"
  },
  "EventData": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Output": "quis",
  "Parameters": {
    "Parameters1": "praesentium",
    "Parameters2": "quia"
  },
  "TraceRun": null,
  "Eventdata": null,
  "Success": true,
  "ErrorInformation": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 573
    }
  }
}
```