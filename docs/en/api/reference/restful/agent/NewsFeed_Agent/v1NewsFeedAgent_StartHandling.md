---
title: POST Agents/NewsFeed/StartHandling
uid: v1NewsFeedAgent_StartHandling
generated: true
content_type: reference
---

# POST Agents/NewsFeed/StartHandling

```http
POST /api/v1/Agents/NewsFeed/StartHandling
```

Marks the news feed item as being handled, that CTA processing has started.


i.e. other users should not start handling it also.
NsApiSlow threshold: 2000 ms.


## Experimental: ## The NewsFeed agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/NewsFeed/StartHandling?$select=name,department,category/id
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

NewsFeedItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NewsFeedItemId | Integer |  |

## Response:bool

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: bool


## Sample request

[!include[sample request](../../samples/agent/request/v1NewsFeedAgent_StartHandling.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1NewsFeedAgent_StartHandling.md)]