---
title: SaveSaleEntity
id: v1SaleAgent_SaveSaleEntity
---

# SaveSaleEntity

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
    "AppointmentId": 682,
    "StartDate": "1997-01-17T14:58:05.1346276+01:00",
    "EndDate": "2002-03-13T14:58:05.1346276+01:00",
    "Type": "BookingForChecklist",
    "Task": "esse",
    "AssociateFullName": "Cassandra Kovacek",
    "ContactName": "Macejkovic-Sawayn",
    "Description": "Future-proofed assymetric emulation",
    "PersonFullName": "Lenna Doyle",
    "PersonId": 862,
    "ContactId": 268,
    "ProjectId": 162,
    "ProjectName": "Pfeffer, Howe and Reilly",
    "IsPublished": true,
    "AssociateId": 765,
    "ColorIndex": 614,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 320,
    "PriorityName": "Jacobson-Dickens",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1997-11-04T14:58:05.1356506+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2008-04-01T14:58:05.1356506+02:00",
    "RecurringEndDate": "2021-05-12T14:58:05.1356506+02:00",
    "MotherId": 746,
    "AssignedBy": 800,
    "AssignedByFullName": "Vladimir Legros MD",
    "RejectReason": "",
    "Location": "non",
    "AlarmLeadTime": "maiores",
    "SaleId": 247,
    "SaleName": "Powlowski-Ritchie",
    "AssociateName": "Cummerata-Feeney",
    "CreatedDate": "2008-12-04T14:58:05.1356506+01:00",
    "CreatedBy": "soluta",
    "CreatedByFullName": "Dr. Annamarie Pagac",
    "CreatedByAssociateId": 266,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 837,
    "Name": "Shanahan, Stark and Kuhn",
    "PersonId": 554,
    "Rank": 754,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 464,
    "FullName": "Lavonne Sawayn",
    "FormalName": "Wolff-Paucek",
    "Deleted": false,
    "EjUserId": 281,
    "UserName": "Dare, McDermott and Heidenreich"
  },
  "UpdatedBy": {
    "AssociateId": 699,
    "Name": "Runolfsson Group",
    "PersonId": 333,
    "Rank": 651,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 268,
    "FullName": "Alexzander Ferry",
    "FormalName": "Kovacek-Kuhn",
    "Deleted": false,
    "EjUserId": 902,
    "UserName": "Bruen, Ward and Prosacco"
  },
  "CreatedBy": {
    "AssociateId": 437,
    "Name": "Upton, Gibson and Buckridge",
    "PersonId": 305,
    "Rank": 515,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 251,
    "FullName": "Brannon Little",
    "FormalName": "Romaguera, Johnson and Emmerich",
    "Deleted": false,
    "EjUserId": 528,
    "UserName": "Legros Inc and Sons"
  },
  "Contact": {
    "ContactId": 751,
    "Name": "McLaughlin Inc and Sons",
    "OrgNr": "650180",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "rem",
    "DirectPhone": "878-804-4588 x077",
    "AssociateId": 260,
    "CountryId": 927,
    "EmailAddress": "tressie.moen@jacobson.name",
    "Kananame": "nesciunt",
    "EmailAddressName": "judah@king.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ora Wolf",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "soluta",
    "FullName": "Samantha Herman",
    "IsOwnerContact": false,
    "ActiveErpLinks": 310
  },
  "Project": {
    "ProjectId": 899,
    "Name": "McDermott Inc and Sons",
    "Description": "Versatile empowering flexibility",
    "URL": "http://www.example.com/",
    "Type": "exercitationem",
    "AssociateId": 651,
    "AssociateFullName": "Nash Daugherty",
    "TypeId": 17,
    "Updated": "2009-01-23T14:58:05.1386301+01:00",
    "StatusId": 966,
    "Status": "qui",
    "TextId": 985,
    "PublishTo": "2021-05-19T14:58:05.1386301+02:00",
    "PublishFrom": "2010-04-10T14:58:05.1386301+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "753615",
    "ActiveErpLinks": 233
  },
  "SaleText": "et",
  "Person": {
    "Position": "dolore",
    "PersonId": 944,
    "Mrmrs": "consequuntur",
    "Firstname": "Theo",
    "Lastname": "Yost",
    "MiddleName": "Gerhold-Halvorson",
    "Title": "adipisci",
    "Description": "Reverse-engineered coherent projection",
    "Email": "carolanne@champlin.biz",
    "FullName": "Johnpaul Collier",
    "DirectPhone": "686.188.8410",
    "FormalName": "Mayer-Kemmer",
    "CountryId": 823,
    "ContactId": 193,
    "ContactName": "Douglas-Oberbrunner",
    "Retired": 898,
    "Rank": 537,
    "ActiveInterests": 232,
    "ContactDepartment": "",
    "ContactCountryId": 612,
    "ContactOrgNr": "948573",
    "FaxPhone": "038.443.8620 x70342",
    "MobilePhone": "(867)522-3440",
    "ContactPhone": "517-262-8745 x6485",
    "AssociateName": "Marvin, Boyle and Reichert",
    "AssociateId": 137,
    "UsePersonAddress": true,
    "ContactFax": "exercitationem",
    "Kanafname": "voluptas",
    "Kanalname": "modi",
    "Post1": "cum",
    "Post2": "consequatur",
    "Post3": "reiciendis",
    "EmailName": "ray@mosciskihuel.info",
    "ContactFullName": "Dr. Idella Nicolas",
    "ActiveErpLinks": 699,
    "TicketPriorityId": 727,
    "SupportLanguageId": 223,
    "SupportAssociateId": 256,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 880,
    "Value": "animi",
    "Tooltip": "nemo"
  },
  "Competitor": {
    "Id": 730,
    "Value": "dolorem",
    "Tooltip": "corporis"
  },
  "Credited": {
    "Id": 195,
    "Value": "iusto",
    "Tooltip": "molestiae"
  },
  "Rating": {
    "Id": 287,
    "Value": "sed",
    "Tooltip": "dolor"
  },
  "Reason": {
    "Id": 51,
    "Value": "ullam",
    "Tooltip": "sit"
  },
  "Source": {
    "Id": 287,
    "Value": "suscipit",
    "Tooltip": "repellendus"
  },
  "Status": "Lost",
  "Saledate": "2015-08-27T14:58:05.139629+02:00",
  "Amount": 19386.924,
  "SaleId": 592,
  "Earning": 10821.702,
  "EarningPercent": 12457.65,
  "Heading": "veritatis",
  "Number": "1426655",
  "Probability": 645,
  "CreatedDate": "2004-04-12T14:58:05.139629+02:00",
  "UpdatedDate": "2004-08-13T14:58:05.139629+02:00",
  "Completed": "Completed",
  "ActiveLinks": 428,
  "Links": [
    {
      "EntityName": "Hintz-Morissette",
      "Id": 878,
      "Description": "Decentralized maximized capacity",
      "ExtraInfo": "dignissimos",
      "LinkId": 206
    },
    {
      "EntityName": "Hintz-Morissette",
      "Id": 878,
      "Description": "Decentralized maximized capacity",
      "ExtraInfo": "dignissimos",
      "LinkId": 206
    }
  ],
  "NextDueDate": "2000-07-11T14:58:05.139629+02:00",
  "Postit": "perspiciatis",
  "SaleType": {
    "Id": 553,
    "Value": "explicabo",
    "Tooltip": "voluptatem"
  },
  "ReasonSold": {
    "Id": 408,
    "Value": "aut",
    "Tooltip": "nulla"
  },
  "ReasonStalled": {
    "Id": 129,
    "Value": "non",
    "Tooltip": "fugiat"
  },
  "ReopenDate": "2011-04-19T14:58:05.1406282+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Jerde LLC",
      "Comment": "harum",
      "StakeholderRoleId": 804,
      "CountryId": 912,
      "PersonId": 16,
      "EmailDescription": "lyric@kemmer.com",
      "EmailId": 387,
      "EmailAddress": "nichole_lang@murray.com",
      "PhoneId": 334,
      "ContactName": "Wyman-Legros",
      "ContactId": 492,
      "SaleId": 351,
      "Mrmrs": "laborum",
      "Firstname": "Erin",
      "MiddleName": "Haag Group",
      "Lastname": "Grant",
      "SaleStakeholderId": 382,
      "Rank": 913,
      "Phone": "1-004-312-3144 x6641"
    }
  ],
  "ActiveErpLinks": 749,
  "UserDefinedFields": {
    "SuperOffice:1": "1720921336",
    "SuperOffice:2": "Rebecca Hoeger IV"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "veniam"
  },
  "PublishEventDate": "2011-06-17T14:58:05.1416288+02:00",
  "PublishTo": "2004-08-23T14:58:05.1416288+02:00",
  "PublishFrom": "2000-10-15T14:58:05.1416288+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 552,
      "Visibility": "All",
      "DisplayValue": "consequatur"
    },
    {
      "VisibleId": 552,
      "Visibility": "All",
      "DisplayValue": "consequatur"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 652,
    "StartDate": "2002-11-27T14:58:05.147628+01:00",
    "EndDate": "2021-08-12T14:58:05.147628+02:00",
    "Type": "BookingForChecklist",
    "Task": "eos",
    "AssociateFullName": "Laverne Pacocha",
    "ContactName": "Pacocha-Fahey",
    "Description": "Sharable static matrices",
    "PersonFullName": "Emerson Grant",
    "PersonId": 650,
    "ContactId": 841,
    "ProjectId": 756,
    "ProjectName": "Glover Group",
    "IsPublished": true,
    "AssociateId": 44,
    "ColorIndex": 753,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 735,
    "PriorityName": "Lueilwitz Inc and Sons",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "2005-09-11T14:58:05.147628+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2009-08-08T14:58:05.147628+02:00",
    "RecurringEndDate": "2000-06-27T14:58:05.147628+02:00",
    "MotherId": 171,
    "AssignedBy": 985,
    "AssignedByFullName": "Greg Leffler",
    "RejectReason": "",
    "Location": "odio",
    "AlarmLeadTime": "velit",
    "SaleId": 92,
    "SaleName": "Barton-Howe",
    "AssociateName": "Runte, Schultz and Johnston",
    "CreatedDate": "1995-11-17T14:58:05.1486283+01:00",
    "CreatedBy": "quaerat",
    "CreatedByFullName": "Gunnar Nolan",
    "CreatedByAssociateId": 690,
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
        "FieldLength": 141
      }
    }
  },
  "Associate": {
    "AssociateId": 553,
    "Name": "Murphy Inc and Sons",
    "PersonId": 584,
    "Rank": 883,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 965,
    "FullName": "Birdie Ondricka",
    "FormalName": "Watsica, Barton and Larson",
    "Deleted": true,
    "EjUserId": 590,
    "UserName": "Bergnaum, Grimes and Schaefer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 580
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 248,
    "Name": "Schinner, Purdy and Aufderhar",
    "PersonId": 174,
    "Rank": 494,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 767,
    "FullName": "Amya Simonis",
    "FormalName": "Ryan-Wolff",
    "Deleted": true,
    "EjUserId": 142,
    "UserName": "Murray, Rath and O'Hara",
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
  "CreatedBy": {
    "AssociateId": 77,
    "Name": "Hudson Inc and Sons",
    "PersonId": 756,
    "Rank": 967,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 853,
    "FullName": "Rodrigo West",
    "FormalName": "Vandervort Inc and Sons",
    "Deleted": true,
    "EjUserId": 757,
    "UserName": "Lehner-Toy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 226
      }
    }
  },
  "Contact": {
    "ContactId": 375,
    "Name": "West, Lemke and Beer",
    "OrgNr": "1419242",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "esse",
    "DirectPhone": "460-761-5863 x1666",
    "AssociateId": 584,
    "CountryId": 458,
    "EmailAddress": "claudia@hicklereynolds.ca",
    "Kananame": "vel",
    "EmailAddressName": "florencio@pfeffer.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Emiliano Romaguera",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quas",
    "FullName": "Nathanael Lockman",
    "IsOwnerContact": false,
    "ActiveErpLinks": 757,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 885
      }
    }
  },
  "Project": {
    "ProjectId": 180,
    "Name": "Ernser Group",
    "Description": "Multi-layered bandwidth-monitored forecast",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 52,
    "AssociateFullName": "Trent Rice",
    "TypeId": 631,
    "Updated": "2005-03-06T14:58:05.1515987+01:00",
    "StatusId": 396,
    "Status": "sint",
    "TextId": 658,
    "PublishTo": "2013-07-06T14:58:05.1515987+02:00",
    "PublishFrom": "1999-11-01T14:58:05.1515987+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1385181",
    "ActiveErpLinks": 185,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 412
      }
    }
  },
  "SaleText": "voluptatem",
  "Person": {
    "Position": "quos",
    "PersonId": 119,
    "Mrmrs": "incidunt",
    "Firstname": "Bria",
    "Lastname": "Hagenes",
    "MiddleName": "Connelly Inc and Sons",
    "Title": "nisi",
    "Description": "Reactive global local area network",
    "Email": "bette_howe@dibbert.co.uk",
    "FullName": "Ally Schmitt",
    "DirectPhone": "(233)607-6353 x3266",
    "FormalName": "Farrell-Hermiston",
    "CountryId": 537,
    "ContactId": 264,
    "ContactName": "Morissette, O'Conner and Mertz",
    "Retired": 987,
    "Rank": 25,
    "ActiveInterests": 123,
    "ContactDepartment": "",
    "ContactCountryId": 194,
    "ContactOrgNr": "732522",
    "FaxPhone": "1-125-865-6286 x18651",
    "MobilePhone": "1-435-667-7057",
    "ContactPhone": "686-465-4180 x675",
    "AssociateName": "Gleichner-Hegmann",
    "AssociateId": 307,
    "UsePersonAddress": true,
    "ContactFax": "voluptates",
    "Kanafname": "eveniet",
    "Kanalname": "deserunt",
    "Post1": "eos",
    "Post2": "dolores",
    "Post3": "occaecati",
    "EmailName": "hallie_ebert@hagenes.com",
    "ContactFullName": "Gisselle Crooks",
    "ActiveErpLinks": 392,
    "TicketPriorityId": 198,
    "SupportLanguageId": 91,
    "SupportAssociateId": 769,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "Currency": {
    "Id": 434,
    "Value": "omnis",
    "Tooltip": "repudiandae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 119
      }
    }
  },
  "Competitor": {
    "Id": 782,
    "Value": "quis",
    "Tooltip": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 892
      }
    }
  },
  "Credited": {
    "Id": 376,
    "Value": "a",
    "Tooltip": "dolorem",
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
  "Rating": {
    "Id": 702,
    "Value": "dolorem",
    "Tooltip": "neque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 17
      }
    }
  },
  "Reason": {
    "Id": 49,
    "Value": "doloribus",
    "Tooltip": "nemo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate integrated partnerships"
        },
        "FieldType": "System.String",
        "FieldLength": 615
      }
    }
  },
  "Source": {
    "Id": 789,
    "Value": "laudantium",
    "Tooltip": "id",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 339
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2004-07-30T14:58:05.1535998+02:00",
  "Amount": 5146.028,
  "SaleId": 6,
  "Earning": 2212.604,
  "EarningPercent": 554.718,
  "Heading": "facilis",
  "Number": "546990",
  "Probability": 754,
  "CreatedDate": "1999-09-17T14:58:05.1535998+02:00",
  "UpdatedDate": "2010-11-15T14:58:05.1535998+01:00",
  "Completed": "Completed",
  "ActiveLinks": 800,
  "Links": [
    {
      "EntityName": "Dicki, Erdman and McGlynn",
      "Id": 59,
      "Description": "Self-enabling encompassing circuit",
      "ExtraInfo": "voluptate",
      "LinkId": 914,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "NextDueDate": "2005-07-20T14:58:05.1535998+02:00",
  "Postit": "nobis",
  "SaleType": {
    "Id": 679,
    "Value": "aut",
    "Tooltip": "dolor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 715
      }
    }
  },
  "ReasonSold": {
    "Id": 335,
    "Value": "sit",
    "Tooltip": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 413
      }
    }
  },
  "ReasonStalled": {
    "Id": 373,
    "Value": "incidunt",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 159
      }
    }
  },
  "ReopenDate": "2000-09-27T14:58:05.1535998+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Friesen, Torp and Langworth",
      "Comment": "fugit",
      "StakeholderRoleId": 719,
      "CountryId": 767,
      "PersonId": 917,
      "EmailDescription": "adolfo@feeney.co.uk",
      "EmailId": 172,
      "EmailAddress": "lavada_wilkinson@lowe.com",
      "PhoneId": 458,
      "ContactName": "Kutch LLC",
      "ContactId": 643,
      "SaleId": 585,
      "Mrmrs": "officia",
      "Firstname": "Sallie",
      "MiddleName": "Kilback-Kub",
      "Lastname": "Hettinger",
      "SaleStakeholderId": 697,
      "Rank": 678,
      "Phone": "1-663-368-3022 x857",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    }
  ],
  "ActiveErpLinks": 508,
  "UserDefinedFields": {
    "SuperOffice:1": "1222253835",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "animi"
  },
  "PublishEventDate": "1996-12-29T14:58:05.1545938+01:00",
  "PublishTo": "1998-07-31T14:58:05.1545938+02:00",
  "PublishFrom": "2010-02-16T14:58:05.1545938+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 784,
      "Visibility": "All",
      "DisplayValue": "molestiae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 153
        }
      }
    },
    {
      "VisibleId": 784,
      "Visibility": "All",
      "DisplayValue": "molestiae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 153
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
      "FieldLength": 768
    }
  }
}
```