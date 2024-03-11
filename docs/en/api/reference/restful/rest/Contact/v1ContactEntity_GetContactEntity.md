---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 02 May 2016 14:23:54 G5T

{
  "ContactId": 365,
  "Name": "Kirlin LLC",
  "Department": "",
  "OrgNr": "1100473",
  "Number1": "922911",
  "Number2": "956843",
  "UpdatedDate": "2016-05-02T14:23:54.9602774+02:00",
  "CreatedDate": "2020-07-31T14:23:54.9602774+02:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "necessitatibus",
      "Description": "Face to face demand-driven task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 303
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "necessitatibus",
      "Description": "Face to face demand-driven task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 303
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 347,
      "Name": "Littel Inc and Sons",
      "ToolTip": "Odit recusandae necessitatibus sit facere quae.",
      "Deleted": true,
      "Rank": 285,
      "Type": "et",
      "ColorBlock": 530,
      "IconHint": "ipsa",
      "Selected": true,
      "LastChanged": "2021-09-22T14:23:54.9602774+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "suscipit",
      "Hidden": false,
      "FullName": "Norberto Frami",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "quia",
      "Description": "Configurable reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "quia",
      "Description": "Configurable reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolore",
      "StrippedValue": "ipsa",
      "Description": "Public-key empowering circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "ipsa",
      "Description": "Public-key empowering circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "facilis",
      "Description": "Multi-channelled content-based protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "facilis",
      "Description": "Multi-channelled content-based protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "Description": "Multi-lateral encompassing array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "maxime",
      "PersonId": 571,
      "Mrmrs": "qui",
      "Firstname": "Rashad",
      "Lastname": "Kovacek",
      "MiddleName": "Walsh Inc and Sons",
      "Title": "enim",
      "Description": "Realigned solution-oriented internet solution",
      "Email": "brennan.padberg@ryan.name",
      "FullName": "Mr. Kiarra Tevin Kunde",
      "DirectPhone": "016-677-1864",
      "FormalName": "Bosco LLC",
      "CountryId": 8,
      "ContactId": 232,
      "ContactName": "Herman, Bins and Bins",
      "Retired": 440,
      "Rank": 65,
      "ActiveInterests": 572,
      "ContactDepartment": "",
      "ContactCountryId": 931,
      "ContactOrgNr": "608853",
      "FaxPhone": "079-622-1389 x5154",
      "MobilePhone": "576.250.0519 x518",
      "ContactPhone": "412-098-2082",
      "AssociateName": "Bashirian, Beier and Balistreri",
      "AssociateId": 782,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "assumenda",
      "Kanalname": "velit",
      "Post1": "fugit",
      "Post2": "totam",
      "Post3": "et",
      "EmailName": "riley_wolf@bosco.info",
      "ContactFullName": "Shemar Spencer Hansen II",
      "ActiveErpLinks": 222,
      "TicketPriorityId": 32,
      "SupportLanguageId": 536,
      "SupportAssociateId": 19,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nihil",
  "Xstop": false,
  "ActiveInterests": 440,
  "GroupId": 346,
  "ActiveStatusMonitorId": 973,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 605,
  "DbiAgentId": 38,
  "DbiLastSyncronized": "1999-01-11T14:23:54.9602774+01:00",
  "DbiKey": "magnam",
  "DbiLastModified": "2014-04-01T14:23:54.9602774+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 875,
  "ActiveErpLinks": 186,
  "BounceEmails": [
    "coy@lynch.biz",
    "berry@volkman.com"
  ],
  "Domains": [
    "quod",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Davin Willms",
    "SuperOffice:2": "Ms. Helmer Cierra Robel V"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 713
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```