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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 02 Aug 2024 13:14:08 G8T

{
  "ContactId": 625,
  "Name": "Orn-Hintz",
  "Department": "",
  "OrgNr": "194416",
  "Number1": "989775",
  "Number2": "885086",
  "UpdatedDate": "2024-08-02T13:14:08.5397442+02:00",
  "CreatedDate": "2000-05-31T13:14:08.5397442+02:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "nam",
      "Description": "Grass-roots directional alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "nam",
      "Description": "Grass-roots directional alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 627,
      "Name": "Lehner, Kling and Gottlieb",
      "ToolTip": "Expedita autem excepturi sed qui.",
      "Deleted": false,
      "Rank": 29,
      "Type": "dicta",
      "ColorBlock": 333,
      "IconHint": "similique",
      "Selected": false,
      "LastChanged": "2024-09-26T13:14:08.5397442+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "minus",
      "Hidden": false,
      "FullName": "Janick Howell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 413
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "in",
      "Description": "Synergized even-keeled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "in",
      "Description": "Synergized even-keeled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "incidunt",
      "StrippedValue": "possimus",
      "Description": "Exclusive bottom-line collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 555
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "possimus",
      "Description": "Exclusive bottom-line collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 555
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nostrum",
      "StrippedValue": "sapiente",
      "Description": "Assimilated high-level benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 346
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "sapiente",
      "Description": "Assimilated high-level benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 346
        }
      }
    }
  ],
  "Description": "Profit-focused secondary installation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veniam",
      "PersonId": 861,
      "Mrmrs": "ut",
      "Firstname": "Tamara",
      "Lastname": "Collins",
      "MiddleName": "Reichel-Corwin",
      "Title": "id",
      "Description": "Secured non-volatile artificial intelligence",
      "Email": "columbus@dickinson.us",
      "FullName": "Della Simonis",
      "DirectPhone": "723.013.2822 x9217",
      "FormalName": "Thompson-Kuhn",
      "CountryId": 791,
      "ContactId": 664,
      "ContactName": "Lubowitz-Durgan",
      "Retired": 840,
      "Rank": 633,
      "ActiveInterests": 87,
      "ContactDepartment": "",
      "ContactCountryId": 481,
      "ContactOrgNr": "1792175",
      "FaxPhone": "633-724-4188",
      "MobilePhone": "1-999-021-2709",
      "ContactPhone": "756.772.5226 x5507",
      "AssociateName": "Grimes-Price",
      "AssociateId": 74,
      "UsePersonAddress": false,
      "ContactFax": "aliquam",
      "Kanafname": "omnis",
      "Kanalname": "autem",
      "Post1": "eaque",
      "Post2": "reprehenderit",
      "Post3": "laboriosam",
      "EmailName": "johnson_ortiz@sawayngreenholt.uk",
      "ContactFullName": "Jett Ernser",
      "ActiveErpLinks": 365,
      "TicketPriorityId": 7,
      "SupportLanguageId": 551,
      "SupportAssociateId": 647,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1126068",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 439
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "eaque",
  "Xstop": true,
  "ActiveInterests": 523,
  "GroupId": 320,
  "ActiveStatusMonitorId": 843,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 452,
  "DbiAgentId": 977,
  "DbiLastSyncronized": "2008-08-22T13:14:08.5397442+02:00",
  "DbiKey": "deserunt",
  "DbiLastModified": "2019-04-14T13:14:08.5397442+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 298,
  "ActiveErpLinks": 605,
  "BounceEmails": [
    "daphne.casper@runolfsdottirwintheiser.us",
    "flossie@mohrlebsack.uk"
  ],
  "Domains": [
    "cumque",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "143233134",
    "SuperOffice:2": "Sabrina Hartmann"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "voluptate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 208
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```