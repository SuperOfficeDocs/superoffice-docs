---
title: GET NewsFeed/{id}
uid: v1NewsFeedItem_GetNewsFeedItem
generated: true
content_type: reference
---

# GET NewsFeed/{id}

```http
GET /api/v1/NewsFeed/{id}
```

Gets a NewsFeedItem object.


Calls the NewsFeed agent service GetNewsFeedItem.
NsApiSlow threshold: 2000 ms.


## Experimental: ## The NewsFeed agent is experimental, subject to change, and not intended for partners.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the NewsFeedItem to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/NewsFeed/{id}?$select=name,department,category/id
```


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

NewsFeedItem found.

| Response | Description |
|----------------|-------------|
| 200 | NewsFeedItem found. |
| 404 | Not Found. |

### Response body: NewsFeedItemWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| NewsFeedItemId | int32 | Primary key |
| Title | string | Short, descriptive headline. Plain text title. Multi-language string supported: 'US:"english";NO:"norsk"'. |
| Summary | string | Short, descriptive summary. Plain text summary. Multi-language string supported: 'US:"english";NO:"norsk"'. |
| Description | object | Multi-language descriptions for the news feed item, where the key is an ISO 2 letter language code (e.g. 'en', 'no', 'de') and the value is the description in that language. Styling via pre-defined CSS classes. No SCRIPT or STYLE tags allowed. The 'current' value is set based on the Accept-Language/SO-Language header. |
| Actions | array | Call to action items for the news feed item. Each item contains a title, an identifier, a type and flavor. |
| ImageLink | string | URL Link to an image associated with the news item. |
| SourceLink | string | URL Link to the source of the news item, or an SOProtocol link to a SuperOffice item |
| PreviewHint | string | Preview hint for the news item. e.g. `{contact_id=123}` |
| FromName | string | Name of the instance that published this item. e.g. `Pete the prospector` |
| FromCategoryName | string | Type of the instance that published this item. e.g. `Prospector Agent` |
| Priority | string | Importance of the news item. Low to High. Higher priority items may be shown more prominently in the feed. |
| Registered | date-time | Registered when  in UTC. |
| Updated | date-time | Last updated when  in UTC. |
| ExpiresAt | date-time | When the news item expires and should no longer be shown in feeds (UTC)  in UTC. |
| Status | string | Indicates if the item is being handled by a CTA. (normal, processing, processed) |
| IsRead | bool | Set to true when the recipient user has read the news feed item. |
| ReadAt | date-time | When the recipient user read the news feed item (UTC)  in UTC. |
| Contact | Contact | Company that is mentioned in the news feed item - null if not applicable |
| Person | Person | Person that is mentioned in the news feed item - null if not applicable |
| Project | Project | Project that is mentioned in the news feed item - null if not applicable |
| Sale | Sale | Sale that is mentioned in the news feed item - null if not applicable |
| ApplicationId | string | The id of the application that registered this news item. Used to resolve where any CTA should be posted when clicked. |
| _Links | object |  |

## Sample request

[!include[sample request](../../samples/rest/request/v1NewsFeedItem_GetNewsFeedItem.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1NewsFeedItem_GetNewsFeedItem.md)]