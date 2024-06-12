---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
generated: true
---

# GET Person/{id}/Summary

```http
GET /api/v1/Person/{personId}/Summary
```

Get summary of person and recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Person/{personId}/Summary?limit=275
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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
GET /api/v1/Person/{personId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 811,
      "TicketStatus": 2,
      "Title": "officia",
      "Registered": "2007-03-19T04:22:35.1104546+01:00",
      "IconHint": "deserunt"
    },
    {
      "TicketId": 811,
      "TicketStatus": 2,
      "Title": "officia",
      "Registered": "2007-03-19T04:22:35.1104546+01:00",
      "IconHint": "deserunt"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 691,
      "DocumentId": 542,
      "Date": "2002-08-17T04:22:35.1104546+02:00",
      "Description": "Synchronised background superstructure",
      "Completed": "Completed",
      "Registered": "2011-04-27T04:22:35.1104546+02:00"
    },
    {
      "AppointmentId": 691,
      "DocumentId": 542,
      "Date": "2002-08-17T04:22:35.1104546+02:00",
      "Description": "Synchronised background superstructure",
      "Completed": "Completed",
      "Registered": "2011-04-27T04:22:35.1104546+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 983,
      "DocumentId": 218,
      "Date": "2004-09-26T04:22:35.1104546+02:00",
      "Description": "Business-focused homogeneous frame",
      "Completed": "Completed",
      "Registered": "2006-03-27T04:22:35.1104546+02:00"
    },
    {
      "AppointmentId": 983,
      "DocumentId": 218,
      "Date": "2004-09-26T04:22:35.1104546+02:00",
      "Description": "Business-focused homogeneous frame",
      "Completed": "Completed",
      "Registered": "2006-03-27T04:22:35.1104546+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 128,
      "SaleDate": "2010-11-08T04:22:35.1104546+01:00",
      "Probability": 724,
      "Heading": "dolorem",
      "Amount": 26040.406,
      "Currency": "sint",
      "AmountInBaseCurrency": 21308.066,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2018-04-30T04:22:35.1104546+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 682,
      "Name": "Kilback Inc and Sons",
      "CompanyName": "McCullough-Wyman",
      "FirstMessage": "explicabo",
      "LastMessage": "facere",
      "WhenRequested": "2012-02-21T04:22:35.1104546+01:00",
      "WhenEnded": "2006-08-21T04:22:35.1104546+02:00"
    }
  ]
}
```