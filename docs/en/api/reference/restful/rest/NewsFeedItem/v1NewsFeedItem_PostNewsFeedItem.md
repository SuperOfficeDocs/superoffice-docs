---
title: POST NewsFeed
uid: v1NewsFeedItem_PostNewsFeedItem
generated: true
content_type: reference
---

# POST NewsFeed

```http
POST /api/v1/NewsFeed
```

Saves a new item to the newsfeed, publishing it to the specified users.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| toAssociateIds | array |  List of associate ids that this news feed item is sent to. |
| toGroupIds | array |  List of group ids that this news feed item is sent to. This gets resolved to associate ids when posted. |
| toAll | bool |  Indicates if this news feed item is sent to all users. Gets resolved into all users when posted. |

```http
POST /api/v1/NewsFeed?toAssociateIds=728,731
POST /api/v1/NewsFeed?toGroupIds=115,347
POST /api/v1/NewsFeed?toAll=True
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

## Request Body: newsFeedItem 

The news feed item to post. NewsFeedItemId is ignored, as a new id will be generated when posting to the newsfeed. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NewsFeedItemId | Integer | Primary key |
| Title | String | Short, descriptive headline. Plain text title. Multi-language string supported: 'US:"english";NO:"norsk"'. |
| Summary | String | Short, descriptive summary. Plain text summary. Multi-language string supported: 'US:"english";NO:"norsk"'. |
| Description | Object | Multi-language descriptions for the news feed item, where the key is an ISO 2 letter language code (e.g. 'en', 'no', 'de') and the value is the description in that language. Styling via pre-defined CSS classes. No SCRIPT or STYLE tags allowed. The 'current' value is set based on the Accept-Language/SO-Language header. |
| Actions | Array | Call to action items for the news feed item. Each item contains a title, an identifier, a type and flavor. |
| ImageLink | String | URL Link to an image associated with the news item. |
| SourceLink | String | URL Link to the source of the news item, or an SOProtocol link to a SuperOffice item |
| PreviewHint | String | Preview hint for the news item. e.g. `{contact_id=123}` |
| FromName | String | Name of the instance that published this item. e.g. `Pete the prospector` |
| FromCategoryName | String | Type of the instance that published this item. e.g. `Prospector Agent` |
| Priority | String | Importance of the news item. Low to High. Higher priority items may be shown more prominently in the feed. |
| Registered | String | Registered when  in UTC. |
| Updated | String | Last updated when  in UTC. |
| ExpiresAt | String | When the news item expires and should no longer be shown in feeds (UTC)  in UTC. |
| Status | String | Indicates if the item is being handled by a CTA. (normal, processing, processed) |
| IsRead | Boolean | Set to true when the recipient user has read the news feed item. |
| ReadAt | String | When the recipient user read the news feed item (UTC)  in UTC. |
| Contact | Contact | Company that is mentioned in the news feed item - null if not applicable |
| Person | Person | Person that is mentioned in the news feed item - null if not applicable |
| Project | Project | Project that is mentioned in the news feed item - null if not applicable |
| Sale | Sale | Sale that is mentioned in the news feed item - null if not applicable |
| ApplicationId | String | The id of the application that registered this news item. Used to resolve where any CTA should be posted when clicked. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: NewsFeedItem

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

## Sample request

[!include[sample request](../../samples/rest/request/v1NewsFeedItem_PostNewsFeedItem.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1NewsFeedItem_PostNewsFeedItem.md)]