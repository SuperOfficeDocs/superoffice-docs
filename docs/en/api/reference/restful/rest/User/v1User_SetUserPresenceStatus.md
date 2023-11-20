---
title: PUT User/{id}/UserPresenceStatus
uid: v1User_SetUserPresenceStatus
generated: true
---

# PUT User/{id}/UserPresenceStatus

```http
PUT /api/v1/User/{associateId}/UserPresenceStatus
```

Set user presence status


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





| Path Part | Type | Description |
|-----------|------|-------------|
| associateId | int32 | AssociateId of user to set status for. **Required** |



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

## Request Body: userPresenceStatus 

User presence status to set 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Status | String | The status (enum) for this user. |
| Message | String | Comment to add for user when status is not present. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UserPresenceStatus

| Property Name | Type |  Description |
|----------------|------|--------------|
| Status | string | The status (enum) for this user. |
| Message | string | Comment to add for user when status is not present. |

## Sample request

```http!
PUT /api/v1/User/{associateId}/UserPresenceStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Status": "StatusDeleted",
  "Message": "ut"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Status": "StatusDeleted",
  "Message": "rerum"
}
```