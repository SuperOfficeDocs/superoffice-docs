---
title: POST Agents/EMail/DeleteEMailAccount
uid: v1EMailAgent_DeleteEMailAccount
generated: true
---

# POST Agents/EMail/DeleteEMailAccount

```http
POST /api/v1/Agents/EMail/DeleteEMailAccount
```

Deletes the EMailAccount


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| EMailAccountId | int32 | **Required** The id of the EMailAccount to be deleted. |

```http
POST /api/v1/Agents/EMail/DeleteEMailAccount?EMailAccountId=284
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/EMail/DeleteEMailAccount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```