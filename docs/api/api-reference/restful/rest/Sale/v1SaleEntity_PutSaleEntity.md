---
title: PUT Sale/{id}
id: v1SaleEntity_PutSaleEntity
---

# PUT Sale/{id}

```http
PUT /api/v1/Sale/{id}
```

Updates the existing SaleEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Sale/{id}?$select=name,department,category/id
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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity updated. |
| 412 | Update stopped because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 551,
    "StartDate": "2002-09-04T15:05:42.6266627+02:00",
    "EndDate": "1995-11-17T15:05:42.6266627+01:00",
    "Type": "BookingForChecklist",
    "Task": "quos",
    "AssociateFullName": "Mr. Bulah Gutmann",
    "ContactName": "Rutherford, Dickens and Leffler",
    "Description": "Total fault-tolerant functionalities",
    "PersonFullName": "Nat Toy II",
    "PersonId": 171,
    "ContactId": 489,
    "ProjectId": 858,
    "ProjectName": "Wehner-Gleichner",
    "IsPublished": false,
    "AssociateId": 478,
    "ColorIndex": 675,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 999,
    "PriorityName": "Watsica-Olson",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "1999-03-05T15:05:42.6416618+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2017-06-18T15:05:42.6416618+02:00",
    "RecurringEndDate": "2014-07-28T15:05:42.6416618+02:00",
    "MotherId": 410,
    "AssignedBy": 94,
    "AssignedByFullName": "Mauricio Hills",
    "RejectReason": "",
    "Location": "dicta",
    "AlarmLeadTime": "velit",
    "SaleId": 224,
    "SaleName": "McLaughlin-Koss",
    "AssociateName": "Bartell-Zemlak",
    "CreatedDate": "1995-02-23T15:05:42.6416618+01:00",
    "CreatedBy": "non",
    "CreatedByFullName": "Mitchel Jast",
    "CreatedByAssociateId": 286,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 884,
    "Name": "Jakubowski-Hansen",
    "PersonId": 126,
    "Rank": 248,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 266,
    "FullName": "Melany Boehm",
    "FormalName": "Morissette, Crona and Stanton",
    "Deleted": false,
    "EjUserId": 637,
    "UserName": "Auer Group"
  },
  "UpdatedBy": {
    "AssociateId": 352,
    "Name": "Kunde-Funk",
    "PersonId": 725,
    "Rank": 462,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 683,
    "FullName": "Henriette Kuhic",
    "FormalName": "Schmeler Group",
    "Deleted": false,
    "EjUserId": 952,
    "UserName": "Fisher, Hintz and DuBuque"
  },
  "CreatedBy": {
    "AssociateId": 112,
    "Name": "Vandervort Inc and Sons",
    "PersonId": 915,
    "Rank": 371,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 50,
    "FullName": "Andreanne Zieme",
    "FormalName": "Sipes, Strosin and Leannon",
    "Deleted": false,
    "EjUserId": 734,
    "UserName": "Mayert-Stroman"
  },
  "Contact": {
    "ContactId": 11,
    "Name": "Hettinger-McDermott",
    "OrgNr": "449758",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nostrum",
    "DirectPhone": "412.135.4214 x8513",
    "AssociateId": 36,
    "CountryId": 814,
    "EmailAddress": "bailey.christiansen@willmsmuller.com",
    "Kananame": "magnam",
    "EmailAddressName": "erin.langworth@borerrosenbaum.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Royal Pagac",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "cupiditate",
    "FullName": "Domenica Kozey",
    "IsOwnerContact": true,
    "ActiveErpLinks": 51
  },
  "Project": {
    "ProjectId": 964,
    "Name": "Kuhic-Weber",
    "Description": "Optional intermediate challenge",
    "URL": "http://www.example.com/",
    "Type": "quaerat",
    "AssociateId": 161,
    "AssociateFullName": "Jeff Larkin",
    "TypeId": 70,
    "Updated": "1998-02-13T15:05:42.6596354+01:00",
    "StatusId": 97,
    "Status": "eius",
    "TextId": 247,
    "PublishTo": "2003-02-08T15:05:42.6596354+01:00",
    "PublishFrom": "1994-12-16T15:05:42.6596354+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1584777",
    "ActiveErpLinks": 819
  },
  "SaleText": "dolores",
  "Person": {
    "Position": "in",
    "PersonId": 513,
    "Mrmrs": "aperiam",
    "Firstname": "Name",
    "Lastname": "Mayer",
    "MiddleName": "Wilderman Group",
    "Title": "omnis",
    "Description": "Multi-lateral even-keeled analyzer",
    "Email": "lavinia.casper@mohrschmeler.uk",
    "FullName": "Mr. Daphney Lind",
    "DirectPhone": "(147)133-8862",
    "FormalName": "Rogahn Group",
    "CountryId": 790,
    "ContactId": 909,
    "ContactName": "Bartoletti-Kessler",
    "Retired": 782,
    "Rank": 328,
    "ActiveInterests": 922,
    "ContactDepartment": "",
    "ContactCountryId": 293,
    "ContactOrgNr": "1181001",
    "FaxPhone": "441-477-1414 x86304",
    "MobilePhone": "1-028-337-8005",
    "ContactPhone": "111-123-4737 x243",
    "AssociateName": "Kerluke-O'Keefe",
    "AssociateId": 426,
    "UsePersonAddress": true,
    "ContactFax": "aperiam",
    "Kanafname": "officiis",
    "Kanalname": "eveniet",
    "Post1": "molestias",
    "Post2": "blanditiis",
    "Post3": "culpa",
    "EmailName": "haven@hermann.us",
    "ContactFullName": "Elliot O'Kon",
    "ActiveErpLinks": 282,
    "TicketPriorityId": 888,
    "SupportLanguageId": 169,
    "SupportAssociateId": 28,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 354,
    "Value": "illum",
    "Tooltip": "dolorem"
  },
  "Competitor": {
    "Id": 955,
    "Value": "laudantium",
    "Tooltip": "cumque"
  },
  "Credited": {
    "Id": 572,
    "Value": "nisi",
    "Tooltip": "quaerat"
  },
  "Rating": {
    "Id": 190,
    "Value": "aut",
    "Tooltip": "sit"
  },
  "Reason": {
    "Id": 849,
    "Value": "aut",
    "Tooltip": "architecto"
  },
  "Source": {
    "Id": 565,
    "Value": "soluta",
    "Tooltip": "quo"
  },
  "Status": "Lost",
  "Saledate": "2017-08-11T15:05:42.6616352+02:00",
  "Amount": 17534.73,
  "SaleId": 849,
  "Earning": 13689.312,
  "EarningPercent": 3466.2039999999997,
  "Heading": "sapiente",
  "Number": "995442",
  "Probability": 540,
  "CreatedDate": "2018-07-14T15:05:42.6616352+02:00",
  "UpdatedDate": "2012-10-05T15:05:42.6616352+02:00",
  "Completed": "Completed",
  "ActiveLinks": 639,
  "Links": [
    {
      "EntityName": "Nitzsche-Yost",
      "Id": 716,
      "Description": "Cross-group systematic circuit",
      "ExtraInfo": "maiores",
      "LinkId": 180
    },
    {
      "EntityName": "Nitzsche-Yost",
      "Id": 716,
      "Description": "Cross-group systematic circuit",
      "ExtraInfo": "maiores",
      "LinkId": 180
    }
  ],
  "NextDueDate": "2004-07-05T15:05:42.6616352+02:00",
  "Postit": "perspiciatis",
  "SaleType": {
    "Id": 475,
    "Value": "et",
    "Tooltip": "nisi"
  },
  "ReasonSold": {
    "Id": 17,
    "Value": "nihil",
    "Tooltip": "dolores"
  },
  "ReasonStalled": {
    "Id": 928,
    "Value": "sit",
    "Tooltip": "est"
  },
  "ReopenDate": "2006-04-10T15:05:42.6616352+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Reynolds-Jacobs",
      "Comment": "quidem",
      "StakeholderRoleId": 441,
      "CountryId": 923,
      "PersonId": 104,
      "EmailDescription": "ada_swaniawski@marquardt.info",
      "EmailId": 206,
      "EmailAddress": "jena.nienow@russel.co.uk",
      "PhoneId": 216,
      "ContactName": "Cormier-Beier",
      "ContactId": 566,
      "SaleId": 98,
      "Mrmrs": "similique",
      "Firstname": "Devan",
      "MiddleName": "Kihn-Fadel",
      "Lastname": "Robel",
      "SaleStakeholderId": 909,
      "Rank": 35,
      "Phone": "1-643-160-5718"
    }
  ],
  "ActiveErpLinks": 394,
  "UserDefinedFields": {
    "SuperOffice:1": "813997496",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "ipsa",
    "CustomFields2": "voluptates"
  },
  "PublishEventDate": "1998-11-18T15:05:42.662635+01:00",
  "PublishTo": "2013-05-18T15:05:42.662635+02:00",
  "PublishFrom": "2019-11-09T15:05:42.662635+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 224,
      "Visibility": "All",
      "DisplayValue": "quisquam"
    },
    {
      "VisibleId": 224,
      "Visibility": "All",
      "DisplayValue": "quisquam"
    }
  ]
}
```

```http_
HTTP/1.1 200 SaleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 74,
    "StartDate": "2018-12-13T15:05:42.6706347+01:00",
    "EndDate": "1998-11-08T15:05:42.6706347+01:00",
    "Type": "BookingForChecklist",
    "Task": "architecto",
    "AssociateFullName": "Mallory Pfeffer",
    "ContactName": "Hackett, Kirlin and Howe",
    "Description": "Progressive regional time-frame",
    "PersonFullName": "Mr. Adeline Nienow",
    "PersonId": 41,
    "ContactId": 656,
    "ProjectId": 863,
    "ProjectName": "Abbott Group",
    "IsPublished": true,
    "AssociateId": 636,
    "ColorIndex": 181,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 572,
    "PriorityName": "Purdy-Friesen",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1999-01-05T15:05:42.6716348+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2015-10-04T15:05:42.6716348+02:00",
    "RecurringEndDate": "2021-05-31T15:05:42.6716348+02:00",
    "MotherId": 288,
    "AssignedBy": 531,
    "AssignedByFullName": "Tobin Herzog",
    "RejectReason": "",
    "Location": "labore",
    "AlarmLeadTime": "maxime",
    "SaleId": 895,
    "SaleName": "Walker, Kub and Stracke",
    "AssociateName": "Cremin LLC",
    "CreatedDate": "1999-04-23T15:05:42.6716348+02:00",
    "CreatedBy": "vitae",
    "CreatedByFullName": "Jada Howell",
    "CreatedByAssociateId": 876,
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
        "FieldLength": 512
      }
    }
  },
  "Associate": {
    "AssociateId": 537,
    "Name": "Zemlak LLC",
    "PersonId": 894,
    "Rank": 297,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 573,
    "FullName": "Ms. Laney Schneider",
    "FormalName": "Gleichner, Sporer and Hayes",
    "Deleted": false,
    "EjUserId": 14,
    "UserName": "Schuster-Senger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 73
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 923,
    "Name": "Kuhlman Group",
    "PersonId": 575,
    "Rank": 531,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 876,
    "FullName": "Laura Mante",
    "FormalName": "Walsh-Dietrich",
    "Deleted": true,
    "EjUserId": 165,
    "UserName": "Buckridge-O'Hara",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 872
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 901,
    "Name": "Zulauf, Ratke and Gottlieb",
    "PersonId": 990,
    "Rank": 700,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 174,
    "FullName": "Ova Kozey",
    "FormalName": "Kiehn, Mertz and Weimann",
    "Deleted": true,
    "EjUserId": 550,
    "UserName": "Hirthe, Hoeger and McGlynn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 312
      }
    }
  },
  "Contact": {
    "ContactId": 465,
    "Name": "Gibson-Kilback",
    "OrgNr": "1383992",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptatem",
    "DirectPhone": "(475)230-6246 x660",
    "AssociateId": 721,
    "CountryId": 215,
    "EmailAddress": "boris@hahnjenkins.co.uk",
    "Kananame": "ratione",
    "EmailAddressName": "rowena@hane.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Barton Greenholt",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "molestiae",
    "FullName": "Valentin Konopelski",
    "IsOwnerContact": true,
    "ActiveErpLinks": 338,
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
  "Project": {
    "ProjectId": 634,
    "Name": "Hessel, Lind and Feeney",
    "Description": "Vision-oriented responsive capability",
    "URL": "http://www.example.com/",
    "Type": "id",
    "AssociateId": 410,
    "AssociateFullName": "Myrtice Ebert",
    "TypeId": 430,
    "Updated": "2006-11-25T15:05:42.6746349+01:00",
    "StatusId": 720,
    "Status": "placeat",
    "TextId": 593,
    "PublishTo": "1997-05-11T15:05:42.6746349+02:00",
    "PublishFrom": "2005-11-23T15:05:42.6746349+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1246521",
    "ActiveErpLinks": 708,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 979
      }
    }
  },
  "SaleText": "optio",
  "Person": {
    "Position": "asperiores",
    "PersonId": 757,
    "Mrmrs": "dignissimos",
    "Firstname": "Ottilie",
    "Lastname": "Kuhlman",
    "MiddleName": "Blanda-O'Connell",
    "Title": "iste",
    "Description": "Quality-focused mobile process improvement",
    "Email": "aliyah.mosciski@nitzsche.co.uk",
    "FullName": "Gussie Fritsch",
    "DirectPhone": "1-415-416-2643 x084",
    "FormalName": "Larkin Inc and Sons",
    "CountryId": 996,
    "ContactId": 824,
    "ContactName": "Pacocha Group",
    "Retired": 788,
    "Rank": 615,
    "ActiveInterests": 997,
    "ContactDepartment": "",
    "ContactCountryId": 774,
    "ContactOrgNr": "105176",
    "FaxPhone": "1-650-480-8803 x8302",
    "MobilePhone": "(362)300-0515 x5646",
    "ContactPhone": "351.066.0351",
    "AssociateName": "Fritsch-Will",
    "AssociateId": 429,
    "UsePersonAddress": true,
    "ContactFax": "repudiandae",
    "Kanafname": "earum",
    "Kanalname": "cum",
    "Post1": "distinctio",
    "Post2": "impedit",
    "Post3": "illo",
    "EmailName": "verdie.heller@hamillstehr.co.uk",
    "ContactFullName": "Colleen Ankunding",
    "ActiveErpLinks": 531,
    "TicketPriorityId": 950,
    "SupportLanguageId": 342,
    "SupportAssociateId": 283,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 775
      }
    }
  },
  "Currency": {
    "Id": 107,
    "Value": "eos",
    "Tooltip": "cum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 512
      }
    }
  },
  "Competitor": {
    "Id": 885,
    "Value": "qui",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deploy mission-critical metrics"
        },
        "FieldType": "System.Int32",
        "FieldLength": 933
      }
    }
  },
  "Credited": {
    "Id": 105,
    "Value": "a",
    "Tooltip": "eveniet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 395
      }
    }
  },
  "Rating": {
    "Id": 812,
    "Value": "laborum",
    "Tooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 700
      }
    }
  },
  "Reason": {
    "Id": 174,
    "Value": "magnam",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 415
      }
    }
  },
  "Source": {
    "Id": 282,
    "Value": "fugiat",
    "Tooltip": "nemo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 746
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2016-04-07T15:05:42.6766347+02:00",
  "Amount": 24319.84,
  "SaleId": 209,
  "Earning": 18493.734,
  "EarningPercent": 25426.142,
  "Heading": "architecto",
  "Number": "1039199",
  "Probability": 372,
  "CreatedDate": "2005-09-02T15:05:42.6766347+02:00",
  "UpdatedDate": "2000-05-31T15:05:42.6766347+02:00",
  "Completed": "Completed",
  "ActiveLinks": 780,
  "Links": [
    {
      "EntityName": "Powlowski-Heller",
      "Id": 681,
      "Description": "Right-sized discrete migration",
      "ExtraInfo": "consectetur",
      "LinkId": 560,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    }
  ],
  "NextDueDate": "2016-10-27T15:05:42.6766347+02:00",
  "Postit": "sunt",
  "SaleType": {
    "Id": 531,
    "Value": "consequuntur",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 227
      }
    }
  },
  "ReasonSold": {
    "Id": 52,
    "Value": "provident",
    "Tooltip": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 995
      }
    }
  },
  "ReasonStalled": {
    "Id": 614,
    "Value": "neque",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 650
      }
    }
  },
  "ReopenDate": "1997-08-27T15:05:42.6766347+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Luettgen, Rosenbaum and Hartmann",
      "Comment": "minima",
      "StakeholderRoleId": 56,
      "CountryId": 631,
      "PersonId": 3,
      "EmailDescription": "koby@carter.com",
      "EmailId": 814,
      "EmailAddress": "ross@durgan.us",
      "PhoneId": 566,
      "ContactName": "Walter-Grant",
      "ContactId": 700,
      "SaleId": 854,
      "Mrmrs": "suscipit",
      "Firstname": "Emie",
      "MiddleName": "Quigley-Orn",
      "Lastname": "Greenfelder",
      "SaleStakeholderId": 483,
      "Rank": 369,
      "Phone": "(670)637-7861",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "ActiveErpLinks": 670,
  "UserDefinedFields": {
    "SuperOffice:1": "Olaf Prohaska",
    "SuperOffice:2": "1645968588"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "accusamus"
  },
  "PublishEventDate": "1995-08-07T15:05:42.6776347+02:00",
  "PublishTo": "2012-08-03T15:05:42.6776347+02:00",
  "PublishFrom": "2018-02-11T15:05:42.6776347+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 956,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 5
        }
      }
    },
    {
      "VisibleId": 956,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 5
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
      "FieldLength": 398
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```