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
GET /api/v1/Person/{personId}/Summary?limit=773
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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | Simple Person data. |
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
      "TicketId": 541,
      "TicketStatus": 530,
      "Title": "dolores",
      "Registered": "2019-03-29T02:49:51.2921904+01:00",
      "IconHint": "ea"
    },
    {
      "TicketId": 541,
      "TicketStatus": 530,
      "Title": "dolores",
      "Registered": "2019-03-29T02:49:51.2921904+01:00",
      "IconHint": "ea"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 66,
      "DocumentId": 835,
      "Date": "2002-07-16T02:49:51.2921904+02:00",
      "Description": "Re-contextualized value-added matrices",
      "Completed": "Completed",
      "Registered": "2003-10-03T02:49:51.2921904+02:00"
    },
    {
      "AppointmentId": 66,
      "DocumentId": 835,
      "Date": "2002-07-16T02:49:51.2921904+02:00",
      "Description": "Re-contextualized value-added matrices",
      "Completed": "Completed",
      "Registered": "2003-10-03T02:49:51.2921904+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 321,
      "DocumentId": 421,
      "Date": "2000-04-07T02:49:51.2921904+02:00",
      "Description": "Quality-focused scalable superstructure",
      "Completed": "Completed",
      "Registered": "2002-04-26T02:49:51.2921904+02:00"
    },
    {
      "AppointmentId": 321,
      "DocumentId": 421,
      "Date": "2000-04-07T02:49:51.2921904+02:00",
      "Description": "Quality-focused scalable superstructure",
      "Completed": "Completed",
      "Registered": "2002-04-26T02:49:51.2921904+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 23,
      "SaleDate": "2002-12-18T02:49:51.2921904+01:00",
      "Probability": 187,
      "Heading": "dolore",
      "Amount": 10361.003999999999,
      "Currency": "alias",
      "AmountInBaseCurrency": 24940.372,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-01-27T02:49:51.2921904+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 991,
      "Name": "Wuckert, Bashirian and Harris",
      "CompanyName": "Armstrong, Roob and Goyette",
      "FirstMessage": "explicabo",
      "LastMessage": "ducimus",
      "WhenRequested": "2000-06-27T02:49:51.2921904+02:00",
      "WhenEnded": "1999-02-05T02:49:51.2921904+01:00"
    }
  ]
}
```