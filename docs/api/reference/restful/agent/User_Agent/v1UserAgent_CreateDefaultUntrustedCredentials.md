---
title: POST Agents/User/CreateDefaultUntrustedCredentials
uid: v1UserAgent_CreateDefaultUntrustedCredentials
---

# POST Agents/User/CreateDefaultUntrustedCredentials

```http
POST /api/v1/Agents/User/CreateDefaultUntrustedCredentials
```

Set default values into a new UntrustedCredentials.

NetServer calculates default values on the entity, which is required when creating/storing a new instance

## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps

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
| ValidFrom | date-time | Credentials are valid from this date. |
| ValidTo | date-time | Credentials are valid to this date. |
| Comment | string | Description of credentials. Max 255 characters. |
| SecretValue | string | Data stored encrypted in the db. Typically a password. Max 70 characters. |
| PublicValue | string | Data stored unencrypted in the db.  Typically server and or username. Max 238 characters. |
| IsActive | bool | Is this credentials currently active. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/User/CreateDefaultUntrustedCredentials
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ValidFrom": "2008-04-26T11:10:28.3612071+02:00",
  "ValidTo": "2004-02-24T11:10:28.3612071+01:00",
  "Comment": "consequatur",
  "SecretValue": "qui",
  "PublicValue": "asperiores",
  "IsActive": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 289
    }
  }
}
```
