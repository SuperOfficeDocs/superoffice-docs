---
title: PUT Script/{uniqueIdentifier}
uid: v1Script_SaveCRMScriptByUniqueIdentifier
generated: true
---

# PUT Script/{uniqueIdentifier}

```http
PUT /api/v1/Script/{uniqueIdentifier}
```

Create or Update the CRMScript information


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





| Path Part | Type | Description |
|-----------|------|-------------|
| uniqueIdentifier | string | Global unique reference to script (independent of installation) **Required** |



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

## Request Body: crmscript 

Information about the CRMScript 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UniqueIdentifier | String | Global unique identifier, accross customers/tenants |
| Name | String | A description of this script |
| Description | String | Optional description of what this script is used for. |
| IncludeId | String | A unique name used for including this script in another |
| Source | String | The script |
| Registered | String | Registered when  in UTC. |
| RegisteredBy | String | Who created this script |
| Updated | String | Last updated when  in UTC. |
| UpdatedBy | String | Who updated this script |
| Path | String | Path to script in the hierarchy. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Script

| Property Name | Type |  Description |
|----------------|------|--------------|
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Name | string | A description of this script |
| Description | string | Optional description of what this script is used for. |
| IncludeId | string | A unique name used for including this script in another |
| Source | string | The script |
| Registered | date-time | Registered when  in UTC. |
| RegisteredBy | string | Who created this script |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy | string | Who updated this script |
| Path | string | Path to script in the hierarchy. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/Script/{uniqueIdentifier}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UniqueIdentifier": "voluptatibus",
  "Name": "Pfannerstill LLC",
  "Description": "Centralized analyzing definition",
  "IncludeId": "quo",
  "Source": "modi",
  "Registered": "2011-08-05T16:00:48.7427419+02:00",
  "RegisteredBy": "cumque",
  "Updated": "2014-10-20T16:00:48.7427419+02:00",
  "UpdatedBy": "aut",
  "Path": "error"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UniqueIdentifier": "neque",
  "Name": "Nikolaus, Ullrich and Klocko",
  "Description": "Ameliorated neutral strategy",
  "IncludeId": "minus",
  "Source": "debitis",
  "Registered": "2015-11-07T16:00:48.7427419+01:00",
  "RegisteredBy": "est",
  "Updated": "2002-11-09T16:00:48.7427419+01:00",
  "UpdatedBy": "aut",
  "Path": "consequuntur",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 202
    }
  }
}
```