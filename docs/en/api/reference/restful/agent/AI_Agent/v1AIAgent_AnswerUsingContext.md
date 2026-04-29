---
title: POST Agents/AI/AnswerUsingContext
uid: v1AIAgent_AnswerUsingContext
generated: true
content_type: reference
---

# POST Agents/AI/AnswerUsingContext

```http
POST /api/v1/Agents/AI/AnswerUsingContext
```

Returns an answer based on the query, and provided context.


NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/AnswerUsingContext?$select=name,department,category/id
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

NamespaceName, Query, ContextIds, Type, Top 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NamespaceName | String |  |
| Query | String |  |
| ContextIds | RagContextIds | Parameters specifying contact/person/project/sale/ticket ids for populating context. <para /> Carrier object for RagContextIds. Services for the RagContextIds Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAIAgent">AI Agent</see>. |
| Type | String |  |
| Top | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RagAnswer

| Property Name | Type |  Description |
|----------------|------|--------------|
| Answer | string | Response to the question |
| Source | array | Array of sources used to ground the answer. Each source has a chunk of text, relevancy score, title. |
| TrackingId | string | Unique identifier for this answer. Used for correlating feedback to answers |

## Sample request

[!include[sample request](../../samples/agent/request/v1AIAgent_AnswerUsingContext.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1AIAgent_AnswerUsingContext.md)]