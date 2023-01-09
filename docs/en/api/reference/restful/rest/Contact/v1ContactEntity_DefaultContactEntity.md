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
Last-Modified: Fri, 25 Jun 2010 17:37:38 G6T

{
  "ContactId": 148,
  "Name": "Howe-Bode",
  "Department": "",
  "OrgNr": "854593",
  "Number1": "1200767",
  "Number2": "936787",
  "UpdatedDate": "2010-06-25T17:37:38.3528329+02:00",
  "CreatedDate": "2022-08-28T17:37:38.3528329+02:00",
  "Emails": [
    {
      "Value": "praesentium",
      "StrippedValue": "in",
      "Description": "Enterprise-wide dynamic approach",
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
      "Value": "praesentium",
      "StrippedValue": "in",
      "Description": "Enterprise-wide dynamic approach",
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
      "Id": 515,
      "Name": "Balistreri-Rempel",
      "ToolTip": "Sequi accusantium enim minima veritatis enim libero voluptas.",
      "Deleted": true,
      "Rank": 2,
      "Type": "eaque",
      "ColorBlock": 229,
      "IconHint": "praesentium",
      "Selected": false,
      "LastChanged": "2001-11-22T17:37:38.3548331+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Margret Pacocha",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "labore",
      "StrippedValue": "dolor",
      "Description": "Business-focused multi-tasking standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "dolor",
      "Description": "Business-focused multi-tasking standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "ex",
      "Description": "Phased stable contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "ex",
      "Description": "Phased stable contingency",
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
  "Faxes": [
    {
      "Value": "accusamus",
      "StrippedValue": "laborum",
      "Description": "Multi-layered secondary methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 263
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "laborum",
      "Description": "Multi-layered secondary methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 263
        }
      }
    }
  ],
  "Description": "Horizontal analyzing instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aliquam",
      "PersonId": 380,
      "Mrmrs": "nihil",
      "Firstname": "Rhianna",
      "Lastname": "Roberts",
      "MiddleName": "Berge Group",
      "Title": "est",
      "Description": "Extended directional product",
      "Email": "nichole@conn.com",
      "FullName": "Bud Amina Hilpert DVM",
      "DirectPhone": "749.617.0972 x96656",
      "FormalName": "Hudson, Koepp and Mayer",
      "CountryId": 716,
      "ContactId": 473,
      "ContactName": "Wolf, Lesch and Nicolas",
      "Retired": 235,
      "Rank": 438,
      "ActiveInterests": 590,
      "ContactDepartment": "",
      "ContactCountryId": 301,
      "ContactOrgNr": "1145389",
      "FaxPhone": "359-006-9941 x6862",
      "MobilePhone": "1-770-501-8267 x66299",
      "ContactPhone": "651-222-3953 x068",
      "AssociateName": "Sanford LLC",
      "AssociateId": 475,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "nihil",
      "Kanalname": "non",
      "Post1": "est",
      "Post2": "quia",
      "Post3": "sint",
      "EmailName": "cassie.nikolaus@stehr.biz",
      "ContactFullName": "Mrs. Laverna Kiehn II",
      "ActiveErpLinks": 554,
      "TicketPriorityId": 794,
      "SupportLanguageId": 181,
      "SupportAssociateId": 895,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dolores",
  "Xstop": true,
  "ActiveInterests": 822,
  "GroupId": 210,
  "ActiveStatusMonitorId": 990,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 779,
  "DbiAgentId": 667,
  "DbiLastSyncronized": "2007-06-25T17:37:38.3588324+02:00",
  "DbiKey": "voluptas",
  "DbiLastModified": "2009-08-24T17:37:38.3588324+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 100,
  "ActiveErpLinks": 33,
  "BounceEmails": [
    "michael@prosaccoterry.ca",
    "brain.walker@mosciskiferry.name"
  ],
  "Domains": [
    "vitae",
    "nobis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dave Graham",
    "SuperOffice:2": "2040369287"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 570
    }
  }
}
```