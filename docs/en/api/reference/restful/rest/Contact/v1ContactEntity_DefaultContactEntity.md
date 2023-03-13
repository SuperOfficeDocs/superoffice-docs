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

### Response body: ContactEntity

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 02 Apr 2005 14:19:10 G4T

{
  "ContactId": 543,
  "Name": "Cummings-Stoltenberg",
  "Department": "",
  "OrgNr": "650694",
  "Number1": "1456791",
  "Number2": "1266037",
  "UpdatedDate": "2005-04-02T14:19:10.1310974+02:00",
  "CreatedDate": "2003-07-25T14:19:10.1310974+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "est",
      "Description": "Business-focused non-volatile archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 141
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "est",
      "Description": "Business-focused non-volatile archive",
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
  "Interests": [
    {
      "Id": 391,
      "Name": "Towne Inc and Sons",
      "ToolTip": "Esse adipisci neque architecto sed.",
      "Deleted": false,
      "Rank": 543,
      "Type": "est",
      "ColorBlock": 541,
      "IconHint": "error",
      "Selected": true,
      "LastChanged": "2016-10-29T14:19:10.1310974+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempora",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Jackson Floyd Kiehn III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "odio",
      "Description": "Balanced tangible internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "odio",
      "Description": "Balanced tangible internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "mollitia",
      "Description": "Operative transitional database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "mollitia",
      "Description": "Operative transitional database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "error",
      "Description": "Reverse-engineered multimedia matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "error",
      "Description": "Reverse-engineered multimedia matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Description": "Persistent foreground superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "est",
      "PersonId": 43,
      "Mrmrs": "accusamus",
      "Firstname": "Chanel",
      "Lastname": "Jacobs",
      "MiddleName": "Ledner Group",
      "Title": "qui",
      "Description": "Phased secondary approach",
      "Email": "johanna@lednerrohan.com",
      "FullName": "Lucinda Lowe",
      "DirectPhone": "(554)976-3355 x9156",
      "FormalName": "Simonis-Schowalter",
      "CountryId": 908,
      "ContactId": 17,
      "ContactName": "Howe, Metz and Orn",
      "Retired": 974,
      "Rank": 518,
      "ActiveInterests": 413,
      "ContactDepartment": "",
      "ContactCountryId": 194,
      "ContactOrgNr": "1224040",
      "FaxPhone": "860-383-9092 x50724",
      "MobilePhone": "032-659-9167 x0277",
      "ContactPhone": "837.808.6729 x56532",
      "AssociateName": "Runolfsdottir-Haag",
      "AssociateId": 354,
      "UsePersonAddress": true,
      "ContactFax": "enim",
      "Kanafname": "repellendus",
      "Kanalname": "expedita",
      "Post1": "nemo",
      "Post2": "totam",
      "Post3": "minus",
      "EmailName": "zella_davis@herzog.co.uk",
      "ContactFullName": "Mrs. Catherine Crist III",
      "ActiveErpLinks": 155,
      "TicketPriorityId": 902,
      "SupportLanguageId": 76,
      "SupportAssociateId": 568,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "debitis",
  "Xstop": true,
  "ActiveInterests": 820,
  "GroupId": 249,
  "ActiveStatusMonitorId": 537,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 991,
  "DbiAgentId": 87,
  "DbiLastSyncronized": "2016-12-01T14:19:10.1467247+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2020-04-15T14:19:10.1467247+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 638,
  "ActiveErpLinks": 365,
  "BounceEmails": [
    "gonzalo.considine@kihn.name",
    "penelope.stoltenberg@dach.uk"
  ],
  "Domains": [
    "qui",
    "ea"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Celestine Hintz DVM",
    "SuperOffice:2": "Ramon Mayert"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 656
    }
  }
}
```