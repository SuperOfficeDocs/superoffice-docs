---
title: POST Agents/EMail/GetEMailAsEmlStream
uid: v1EMailAgent_GetEMailAsEmlStream
generated: true
content_type: reference
---

# POST Agents/EMail/GetEMailAsEmlStream

```http
POST /api/v1/Agents/EMail/GetEMailAsEmlStream
```

Get an inbox e-mail (by its EmailItemId) serialized as an Outlook-openable RFC822 (.


eml) stream. Works for both IMAP and Graph/Exchange-Online mailboxes because it serializes the loaded entity instead of re-fetching the raw message by server id.
NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailAsEmlStream?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/octet-stream`, `application/pdf`, `text/plain`, `text/html`, `multipart/related` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

EmailItemId, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailItemId | Integer |  |
| IncludeAttachments | Boolean |  |

## Response:binary

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: binary


## Sample request

[!include[sample request](../../samples/agent/request/v1EMailAgent_GetEMailAsEmlStream.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1EMailAgent_GetEMailAsEmlStream.md)]