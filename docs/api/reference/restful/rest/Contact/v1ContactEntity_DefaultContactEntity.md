---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 26 Aug 2019 02:49:50 G8T

{
  "ContactId": 596,
  "Name": "Aufderhar LLC",
  "Department": "",
  "OrgNr": "866851",
  "Number1": "1667456",
  "Number2": "411971",
  "UpdatedDate": "2019-08-26T02:49:50.7296616+02:00",
  "CreatedDate": "2007-07-15T02:49:50.7296616+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "ut",
      "Description": "Distributed uniform algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 659
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ut",
      "Description": "Distributed uniform algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 659
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 367,
      "Name": "Wiza-Kulas",
      "ToolTip": "Quasi magnam quaerat similique.",
      "Deleted": false,
      "Rank": 829,
      "Type": "ullam",
      "ColorBlock": 171,
      "IconHint": "veniam",
      "Selected": true,
      "LastChanged": "2012-09-20T02:49:50.7296616+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nulla",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Duane Hermiston",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "illum",
      "StrippedValue": "quis",
      "Description": "Cross-group stable toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "quis",
      "Description": "Cross-group stable toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Self-enabling system-worthy core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Self-enabling system-worthy core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "excepturi",
      "StrippedValue": "nemo",
      "Description": "Team-oriented responsive portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "nemo",
      "Description": "Team-oriented responsive portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    }
  ],
  "Description": "Customer-focused maximized knowledge base",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloremque",
      "PersonId": 745,
      "Mrmrs": "labore",
      "Firstname": "Aglae",
      "Lastname": "Crona",
      "MiddleName": "Goyette Inc and Sons",
      "Title": "quia",
      "Description": "Optional stable adapter",
      "Email": "kristofer@schamberger.uk",
      "FullName": "Ike Kessler I",
      "DirectPhone": "452-063-0926 x538",
      "FormalName": "Goyette-Torp",
      "CountryId": 538,
      "ContactId": 745,
      "ContactName": "Walker Group",
      "Retired": 941,
      "Rank": 641,
      "ActiveInterests": 190,
      "ContactDepartment": "",
      "ContactCountryId": 558,
      "ContactOrgNr": "1129559",
      "FaxPhone": "005.840.7128 x52281",
      "MobilePhone": "(303)203-2365 x3332",
      "ContactPhone": "885-744-4407 x1790",
      "AssociateName": "Weber LLC",
      "AssociateId": 353,
      "UsePersonAddress": false,
      "ContactFax": "magnam",
      "Kanafname": "recusandae",
      "Kanalname": "non",
      "Post1": "neque",
      "Post2": "omnis",
      "Post3": "facere",
      "EmailName": "allene@jastchamplin.biz",
      "ContactFullName": "Maynard Legros",
      "ActiveErpLinks": 19,
      "TicketPriorityId": 423,
      "SupportLanguageId": 140,
      "SupportAssociateId": 568,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 141
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "commodi",
  "Xstop": false,
  "ActiveInterests": 121,
  "GroupId": 887,
  "ActiveStatusMonitorId": 333,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 501,
  "DbiAgentId": 872,
  "DbiLastSyncronized": "1997-12-09T02:49:50.7452861+01:00",
  "DbiKey": "aliquid",
  "DbiLastModified": "2010-04-04T02:49:50.7452861+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 114,
  "ActiveErpLinks": 239,
  "BounceEmails": [
    "greta@hansenschmeler.ca",
    "felipe_feil@schulist.biz"
  ],
  "Domains": [
    "aut",
    "rem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1333786251",
    "SuperOffice:2": "Savanah Heathcote"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "accusantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 687
    }
  }
}
```