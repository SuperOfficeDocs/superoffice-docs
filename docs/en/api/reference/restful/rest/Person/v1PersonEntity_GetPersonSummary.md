---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
generated: true
content_type: reference
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
GET /api/v1/Person/{personId}/Summary?limit=908
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
      "TicketId": 401,
      "TicketStatus": 57,
      "Title": "blanditiis",
      "Registered": "2001-07-13T02:30:52.7726429+02:00",
      "IconHint": "distinctio"
    },
    {
      "TicketId": 401,
      "TicketStatus": 57,
      "Title": "blanditiis",
      "Registered": "2001-07-13T02:30:52.7726429+02:00",
      "IconHint": "distinctio"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 583,
      "DocumentId": 234,
      "Date": "2017-01-16T02:30:52.7726429+01:00",
      "Description": "Future-proofed directional initiative",
      "Completed": "Completed",
      "Registered": "2001-02-21T02:30:52.7726429+01:00"
    },
    {
      "AppointmentId": 583,
      "DocumentId": 234,
      "Date": "2017-01-16T02:30:52.7726429+01:00",
      "Description": "Future-proofed directional initiative",
      "Completed": "Completed",
      "Registered": "2001-02-21T02:30:52.7726429+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 835,
      "DocumentId": 394,
      "Date": "2014-11-09T02:30:52.7726429+01:00",
      "Description": "Persevering object-oriented Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2016-12-13T02:30:52.7726429+01:00"
    },
    {
      "AppointmentId": 835,
      "DocumentId": 394,
      "Date": "2014-11-09T02:30:52.7726429+01:00",
      "Description": "Persevering object-oriented Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2016-12-13T02:30:52.7726429+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 330,
      "SaleDate": "2016-07-28T02:30:52.7726429+02:00",
      "Probability": 309,
      "Heading": "officiis",
      "Amount": 26231.579999999998,
      "Currency": "veritatis",
      "AmountInBaseCurrency": 12686.431999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-11-10T02:30:52.7726429+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 213,
      "Name": "Hane-Larson",
      "CompanyName": "Metz, Hettinger and Corwin",
      "FirstMessage": "error",
      "LastMessage": "ipsam",
      "WhenRequested": "2003-10-04T02:30:52.7726429+02:00",
      "WhenEnded": "1998-09-03T02:30:52.7726429+02:00"
    }
  ]
}
```