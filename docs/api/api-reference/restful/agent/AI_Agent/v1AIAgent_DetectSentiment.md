---
title: POST Agents/AI/DetectSentiment
id: v1AIAgent_DetectSentiment
---

# POST Agents/AI/DetectSentiment

```http
POST /api/v1/Agents/AI/DetectSentiment
```

Detect the sentiment of a (reasonably short) text.

Sentiment analysis may cause a translation to be made, since sentiment analysis only supports a limited set of languages





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/DetectSentiment?$select=name,department,category/id
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

Text 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Text | string |  |


## Response: object

Sentiment information: Score (-100 to 100) and Confidence (0 to 100)



Carrier object for Sentiment.
Services for the Sentiment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAIAgent">AI Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Score | int32 | Sentiment score, -100 = very unhappy, 100 = very happy, 0 = no idea (not recognized) |
| Confidence | int32 | Sentiment analysis confidence, where available. 0 = no idea, 100 = perfectly confident, -1 = no confidence score available |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/AI/DetectSentiment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Text": "est"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Score": 197,
  "Confidence": 390,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 690
    }
  }
}
```