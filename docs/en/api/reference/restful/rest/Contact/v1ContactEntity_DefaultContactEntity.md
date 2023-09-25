---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 31 Jul 1996 03:24:51 G7T

{
  "ContactId": 373,
  "Name": "Pfeffer Inc and Sons",
  "Department": "",
  "OrgNr": "571889",
  "Number1": "1313457",
  "Number2": "1770493",
  "UpdatedDate": "1996-07-31T03:24:51.459286+02:00",
  "CreatedDate": "2002-09-22T03:24:51.459286+02:00",
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Reduced needs-based product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Reduced needs-based product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 862,
      "Name": "Bahringer-Hodkiewicz",
      "ToolTip": "Dolorem inventore dignissimos et.",
      "Deleted": true,
      "Rank": 760,
      "Type": "saepe",
      "ColorBlock": 275,
      "IconHint": "nisi",
      "Selected": true,
      "LastChanged": "2016-06-25T03:24:51.459286+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "illo",
      "Hidden": true,
      "FullName": "Colby Yundt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "alias",
      "Description": "Multi-tiered motivating interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 657
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "alias",
      "Description": "Multi-tiered motivating interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 657
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "voluptatum",
      "Description": "Compatible non-volatile database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "voluptatum",
      "Description": "Compatible non-volatile database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quaerat",
      "StrippedValue": "magni",
      "Description": "Pre-emptive client-server structure",
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
      "Value": "quaerat",
      "StrippedValue": "magni",
      "Description": "Pre-emptive client-server structure",
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
  "Description": "Programmable 6th generation benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellat",
      "PersonId": 624,
      "Mrmrs": "qui",
      "Firstname": "Laurence",
      "Lastname": "Crist",
      "MiddleName": "Hickle, Jacobs and Rippin",
      "Title": "voluptas",
      "Description": "Persistent heuristic framework",
      "Email": "reuben@spinka.com",
      "FullName": "Chesley Runolfsson",
      "DirectPhone": "024.453.3176 x324",
      "FormalName": "Wiegand Inc and Sons",
      "CountryId": 759,
      "ContactId": 23,
      "ContactName": "Hagenes Inc and Sons",
      "Retired": 441,
      "Rank": 980,
      "ActiveInterests": 498,
      "ContactDepartment": "whiteboard impactful niches",
      "ContactCountryId": 943,
      "ContactOrgNr": "1444712",
      "FaxPhone": "1-760-729-4217",
      "MobilePhone": "987.005.7673 x0877",
      "ContactPhone": "(912)138-6190 x1548",
      "AssociateName": "Leffler, Hane and Hahn",
      "AssociateId": 819,
      "UsePersonAddress": false,
      "ContactFax": "maiores",
      "Kanafname": "temporibus",
      "Kanalname": "minus",
      "Post1": "dolores",
      "Post2": "perferendis",
      "Post3": "numquam",
      "EmailName": "brayan.keebler@gorczanyreilly.name",
      "ContactFullName": "Julie Rutherford",
      "ActiveErpLinks": 754,
      "TicketPriorityId": 572,
      "SupportLanguageId": 951,
      "SupportAssociateId": 122,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": false,
  "ActiveInterests": 125,
  "GroupId": 218,
  "ActiveStatusMonitorId": 549,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 454,
  "DbiAgentId": 498,
  "DbiLastSyncronized": "2003-02-13T03:24:51.4743263+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2017-05-19T03:24:51.4743263+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 143,
  "ActiveErpLinks": 701,
  "BounceEmails": [
    "dorothy_wehner@romaguera.name",
    "alexys.klocko@schmidt.info"
  ],
  "Domains": [
    "aut",
    "ad"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Santino Darren Hessel DDS",
    "SuperOffice:2": "Tavares D'Amore"
  },
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "incidunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 488
    }
  }
}
```