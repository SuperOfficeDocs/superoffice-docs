---
title: POST Agents/Sale/SaveSaleEntity
id: v1SaleAgent_SaveSaleEntity
---

# POST Agents/Sale/SaveSaleEntity

```http
POST /api/v1/Agents/Sale/SaveSaleEntity
```

Updates the existing SaleEntity or creates a new SaleEntity if the id parameter is empty








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

The SaleEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object

Partial SaleEntity class associating the generated SaleEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/SaveSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 763,
    "StartDate": "2009-04-30T18:28:50.0756702+02:00",
    "EndDate": "2021-05-14T18:28:50.0756702+02:00",
    "Type": "BookingForChecklist",
    "Task": "molestias",
    "AssociateFullName": "Mathew Sporer",
    "ContactName": "Hackett-Batz",
    "Description": "Optional interactive service-desk",
    "PersonFullName": "Jude Schroeder",
    "PersonId": 12,
    "ContactId": 81,
    "ProjectId": 206,
    "ProjectName": "Kunde LLC",
    "IsPublished": false,
    "AssociateId": 46,
    "ColorIndex": 426,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 619,
    "PriorityName": "Labadie-Hilll",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1996-11-03T18:28:50.0766687+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2017-01-30T18:28:50.0766687+01:00",
    "RecurringEndDate": "2010-03-24T18:28:50.0766687+01:00",
    "MotherId": 824,
    "AssignedBy": 571,
    "AssignedByFullName": "Abigail Pacocha",
    "RejectReason": "",
    "Location": "et",
    "AlarmLeadTime": "sapiente",
    "SaleId": 527,
    "SaleName": "Kessler, Boehm and Witting",
    "AssociateName": "Walter Inc and Sons",
    "CreatedDate": "2002-12-26T18:28:50.0766687+01:00",
    "CreatedBy": "ab",
    "CreatedByFullName": "Neal Russel DDS",
    "CreatedByAssociateId": 105,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 246,
    "Name": "Goldner-Brekke",
    "PersonId": 770,
    "Rank": 674,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 790,
    "FullName": "Mafalda Johnston",
    "FormalName": "Quigley, Stoltenberg and Casper",
    "Deleted": true,
    "EjUserId": 75,
    "UserName": "Sipes Group"
  },
  "UpdatedBy": {
    "AssociateId": 602,
    "Name": "Frami Inc and Sons",
    "PersonId": 498,
    "Rank": 379,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 254,
    "FullName": "Bailee Jaskolski",
    "FormalName": "Feest Group",
    "Deleted": false,
    "EjUserId": 28,
    "UserName": "Kris, Fay and Hamill"
  },
  "CreatedBy": {
    "AssociateId": 16,
    "Name": "Gleichner-Witting",
    "PersonId": 343,
    "Rank": 313,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 840,
    "FullName": "George Trantow",
    "FormalName": "Stracke Group",
    "Deleted": true,
    "EjUserId": 242,
    "UserName": "VonRueden, Runolfsdottir and Okuneva"
  },
  "Contact": {
    "ContactId": 91,
    "Name": "Gusikowski LLC",
    "OrgNr": "897338",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dignissimos",
    "DirectPhone": "1-520-664-0315",
    "AssociateId": 576,
    "CountryId": 733,
    "EmailAddress": "alec.armstrong@bahringer.ca",
    "Kananame": "iste",
    "EmailAddressName": "gladyce@osinski.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lonny Huels",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "placeat",
    "FullName": "Charlie Boyle",
    "IsOwnerContact": false,
    "ActiveErpLinks": 652
  },
  "Project": {
    "ProjectId": 206,
    "Name": "Reichel-Cronin",
    "Description": "Cloned executive infrastructure",
    "URL": "http://www.example.com/",
    "Type": "doloribus",
    "AssociateId": 612,
    "AssociateFullName": "Kiana Dietrich",
    "TypeId": 861,
    "Updated": "1999-06-23T18:28:50.0807001+02:00",
    "StatusId": 324,
    "Status": "nobis",
    "TextId": 374,
    "PublishTo": "1999-06-12T18:28:50.0807001+02:00",
    "PublishFrom": "1998-07-08T18:28:50.0807001+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1499013",
    "ActiveErpLinks": 784
  },
  "SaleText": "suscipit",
  "Person": {
    "Position": "minima",
    "PersonId": 798,
    "Mrmrs": "necessitatibus",
    "Firstname": "Amy",
    "Lastname": "Dooley",
    "MiddleName": "Von-McKenzie",
    "Title": "enim",
    "Description": "Assimilated high-level Graphic Interface",
    "Email": "ara.friesen@leschboyer.uk",
    "FullName": "Jensen Reinger",
    "DirectPhone": "1-708-731-0581",
    "FormalName": "Howell, Larkin and Ziemann",
    "CountryId": 482,
    "ContactId": 904,
    "ContactName": "Harber, Jerde and Hauck",
    "Retired": 363,
    "Rank": 459,
    "ActiveInterests": 149,
    "ContactDepartment": "",
    "ContactCountryId": 774,
    "ContactOrgNr": "1038108",
    "FaxPhone": "778.318.3286 x0108",
    "MobilePhone": "626.630.1650",
    "ContactPhone": "738.307.5261",
    "AssociateName": "Johnston Inc and Sons",
    "AssociateId": 612,
    "UsePersonAddress": false,
    "ContactFax": "rerum",
    "Kanafname": "ipsam",
    "Kanalname": "voluptas",
    "Post1": "inventore",
    "Post2": "ad",
    "Post3": "quibusdam",
    "EmailName": "napoleon@cronahegmann.us",
    "ContactFullName": "Bo Bergnaum",
    "ActiveErpLinks": 310,
    "TicketPriorityId": 578,
    "SupportLanguageId": 614,
    "SupportAssociateId": 172,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 492,
    "Value": "voluptatem",
    "Tooltip": "totam"
  },
  "Competitor": {
    "Id": 883,
    "Value": "quia",
    "Tooltip": "nulla"
  },
  "Credited": {
    "Id": 249,
    "Value": "dolore",
    "Tooltip": "veritatis"
  },
  "Rating": {
    "Id": 318,
    "Value": "similique",
    "Tooltip": "perferendis"
  },
  "Reason": {
    "Id": 49,
    "Value": "atque",
    "Tooltip": "doloribus"
  },
  "Source": {
    "Id": 942,
    "Value": "ducimus",
    "Tooltip": "non"
  },
  "Status": "Lost",
  "Saledate": "2011-10-15T18:28:50.0816964+02:00",
  "Amount": 12645.689999999999,
  "SaleId": 144,
  "Earning": 25009.32,
  "EarningPercent": 16980.012,
  "Heading": "aut",
  "Number": "1321535",
  "Probability": 633,
  "CreatedDate": "2003-05-31T18:28:50.0816964+02:00",
  "UpdatedDate": "2015-12-31T18:28:50.0816964+01:00",
  "Completed": "Completed",
  "ActiveLinks": 386,
  "Links": [
    {
      "EntityName": "Brakus-Kshlerin",
      "Id": 717,
      "Description": "Self-enabling regional policy",
      "ExtraInfo": "animi",
      "LinkId": 125
    },
    {
      "EntityName": "Brakus-Kshlerin",
      "Id": 717,
      "Description": "Self-enabling regional policy",
      "ExtraInfo": "animi",
      "LinkId": 125
    }
  ],
  "NextDueDate": "1996-09-25T18:28:50.0816964+02:00",
  "Postit": "ipsa",
  "SaleType": {
    "Id": 267,
    "Value": "qui",
    "Tooltip": "harum"
  },
  "ReasonSold": {
    "Id": 324,
    "Value": "debitis",
    "Tooltip": "aut"
  },
  "ReasonStalled": {
    "Id": 991,
    "Value": "repellat",
    "Tooltip": "rerum"
  },
  "ReopenDate": "2002-06-18T18:28:50.0816964+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Hilpert-Hermann",
      "Comment": "est",
      "StakeholderRoleId": 513,
      "CountryId": 839,
      "PersonId": 668,
      "EmailDescription": "marley_cruickshank@schneider.com",
      "EmailId": 280,
      "EmailAddress": "gregorio_mraz@trantow.ca",
      "PhoneId": 205,
      "ContactName": "Kulas, Dietrich and Schoen",
      "ContactId": 307,
      "SaleId": 100,
      "Mrmrs": "numquam",
      "Firstname": "Nettie",
      "MiddleName": "Rau-Haley",
      "Lastname": "Romaguera",
      "SaleStakeholderId": 690,
      "Rank": 65,
      "Phone": "(857)840-0268"
    }
  ],
  "ActiveErpLinks": 242,
  "UserDefinedFields": {
    "SuperOffice:1": "Jalen Murray",
    "SuperOffice:2": "Celestino Leuschke"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "cupiditate"
  },
  "PublishEventDate": "1995-07-12T18:28:50.0826987+02:00",
  "PublishTo": "2000-06-04T18:28:50.0826987+02:00",
  "PublishFrom": "2002-05-24T18:28:50.0826987+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 348,
      "Visibility": "All",
      "DisplayValue": "dolor"
    },
    {
      "VisibleId": 348,
      "Visibility": "All",
      "DisplayValue": "dolor"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 408,
    "StartDate": "2001-04-28T18:28:50.1417779+02:00",
    "EndDate": "2013-02-05T18:28:50.1417779+01:00",
    "Type": "BookingForChecklist",
    "Task": "repudiandae",
    "AssociateFullName": "Ms. Eulah Effertz",
    "ContactName": "McClure, Willms and Osinski",
    "Description": "Pre-emptive exuding matrices",
    "PersonFullName": "Brandi Murphy",
    "PersonId": 413,
    "ContactId": 917,
    "ProjectId": 806,
    "ProjectName": "Hettinger, Hagenes and Waters",
    "IsPublished": true,
    "AssociateId": 492,
    "ColorIndex": 491,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 572,
    "PriorityName": "Kertzmann-Littel",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "1997-04-16T18:28:50.1427699+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2015-06-08T18:28:50.1427699+02:00",
    "RecurringEndDate": "1998-03-02T18:28:50.1427699+01:00",
    "MotherId": 478,
    "AssignedBy": 656,
    "AssignedByFullName": "Shane Schiller",
    "RejectReason": "",
    "Location": "et",
    "AlarmLeadTime": "est",
    "SaleId": 985,
    "SaleName": "Borer, Stanton and Kemmer",
    "AssociateName": "Howe LLC",
    "CreatedDate": "2019-02-16T18:28:50.1427699+01:00",
    "CreatedBy": "itaque",
    "CreatedByFullName": "Mrs. Pinkie Jacobi",
    "CreatedByAssociateId": 945,
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
        "FieldLength": 773
      }
    }
  },
  "Associate": {
    "AssociateId": 681,
    "Name": "Mueller, Anderson and Cartwright",
    "PersonId": 255,
    "Rank": 318,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 8,
    "FullName": "Jeanne Heaney",
    "FormalName": "Hodkiewicz-Beatty",
    "Deleted": true,
    "EjUserId": 774,
    "UserName": "Bergnaum, Corwin and Bailey",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 527
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 481,
    "Name": "Kovacek, McLaughlin and Klein",
    "PersonId": 480,
    "Rank": 840,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 839,
    "FullName": "Shaylee Bernier",
    "FormalName": "Bahringer, Rogahn and Waters",
    "Deleted": true,
    "EjUserId": 815,
    "UserName": "Ankunding-Mann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 495
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 709,
    "Name": "Waelchi-Powlowski",
    "PersonId": 586,
    "Rank": 769,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 607,
    "FullName": "Kattie Herman",
    "FormalName": "Batz-Kuhlman",
    "Deleted": false,
    "EjUserId": 213,
    "UserName": "Torphy, Osinski and Goyette",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 212
      }
    }
  },
  "Contact": {
    "ContactId": 543,
    "Name": "Kohler Inc and Sons",
    "OrgNr": "754532",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "magni",
    "DirectPhone": "862.412.8373 x7134",
    "AssociateId": 654,
    "CountryId": 758,
    "EmailAddress": "emilie_kassulke@nolanpredovic.us",
    "Kananame": "expedita",
    "EmailAddressName": "kelly@mueller.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Diego Langosh",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "a",
    "FullName": "Morton Kerluke II",
    "IsOwnerContact": false,
    "ActiveErpLinks": 403,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 655
      }
    }
  },
  "Project": {
    "ProjectId": 945,
    "Name": "Rohan-Moen",
    "Description": "Upgradable clear-thinking orchestration",
    "URL": "http://www.example.com/",
    "Type": "sit",
    "AssociateId": 74,
    "AssociateFullName": "Emmitt Kunze",
    "TypeId": 866,
    "Updated": "2011-08-11T18:28:50.1447755+02:00",
    "StatusId": 317,
    "Status": "architecto",
    "TextId": 497,
    "PublishTo": "2004-03-04T18:28:50.1447755+01:00",
    "PublishFrom": "2017-09-27T18:28:50.1447755+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1307332",
    "ActiveErpLinks": 490,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 688
      }
    }
  },
  "SaleText": "beatae",
  "Person": {
    "Position": "pariatur",
    "PersonId": 6,
    "Mrmrs": "recusandae",
    "Firstname": "Felicia",
    "Lastname": "Auer",
    "MiddleName": "DuBuque-Schulist",
    "Title": "sit",
    "Description": "Business-focused analyzing service-desk",
    "Email": "kiley@hyatt.info",
    "FullName": "Jillian Weber",
    "DirectPhone": "1-813-756-0874",
    "FormalName": "Kerluke-Kiehn",
    "CountryId": 967,
    "ContactId": 235,
    "ContactName": "Green, Skiles and Gislason",
    "Retired": 825,
    "Rank": 442,
    "ActiveInterests": 720,
    "ContactDepartment": "",
    "ContactCountryId": 354,
    "ContactOrgNr": "925571",
    "FaxPhone": "(041)144-7380",
    "MobilePhone": "110-023-6143 x875",
    "ContactPhone": "(216)248-8438 x46388",
    "AssociateName": "Mann-Hartmann",
    "AssociateId": 672,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "commodi",
    "Kanalname": "exercitationem",
    "Post1": "tempore",
    "Post2": "vero",
    "Post3": "est",
    "EmailName": "dana.hodkiewicz@cruickshank.co.uk",
    "ContactFullName": "Maryam Schinner",
    "ActiveErpLinks": 109,
    "TicketPriorityId": 617,
    "SupportLanguageId": 549,
    "SupportAssociateId": 9,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 866
      }
    }
  },
  "Currency": {
    "Id": 583,
    "Value": "optio",
    "Tooltip": "ipsum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 170
      }
    }
  },
  "Competitor": {
    "Id": 379,
    "Value": "voluptates",
    "Tooltip": "vel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 729
      }
    }
  },
  "Credited": {
    "Id": 572,
    "Value": "ea",
    "Tooltip": "harum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "Rating": {
    "Id": 751,
    "Value": "quis",
    "Tooltip": "atque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 516
      }
    }
  },
  "Reason": {
    "Id": 920,
    "Value": "explicabo",
    "Tooltip": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 154
      }
    }
  },
  "Source": {
    "Id": 783,
    "Value": "nostrum",
    "Tooltip": "atque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 396
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2003-03-27T18:28:50.1467743+01:00",
  "Amount": 16998.816,
  "SaleId": 284,
  "Earning": 9461.546,
  "EarningPercent": 28240.474,
  "Heading": "error",
  "Number": "1677584",
  "Probability": 512,
  "CreatedDate": "1999-07-24T18:28:50.1467743+02:00",
  "UpdatedDate": "2016-03-28T18:28:50.1467743+02:00",
  "Completed": "Completed",
  "ActiveLinks": 221,
  "Links": [
    {
      "EntityName": "Corkery Inc and Sons",
      "Id": 635,
      "Description": "Organized national website",
      "ExtraInfo": "ut",
      "LinkId": 262,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    }
  ],
  "NextDueDate": "2009-04-06T18:28:50.1467743+02:00",
  "Postit": "nulla",
  "SaleType": {
    "Id": 868,
    "Value": "provident",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 223
      }
    }
  },
  "ReasonSold": {
    "Id": 255,
    "Value": "iure",
    "Tooltip": "suscipit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 591
      }
    }
  },
  "ReasonStalled": {
    "Id": 339,
    "Value": "iure",
    "Tooltip": "porro",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 23
      }
    }
  },
  "ReopenDate": "2018-04-15T18:28:50.1467743+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kiehn, Olson and Harvey",
      "Comment": "nam",
      "StakeholderRoleId": 951,
      "CountryId": 901,
      "PersonId": 23,
      "EmailDescription": "ebba@kuhickessler.us",
      "EmailId": 427,
      "EmailAddress": "delilah@walsh.us",
      "PhoneId": 316,
      "ContactName": "Pfeffer LLC",
      "ContactId": 829,
      "SaleId": 593,
      "Mrmrs": "et",
      "Firstname": "Gregorio",
      "MiddleName": "Lesch-Hackett",
      "Lastname": "Sanford",
      "SaleStakeholderId": 594,
      "Rank": 290,
      "Phone": "1-436-662-7286 x21760",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "ActiveErpLinks": 213,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Vivien Kessler",
    "SuperOffice:2": "Brendon Mayert"
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "corrupti"
  },
  "PublishEventDate": "2021-09-06T18:28:50.1477749+02:00",
  "PublishTo": "2013-09-27T18:28:50.1477749+02:00",
  "PublishFrom": "2009-05-28T18:28:50.1477749+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 147,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    },
    {
      "VisibleId": 147,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 748
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
        "Reason": "empower global portals"
      },
      "FieldType": "System.String",
      "FieldLength": 326
    }
  }
}
```