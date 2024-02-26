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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 865,
  "Name": "Dare-Lindgren",
  "ProjectNumber": "1682043",
  "ProjectMembers": [
    {
      "ProjectmemberId": 618,
      "ContactId": 986,
      "ProjectId": 4,
      "ContactName": "Hane, Davis and Hoeger",
      "ContactDepartment": "",
      "ProjectName": "Abshire-Lowe",
      "EmailId": 948,
      "EmailAddress": "abbigail.labadie@streich.ca",
      "CountryId": 274,
      "Firstname": "Hermann",
      "MiddleName": "Gerhold-Padberg",
      "Lastname": "Okuneva",
      "PersonId": 917,
      "Mrmrs": "error",
      "ProjectMemberTypeName": "Leffler, Wiegand and Glover",
      "Phone": "289-878-8033",
      "PhoneId": 704,
      "ProjectMemberTypeId": 372,
      "EmailAddressName": "reta@luettgen.name",
      "Comment": "sit",
      "FullName": "Eleanore Bosco"
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "nemo",
      "Description": "Organic 3rd generation standardization"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "nemo",
      "Description": "Organic 3rd generation standardization"
    }
  ],
  "CreatedDate": "1996-11-04T10:30:32.1980491+01:00",
  "UpdatedDate": "2007-07-04T10:30:32.1980491+02:00",
  "Description": "Fully-configurable static policy",
  "Postit": "repellendus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Assimilated impactful data-warehouse",
  "ActiveStatusMonitorId": 84,
  "Links": [
    {
      "EntityName": "Grimes, Okuneva and Lebsack",
      "Id": 974,
      "Description": "Sharable next generation moratorium",
      "ExtraInfo": "sunt",
      "LinkId": 204
    },
    {
      "EntityName": "Grimes, Okuneva and Lebsack",
      "Id": 974,
      "Description": "Sharable next generation moratorium",
      "ExtraInfo": "sunt",
      "LinkId": 204
    }
  ],
  "ActiveLinks": 957,
  "Completed": false,
  "NextMilestoneDate": "2016-03-05T10:30:32.1980491+01:00",
  "NmdAppointmentId": 321,
  "EndDate": "2019-08-04T10:30:32.1980491+02:00",
  "ActiveErpLinks": 104,
  "UserDefinedFields": {
    "SuperOffice:1": "Addie Balistreri",
    "SuperOffice:2": "565918934"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2016-02-19T10:30:32.1980491+01:00",
  "PublishTo": "1997-11-04T10:30:32.1980491+01:00",
  "PublishFrom": "2000-05-27T10:30:32.1980491+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 356,
  "Name": "Kutch-Gislason",
  "ProjectNumber": "1436732",
  "ProjectMembers": [
    {
      "ProjectmemberId": 173,
      "ContactId": 579,
      "ProjectId": 835,
      "ContactName": "Douglas Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Brekke-Doyle",
      "EmailId": 495,
      "EmailAddress": "dayana@rempeldickinson.com",
      "CountryId": 245,
      "Firstname": "Beth",
      "MiddleName": "Buckridge, Raynor and Quitzon",
      "Lastname": "Blanda",
      "PersonId": 222,
      "Mrmrs": "fugit",
      "ProjectMemberTypeName": "Keeling LLC",
      "Phone": "936.575.6238 x0601",
      "PhoneId": 993,
      "ProjectMemberTypeId": 699,
      "EmailAddressName": "wyatt@hickle.us",
      "Comment": "vel",
      "FullName": "Eleanore Kris",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "quasi",
      "Description": "Pre-emptive high-level projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "quasi",
      "Description": "Pre-emptive high-level projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "CreatedDate": "2020-12-14T10:30:32.2136745+01:00",
  "UpdatedDate": "2010-08-02T10:30:32.2136745+02:00",
  "Description": "Triple-buffered encompassing software",
  "Postit": "optio",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Cross-group didactic paradigm",
  "ActiveStatusMonitorId": 886,
  "Links": [
    {
      "EntityName": "Hilpert Inc and Sons",
      "Id": 596,
      "Description": "Reactive encompassing forecast",
      "ExtraInfo": "vel",
      "LinkId": 319,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "ActiveLinks": 35,
  "Completed": false,
  "NextMilestoneDate": "2007-03-13T10:30:32.2136745+01:00",
  "NmdAppointmentId": 65,
  "EndDate": "2011-04-30T10:30:32.2136745+02:00",
  "ActiveErpLinks": 206,
  "UserDefinedFields": {
    "SuperOffice:1": "35579311",
    "SuperOffice:2": "Dr. Pablo Bruen"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "itaque"
  },
  "PublishEventDate": "2007-11-08T10:30:32.2136745+01:00",
  "PublishTo": "2012-01-03T10:30:32.2136745+01:00",
  "PublishFrom": "2009-07-01T10:30:32.2136745+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 335
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```