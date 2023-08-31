---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 191,
  "Name": "Feest, Kertzmann and Tremblay",
  "ProjectNumber": "1150751",
  "ProjectMembers": [
    {
      "ProjectmemberId": 395,
      "ContactId": 689,
      "ProjectId": 779,
      "ContactName": "Heaney-Kerluke",
      "ContactDepartment": "",
      "ProjectName": "Wilderman-Raynor",
      "EmailId": 358,
      "EmailAddress": "abe.frami@hagenesstracke.uk",
      "CountryId": 177,
      "Firstname": "Russel",
      "MiddleName": "Hand, O'Keefe and Brown",
      "Lastname": "Turner",
      "PersonId": 40,
      "Mrmrs": "culpa",
      "ProjectMemberTypeName": "Bode-Christiansen",
      "Phone": "1-032-581-4885 x0778",
      "PhoneId": 966,
      "ProjectMemberTypeId": 223,
      "EmailAddressName": "ansel@runolfsson.com",
      "Comment": "placeat",
      "FullName": "Mr. Noelia Gottlieb Sr."
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "in",
      "Description": "Enterprise-wide radical toolset"
    },
    {
      "Value": "qui",
      "StrippedValue": "in",
      "Description": "Enterprise-wide radical toolset"
    }
  ],
  "CreatedDate": "1999-08-23T03:31:32.7538737+02:00",
  "UpdatedDate": "1996-05-21T03:31:32.7538737+02:00",
  "Description": "Enhanced radical software",
  "Postit": "expedita",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Ergonomic 6th generation budgetary management",
  "ActiveStatusMonitorId": 254,
  "Links": [
    {
      "EntityName": "Moore-Kuhn",
      "Id": 337,
      "Description": "Reduced motivating productivity",
      "ExtraInfo": "ad",
      "LinkId": 420
    },
    {
      "EntityName": "Moore-Kuhn",
      "Id": 337,
      "Description": "Reduced motivating productivity",
      "ExtraInfo": "ad",
      "LinkId": 420
    }
  ],
  "ActiveLinks": 941,
  "Completed": false,
  "NextMilestoneDate": "2010-07-03T03:31:32.7538737+02:00",
  "NmdAppointmentId": 671,
  "EndDate": "2009-04-27T03:31:32.7538737+02:00",
  "ActiveErpLinks": 333,
  "UserDefinedFields": {
    "SuperOffice:1": "Deontae Maggio",
    "SuperOffice:2": "829372773"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "laborum"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "modi"
  },
  "PublishEventDate": "2022-06-29T03:31:32.7538737+02:00",
  "PublishTo": "2012-01-17T03:31:32.7538737+01:00",
  "PublishFrom": "2005-03-31T03:31:32.7538737+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 772,
  "Name": "Kautzer-Kling",
  "ProjectNumber": "1662744",
  "ProjectMembers": [
    {
      "ProjectmemberId": 712,
      "ContactId": 824,
      "ProjectId": 972,
      "ContactName": "Batz LLC",
      "ContactDepartment": "",
      "ProjectName": "McCullough, Schultz and Hettinger",
      "EmailId": 205,
      "EmailAddress": "frances@oconnell.ca",
      "CountryId": 425,
      "Firstname": "Evie",
      "MiddleName": "Crooks Group",
      "Lastname": "Kozey",
      "PersonId": 166,
      "Mrmrs": "perferendis",
      "ProjectMemberTypeName": "Murphy, Robel and Runte",
      "Phone": "(040)285-9074",
      "PhoneId": 472,
      "ProjectMemberTypeId": 519,
      "EmailAddressName": "amie@yost.ca",
      "Comment": "deleniti",
      "FullName": "Prof. Cristopher Jaycee Witting",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "qui",
      "Description": "Synergistic regional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "qui",
      "Description": "Synergistic regional product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "CreatedDate": "1996-08-04T03:31:32.7538737+02:00",
  "UpdatedDate": "2009-06-02T03:31:32.7538737+02:00",
  "Description": "Vision-oriented eco-centric pricing structure",
  "Postit": "similique",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Face to face incremental algorithm",
  "ActiveStatusMonitorId": 819,
  "Links": [
    {
      "EntityName": "Gleason, Lebsack and Will",
      "Id": 709,
      "Description": "Cross-group regional solution",
      "ExtraInfo": "praesentium",
      "LinkId": 517,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "ActiveLinks": 886,
  "Completed": true,
  "NextMilestoneDate": "2002-11-26T03:31:32.7538737+01:00",
  "NmdAppointmentId": 652,
  "EndDate": "2004-01-17T03:31:32.7538737+01:00",
  "ActiveErpLinks": 555,
  "UserDefinedFields": {
    "SuperOffice:1": "345439446",
    "SuperOffice:2": "1842405107"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "ducimus"
  },
  "PublishEventDate": "2013-06-17T03:31:32.7538737+02:00",
  "PublishTo": "2001-08-13T03:31:32.7538737+02:00",
  "PublishFrom": "2017-03-17T03:31:32.7538737+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 153
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```