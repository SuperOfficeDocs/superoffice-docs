---
title: POST NewsFeed/{id}/Read
uid: v1NewsFeedItem_MarkAsRead
generated: true
content_type: reference
---

# POST NewsFeed/{id}/Read

```http
POST /api/v1/NewsFeed/{newsFeedItemId}/Read
```

Marks the news feed item as read, so it can be un-bolded in the current user's feed.






| Path Part | Type | Description |
|-----------|------|-------------|
| newsFeedItemId | int32 | Id of the news feed item to mark as seen for this user. **Required** |



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

[!include[sample request](../../samples/rest/request/v1NewsFeedItem_MarkAsRead.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1NewsFeedItem_MarkAsRead.md)]