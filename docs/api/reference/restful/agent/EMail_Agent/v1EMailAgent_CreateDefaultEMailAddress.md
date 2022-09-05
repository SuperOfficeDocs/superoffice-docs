---
title: POST Agents/EMail/CreateDefaultEMailAddress
uid: v1EMailAgent_CreateDefaultEMailAddress
---

# POST Agents/EMail/CreateDefaultEMailAddress

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailAddress
```

Set default values into a new EMailAddress.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.







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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| ContactName | string |  |
| PersonId | int32 | Primary key |
| PersonName | string |  |
| AssociateId | int32 | Primary key |
| Address | string |  |
| EmailId | int32 | Primary key |
| DuplicatePersonIds | array | All persons with this EmailAddress stored in db is listed here |
| Name | string | The name on the email address |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 208,
  "ContactName": "Jast-Murazik",
  "PersonId": 544,
  "PersonName": "Rosenbaum LLC",
  "AssociateId": 217,
  "Address": "ullam",
  "EmailId": 343,
  "DuplicatePersonIds": [
    599,
    690
  ],
  "Name": "Lind, Hirthe and Bergstrom",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 823
    }
  }
}
```