---
title: GET ChatTopic/{id}/IsOpen
uid: v1ChatTopicEntity_IsWithinOpeningHours
generated: true
content_type: reference
---

# GET ChatTopic/{id}/IsOpen

```http
GET /api/v1/ChatTopic/{chatTopicId}/IsOpen
```

Check if we are right now within the opening hours of the given topic.


Will use timezones to calculate if configured.





| Path Part | Type | Description |
|-----------|------|-------------|
| chatTopicId | int32 | The id of the topic to check **Required** |



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


## Response:bool

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: bool


## Sample request

[!include[sample request](../../samples/rest/request/v1ChatTopicEntity_IsWithinOpeningHours.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1ChatTopicEntity_IsWithinOpeningHours.md)]