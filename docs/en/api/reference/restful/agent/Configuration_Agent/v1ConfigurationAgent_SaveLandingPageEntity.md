---
title: POST Agents/Configuration/SaveLandingPageEntity
uid: v1ConfigurationAgent_SaveLandingPageEntity
generated: true
content_type: reference
---

# POST Agents/Configuration/SaveLandingPageEntity

```http
POST /api/v1/Agents/Configuration/SaveLandingPageEntity
```

Updates the existing LandingPageEntity or creates a new LandingPageEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: landingPageEntity 

The LandingPageEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LandingPageId | Integer |  |
| AssociateId | Integer |  |
| EntityTableName | String |  |
| SelectionId | Integer |  |
| PinnedSelections | Array |  |
| PinnedEntities | Array |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TimeZoneData

| Property Name | Type |  Description |
|----------------|------|--------------|
| LandingPageId | int32 |  |
| AssociateId | int32 |  |
| EntityTableName | string |  |
| SelectionId | int32 |  |
| PinnedSelections | array |  |
| PinnedEntities | array |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1ConfigurationAgent_SaveLandingPageEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ConfigurationAgent_SaveLandingPageEntity.md)]