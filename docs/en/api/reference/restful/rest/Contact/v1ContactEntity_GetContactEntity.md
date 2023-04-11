---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
Last-Modified: Wed, 15 Aug 2007 15:29:29 G8T

{
  "ContactId": 714,
  "Name": "Feest LLC",
  "Department": "",
  "OrgNr": "602016",
  "Number1": "594682",
  "Number2": "661802",
  "UpdatedDate": "2007-08-15T15:29:29.5212021+02:00",
  "CreatedDate": "2020-09-01T15:29:29.5212021+02:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "consequatur",
      "Description": "Future-proofed secondary neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "consequatur",
      "Description": "Future-proofed secondary neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 58,
      "Name": "Schroeder-Cartwright",
      "ToolTip": "Dolore architecto impedit.",
      "Deleted": false,
      "Rank": 189,
      "Type": "blanditiis",
      "ColorBlock": 988,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "1998-01-20T15:29:29.5212021+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "inventore",
      "Hidden": false,
      "FullName": "Shania Bartell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 644
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Secured uniform hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Secured uniform hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "delectus",
      "StrippedValue": "cupiditate",
      "Description": "Horizontal transitional array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "cupiditate",
      "Description": "Horizontal transitional array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magni",
      "StrippedValue": "quae",
      "Description": "Business-focused non-volatile intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "quae",
      "Description": "Business-focused non-volatile intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "Description": "Multi-lateral holistic implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 309,
      "Mrmrs": "et",
      "Firstname": "Therese",
      "Lastname": "Schaefer",
      "MiddleName": "Schroeder, Rodriguez and Durgan",
      "Title": "sint",
      "Description": "Front-line 6th generation ability",
      "Email": "kendra_purdy@gerholdschuster.ca",
      "FullName": "Marjolaine Coby Kihn Sr.",
      "DirectPhone": "1-714-642-0667 x3975",
      "FormalName": "Bogisich Inc and Sons",
      "CountryId": 800,
      "ContactId": 939,
      "ContactName": "Hauck Inc and Sons",
      "Retired": 511,
      "Rank": 571,
      "ActiveInterests": 838,
      "ContactDepartment": "",
      "ContactCountryId": 943,
      "ContactOrgNr": "886807",
      "FaxPhone": "702-932-9068 x50291",
      "MobilePhone": "278.298.0343 x2601",
      "ContactPhone": "(032)588-3307",
      "AssociateName": "Gulgowski-West",
      "AssociateId": 398,
      "UsePersonAddress": true,
      "ContactFax": "voluptas",
      "Kanafname": "ut",
      "Kanalname": "occaecati",
      "Post1": "labore",
      "Post2": "nulla",
      "Post3": "non",
      "EmailName": "hilton@padberg.info",
      "ContactFullName": "Jude Smitham",
      "ActiveErpLinks": 570,
      "TicketPriorityId": 159,
      "SupportLanguageId": 268,
      "SupportAssociateId": 961,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "id",
  "Xstop": false,
  "ActiveInterests": 628,
  "GroupId": 736,
  "ActiveStatusMonitorId": 120,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 131,
  "DbiAgentId": 745,
  "DbiLastSyncronized": "2011-07-04T15:29:29.5257018+02:00",
  "DbiKey": "nostrum",
  "DbiLastModified": "1995-11-23T15:29:29.5257018+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 802,
  "ActiveErpLinks": 573,
  "BounceEmails": [
    "frank.roberts@hickle.co.uk",
    "maeve.boehm@swift.us"
  ],
  "Domains": [
    "maxime",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Tyree Rutherford",
    "SuperOffice:2": "1446605281"
  },
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 75
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```