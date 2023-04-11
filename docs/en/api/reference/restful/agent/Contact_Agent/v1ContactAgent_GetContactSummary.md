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
| ContactId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
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
  "ContactId": 662,
  "Limit": 651
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
      "TicketId": 121,
      "TicketStatus": 465,
      "Title": "explicabo",
      "Registered": "2010-07-05T15:29:21.2307827+02:00",
      "IconHint": "sunt"
    },
    {
      "TicketId": 121,
      "TicketStatus": 465,
      "Title": "explicabo",
      "Registered": "2010-07-05T15:29:21.2307827+02:00",
      "IconHint": "sunt"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 362,
      "DocumentId": 642,
      "Date": "2008-10-21T15:29:21.2307827+02:00",
      "Description": "Team-oriented human-resource capability",
      "Completed": "Completed",
      "Registered": "2015-10-12T15:29:21.2307827+02:00"
    },
    {
      "AppointmentId": 362,
      "DocumentId": 642,
      "Date": "2008-10-21T15:29:21.2307827+02:00",
      "Description": "Team-oriented human-resource capability",
      "Completed": "Completed",
      "Registered": "2015-10-12T15:29:21.2307827+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 687,
      "DocumentId": 451,
      "Date": "2022-03-18T15:29:21.2307827+01:00",
      "Description": "Diverse composite encoding",
      "Completed": "Completed",
      "Registered": "2008-06-21T15:29:21.2307827+02:00"
    },
    {
      "AppointmentId": 687,
      "DocumentId": 451,
      "Date": "2022-03-18T15:29:21.2307827+01:00",
      "Description": "Diverse composite encoding",
      "Completed": "Completed",
      "Registered": "2008-06-21T15:29:21.2307827+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 338,
      "SaleDate": "2001-12-21T15:29:21.2307827+01:00",
      "Probability": 927,
      "Heading": "perspiciatis",
      "Amount": 7976.03,
      "Currency": "odio",
      "AmountInBaseCurrency": 6669.152,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-08-31T15:29:21.2307827+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 640,
      "Name": "Lueilwitz LLC",
      "CompanyName": "Schowalter, Wehner and Lubowitz",
      "FirstMessage": "impedit",
      "LastMessage": "sapiente",
      "WhenRequested": "1999-07-02T15:29:21.2307827+02:00",
      "WhenEnded": "2005-01-27T15:29:21.2307827+01:00"
    }
  ]
}
```