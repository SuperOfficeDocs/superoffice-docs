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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 726,
  "Limit": 694
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
      "TicketId": 646,
      "TicketStatus": 517,
      "Title": "atque",
      "Registered": "2017-11-21T04:22:26.2934337+01:00",
      "IconHint": "quas"
    },
    {
      "TicketId": 646,
      "TicketStatus": 517,
      "Title": "atque",
      "Registered": "2017-11-21T04:22:26.2934337+01:00",
      "IconHint": "quas"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 30,
      "DocumentId": 933,
      "Date": "2010-03-24T04:22:26.2934337+01:00",
      "Description": "Universal systemic Graphical User Interface",
      "Completed": "Completed",
      "Registered": "1997-09-16T04:22:26.2934337+02:00"
    },
    {
      "AppointmentId": 30,
      "DocumentId": 933,
      "Date": "2010-03-24T04:22:26.2934337+01:00",
      "Description": "Universal systemic Graphical User Interface",
      "Completed": "Completed",
      "Registered": "1997-09-16T04:22:26.2934337+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 622,
      "DocumentId": 423,
      "Date": "2018-01-28T04:22:26.2934337+01:00",
      "Description": "Assimilated 24 hour support",
      "Completed": "Completed",
      "Registered": "2017-05-23T04:22:26.2934337+02:00"
    },
    {
      "AppointmentId": 622,
      "DocumentId": 423,
      "Date": "2018-01-28T04:22:26.2934337+01:00",
      "Description": "Assimilated 24 hour support",
      "Completed": "Completed",
      "Registered": "2017-05-23T04:22:26.2934337+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 432,
      "SaleDate": "2011-05-15T04:22:26.2934337+02:00",
      "Probability": 696,
      "Heading": "dolorem",
      "Amount": 29011.438,
      "Currency": "consequuntur",
      "AmountInBaseCurrency": 5694.478,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2022-09-22T04:22:26.2934337+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 130,
      "Name": "Kunde, Rodriguez and O'Conner",
      "CompanyName": "Kassulke-Weissnat",
      "FirstMessage": "vero",
      "LastMessage": "molestias",
      "WhenRequested": "2000-03-29T04:22:26.2934337+02:00",
      "WhenEnded": "2013-02-01T04:22:26.2934337+01:00"
    }
  ]
}
```