---
title: GetEmailAppointment
id: v1EMailAgent_GetEmailAppointment
---

# GetEmailAppointment

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MailItemId": 555
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 113,
    "StartDate": "2018-06-01T14:58:04.0974669+02:00",
    "EndDate": "2011-07-21T14:58:04.0974669+02:00",
    "Type": "BookingForChecklist",
    "Task": "ea",
    "AssociateFullName": "Leonel Kulas",
    "ContactName": "Grady, Will and Jacobi",
    "Description": "Profit-focused grid-enabled migration",
    "PersonFullName": "Phoebe Swift",
    "PersonId": 864,
    "ContactId": 783,
    "ProjectId": 8,
    "ProjectName": "Vandervort LLC",
    "IsPublished": false,
    "AssociateId": 916,
    "ColorIndex": 302,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 849,
    "PriorityName": "Armstrong, Bins and Beahan",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1996-07-07T14:58:04.0974669+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1997-08-21T14:58:04.0974669+02:00",
    "RecurringEndDate": "1997-03-08T14:58:04.0974669+01:00",
    "MotherId": 470,
    "AssignedBy": 164,
    "AssignedByFullName": "Favian Collins V",
    "RejectReason": "streamline bleeding-edge vortals",
    "Location": "corrupti",
    "AlarmLeadTime": "nesciunt",
    "SaleId": 624,
    "SaleName": "Borer-Brown",
    "AssociateName": "Nader, Hills and McDermott",
    "CreatedDate": "2003-02-23T14:58:04.0984659+01:00",
    "CreatedBy": "dicta",
    "CreatedByFullName": "Sallie Hauck II",
    "CreatedByAssociateId": 821,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 984
      }
    }
  },
  "CalMethod": "Add",
  "Participants": [
    "nulla",
    "aut"
  ],
  "Comment": "aut",
  "Sequence": 591,
  "DtStart": "2010-11-28T14:58:04.0984659+01:00",
  "DtEnd": "2000-05-12T14:58:04.0984659+02:00",
  "Superseded": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "implement leading-edge methodologies"
      },
      "FieldType": "System.Int32",
      "FieldLength": 525
    }
  }
}
```