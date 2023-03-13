---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
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
GET /api/v1/Person/{personId}/Summary?limit=292
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
      "TicketId": 869,
      "TicketStatus": 192,
      "Title": "quasi",
      "Registered": "2006-07-13T14:19:10.4592274+02:00",
      "IconHint": "harum"
    },
    {
      "TicketId": 869,
      "TicketStatus": 192,
      "Title": "quasi",
      "Registered": "2006-07-13T14:19:10.4592274+02:00",
      "IconHint": "harum"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 163,
      "DocumentId": 712,
      "Date": "1998-03-26T14:19:10.4592274+01:00",
      "Description": "Multi-layered well-modulated superstructure",
      "Completed": "Completed",
      "Registered": "2011-11-14T14:19:10.4592274+01:00"
    },
    {
      "AppointmentId": 163,
      "DocumentId": 712,
      "Date": "1998-03-26T14:19:10.4592274+01:00",
      "Description": "Multi-layered well-modulated superstructure",
      "Completed": "Completed",
      "Registered": "2011-11-14T14:19:10.4592274+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 633,
      "DocumentId": 678,
      "Date": "2013-08-03T14:19:10.4592274+02:00",
      "Description": "Stand-alone interactive matrices",
      "Completed": "Completed",
      "Registered": "2001-01-16T14:19:10.4592274+01:00"
    },
    {
      "AppointmentId": 633,
      "DocumentId": 678,
      "Date": "2013-08-03T14:19:10.4592274+02:00",
      "Description": "Stand-alone interactive matrices",
      "Completed": "Completed",
      "Registered": "2001-01-16T14:19:10.4592274+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 360,
      "SaleDate": "1996-02-15T14:19:10.4592274+01:00",
      "Probability": 870,
      "Heading": "molestiae",
      "Amount": 28726.244,
      "Currency": "quam",
      "AmountInBaseCurrency": 5142.894,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1996-05-08T14:19:10.4592274+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 510,
      "Name": "Gaylord-Schaefer",
      "CompanyName": "Hartmann, Hauck and Goyette",
      "FirstMessage": "enim",
      "LastMessage": "corrupti",
      "WhenRequested": "2016-03-17T14:19:10.4592274+01:00",
      "WhenEnded": "2004-01-18T14:19:10.4592274+01:00"
    }
  ]
}
```