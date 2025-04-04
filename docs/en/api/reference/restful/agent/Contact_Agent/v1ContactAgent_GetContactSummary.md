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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 961,
  "Limit": 917
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
      "TicketId": 561,
      "TicketStatus": 649,
      "Title": "velit",
      "Registered": "2004-07-16T13:13:59.9850807+02:00",
      "IconHint": "occaecati"
    },
    {
      "TicketId": 561,
      "TicketStatus": 649,
      "Title": "velit",
      "Registered": "2004-07-16T13:13:59.9850807+02:00",
      "IconHint": "occaecati"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 391,
      "DocumentId": 867,
      "Date": "2004-08-20T13:13:59.9850807+02:00",
      "Description": "Persistent cohesive utilisation",
      "Completed": "Completed",
      "Registered": "2021-04-30T13:13:59.9850807+02:00"
    },
    {
      "AppointmentId": 391,
      "DocumentId": 867,
      "Date": "2004-08-20T13:13:59.9850807+02:00",
      "Description": "Persistent cohesive utilisation",
      "Completed": "Completed",
      "Registered": "2021-04-30T13:13:59.9850807+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 298,
      "DocumentId": 428,
      "Date": "2015-03-06T13:13:59.9850807+01:00",
      "Description": "Streamlined composite portal",
      "Completed": "Completed",
      "Registered": "2013-07-05T13:13:59.9850807+02:00"
    },
    {
      "AppointmentId": 298,
      "DocumentId": 428,
      "Date": "2015-03-06T13:13:59.9850807+01:00",
      "Description": "Streamlined composite portal",
      "Completed": "Completed",
      "Registered": "2013-07-05T13:13:59.9850807+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 69,
      "SaleDate": "2011-01-09T13:13:59.9850807+01:00",
      "Probability": 176,
      "Heading": "et",
      "Amount": 29663.309999999998,
      "Currency": "porro",
      "AmountInBaseCurrency": 27090.296,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-08-30T13:13:59.9850807+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 757,
      "Name": "Wisozk-Rodriguez",
      "CompanyName": "Tremblay-Shanahan",
      "FirstMessage": "aperiam",
      "LastMessage": "nemo",
      "WhenRequested": "2012-10-25T13:13:59.9850807+02:00",
      "WhenEnded": "2013-06-15T13:13:59.9850807+02:00"
    }
  ]
}
```