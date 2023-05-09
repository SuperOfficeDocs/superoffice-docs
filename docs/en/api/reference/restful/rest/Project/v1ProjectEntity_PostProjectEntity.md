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
  "ProjectId": 597,
  "Name": "Borer-Pollich",
  "ProjectNumber": "1169732",
  "ProjectMembers": [
    {
      "ProjectmemberId": 639,
      "ContactId": 454,
      "ProjectId": 286,
      "ContactName": "Reichert LLC",
      "ContactDepartment": "",
      "ProjectName": "Runolfsdottir-Metz",
      "EmailId": 262,
      "EmailAddress": "reagan@schaefer.info",
      "CountryId": 816,
      "Firstname": "Janiya",
      "MiddleName": "Quitzon-Keeling",
      "Lastname": "Kemmer",
      "PersonId": 452,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Streich LLC",
      "Phone": "(273)319-6504 x39870",
      "PhoneId": 775,
      "ProjectMemberTypeId": 853,
      "EmailAddressName": "eleazar.pollich@bogan.co.uk",
      "Comment": "omnis",
      "FullName": "Kamryn Keeling DVM"
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Multi-layered stable middleware"
    },
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Multi-layered stable middleware"
    }
  ],
  "CreatedDate": "2010-04-30T03:51:33.8178024+02:00",
  "UpdatedDate": "2007-04-13T03:51:33.8178024+02:00",
  "Description": "Streamlined value-added projection",
  "Postit": "tempora",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Public-key even-keeled portal",
  "ActiveStatusMonitorId": 519,
  "Links": [
    {
      "EntityName": "Gusikowski, Mertz and Erdman",
      "Id": 127,
      "Description": "Synergistic radical encoding",
      "ExtraInfo": "quis",
      "LinkId": 482
    },
    {
      "EntityName": "Gusikowski, Mertz and Erdman",
      "Id": 127,
      "Description": "Synergistic radical encoding",
      "ExtraInfo": "quis",
      "LinkId": 482
    }
  ],
  "ActiveLinks": 622,
  "Completed": false,
  "NextMilestoneDate": "1997-04-09T03:51:33.8178024+02:00",
  "NmdAppointmentId": 514,
  "EndDate": "2021-06-08T03:51:33.8178024+02:00",
  "ActiveErpLinks": 355,
  "UserDefinedFields": {
    "SuperOffice:1": "Trudie Dibbert",
    "SuperOffice:2": "1302462228"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "dolorem"
  },
  "PublishEventDate": "2006-06-24T03:51:33.8178024+02:00",
  "PublishTo": "1998-05-18T03:51:33.8178024+02:00",
  "PublishFrom": "1998-09-15T03:51:33.8178024+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 949,
  "Name": "Hayes-Leannon",
  "ProjectNumber": "1229855",
  "ProjectMembers": [
    {
      "ProjectmemberId": 926,
      "ContactId": 617,
      "ProjectId": 203,
      "ContactName": "Langworth-Fadel",
      "ContactDepartment": "",
      "ProjectName": "Ruecker Group",
      "EmailId": 905,
      "EmailAddress": "fabian@schiller.com",
      "CountryId": 949,
      "Firstname": "Stuart",
      "MiddleName": "Hermiston Inc and Sons",
      "Lastname": "Collins",
      "PersonId": 459,
      "Mrmrs": "debitis",
      "ProjectMemberTypeName": "Hauck-Leffler",
      "Phone": "925.079.8495 x523",
      "PhoneId": 806,
      "ProjectMemberTypeId": 941,
      "EmailAddressName": "tracey@brakus.uk",
      "Comment": "sequi",
      "FullName": "Julianne Price",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nesciunt",
      "StrippedValue": "sapiente",
      "Description": "Digitized heuristic attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "sapiente",
      "Description": "Digitized heuristic attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "CreatedDate": "2015-06-26T03:51:33.8178024+02:00",
  "UpdatedDate": "2016-10-30T03:51:33.8178024+01:00",
  "Description": "Ameliorated assymetric analyzer",
  "Postit": "aut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Configurable multi-state interface",
  "ActiveStatusMonitorId": 850,
  "Links": [
    {
      "EntityName": "Cruickshank, VonRueden and Kertzmann",
      "Id": 645,
      "Description": "Organic impactful approach",
      "ExtraInfo": "sit",
      "LinkId": 342,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    }
  ],
  "ActiveLinks": 846,
  "Completed": true,
  "NextMilestoneDate": "2007-08-01T03:51:33.8178024+02:00",
  "NmdAppointmentId": 192,
  "EndDate": "2017-06-05T03:51:33.8178024+02:00",
  "ActiveErpLinks": 693,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1649464950"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "error"
  },
  "PublishEventDate": "2000-05-12T03:51:33.8178024+02:00",
  "PublishTo": "2002-03-19T03:51:33.8178024+01:00",
  "PublishFrom": "2000-01-10T03:51:33.8178024+01:00",
  "IsPublished": false,
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