---
title: POST Agents/EMail/SyncEmailAccounts
uid: v1EMailAgent_SyncEmailAccounts
generated: true
content_type: reference
---

# POST Agents/EMail/SyncEmailAccounts

```http
POST /api/v1/Agents/EMail/SyncEmailAccounts
```

Start syncing of the given accounts, from mail server to SuperOffice database cache.


Only one of these API calls may run at a time. If one is already active, we return after 1 (one) second, with no indication that the sync was not really started. This is a way to throttle sync'ing to avoid making the mail servers angry at us. &lt;br/&gt; There is an &lt;b&gt;additional&lt;/b&gt; level of throttling within the implementation as well, limiting us to a maximum of 10 tasks, regardless of how many associates are to to be sync'ed. The outer, API-level lock is released when all those tasks are done.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SyncEmailAccounts?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

SyncUserAccounts 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SyncUserAccounts | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/EMail/SyncEmailAccounts
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SyncUserAccounts": [
    {
      "AccountId": 257,
      "AssociateName": "Pagac-Mohr",
      "AssociateId": 260
    },
    {
      "AccountId": 257,
      "AssociateName": "Pagac-Mohr",
      "AssociateId": 260
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```