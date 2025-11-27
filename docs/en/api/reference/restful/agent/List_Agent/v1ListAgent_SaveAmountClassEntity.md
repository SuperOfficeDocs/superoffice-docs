---
title: POST Agents/List/SaveAmountClassEntity
uid: v1ListAgent_SaveAmountClassEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveAmountClassEntity

```http
POST /api/v1/Agents/List/SaveAmountClassEntity
```

Updates the existing AmountClassEntity or creates a new AmountClassEntity if the id parameter is 0.


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

## Request Body: amountClassEntity 

The AmountClassEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AmountClassId | Integer | Primary key |
| Name | String | The list item |
| Tooltip | String | Tooltip or other description |
| Rank | Integer | Rank order |
| AmountFrom | Number | Lower limit of this amount class |
| AmountTo | Number | Upper limit of this amount class |
| Deleted | Boolean | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| CurrencyId | Integer | Currency the limits in this amount class refer to. Mixing currencies between classes can give rise to overlapping intervals and thus unpredictable classifications. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AmountClassEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| AmountClassId | int32 | Primary key |
| Name | string | The list item |
| Tooltip | string | Tooltip or other description |
| Rank | int32 | Rank order |
| AmountFrom | double | Lower limit of this amount class |
| AmountTo | double | Upper limit of this amount class |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| CurrencyId | int32 | Currency the limits in this amount class refer to. Mixing currencies between classes can give rise to overlapping intervals and thus unpredictable classifications. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1ListAgent_SaveAmountClassEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_SaveAmountClassEntity.md)]