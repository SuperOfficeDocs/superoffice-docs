---
title: POST Sale
id: v1SaleEntity_PostSaleEntity
---

# POST Sale

```http
POST /api/v1/Sale
```

Creates a new SaleEntity

Calls the Sale agent service SaveSaleEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Sale?$select=name,department,category/id
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

## Request Body: newEntity  

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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Sale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 133,
    "StartDate": "1997-02-21T18:25:50.93926+01:00",
    "EndDate": "1999-09-05T18:25:50.93926+02:00",
    "Type": "BookingForChecklist",
    "Task": "dolor",
    "AssociateFullName": "Timothy Ledner",
    "ContactName": "Robel, Friesen and Waelchi",
    "Description": "Implemented attitude-oriented throughput",
    "PersonFullName": "Everardo Schmeler",
    "PersonId": 499,
    "ContactId": 496,
    "ProjectId": 673,
    "ProjectName": "Thompson Group",
    "IsPublished": true,
    "AssociateId": 385,
    "ColorIndex": 433,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 834,
    "PriorityName": "Gislason-Rolfson",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1996-12-21T18:25:50.93926+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2006-02-03T18:25:50.93926+01:00",
    "RecurringEndDate": "1998-12-29T18:25:50.93926+01:00",
    "MotherId": 412,
    "AssignedBy": 485,
    "AssignedByFullName": "Florencio Rempel",
    "RejectReason": "",
    "Location": "praesentium",
    "AlarmLeadTime": "non",
    "SaleId": 952,
    "SaleName": "Schinner-Borer",
    "AssociateName": "Schmeler-Beier",
    "CreatedDate": "1999-02-23T18:25:50.9402578+01:00",
    "CreatedBy": "esse",
    "CreatedByFullName": "Mrs. Jalen Okuneva",
    "CreatedByAssociateId": 253,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 589,
    "Name": "Lehner, Zboncak and Balistreri",
    "PersonId": 342,
    "Rank": 901,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 940,
    "FullName": "Christ Zemlak",
    "FormalName": "Schmitt-Beer",
    "Deleted": false,
    "EjUserId": 48,
    "UserName": "Dickens-Schuppe"
  },
  "UpdatedBy": {
    "AssociateId": 10,
    "Name": "Crooks-Bailey",
    "PersonId": 126,
    "Rank": 163,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 132,
    "FullName": "Dr. Deondre Beer",
    "FormalName": "Prosacco, Turner and Monahan",
    "Deleted": false,
    "EjUserId": 250,
    "UserName": "Okuneva Group"
  },
  "CreatedBy": {
    "AssociateId": 646,
    "Name": "Jones-Turner",
    "PersonId": 308,
    "Rank": 298,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 627,
    "FullName": "Tia Dickinson",
    "FormalName": "Abbott, Emard and Rippin",
    "Deleted": false,
    "EjUserId": 966,
    "UserName": "Schoen, Hackett and Gleichner"
  },
  "Contact": {
    "ContactId": 740,
    "Name": "Terry-Hermann",
    "OrgNr": "1082022",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "placeat",
    "DirectPhone": "1-443-623-6043",
    "AssociateId": 290,
    "CountryId": 487,
    "EmailAddress": "muriel@turner.uk",
    "Kananame": "temporibus",
    "EmailAddressName": "estrella@pfannerstillking.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dixie Dare",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nobis",
    "FullName": "Ms. Michel Hahn",
    "IsOwnerContact": false,
    "ActiveErpLinks": 518
  },
  "Project": {
    "ProjectId": 481,
    "Name": "DuBuque-Runolfsdottir",
    "Description": "Face to face system-worthy utilisation",
    "URL": "http://www.example.com/",
    "Type": "voluptatem",
    "AssociateId": 143,
    "AssociateFullName": "Nasir Bauch",
    "TypeId": 76,
    "Updated": "2007-11-09T18:25:50.9422603+01:00",
    "StatusId": 646,
    "Status": "nihil",
    "TextId": 183,
    "PublishTo": "1994-08-17T18:25:50.9422603+02:00",
    "PublishFrom": "2021-07-14T18:25:50.9422603+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1808066",
    "ActiveErpLinks": 843
  },
  "SaleText": "impedit",
  "Person": {
    "Position": "totam",
    "PersonId": 560,
    "Mrmrs": "natus",
    "Firstname": "Duane",
    "Lastname": "Thiel",
    "MiddleName": "Balistreri-Tromp",
    "Title": "voluptas",
    "Description": "Multi-channelled foreground help-desk",
    "Email": "edyth@lebsackcollier.biz",
    "FullName": "Garett Armstrong II",
    "DirectPhone": "1-546-338-8137",
    "FormalName": "Casper, Waelchi and Koepp",
    "CountryId": 165,
    "ContactId": 674,
    "ContactName": "Rodriguez-Lesch",
    "Retired": 662,
    "Rank": 728,
    "ActiveInterests": 598,
    "ContactDepartment": "",
    "ContactCountryId": 678,
    "ContactOrgNr": "1061423",
    "FaxPhone": "1-103-046-3536",
    "MobilePhone": "407-205-3140 x8865",
    "ContactPhone": "(530)886-0561 x861",
    "AssociateName": "Kuhn-Schumm",
    "AssociateId": 790,
    "UsePersonAddress": false,
    "ContactFax": "incidunt",
    "Kanafname": "nulla",
    "Kanalname": "sunt",
    "Post1": "nemo",
    "Post2": "dolorem",
    "Post3": "ut",
    "EmailName": "nathanael@bergeboyer.co.uk",
    "ContactFullName": "Ivy Rippin",
    "ActiveErpLinks": 900,
    "TicketPriorityId": 493,
    "SupportLanguageId": 499,
    "SupportAssociateId": 74,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 169,
    "Value": "a",
    "Tooltip": "assumenda"
  },
  "Competitor": {
    "Id": 45,
    "Value": "sit",
    "Tooltip": "consequatur"
  },
  "Credited": {
    "Id": 399,
    "Value": "repellendus",
    "Tooltip": "praesentium"
  },
  "Rating": {
    "Id": 995,
    "Value": "dolor",
    "Tooltip": "nisi"
  },
  "Reason": {
    "Id": 509,
    "Value": "sed",
    "Tooltip": "sequi"
  },
  "Source": {
    "Id": 304,
    "Value": "sed",
    "Tooltip": "sed"
  },
  "Status": "Lost",
  "Saledate": "2001-08-28T18:25:50.9452408+02:00",
  "Amount": 29334.239999999998,
  "SaleId": 775,
  "Earning": 8684.314,
  "EarningPercent": 15629.258,
  "Heading": "sequi",
  "Number": "1549229",
  "Probability": 19,
  "CreatedDate": "2020-06-16T18:25:50.9452408+02:00",
  "UpdatedDate": "2020-06-21T18:25:50.9452408+02:00",
  "Completed": "Completed",
  "ActiveLinks": 70,
  "Links": [
    {
      "EntityName": "Hagenes Inc and Sons",
      "Id": 159,
      "Description": "Multi-channelled 5th generation paradigm",
      "ExtraInfo": "voluptatem",
      "LinkId": 567
    },
    {
      "EntityName": "Hagenes Inc and Sons",
      "Id": 159,
      "Description": "Multi-channelled 5th generation paradigm",
      "ExtraInfo": "voluptatem",
      "LinkId": 567
    }
  ],
  "NextDueDate": "2018-01-30T18:25:50.9452408+01:00",
  "Postit": "id",
  "SaleType": {
    "Id": 999,
    "Value": "in",
    "Tooltip": "nulla"
  },
  "ReasonSold": {
    "Id": 830,
    "Value": "expedita",
    "Tooltip": "aut"
  },
  "ReasonStalled": {
    "Id": 684,
    "Value": "voluptatem",
    "Tooltip": "esse"
  },
  "ReopenDate": "2010-08-03T18:25:50.9452408+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Klein Group",
      "Comment": "sequi",
      "StakeholderRoleId": 139,
      "CountryId": 993,
      "PersonId": 404,
      "EmailDescription": "shad@gaylord.info",
      "EmailId": 210,
      "EmailAddress": "linnie@crist.com",
      "PhoneId": 979,
      "ContactName": "Fadel Inc and Sons",
      "ContactId": 411,
      "SaleId": 909,
      "Mrmrs": "eum",
      "Firstname": "Clinton",
      "MiddleName": "Langworth-Gutmann",
      "Lastname": "Thompson",
      "SaleStakeholderId": 827,
      "Rank": 112,
      "Phone": "557.418.8651"
    }
  ],
  "ActiveErpLinks": 328,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "eligendi"
  },
  "PublishEventDate": "2021-05-21T18:25:50.9462238+02:00",
  "PublishTo": "1998-10-01T18:25:50.9462238+02:00",
  "PublishFrom": "2009-09-28T18:25:50.9462238+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 954,
      "Visibility": "All",
      "DisplayValue": "aspernatur"
    },
    {
      "VisibleId": 954,
      "Visibility": "All",
      "DisplayValue": "aspernatur"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 864,
    "StartDate": "2003-03-04T18:25:50.9542592+01:00",
    "EndDate": "2000-12-04T18:25:50.9542592+01:00",
    "Type": "BookingForChecklist",
    "Task": "quia",
    "AssociateFullName": "Mrs. Ciara Harvey",
    "ContactName": "Skiles, West and Ratke",
    "Description": "Mandatory impactful software",
    "PersonFullName": "Chloe Berge",
    "PersonId": 707,
    "ContactId": 384,
    "ProjectId": 806,
    "ProjectName": "Langosh LLC",
    "IsPublished": false,
    "AssociateId": 918,
    "ColorIndex": 788,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 977,
    "PriorityName": "Aufderhar Group",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2019-11-17T18:25:50.9542592+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2015-10-23T18:25:50.9542592+02:00",
    "RecurringEndDate": "1995-05-26T18:25:50.9542592+02:00",
    "MotherId": 469,
    "AssignedBy": 860,
    "AssignedByFullName": "Hertha Glover",
    "RejectReason": "",
    "Location": "aut",
    "AlarmLeadTime": "vitae",
    "SaleId": 434,
    "SaleName": "Crona-Lowe",
    "AssociateName": "Wintheiser Inc and Sons",
    "CreatedDate": "2011-06-13T18:25:50.9542592+02:00",
    "CreatedBy": "tempore",
    "CreatedByFullName": "Loma Willms",
    "CreatedByAssociateId": 757,
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
        "FieldLength": 200
      }
    }
  },
  "Associate": {
    "AssociateId": 417,
    "Name": "Ratke, Hintz and White",
    "PersonId": 320,
    "Rank": 247,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 734,
    "FullName": "Brody Harvey",
    "FormalName": "Okuneva, Cremin and Gusikowski",
    "Deleted": false,
    "EjUserId": 801,
    "UserName": "Miller-Donnelly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 839
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 898,
    "Name": "Adams, O'Reilly and Monahan",
    "PersonId": 981,
    "Rank": 682,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 236,
    "FullName": "Daron Smith I",
    "FormalName": "Donnelly Inc and Sons",
    "Deleted": true,
    "EjUserId": 279,
    "UserName": "Cummings Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 703
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 559,
    "Name": "Rice, Schmidt and Shanahan",
    "PersonId": 399,
    "Rank": 483,
    "Tooltip": "saepe",
    "Type": "AnonymousAssociate",
    "GroupIdx": 518,
    "FullName": "Ms. Jadon Doyle",
    "FormalName": "Weimann-VonRueden",
    "Deleted": true,
    "EjUserId": 291,
    "UserName": "Keebler, Lueilwitz and Zulauf",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 544
      }
    }
  },
  "Contact": {
    "ContactId": 729,
    "Name": "Robel, Hettinger and Kuphal",
    "OrgNr": "400550",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sint",
    "DirectPhone": "764-286-1470 x413",
    "AssociateId": 211,
    "CountryId": 822,
    "EmailAddress": "brandon.rice@huel.name",
    "Kananame": "consequuntur",
    "EmailAddressName": "candelario@gutkowskiharvey.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Alan Lang II",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "rem",
    "FullName": "Miss Emily Lynch",
    "IsOwnerContact": false,
    "ActiveErpLinks": 458,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 395
      }
    }
  },
  "Project": {
    "ProjectId": 156,
    "Name": "Lesch, Zieme and Bednar",
    "Description": "Progressive responsive access",
    "URL": "http://www.example.com/",
    "Type": "vel",
    "AssociateId": 869,
    "AssociateFullName": "Jayce Leffler IV",
    "TypeId": 232,
    "Updated": "2008-09-16T18:25:50.9592572+02:00",
    "StatusId": 204,
    "Status": "dolores",
    "TextId": 838,
    "PublishTo": "1996-06-28T18:25:50.9592572+02:00",
    "PublishFrom": "2014-02-21T18:25:50.9592572+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "607390",
    "ActiveErpLinks": 419,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 488
      }
    }
  },
  "SaleText": "occaecati",
  "Person": {
    "Position": "repellat",
    "PersonId": 942,
    "Mrmrs": "laboriosam",
    "Firstname": "Rigoberto",
    "Lastname": "Lubowitz",
    "MiddleName": "Kunde LLC",
    "Title": "id",
    "Description": "Up-sized client-server project",
    "Email": "marcelina@franecki.ca",
    "FullName": "Gracie Glover DVM",
    "DirectPhone": "(224)024-6444 x413",
    "FormalName": "Upton, Hauck and Hartmann",
    "CountryId": 561,
    "ContactId": 662,
    "ContactName": "Jaskolski LLC",
    "Retired": 501,
    "Rank": 828,
    "ActiveInterests": 694,
    "ContactDepartment": "",
    "ContactCountryId": 505,
    "ContactOrgNr": "508345",
    "FaxPhone": "443.328.8531 x2624",
    "MobilePhone": "771-518-7580",
    "ContactPhone": "662-085-8608 x7038",
    "AssociateName": "Rowe-Cruickshank",
    "AssociateId": 507,
    "UsePersonAddress": false,
    "ContactFax": "consequatur",
    "Kanafname": "fuga",
    "Kanalname": "ea",
    "Post1": "atque",
    "Post2": "aut",
    "Post3": "aut",
    "EmailName": "emily@gibsongrady.com",
    "ContactFullName": "Cordelia Murazik",
    "ActiveErpLinks": 725,
    "TicketPriorityId": 505,
    "SupportLanguageId": 501,
    "SupportAssociateId": 232,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 652
      }
    }
  },
  "Currency": {
    "Id": 857,
    "Value": "tempore",
    "Tooltip": "inventore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 71
      }
    }
  },
  "Competitor": {
    "Id": 470,
    "Value": "dolorum",
    "Tooltip": "facere",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 326
      }
    }
  },
  "Credited": {
    "Id": 683,
    "Value": "est",
    "Tooltip": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 963
      }
    }
  },
  "Rating": {
    "Id": 865,
    "Value": "reprehenderit",
    "Tooltip": "atque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 750
      }
    }
  },
  "Reason": {
    "Id": 34,
    "Value": "ea",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 581
      }
    }
  },
  "Source": {
    "Id": 590,
    "Value": "ut",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 953
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2000-08-05T18:25:50.960224+02:00",
  "Amount": 19296.038,
  "SaleId": 821,
  "Earning": 25297.647999999997,
  "EarningPercent": 26588.856,
  "Heading": "ea",
  "Number": "929433",
  "Probability": 657,
  "CreatedDate": "2015-02-28T18:25:50.960224+01:00",
  "UpdatedDate": "2021-03-26T18:25:50.960224+01:00",
  "Completed": "Completed",
  "ActiveLinks": 366,
  "Links": [
    {
      "EntityName": "Glover Inc and Sons",
      "Id": 920,
      "Description": "Re-engineered fault-tolerant benchmark",
      "ExtraInfo": "quod",
      "LinkId": 276,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "NextDueDate": "2013-11-18T18:25:50.960224+01:00",
  "Postit": "sunt",
  "SaleType": {
    "Id": 288,
    "Value": "fugiat",
    "Tooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 548
      }
    }
  },
  "ReasonSold": {
    "Id": 992,
    "Value": "ut",
    "Tooltip": "suscipit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 500
      }
    }
  },
  "ReasonStalled": {
    "Id": 926,
    "Value": "aut",
    "Tooltip": "error",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 546
      }
    }
  },
  "ReopenDate": "2019-03-26T18:25:50.9612239+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Jenkins Inc and Sons",
      "Comment": "nihil",
      "StakeholderRoleId": 565,
      "CountryId": 962,
      "PersonId": 382,
      "EmailDescription": "nichole@beer.com",
      "EmailId": 398,
      "EmailAddress": "emmitt_weissnat@littel.biz",
      "PhoneId": 369,
      "ContactName": "Grant-Schuppe",
      "ContactId": 81,
      "SaleId": 963,
      "Mrmrs": "aliquam",
      "Firstname": "Marcelino",
      "MiddleName": "Kautzer, Collier and Senger",
      "Lastname": "Haag",
      "SaleStakeholderId": 117,
      "Rank": 559,
      "Phone": "167.474.3210",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 953
        }
      }
    }
  ],
  "ActiveErpLinks": 583,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Elise Langworth Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "reprehenderit",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "quia"
  },
  "PublishEventDate": "2020-03-22T18:25:50.9612239+01:00",
  "PublishTo": "2006-05-08T18:25:50.9612239+02:00",
  "PublishFrom": "1995-07-18T18:25:50.9612239+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 539,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 955
        }
      }
    },
    {
      "VisibleId": 539,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 955
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
      "FieldLength": 112
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```