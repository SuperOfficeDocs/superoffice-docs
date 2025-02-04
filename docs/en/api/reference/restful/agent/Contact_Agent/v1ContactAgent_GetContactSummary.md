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
  "ContactId": 681,
  "Limit": 260
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
      "TicketId": 974,
      "TicketStatus": 636,
      "Title": "maiores",
      "Registered": "2015-10-07T13:13:22.4926246+02:00",
      "IconHint": "totam"
    },
    {
      "TicketId": 974,
      "TicketStatus": 636,
      "Title": "maiores",
      "Registered": "2015-10-07T13:13:22.4926246+02:00",
      "IconHint": "totam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 277,
      "DocumentId": 675,
      "Date": "2012-06-03T13:13:22.4926246+02:00",
      "Description": "Polarised cohesive Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2018-09-28T13:13:22.4926246+02:00"
    },
    {
      "AppointmentId": 277,
      "DocumentId": 675,
      "Date": "2012-06-03T13:13:22.4926246+02:00",
      "Description": "Polarised cohesive Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2018-09-28T13:13:22.4926246+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 470,
      "DocumentId": 622,
      "Date": "2016-03-11T13:13:22.4926246+01:00",
      "Description": "Monitored stable contingency",
      "Completed": "Completed",
      "Registered": "2017-10-12T13:13:22.4926246+02:00"
    },
    {
      "AppointmentId": 470,
      "DocumentId": 622,
      "Date": "2016-03-11T13:13:22.4926246+01:00",
      "Description": "Monitored stable contingency",
      "Completed": "Completed",
      "Registered": "2017-10-12T13:13:22.4926246+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 949,
      "SaleDate": "2013-12-17T13:13:22.4926246+01:00",
      "Probability": 220,
      "Heading": "rerum",
      "Amount": 26275.456,
      "Currency": "ut",
      "AmountInBaseCurrency": 24112.996,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2022-01-26T13:13:22.4926246+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 409,
      "Name": "Swaniawski, Green and Hane",
      "CompanyName": "Bogisich, Nienow and Gaylord",
      "FirstMessage": "omnis",
      "LastMessage": "ea",
      "WhenRequested": "2023-06-21T13:13:22.4926246+02:00",
      "WhenEnded": "2002-08-08T13:13:22.4926246+02:00"
    }
  ]
}
```