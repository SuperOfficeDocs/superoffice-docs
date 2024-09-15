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
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 900,
  "Name": "Fay, Green and Gaylord",
  "ProjectNumber": "1394818",
  "ProjectMembers": [
    {
      "ProjectmemberId": 442,
      "ContactId": 301,
      "ProjectId": 439,
      "ContactName": "Feil Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Tremblay-Heidenreich",
      "EmailId": 952,
      "EmailAddress": "seamus.mraz@hyatthills.info",
      "CountryId": 257,
      "Firstname": "Gerhard",
      "MiddleName": "VonRueden, Gerhold and Bruen",
      "Lastname": "Bednar",
      "PersonId": 766,
      "Mrmrs": "iure",
      "ProjectMemberTypeName": "Stiedemann-Cummerata",
      "Phone": "1-819-059-7390",
      "PhoneId": 306,
      "ProjectMemberTypeId": 186,
      "EmailAddressName": "lavon_collier@windler.uk",
      "Comment": "laboriosam",
      "FullName": "Arthur Rau IV"
    }
  ],
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "quidem",
      "Description": "Re-engineered multi-state customer loyalty"
    },
    {
      "Value": "totam",
      "StrippedValue": "quidem",
      "Description": "Re-engineered multi-state customer loyalty"
    }
  ],
  "CreatedDate": "2015-08-05T04:02:06.7128881+02:00",
  "UpdatedDate": "1998-04-05T04:02:06.7128881+02:00",
  "Description": "Centralized stable project",
  "Postit": "sint",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Triple-buffered scalable hub",
  "ActiveStatusMonitorId": 360,
  "Links": [
    {
      "EntityName": "Swift Inc and Sons",
      "Id": 622,
      "Description": "Down-sized multimedia customer loyalty",
      "ExtraInfo": "et",
      "LinkId": 970
    },
    {
      "EntityName": "Swift Inc and Sons",
      "Id": 622,
      "Description": "Down-sized multimedia customer loyalty",
      "ExtraInfo": "et",
      "LinkId": 970
    }
  ],
  "ActiveLinks": 227,
  "Completed": false,
  "NextMilestoneDate": "2013-01-23T04:02:06.7128881+01:00",
  "NmdAppointmentId": 708,
  "EndDate": "2020-11-06T04:02:06.7128881+01:00",
  "ActiveErpLinks": 904,
  "UserDefinedFields": {
    "SuperOffice:1": "Oral Haag",
    "SuperOffice:2": "382188108"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "ipsum",
    "CustomFields2": "alias"
  },
  "PublishEventDate": "1999-07-09T04:02:06.7128881+02:00",
  "PublishTo": "2019-06-23T04:02:06.7128881+02:00",
  "PublishFrom": "2016-11-27T04:02:06.7128881+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 512,
  "Name": "Glover Inc and Sons",
  "ProjectNumber": "1296452",
  "ProjectMembers": [
    {
      "ProjectmemberId": 823,
      "ContactId": 514,
      "ProjectId": 847,
      "ContactName": "Hessel-Casper",
      "ContactDepartment": "",
      "ProjectName": "Waters-Jakubowski",
      "EmailId": 378,
      "EmailAddress": "reyna.mertz@nikolaus.ca",
      "CountryId": 383,
      "Firstname": "Perry",
      "MiddleName": "Lueilwitz Inc and Sons",
      "Lastname": "Boyle",
      "PersonId": 533,
      "Mrmrs": "sapiente",
      "ProjectMemberTypeName": "Huel LLC",
      "Phone": "(697)837-4776 x390",
      "PhoneId": 645,
      "ProjectMemberTypeId": 793,
      "EmailAddressName": "emerald@stracke.biz",
      "Comment": "iure",
      "FullName": "Colin Kuvalis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 53
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "quo",
      "Description": "Optional demand-driven collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "quo",
      "Description": "Optional demand-driven collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "CreatedDate": "2013-12-07T04:02:06.7128881+01:00",
  "UpdatedDate": "2011-03-30T04:02:06.7128881+02:00",
  "Description": "Vision-oriented eco-centric paradigm",
  "Postit": "sed",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Decentralized incremental time-frame",
  "ActiveStatusMonitorId": 245,
  "Links": [
    {
      "EntityName": "Witting Group",
      "Id": 995,
      "Description": "Cloned contextually-based methodology",
      "ExtraInfo": "tenetur",
      "LinkId": 97,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "ActiveLinks": 971,
  "Completed": false,
  "NextMilestoneDate": "2010-04-01T04:02:06.7128881+02:00",
  "NmdAppointmentId": 948,
  "EndDate": "2019-09-27T04:02:06.7128881+02:00",
  "ActiveErpLinks": 624,
  "UserDefinedFields": {
    "SuperOffice:1": "Mitchell Barton",
    "SuperOffice:2": "Ms. Otilia Roosevelt Kreiger DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "sapiente"
  },
  "PublishEventDate": "2015-06-06T04:02:06.7128881+02:00",
  "PublishTo": "2023-09-26T04:02:06.7128881+02:00",
  "PublishFrom": "2019-09-28T04:02:06.7128881+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 415
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```