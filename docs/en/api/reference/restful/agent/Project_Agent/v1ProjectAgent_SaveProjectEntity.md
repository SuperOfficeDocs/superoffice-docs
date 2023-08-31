---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

### Response body: ProjectEntity

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

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 355,
  "Name": "Rowe, Yost and Beahan",
  "ProjectNumber": "1001197",
  "ProjectMembers": [
    {
      "ProjectmemberId": 853,
      "ContactId": 63,
      "ProjectId": 638,
      "ContactName": "Satterfield-Volkman",
      "ContactDepartment": "",
      "ProjectName": "Bayer-Lowe",
      "EmailId": 759,
      "EmailAddress": "adam_oberbrunner@kshlerin.name",
      "CountryId": 665,
      "Firstname": "Madonna",
      "MiddleName": "Roberts, Bergstrom and Goyette",
      "Lastname": "Robel",
      "PersonId": 332,
      "Mrmrs": "quam",
      "ProjectMemberTypeName": "Rogahn, Green and McLaughlin",
      "Phone": "563-116-5925 x85525",
      "PhoneId": 607,
      "ProjectMemberTypeId": 685,
      "EmailAddressName": "drake_waters@hudsongreenfelder.us",
      "Comment": "animi",
      "FullName": "Dr. Waino Amir Gottlieb"
    }
  ],
  "Urls": [
    {
      "Value": "consectetur",
      "StrippedValue": "natus",
      "Description": "Automated bottom-line system engine"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "natus",
      "Description": "Automated bottom-line system engine"
    }
  ],
  "CreatedDate": "2004-02-24T03:31:26.9799814+01:00",
  "UpdatedDate": "2003-08-06T03:31:26.9799814+02:00",
  "Description": "Seamless mission-critical infrastructure",
  "Postit": "soluta",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Organic 24 hour access",
  "ActiveStatusMonitorId": 912,
  "Links": [
    {
      "EntityName": "Sipes-Green",
      "Id": 628,
      "Description": "Progressive multi-tasking paradigm",
      "ExtraInfo": "omnis",
      "LinkId": 560
    },
    {
      "EntityName": "Sipes-Green",
      "Id": 628,
      "Description": "Progressive multi-tasking paradigm",
      "ExtraInfo": "omnis",
      "LinkId": 560
    }
  ],
  "ActiveLinks": 838,
  "Completed": true,
  "NextMilestoneDate": "2010-10-10T03:31:26.9799814+02:00",
  "NmdAppointmentId": 703,
  "EndDate": "2008-08-13T03:31:26.9799814+02:00",
  "ActiveErpLinks": 554,
  "UserDefinedFields": {
    "SuperOffice:1": "Joy Alvera Padberg II",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "tempora",
    "CustomFields2": "sed"
  },
  "PublishEventDate": "2004-03-16T03:31:26.9799814+01:00",
  "PublishTo": "2023-06-28T03:31:26.9799814+02:00",
  "PublishFrom": "1998-06-11T03:31:26.9799814+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 54,
  "Name": "Mayert, Romaguera and Rodriguez",
  "ProjectNumber": "929569",
  "ProjectMembers": [
    {
      "ProjectmemberId": 456,
      "ContactId": 583,
      "ProjectId": 640,
      "ContactName": "Maggio-Runte",
      "ContactDepartment": "",
      "ProjectName": "Harber-Friesen",
      "EmailId": 331,
      "EmailAddress": "golda_schulist@dickinsonkemmer.co.uk",
      "CountryId": 668,
      "Firstname": "Odie",
      "MiddleName": "Nitzsche Inc and Sons",
      "Lastname": "Smitham",
      "PersonId": 249,
      "Mrmrs": "debitis",
      "ProjectMemberTypeName": "Cruickshank, Effertz and Schuppe",
      "Phone": "152-562-4147 x8375",
      "PhoneId": 14,
      "ProjectMemberTypeId": 531,
      "EmailAddressName": "ryleigh.orn@stroman.name",
      "Comment": "et",
      "FullName": "Elmira Jeremy Hermann PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsam",
      "StrippedValue": "deserunt",
      "Description": "Reduced zero tolerance access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 468
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "deserunt",
      "Description": "Reduced zero tolerance access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 468
        }
      }
    }
  ],
  "CreatedDate": "2004-12-09T03:31:26.9799814+01:00",
  "UpdatedDate": "2007-12-14T03:31:26.9799814+01:00",
  "Description": "Optional web-enabled capability",
  "Postit": "quo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Universal transitional workforce",
  "ActiveStatusMonitorId": 340,
  "Links": [
    {
      "EntityName": "Kuhlman, Stamm and Leannon",
      "Id": 981,
      "Description": "Synergistic clear-thinking focus group",
      "ExtraInfo": "alias",
      "LinkId": 387,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    }
  ],
  "ActiveLinks": 502,
  "Completed": false,
  "NextMilestoneDate": "2023-02-04T03:31:26.9799814+01:00",
  "NmdAppointmentId": 803,
  "EndDate": "2022-02-03T03:31:26.9799814+01:00",
  "ActiveErpLinks": 888,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Major Burley Predovic",
    "SuperOffice:2": "Dr. Darwin Lind"
  },
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "consequuntur"
  },
  "PublishEventDate": "2019-07-21T03:31:26.9799814+02:00",
  "PublishTo": "2006-04-16T03:31:26.9799814+02:00",
  "PublishFrom": "2004-05-22T03:31:26.9799814+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 256
    }
  }
}
```