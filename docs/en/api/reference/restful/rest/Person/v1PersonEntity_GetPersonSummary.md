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
GET /api/v1/Person/{personId}/Summary?limit=289
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 351,
      "TicketStatus": 738,
      "Title": "eum",
      "Registered": "2007-08-31T14:28:27.008316+02:00",
      "IconHint": "accusantium"
    },
    {
      "TicketId": 351,
      "TicketStatus": 738,
      "Title": "eum",
      "Registered": "2007-08-31T14:28:27.008316+02:00",
      "IconHint": "accusantium"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 774,
      "DocumentId": 639,
      "Date": "2000-04-17T14:28:27.008316+02:00",
      "Description": "Re-contextualized cohesive throughput",
      "Completed": "Completed",
      "Registered": "2024-10-29T14:28:27.008316+01:00"
    },
    {
      "AppointmentId": 774,
      "DocumentId": 639,
      "Date": "2000-04-17T14:28:27.008316+02:00",
      "Description": "Re-contextualized cohesive throughput",
      "Completed": "Completed",
      "Registered": "2024-10-29T14:28:27.008316+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 367,
      "DocumentId": 922,
      "Date": "1999-06-20T14:28:27.008316+02:00",
      "Description": "Re-engineered bandwidth-monitored array",
      "Completed": "Completed",
      "Registered": "2007-07-31T14:28:27.008316+02:00"
    },
    {
      "AppointmentId": 367,
      "DocumentId": 922,
      "Date": "1999-06-20T14:28:27.008316+02:00",
      "Description": "Re-engineered bandwidth-monitored array",
      "Completed": "Completed",
      "Registered": "2007-07-31T14:28:27.008316+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 468,
      "SaleDate": "2014-12-13T14:28:27.008316+01:00",
      "Probability": 483,
      "Heading": "qui",
      "Amount": 22514.656,
      "Currency": "unde",
      "AmountInBaseCurrency": 10329.663999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2015-07-14T14:28:27.008316+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 777,
      "Name": "Schroeder Group",
      "CompanyName": "Dare LLC",
      "FirstMessage": "officiis",
      "LastMessage": "quod",
      "WhenRequested": "2022-07-22T14:28:27.008316+02:00",
      "WhenEnded": "2022-05-04T14:28:27.008316+02:00"
    }
  ]
}
```