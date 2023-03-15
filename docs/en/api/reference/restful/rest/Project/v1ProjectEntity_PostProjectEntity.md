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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 737,
  "Name": "Paucek, Deckow and Nienow",
  "ProjectNumber": "665681",
  "ProjectMembers": [
    {
      "ProjectmemberId": 677,
      "ContactId": 708,
      "ProjectId": 277,
      "ContactName": "Emard-West",
      "ContactDepartment": "",
      "ProjectName": "Smitham-Beatty",
      "EmailId": 177,
      "EmailAddress": "malvina@trantow.com",
      "CountryId": 568,
      "Firstname": "Gavin",
      "MiddleName": "Williamson-Stamm",
      "Lastname": "Oberbrunner",
      "PersonId": 959,
      "Mrmrs": "sed",
      "ProjectMemberTypeName": "Yundt, Wolff and Ruecker",
      "Phone": "(006)814-0504",
      "PhoneId": 605,
      "ProjectMemberTypeId": 859,
      "EmailAddressName": "justus_watsica@metz.com",
      "Comment": "deleniti",
      "FullName": "Zora Roob"
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "velit",
      "Description": "Inverse assymetric knowledge base"
    },
    {
      "Value": "quia",
      "StrippedValue": "velit",
      "Description": "Inverse assymetric knowledge base"
    }
  ],
  "CreatedDate": "2011-01-09T12:15:27.1356332+01:00",
  "UpdatedDate": "2012-11-24T12:15:27.1356332+01:00",
  "Description": "Down-sized 3rd generation structure",
  "Postit": "iusto",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Quality-focused background complexity",
  "ActiveStatusMonitorId": 692,
  "Links": [
    {
      "EntityName": "Leannon, Fahey and King",
      "Id": 261,
      "Description": "Upgradable upward-trending flexibility",
      "ExtraInfo": "fuga",
      "LinkId": 651
    },
    {
      "EntityName": "Leannon, Fahey and King",
      "Id": 261,
      "Description": "Upgradable upward-trending flexibility",
      "ExtraInfo": "fuga",
      "LinkId": 651
    }
  ],
  "ActiveLinks": 109,
  "Completed": true,
  "NextMilestoneDate": "2018-08-14T12:15:27.1366412+02:00",
  "NmdAppointmentId": 742,
  "EndDate": "2021-12-09T12:15:27.1366412+01:00",
  "ActiveErpLinks": 632,
  "UserDefinedFields": {
    "SuperOffice:1": "Floy Schmitt",
    "SuperOffice:2": "640955171"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "quos"
  },
  "PublishEventDate": "2002-11-12T12:15:27.137634+01:00",
  "PublishTo": "2007-07-04T12:15:27.137634+02:00",
  "PublishFrom": "1999-11-27T12:15:27.137634+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 9,
  "Name": "Romaguera Group",
  "ProjectNumber": "1385064",
  "ProjectMembers": [
    {
      "ProjectmemberId": 812,
      "ContactId": 600,
      "ProjectId": 523,
      "ContactName": "Runolfsdottir, Feil and Schaden",
      "ContactDepartment": "",
      "ProjectName": "Moen-Koss",
      "EmailId": 220,
      "EmailAddress": "allen.fahey@rodriguez.info",
      "CountryId": 991,
      "Firstname": "Nolan",
      "MiddleName": "Thompson-Schroeder",
      "Lastname": "Schamberger",
      "PersonId": 5,
      "Mrmrs": "doloremque",
      "ProjectMemberTypeName": "Ziemann, Jones and McClure",
      "Phone": "583-418-5842 x108",
      "PhoneId": 681,
      "ProjectMemberTypeId": 479,
      "EmailAddressName": "casandra_fisher@murazik.com",
      "Comment": "ut",
      "FullName": "Moriah Gina Zboncak PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 540
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "atque",
      "Description": "Networked bottom-line capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "atque",
      "Description": "Networked bottom-line capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "CreatedDate": "2007-07-08T12:15:27.1416335+02:00",
  "UpdatedDate": "2020-03-09T12:15:27.1416335+01:00",
  "Description": "Multi-channelled eco-centric focus group",
  "Postit": "quaerat",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Object-based bottom-line data-warehouse",
  "ActiveStatusMonitorId": 20,
  "Links": [
    {
      "EntityName": "Hoppe, Beahan and Willms",
      "Id": 564,
      "Description": "Customer-focused intermediate productivity",
      "ExtraInfo": "quia",
      "LinkId": 85,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    }
  ],
  "ActiveLinks": 755,
  "Completed": true,
  "NextMilestoneDate": "2013-10-11T12:15:27.1436328+02:00",
  "NmdAppointmentId": 4,
  "EndDate": "2009-09-01T12:15:27.1436328+02:00",
  "ActiveErpLinks": 252,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Fae Frami",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "asperiores"
  },
  "PublishEventDate": "2019-09-30T12:15:27.1436328+02:00",
  "PublishTo": "2009-04-28T12:15:27.1436328+02:00",
  "PublishFrom": "2002-12-31T12:15:27.1436328+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 212
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```