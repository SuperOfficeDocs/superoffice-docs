---
title: POST Agents/EMail/GetEmailAppointment
id: v1EMailAgent_GetEmailAppointment
---

# POST Agents/EMail/GetEmailAppointment

```http
POST /api/v1/Agents/EMail/GetEmailAppointment
```

Get appointment data contained in the emails iCal attachment



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEmailAppointment?$select=name,department,category/id
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

MailItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailItemId | int32 |  |


## Response: object

Information about an email appointment received as iCal data



Carrier object for EMailAppointment.
Services for the EMailAppointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Appointment information |
| CalMethod | string | Method field stored in ICS file. |
| Participants | array | List of participants in the iCal file - first one being the organizer |
| Comment | string | Comment attached to the calendar event (accept / reject reason etc.) |
| Sequence | int32 | Sequence number in ICS file. |
| DtStart | date-time | Start date/time in ICS file. |
| DtEnd | date-time | End date/time in ICS file. |
| Superseded | bool | A newer invitation exists |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetEmailAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MailItemId": 805
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 498,
    "StartDate": "1999-01-29T18:28:49.0119589+01:00",
    "EndDate": "2015-02-04T18:28:49.0119589+01:00",
    "Type": "BookingForChecklist",
    "Task": "autem",
    "AssociateFullName": "Shayne Ankunding",
    "ContactName": "Morissette, Hyatt and Shanahan",
    "Description": "Proactive directional pricing structure",
    "PersonFullName": "Mrs. Austin Olson",
    "PersonId": 650,
    "ContactId": 397,
    "ProjectId": 281,
    "ProjectName": "Davis Group",
    "IsPublished": true,
    "AssociateId": 161,
    "ColorIndex": 302,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 962,
    "PriorityName": "Kihn Inc and Sons",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2020-07-25T18:28:49.012956+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2010-09-16T18:28:49.012956+02:00",
    "RecurringEndDate": "2011-04-06T18:28:49.012956+02:00",
    "MotherId": 974,
    "AssignedBy": 387,
    "AssignedByFullName": "Coralie Bahringer",
    "RejectReason": "",
    "Location": "omnis",
    "AlarmLeadTime": "maiores",
    "SaleId": 489,
    "SaleName": "Runte LLC",
    "AssociateName": "Ritchie, Stamm and Dickens",
    "CreatedDate": "1998-03-02T18:28:49.012956+01:00",
    "CreatedBy": "voluptas",
    "CreatedByFullName": "Jovan Kris",
    "CreatedByAssociateId": 375,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 736
      }
    }
  },
  "CalMethod": "Add",
  "Participants": [
    "quod",
    "voluptas"
  ],
  "Comment": "dolor",
  "Sequence": 564,
  "DtStart": "2016-10-20T18:28:49.012956+02:00",
  "DtEnd": "1995-02-08T18:28:49.012956+01:00",
  "Superseded": true,
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
      "FieldLength": 538
    }
  }
}
```