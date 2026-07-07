---
title: DEL NewsFeed/{id}
uid: v1NewsFeedItem_DeleteNewsFeedItem
generated: true
content_type: reference
---

# DEL NewsFeed/{id}

```http
DELETE /api/v1/NewsFeed/{id}
```

Deletes the NewsFeedItem


## Experimental: ## The NewsFeed agent is experimental, subject to change, and not intended for partners. Calls the NewsFeed agent service DeleteNewsFeedItem.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The NewsFeedItem to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

NewsFeedItem deleted.

| Response | Description |
|----------------|-------------|
| 204 | NewsFeedItem deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1NewsFeedItem_DeleteNewsFeedItem.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1NewsFeedItem_DeleteNewsFeedItem.md)]