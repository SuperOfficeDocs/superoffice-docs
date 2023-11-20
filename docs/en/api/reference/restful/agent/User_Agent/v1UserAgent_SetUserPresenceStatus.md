---
title: POST Agents/User/SetUserPresenceStatus
uid: v1UserAgent_SetUserPresenceStatus
generated: true
---

# POST Agents/User/SetUserPresenceStatus

```http
POST /api/v1/Agents/User/SetUserPresenceStatus
```

Set user presence status


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/SetUserPresenceStatus?$select=name,department,category/id
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

AssociateId, UserPresenceStatus 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |
| UserPresenceStatus | UserPresenceStatus | Manage present/absent status for a Service user account (influences ticket assignments). <para /> Carrier object for UserPresenceStatus. Services for the UserPresenceStatus Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. |

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
POST /api/v1/Agents/User/SetUserPresenceStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 259,
  "UserPresenceStatus": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Status": "StatusDeleted",
  "Message": "sint"
}
```