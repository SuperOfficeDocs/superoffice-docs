---
title: CreateDefaultEMailFolder
id: v1EMailAgent_CreateDefaultEMailFolder
---

# CreateDefaultEMailFolder

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


## Response: object

Properties for a mail folder



Carrier object for EMailFolder.
Services for the EMailFolder Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Name of folder |
| Delimiter | string | The character which is used to delimit folder levels on the server |
| Flags | string | Flags associated with the folder |
| TotalItems | int32 | Total number of messages in the folder |
| UnreadItems | int32 | Number of unread messages in the folder |
| Subscribed | bool | Indicates if the folder is subscribed to |
| EmailFolderId | int32 | Primary key |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailFolder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Name": "Huels, Lindgren and Rowe",
  "Delimiter": "quas",
  "Flags": "officiis",
  "TotalItems": 831,
  "UnreadItems": 350,
  "Subscribed": true,
  "EmailFolderId": 217,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 214
    }
  }
}
```