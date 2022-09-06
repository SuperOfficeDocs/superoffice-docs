---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
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

ContactId, Limit

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| Limit | int32 |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 763,
  "Limit": 818
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 319,
      "TicketStatus": 883,
      "Title": "sunt",
      "Registered": "2015-08-20T11:10:26.3644582+02:00",
      "IconHint": "ab"
    },
    {
      "TicketId": 319,
      "TicketStatus": 883,
      "Title": "sunt",
      "Registered": "2015-08-20T11:10:26.3644582+02:00",
      "IconHint": "ab"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 748,
      "DocumentId": 147,
      "Date": "1996-08-09T11:10:26.3644582+02:00",
      "Description": "Proactive cohesive definition",
      "Completed": "Completed",
      "Registered": "2016-06-04T11:10:26.3644582+02:00"
    },
    {
      "AppointmentId": 748,
      "DocumentId": 147,
      "Date": "1996-08-09T11:10:26.3644582+02:00",
      "Description": "Proactive cohesive definition",
      "Completed": "Completed",
      "Registered": "2016-06-04T11:10:26.3644582+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 127,
      "DocumentId": 414,
      "Date": "2020-05-08T11:10:26.3644582+02:00",
      "Description": "Compatible responsive projection",
      "Completed": "Completed",
      "Registered": "1996-05-05T11:10:26.3644582+02:00"
    },
    {
      "AppointmentId": 127,
      "DocumentId": 414,
      "Date": "2020-05-08T11:10:26.3644582+02:00",
      "Description": "Compatible responsive projection",
      "Completed": "Completed",
      "Registered": "1996-05-05T11:10:26.3644582+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 468,
      "SaleDate": "2017-11-18T11:10:26.3644582+01:00",
      "Probability": 564,
      "Heading": "a",
      "Amount": 28936.221999999998,
      "Currency": "ut",
      "AmountInBaseCurrency": 21521.178,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-09-23T11:10:26.3644582+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 743,
      "Name": "Thiel Inc and Sons",
      "CompanyName": "Weber Inc and Sons",
      "FirstMessage": "laborum",
      "LastMessage": "voluptas",
      "WhenRequested": "2015-11-15T11:10:26.3644582+01:00",
      "WhenEnded": "2018-11-09T11:10:26.3644582+01:00"
    }
  ]
}
```
