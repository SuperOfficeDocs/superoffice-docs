---
title: POST Agents/NewsFeed/DeleteNewsFeedItem
uid: v1NewsFeedAgent_DeleteNewsFeedItem
generated: true
content_type: reference
---

# POST Agents/NewsFeed/DeleteNewsFeedItem

```http
POST /api/v1/Agents/NewsFeed/DeleteNewsFeedItem
```

Deletes the NewsFeedItem


NsApiSlow threshold: 2000 ms.


## Experimental: ## The NewsFeed agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| newsFeedItemId | int32 | **Required** The identity of the NewsFeedItem |

```http
POST /api/v1/Agents/NewsFeed/DeleteNewsFeedItem?newsFeedItemId=944
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

[!include[sample request](../../samples/agent/request/v1NewsFeedAgent_DeleteNewsFeedItem.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1NewsFeedAgent_DeleteNewsFeedItem.md)]