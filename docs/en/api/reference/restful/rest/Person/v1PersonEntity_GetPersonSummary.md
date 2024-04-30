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
GET /api/v1/Person/{personId}/Summary?limit=117
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 203,
      "TicketStatus": 646,
      "Title": "temporibus",
      "Registered": "2012-05-30T11:16:13.9957039+02:00",
      "IconHint": "reprehenderit"
    },
    {
      "TicketId": 203,
      "TicketStatus": 646,
      "Title": "temporibus",
      "Registered": "2012-05-30T11:16:13.9957039+02:00",
      "IconHint": "reprehenderit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 578,
      "DocumentId": 153,
      "Date": "2022-05-26T11:16:13.9957039+02:00",
      "Description": "Phased systematic local area network",
      "Completed": "Completed",
      "Registered": "2022-10-17T11:16:13.9957039+02:00"
    },
    {
      "AppointmentId": 578,
      "DocumentId": 153,
      "Date": "2022-05-26T11:16:13.9957039+02:00",
      "Description": "Phased systematic local area network",
      "Completed": "Completed",
      "Registered": "2022-10-17T11:16:13.9957039+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 126,
      "DocumentId": 971,
      "Date": "2024-03-12T11:16:13.9957039+01:00",
      "Description": "Organic client-server forecast",
      "Completed": "Completed",
      "Registered": "1997-10-18T11:16:13.9957039+02:00"
    },
    {
      "AppointmentId": 126,
      "DocumentId": 971,
      "Date": "2024-03-12T11:16:13.9957039+01:00",
      "Description": "Organic client-server forecast",
      "Completed": "Completed",
      "Registered": "1997-10-18T11:16:13.9957039+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 577,
      "SaleDate": "2021-10-18T11:16:13.9957039+02:00",
      "Probability": 421,
      "Heading": "dolore",
      "Amount": 7797.392,
      "Currency": "doloremque",
      "AmountInBaseCurrency": 10232.51,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-06-15T11:16:13.9957039+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 656,
      "Name": "Runolfsdottir Group",
      "CompanyName": "Goodwin, Hagenes and Dach",
      "FirstMessage": "ut",
      "LastMessage": "ea",
      "WhenRequested": "2006-07-17T11:16:13.9957039+02:00",
      "WhenEnded": "2010-11-15T11:16:13.9957039+01:00"
    }
  ]
}
```