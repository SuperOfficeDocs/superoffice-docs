---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
content_type: reference
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.
NsApiSlow threshold: 2000 ms.






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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 385,
  "Name": "Okuneva, Price and Hegmann",
  "ProjectNumber": "1548607",
  "ProjectMembers": [
    {
      "ProjectmemberId": 785,
      "ContactId": 591,
      "ProjectId": 480,
      "ContactName": "Crooks, Smitham and Green",
      "ContactDepartment": "",
      "ProjectName": "Walter Inc and Sons",
      "EmailId": 902,
      "EmailAddress": "karson@powlowski.co.uk",
      "CountryId": 726,
      "Firstname": "Sydni",
      "MiddleName": "Heidenreich, Oberbrunner and Bode",
      "Lastname": "Watsica",
      "PersonId": 201,
      "Mrmrs": "quae",
      "ProjectMemberTypeName": "Hintz LLC",
      "Phone": "(489)743-7171",
      "PhoneId": 681,
      "ProjectMemberTypeId": 402,
      "EmailAddressName": "camren@homenickbalistreri.info",
      "Comment": "qui",
      "FullName": "Brooke Glover",
      "Registered": "2020-03-20T03:40:55.9292805+01:00",
      "Updated": "2021-03-11T03:40:55.9292805+01:00"
    }
  ],
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "maxime",
      "Description": "Inverse object-oriented definition"
    },
    {
      "Value": "placeat",
      "StrippedValue": "maxime",
      "Description": "Inverse object-oriented definition"
    }
  ],
  "CreatedDate": "2020-10-08T03:40:55.9292805+02:00",
  "UpdatedDate": "2007-11-05T03:40:55.9292805+01:00",
  "Description": "Open-source incremental adapter",
  "Postit": "pariatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Inverse methodical attitude",
  "ActiveStatusMonitorId": 862,
  "Links": [
    {
      "EntityName": "Larson-Kris",
      "Id": 643,
      "Description": "Quality-focused tangible capability",
      "ExtraInfo": "recusandae",
      "LinkId": 42
    },
    {
      "EntityName": "Larson-Kris",
      "Id": 643,
      "Description": "Quality-focused tangible capability",
      "ExtraInfo": "recusandae",
      "LinkId": 42
    }
  ],
  "ActiveLinks": 60,
  "Completed": false,
  "NextMilestoneDate": "2009-08-12T03:40:55.9292805+02:00",
  "NmdAppointmentId": 397,
  "EndDate": "2019-07-20T03:40:55.9292805+02:00",
  "ActiveErpLinks": 428,
  "UserDefinedFields": {
    "SuperOffice:1": "Dianna Bednar",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "eos"
  },
  "PublishEventDate": "2008-11-26T03:40:55.9292805+01:00",
  "PublishTo": "2003-03-23T03:40:55.9292805+01:00",
  "PublishFrom": "2017-01-05T03:40:55.9292805+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 341,
  "Name": "Wuckert Inc and Sons",
  "ProjectNumber": "1256801",
  "ProjectMembers": [
    {
      "ProjectmemberId": 980,
      "ContactId": 233,
      "ProjectId": 321,
      "ContactName": "Keeling-Parisian",
      "ContactDepartment": "",
      "ProjectName": "Boehm, Fisher and Marks",
      "EmailId": 119,
      "EmailAddress": "rosetta.wilderman@casper.uk",
      "CountryId": 690,
      "Firstname": "Madilyn",
      "MiddleName": "Marvin Group",
      "Lastname": "Konopelski",
      "PersonId": 955,
      "Mrmrs": "sequi",
      "ProjectMemberTypeName": "Kiehn Group",
      "Phone": "(064)345-6174 x626",
      "PhoneId": 16,
      "ProjectMemberTypeId": 678,
      "EmailAddressName": "bryce.jacobi@thompson.ca",
      "Comment": "inventore",
      "FullName": "Vernice Rice I",
      "Registered": "2005-04-15T03:40:55.9449064+02:00",
      "Updated": "2013-08-05T03:40:55.9449064+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Devolved multimedia firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Devolved multimedia firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    }
  ],
  "CreatedDate": "2024-06-24T03:40:55.9449064+02:00",
  "UpdatedDate": "2016-11-20T03:40:55.9449064+01:00",
  "Description": "Open-source grid-enabled productivity",
  "Postit": "iste",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Grass-roots fault-tolerant standardization",
  "ActiveStatusMonitorId": 619,
  "Links": [
    {
      "EntityName": "Berge-Strosin",
      "Id": 526,
      "Description": "Reverse-engineered empowering Graphical User Interface",
      "ExtraInfo": "dolores",
      "LinkId": 727,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "ActiveLinks": 52,
  "Completed": false,
  "NextMilestoneDate": "2015-08-26T03:40:55.9449064+02:00",
  "NmdAppointmentId": 509,
  "EndDate": "2012-02-25T03:40:55.9449064+01:00",
  "ActiveErpLinks": 306,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Hayden Hermann MD"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "totam"
  },
  "PublishEventDate": "2008-06-29T03:40:55.9449064+02:00",
  "PublishTo": "2018-05-02T03:40:55.9449064+02:00",
  "PublishFrom": "2024-05-15T03:40:55.9449064+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 598
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```