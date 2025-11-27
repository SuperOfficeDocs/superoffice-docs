---
title: POST Agents/Pocket/GetMyCallerIDs
uid: v1PocketAgent_GetMyCallerIDs
generated: true
content_type: reference
---

# POST Agents/Pocket/GetMyCallerIDs

```http
POST /api/v1/Agents/Pocket/GetMyCallerIDs
```

Get caller ids that the current principal might be interested in (phone numbers of related persons in sales and appointments created/owned/touched by ourselves or colleagues in our primary group


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Pocket/GetMyCallerIDs?$select=name,department,category/id
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

LastHash, MinDate, MaxDate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LastHash | String |  |
| MinDate | String |  |
| MaxDate | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CallerIDCollection

| Property Name | Type |  Description |
|----------------|------|--------------|
| CallerIDHash | string | Hash of the caller ids, used for checking if the same set of caller ids was sent earlier |
| CallerIDs | array | Array of caller ids, sorted numerically on the phone number |

## Sample request

[!include[sample request](../../samples/agent/request/v1PocketAgent_GetMyCallerIDs.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1PocketAgent_GetMyCallerIDs.md)]