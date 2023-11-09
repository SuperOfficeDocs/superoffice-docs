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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 802,
  "Name": "Schimmel Group",
  "ProjectNumber": "1337546",
  "ProjectMembers": [
    {
      "ProjectmemberId": 96,
      "ContactId": 66,
      "ProjectId": 874,
      "ContactName": "Swaniawski, Gorczany and Koelpin",
      "ContactDepartment": "",
      "ProjectName": "Goodwin, Kautzer and Wolf",
      "EmailId": 337,
      "EmailAddress": "geovanny@wehner.info",
      "CountryId": 713,
      "Firstname": "Marty",
      "MiddleName": "Okuneva Inc and Sons",
      "Lastname": "Leannon",
      "PersonId": 6,
      "Mrmrs": "quasi",
      "ProjectMemberTypeName": "VonRueden, Champlin and Wunsch",
      "Phone": "(217)961-9512 x2600",
      "PhoneId": 729,
      "ProjectMemberTypeId": 794,
      "EmailAddressName": "anita.grant@ohara.ca",
      "Comment": "consequatur",
      "FullName": "Delores Nikolaus"
    }
  ],
  "Urls": [
    {
      "Value": "nisi",
      "StrippedValue": "excepturi",
      "Description": "Intuitive solution-oriented hierarchy"
    },
    {
      "Value": "nisi",
      "StrippedValue": "excepturi",
      "Description": "Intuitive solution-oriented hierarchy"
    }
  ],
  "CreatedDate": "2006-05-11T11:06:42.0197245+02:00",
  "UpdatedDate": "2009-07-21T11:06:42.0197245+02:00",
  "Description": "Multi-channelled stable data-warehouse",
  "Postit": "enim",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Up-sized directional structure",
  "ActiveStatusMonitorId": 627,
  "Links": [
    {
      "EntityName": "Ritchie, Sanford and Lueilwitz",
      "Id": 389,
      "Description": "Up-sized 4th generation system engine",
      "ExtraInfo": "et",
      "LinkId": 887
    },
    {
      "EntityName": "Ritchie, Sanford and Lueilwitz",
      "Id": 389,
      "Description": "Up-sized 4th generation system engine",
      "ExtraInfo": "et",
      "LinkId": 887
    }
  ],
  "ActiveLinks": 482,
  "Completed": false,
  "NextMilestoneDate": "2022-12-17T11:06:42.0197245+01:00",
  "NmdAppointmentId": 598,
  "EndDate": "2009-04-10T11:06:42.0197245+02:00",
  "ActiveErpLinks": 272,
  "UserDefinedFields": {
    "SuperOffice:1": "Ezra Batz",
    "SuperOffice:2": "Miss Kitty Daisy Reichel"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "optio"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "soluta"
  },
  "PublishEventDate": "2022-06-12T11:06:42.0197245+02:00",
  "PublishTo": "2005-01-21T11:06:42.0197245+01:00",
  "PublishFrom": "2003-08-27T11:06:42.0197245+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 393,
  "Name": "O'Connell, Schuppe and Dare",
  "ProjectNumber": "1072285",
  "ProjectMembers": [
    {
      "ProjectmemberId": 865,
      "ContactId": 93,
      "ProjectId": 403,
      "ContactName": "Lakin Group",
      "ContactDepartment": "",
      "ProjectName": "Deckow Group",
      "EmailId": 226,
      "EmailAddress": "ivory@beier.uk",
      "CountryId": 691,
      "Firstname": "Reuben",
      "MiddleName": "Tillman-Medhurst",
      "Lastname": "Hickle",
      "PersonId": 449,
      "Mrmrs": "asperiores",
      "ProjectMemberTypeName": "Langosh-Nienow",
      "Phone": "(393)342-0175",
      "PhoneId": 718,
      "ProjectMemberTypeId": 44,
      "EmailAddressName": "delphia@strosinmarks.com",
      "Comment": "vel",
      "FullName": "Mr. Loyal Parker I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "distinctio",
      "StrippedValue": "ipsam",
      "Description": "Secured dynamic model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "ipsam",
      "Description": "Secured dynamic model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    }
  ],
  "CreatedDate": "2000-09-26T11:06:42.0197245+02:00",
  "UpdatedDate": "2016-07-03T11:06:42.0197245+02:00",
  "Description": "Phased bottom-line utilisation",
  "Postit": "harum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Organic systemic archive",
  "ActiveStatusMonitorId": 380,
  "Links": [
    {
      "EntityName": "Metz Group",
      "Id": 49,
      "Description": "Reduced zero defect local area network",
      "ExtraInfo": "quibusdam",
      "LinkId": 885,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "ActiveLinks": 331,
  "Completed": false,
  "NextMilestoneDate": "2020-07-01T11:06:42.0353528+02:00",
  "NmdAppointmentId": 481,
  "EndDate": "2010-04-02T11:06:42.0353528+02:00",
  "ActiveErpLinks": 704,
  "UserDefinedFields": {
    "SuperOffice:1": "1428178312",
    "SuperOffice:2": "Mr. Kim Ulises Dicki"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "totam"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "iste"
  },
  "PublishEventDate": "2006-11-26T11:06:42.0353528+01:00",
  "PublishTo": "2016-06-13T11:06:42.0353528+02:00",
  "PublishFrom": "2018-09-19T11:06:42.0353528+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 158
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```