---
title: POST List/TicketPriority/Items
id: v1TicketPriorityList_PostTicketPriorityEntity
---

# POST List/TicketPriority/Items

```http
POST /api/v1/List/TicketPriority/Items
```

Create a new TicketPriorityEntity list item

Calls the List agent service SaveTicketPriorityEntity.






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

## Request Body: newEntity  

The TicketPriorityEntity to be created. 

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
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 546,
  "Name": "Hartmann-Hoppe",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 691,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 788,
  "MonStart": "2002-09-03T18:25:52.3076722+02:00",
  "MonStop": "2004-12-05T18:25:52.3076722+01:00",
  "TueStart": "2018-12-21T18:25:52.3076722+01:00",
  "TueStop": "2000-06-16T18:25:52.3076722+02:00",
  "WedStart": "1995-09-24T18:25:52.3076722+02:00",
  "WedStop": "2019-12-14T18:25:52.3076722+01:00",
  "ThuStart": "2009-06-11T18:25:52.3076722+02:00",
  "ThuStop": "2006-12-18T18:25:52.3076722+01:00",
  "FriStart": "2015-05-15T18:25:52.3076722+02:00",
  "FriStop": "2021-03-17T18:25:52.3076722+01:00",
  "SatStart": "2017-10-21T18:25:52.3076722+02:00",
  "SatStop": "2006-07-07T18:25:52.3076722+02:00",
  "SunStart": "2011-12-22T18:25:52.3076722+01:00",
  "SunStop": "2013-12-19T18:25:52.3076722+01:00",
  "NonDates": [
    "minima",
    "eos"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 991,
      "AlertLevel": 49,
      "AlertTimeout": 498,
      "Action": 39,
      "DelegateTo": 201,
      "ScriptId": 740,
      "EmailTo": "gabriella.haley@gleichner.name",
      "SmsTo": "numquam",
      "ReplyTemplateIdCustomer": 191,
      "ReplyTemplateIdUser": 956,
      "ReplyTemplateIdCatmast": 884,
      "ReplyTemplateIdEmail": 505,
      "RtiCustomerSms": 58,
      "ReplyTemplateIdUserSms": 542,
      "ReplyTemplateIdCatmastSms": 1000,
      "ReplyTemplateIdSms": 347
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 793,
  "Name": "Legros, Stracke and Swaniawski",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 265,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 527,
  "MonStart": "1998-03-04T18:25:52.3086802+01:00",
  "MonStop": "2001-10-05T18:25:52.3086802+02:00",
  "TueStart": "2002-10-06T18:25:52.3086802+02:00",
  "TueStop": "2002-04-20T18:25:52.3086802+02:00",
  "WedStart": "1997-12-19T18:25:52.3086802+01:00",
  "WedStop": "2019-01-19T18:25:52.3086802+01:00",
  "ThuStart": "2018-09-23T18:25:52.3086802+02:00",
  "ThuStop": "2013-03-26T18:25:52.3086802+01:00",
  "FriStart": "2007-10-04T18:25:52.3086802+02:00",
  "FriStop": "2008-06-08T18:25:52.3086802+02:00",
  "SatStart": "1997-10-20T18:25:52.3086802+02:00",
  "SatStop": "2020-04-09T18:25:52.3086802+02:00",
  "SunStart": "2012-05-09T18:25:52.3086802+02:00",
  "SunStop": "2020-01-03T18:25:52.3086802+01:00",
  "NonDates": [
    "qui",
    "nobis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 865,
      "AlertLevel": 447,
      "AlertTimeout": 578,
      "Action": 240,
      "DelegateTo": 724,
      "ScriptId": 747,
      "EmailTo": "murphy@keebler.name",
      "SmsTo": "perspiciatis",
      "ReplyTemplateIdCustomer": 139,
      "ReplyTemplateIdUser": 801,
      "ReplyTemplateIdCatmast": 941,
      "ReplyTemplateIdEmail": 207,
      "RtiCustomerSms": 486,
      "ReplyTemplateIdUserSms": 301,
      "ReplyTemplateIdCatmastSms": 781,
      "ReplyTemplateIdSms": 685,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 374
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
      "FieldType": "System.Int32",
      "FieldLength": 621
    }
  }
}
```