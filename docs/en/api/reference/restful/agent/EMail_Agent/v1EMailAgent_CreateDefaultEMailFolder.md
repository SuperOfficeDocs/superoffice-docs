---
title: POST Agents/EMail/CreateDefaultEMailFolder
uid: v1EMailAgent_CreateDefaultEMailFolder
generated: true
---

# POST Agents/EMail/CreateDefaultEMailFolder

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailFolder
```

Set default values into a new EMailFolder.


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

### Response body: EMailFolder

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Name of folder |
| Delimiter | string | The character which is used to delimit folder levels on the server |
| Flags | string | Flags associated with the folder |
| TotalItems | int32 | Total number of messages in the folder |
| UnreadItems | int32 | Number of unread messages in the folder |
| Subscribed | bool | Indicates if the folder is subscribed to |
| EmailFolderId | int32 | Primary key |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailFolder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Name": "Bosco, Hagenes and Monahan",
  "Delimiter": "delectus",
  "Flags": "consequatur",
  "TotalItems": 735,
  "UnreadItems": 592,
  "Subscribed": true,
  "EmailFolderId": 344,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 592
    }
  }
}
```