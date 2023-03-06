---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 850,
  "Name": "Gutmann-Pollich",
  "ProjectNumber": "554503",
  "ProjectMembers": [
    {
      "ProjectmemberId": 954,
      "ContactId": 263,
      "ProjectId": 184,
      "ContactName": "Kris-Botsford",
      "ContactDepartment": "",
      "ProjectName": "Marquardt LLC",
      "EmailId": 404,
      "EmailAddress": "daron@funkkoelpin.uk",
      "CountryId": 310,
      "Firstname": "Dayana",
      "MiddleName": "Wilderman-Buckridge",
      "Lastname": "Torphy",
      "PersonId": 733,
      "Mrmrs": "debitis",
      "ProjectMemberTypeName": "Barrows-Senger",
      "Phone": "(939)469-9570 x75221",
      "PhoneId": 352,
      "ProjectMemberTypeId": 195,
      "EmailAddressName": "dedrick.hudson@tromp.name",
      "Comment": "et",
      "FullName": "Dr. Joanny Bosco MD"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "eos",
      "Description": "Organic uniform initiative"
    },
    {
      "Value": "ut",
      "StrippedValue": "eos",
      "Description": "Organic uniform initiative"
    }
  ],
  "CreatedDate": "2011-05-17T14:19:10.4904756+02:00",
  "UpdatedDate": "2016-08-22T14:19:10.4904756+02:00",
  "Description": "Future-proofed actuating secured line",
  "Postit": "maiores",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Open-architected web-enabled instruction set",
  "ActiveStatusMonitorId": 69,
  "Links": [
    {
      "EntityName": "Sanford, Cronin and Lindgren",
      "Id": 960,
      "Description": "Open-source bi-directional workforce",
      "ExtraInfo": "quia",
      "LinkId": 544
    },
    {
      "EntityName": "Sanford, Cronin and Lindgren",
      "Id": 960,
      "Description": "Open-source bi-directional workforce",
      "ExtraInfo": "quia",
      "LinkId": 544
    }
  ],
  "ActiveLinks": 590,
  "Completed": false,
  "NextMilestoneDate": "1995-11-12T14:19:10.4904756+01:00",
  "NmdAppointmentId": 953,
  "EndDate": "2019-03-29T14:19:10.4904756+01:00",
  "ActiveErpLinks": 612,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Dawn O'Keefe",
    "SuperOffice:2": "Oma Bogisich"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2001-01-20T14:19:10.4904756+01:00",
  "PublishTo": "2010-07-11T14:19:10.4904756+02:00",
  "PublishFrom": "2006-01-09T14:19:10.4904756+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 493,
  "Name": "Hahn-Robel",
  "ProjectNumber": "899967",
  "ProjectMembers": [
    {
      "ProjectmemberId": 403,
      "ContactId": 2,
      "ProjectId": 849,
      "ContactName": "Volkman-Fahey",
      "ContactDepartment": "",
      "ProjectName": "Blanda, Boehm and Fay",
      "EmailId": 965,
      "EmailAddress": "douglas@bayer.uk",
      "CountryId": 877,
      "Firstname": "Serenity",
      "MiddleName": "Greenfelder Inc and Sons",
      "Lastname": "Veum",
      "PersonId": 834,
      "Mrmrs": "deleniti",
      "ProjectMemberTypeName": "Tillman-Swift",
      "Phone": "(366)861-3856 x94882",
      "PhoneId": 29,
      "ProjectMemberTypeId": 753,
      "EmailAddressName": "ellsworth@weimannvolkman.name",
      "Comment": "vel",
      "FullName": "Tyrese Friesen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "unde",
      "Description": "Exclusive bottom-line portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "unde",
      "Description": "Exclusive bottom-line portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "CreatedDate": "1998-02-05T14:19:10.4904756+01:00",
  "UpdatedDate": "2007-09-03T14:19:10.4904756+02:00",
  "Description": "Right-sized foreground leverage",
  "Postit": "quae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Realigned intangible focus group",
  "ActiveStatusMonitorId": 396,
  "Links": [
    {
      "EntityName": "Herzog Inc and Sons",
      "Id": 704,
      "Description": "Cloned contextually-based algorithm",
      "ExtraInfo": "modi",
      "LinkId": 591,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    }
  ],
  "ActiveLinks": 836,
  "Completed": true,
  "NextMilestoneDate": "2013-02-17T14:19:10.4904756+01:00",
  "NmdAppointmentId": 946,
  "EndDate": "2018-03-09T14:19:10.4904756+01:00",
  "ActiveErpLinks": 747,
  "UserDefinedFields": {
    "SuperOffice:1": "Aryanna Sawayn",
    "SuperOffice:2": "1122974529"
  },
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "modi"
  },
  "PublishEventDate": "1999-08-30T14:19:10.4904756+02:00",
  "PublishTo": "2019-07-21T14:19:10.4904756+02:00",
  "PublishFrom": "2015-02-08T14:19:10.4904756+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 361
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```