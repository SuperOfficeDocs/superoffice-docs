---
title: POST Agents/User/CreateDefaultUntrustedCredentials
uid: v1UserAgent_CreateDefaultUntrustedCredentials
generated: true
---

# POST Agents/User/CreateDefaultUntrustedCredentials

```http
POST /api/v1/Agents/User/CreateDefaultUntrustedCredentials
```

Set default values into a new UntrustedCredentials.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.







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

### Response body: UntrustedCredentials

| Property Name | Type |  Description |
|----------------|------|--------------|
| ValidFrom | date-time | Credentials are valid from this date. |
| ValidTo | date-time | Credentials are valid to this date. |
| Comment | string | Description of credentials. Max 255 characters. |
| SecretValue | string | Data stored encrypted in the db. Typically a password. Max 70 characters. |
| PublicValue | string | Data stored unencrypted in the db.  Typically server and or username. Max 238 characters. |
| IsActive | bool | Is this credentials currently active. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/CreateDefaultUntrustedCredentials
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ValidFrom": "2007-09-26T03:45:24.1548097+02:00",
  "ValidTo": "2002-03-07T03:45:24.1548097+01:00",
  "Comment": "laboriosam",
  "SecretValue": "sint",
  "PublicValue": "omnis",
  "IsActive": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 643
    }
  }
}
```