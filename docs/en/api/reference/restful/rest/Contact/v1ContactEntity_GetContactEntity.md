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
GET /api/v1/Contact/{id}?fk=False
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 19 Jul 2021 10:30:31 G7T

{
  "ContactId": 996,
  "Name": "Sporer Group",
  "Department": "",
  "OrgNr": "90073",
  "Number1": "1034740",
  "Number2": "722497",
  "UpdatedDate": "2021-07-19T10:30:31.8855621+02:00",
  "CreatedDate": "2018-10-25T10:30:31.8855621+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "expedita",
      "Description": "Fundamental multi-tasking approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "expedita",
      "Description": "Fundamental multi-tasking approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 249,
      "Name": "Klein Group",
      "ToolTip": "Hic eaque commodi doloribus enim nemo non.",
      "Deleted": true,
      "Rank": 672,
      "Type": "laborum",
      "ColorBlock": 285,
      "IconHint": "cupiditate",
      "Selected": true,
      "LastChanged": "2012-05-26T10:30:31.8855621+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "ea",
      "Hidden": false,
      "FullName": "Mrs. Dustin Gusikowski III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "exercitationem",
      "Description": "Open-source local knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 620
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "exercitationem",
      "Description": "Open-source local knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 620
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "ducimus",
      "Description": "Horizontal local capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ducimus",
      "Description": "Horizontal local capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "dolorem",
      "Description": "Mandatory human-resource definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "dolorem",
      "Description": "Mandatory human-resource definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "Description": "Networked incremental implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "labore",
      "PersonId": 929,
      "Mrmrs": "nobis",
      "Firstname": "Daren",
      "Lastname": "Hahn",
      "MiddleName": "Aufderhar Group",
      "Title": "nostrum",
      "Description": "Proactive client-driven contingency",
      "Email": "elias@fahey.uk",
      "FullName": "Chandler Abshire MD",
      "DirectPhone": "(015)881-9603",
      "FormalName": "Kemmer Inc and Sons",
      "CountryId": 183,
      "ContactId": 800,
      "ContactName": "Hegmann LLC",
      "Retired": 734,
      "Rank": 457,
      "ActiveInterests": 115,
      "ContactDepartment": "",
      "ContactCountryId": 221,
      "ContactOrgNr": "1208811",
      "FaxPhone": "1-812-208-0164",
      "MobilePhone": "1-005-351-2755 x7398",
      "ContactPhone": "1-601-083-5227",
      "AssociateName": "Sauer-Kovacek",
      "AssociateId": 570,
      "UsePersonAddress": true,
      "ContactFax": "magnam",
      "Kanafname": "similique",
      "Kanalname": "autem",
      "Post1": "voluptatem",
      "Post2": "dolores",
      "Post3": "quis",
      "EmailName": "milan@friesenconroy.name",
      "ContactFullName": "Elias Gerhold Sr.",
      "ActiveErpLinks": 584,
      "TicketPriorityId": 499,
      "SupportLanguageId": 57,
      "SupportAssociateId": 515,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "in",
  "Xstop": true,
  "ActiveInterests": 82,
  "GroupId": 532,
  "ActiveStatusMonitorId": 550,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 903,
  "DbiAgentId": 653,
  "DbiLastSyncronized": "1998-10-06T10:30:31.8855621+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2021-07-24T10:30:31.8855621+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 288,
  "ActiveErpLinks": 788,
  "BounceEmails": [
    "ethelyn@jacobs.uk",
    "rowan@abernathylehner.name"
  ],
  "Domains": [
    "voluptas",
    "itaque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1047989735",
    "SuperOffice:2": "Daisy Willis Gottlieb Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "cupiditate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 661
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```