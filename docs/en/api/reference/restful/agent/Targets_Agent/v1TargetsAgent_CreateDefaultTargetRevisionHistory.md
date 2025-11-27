---
title: POST Agents/Targets/CreateDefaultTargetRevisionHistory
uid: v1TargetsAgent_CreateDefaultTargetRevisionHistory
generated: true
content_type: reference
---

# POST Agents/Targets/CreateDefaultTargetRevisionHistory

```http
POST /api/v1/Agents/Targets/CreateDefaultTargetRevisionHistory
```

Loading default values into a new TargetRevisionHistory.


NsApiSlow threshold: 5000 ms.







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TargetRevisionHistory

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetGroupId | int32 | The group id - but it may not still exist |
| Year | int32 | The year this set of targets are associated with (2020, 2021...) |
| Revisions | array | Collection of revisions (with changes) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1TargetsAgent_CreateDefaultTargetRevisionHistory.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1TargetsAgent_CreateDefaultTargetRevisionHistory.md)]