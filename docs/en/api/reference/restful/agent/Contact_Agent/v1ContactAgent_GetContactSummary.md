---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
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
  "ContactId": 313,
  "Limit": 723
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
      "TicketId": 48,
      "TicketStatus": 584,
      "Title": "doloremque",
      "Registered": "2003-05-06T11:44:33.1504543+02:00",
      "IconHint": "et"
    },
    {
      "TicketId": 48,
      "TicketStatus": 584,
      "Title": "doloremque",
      "Registered": "2003-05-06T11:44:33.1504543+02:00",
      "IconHint": "et"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 927,
      "DocumentId": 876,
      "Date": "2021-12-14T11:44:33.1504543+01:00",
      "Description": "Intuitive hybrid focus group",
      "Completed": "Completed",
      "Registered": "2023-09-01T11:44:33.1504543+02:00"
    },
    {
      "AppointmentId": 927,
      "DocumentId": 876,
      "Date": "2021-12-14T11:44:33.1504543+01:00",
      "Description": "Intuitive hybrid focus group",
      "Completed": "Completed",
      "Registered": "2023-09-01T11:44:33.1504543+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 492,
      "DocumentId": 99,
      "Date": "2024-02-04T11:44:33.1504543+01:00",
      "Description": "Progressive content-based moderator",
      "Completed": "Completed",
      "Registered": "2022-08-15T11:44:33.1504543+02:00"
    },
    {
      "AppointmentId": 492,
      "DocumentId": 99,
      "Date": "2024-02-04T11:44:33.1504543+01:00",
      "Description": "Progressive content-based moderator",
      "Completed": "Completed",
      "Registered": "2022-08-15T11:44:33.1504543+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 821,
      "SaleDate": "2008-09-18T11:44:33.1504543+02:00",
      "Probability": 951,
      "Heading": "ea",
      "Amount": 24677.115999999998,
      "Currency": "eos",
      "AmountInBaseCurrency": 4208.9619999999995,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2010-11-02T11:44:33.1504543+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 92,
      "Name": "Smitham-Wintheiser",
      "CompanyName": "Von, Halvorson and Beatty",
      "FirstMessage": "architecto",
      "LastMessage": "tempora",
      "WhenRequested": "2006-05-17T11:44:33.1504543+02:00",
      "WhenEnded": "2020-10-15T11:44:33.1504543+02:00"
    }
  ]
}
```