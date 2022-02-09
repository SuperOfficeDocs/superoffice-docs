---
title: PUT List/TicketPriority/Items/{id}
id: v1TicketPriorityList_PutTicketPriorityEntity
---

# PUT List/TicketPriority/Items/{id}

```http
PUT /api/v1/List/TicketPriority/Items/{id}
```

Updates the existing TicketPriorityEntity

Calls the List agent service SaveTicketPriorityEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketPriorityEntity to be saved. **Required** |



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

## Request Body: entity  

The details of TicketPriorityEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | int32 | The primary key (auto-incremented) |
| Name | string | The name of the priority. |
| Status | string | The status (normal/deleted) of the priority. |
| Flags | string | A bitmask of flags. |
| SortOrder | int32 | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | string | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | string | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | string | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | string | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | string | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | string | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | int32 | Deadline to add if escalated (minutes) |
| MonStart | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | date-time | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | date-time | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | date-time | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | date-time | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | date-time | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | date-time | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | date-time | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | date-time | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | date-time | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | date-time | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | date-time | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | date-time | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime |
| EscalationLevels | array | Escalation levels bound to the parent priority |


## Response: object

Entity for a ticket priority. This entity describes the meta data for a ticket priority, and provides special operations on it.



Carrier object for TicketPriorityEntity.
Services for the TicketPriorityEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | int32 | The primary key (auto-incremented) |
| Name | string | The name of the priority. |
| Status | string | The status (normal/deleted) of the priority. |
| Flags | string | A bitmask of flags. |
| SortOrder | int32 | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | string | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | string | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | string | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | string | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | string | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | string | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | int32 | Deadline to add if escalated (minutes) |
| MonStart | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | date-time | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | date-time | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | date-time | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | date-time | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | date-time | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | date-time | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | date-time | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | date-time | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | date-time | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | date-time | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | date-time | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | date-time | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime |
| EscalationLevels | array | Escalation levels bound to the parent priority |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 98,
  "Name": "Brakus, Kris and Little",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 154,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 117,
  "MonStart": "1996-02-04T18:25:52.311673+01:00",
  "MonStop": "2004-04-30T18:25:52.311673+02:00",
  "TueStart": "2019-02-25T18:25:52.311673+01:00",
  "TueStop": "2002-12-14T18:25:52.311673+01:00",
  "WedStart": "2001-08-16T18:25:52.311673+02:00",
  "WedStop": "2008-12-27T18:25:52.311673+01:00",
  "ThuStart": "1996-02-21T18:25:52.311673+01:00",
  "ThuStop": "2014-03-20T18:25:52.311673+01:00",
  "FriStart": "2019-04-30T18:25:52.311673+02:00",
  "FriStop": "2003-04-30T18:25:52.311673+02:00",
  "SatStart": "2006-01-29T18:25:52.311673+01:00",
  "SatStop": "1995-09-24T18:25:52.311673+02:00",
  "SunStart": "1998-10-02T18:25:52.311673+02:00",
  "SunStop": "1996-07-10T18:25:52.311673+02:00",
  "NonDates": [
    "recusandae",
    "rerum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 484,
      "AlertLevel": 581,
      "AlertTimeout": 493,
      "Action": 780,
      "DelegateTo": 537,
      "ScriptId": 39,
      "EmailTo": "jules@blockcassin.ca",
      "SmsTo": "ut",
      "ReplyTemplateIdCustomer": 604,
      "ReplyTemplateIdUser": 985,
      "ReplyTemplateIdCatmast": 688,
      "ReplyTemplateIdEmail": 795,
      "RtiCustomerSms": 987,
      "ReplyTemplateIdUserSms": 152,
      "ReplyTemplateIdCatmastSms": 648,
      "ReplyTemplateIdSms": 289
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 904,
  "Name": "Huel, Hintz and Ziemann",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 702,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 503,
  "MonStart": "2002-04-05T18:25:52.311673+02:00",
  "MonStop": "1996-10-17T18:25:52.311673+02:00",
  "TueStart": "2021-03-25T18:25:52.311673+01:00",
  "TueStop": "2008-01-12T18:25:52.311673+01:00",
  "WedStart": "2006-06-22T18:25:52.311673+02:00",
  "WedStop": "1997-10-15T18:25:52.311673+02:00",
  "ThuStart": "2018-04-25T18:25:52.311673+02:00",
  "ThuStop": "2013-02-04T18:25:52.311673+01:00",
  "FriStart": "2013-02-19T18:25:52.311673+01:00",
  "FriStop": "2016-12-16T18:25:52.311673+01:00",
  "SatStart": "2010-10-06T18:25:52.311673+02:00",
  "SatStop": "1999-02-27T18:25:52.311673+01:00",
  "SunStart": "2021-10-31T18:25:52.311673+01:00",
  "SunStop": "2014-01-12T18:25:52.311673+01:00",
  "NonDates": [
    "quas",
    "sint"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 878,
      "AlertLevel": 375,
      "AlertTimeout": 567,
      "Action": 130,
      "DelegateTo": 314,
      "ScriptId": 929,
      "EmailTo": "katheryn@armstrongdickinson.uk",
      "SmsTo": "voluptas",
      "ReplyTemplateIdCustomer": 932,
      "ReplyTemplateIdUser": 830,
      "ReplyTemplateIdCatmast": 270,
      "ReplyTemplateIdEmail": 973,
      "RtiCustomerSms": 314,
      "ReplyTemplateIdUserSms": 351,
      "ReplyTemplateIdCatmastSms": 396,
      "ReplyTemplateIdSms": 219,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 814
    }
  }
}
```