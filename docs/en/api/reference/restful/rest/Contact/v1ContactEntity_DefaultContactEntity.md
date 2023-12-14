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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 11 Jan 2013 13:57:18 G1T

{
  "ContactId": 713,
  "Name": "Pagac-Bahringer",
  "Department": "",
  "OrgNr": "739638",
  "Number1": "1168984",
  "Number2": "1214346",
  "UpdatedDate": "2013-01-11T13:57:18.5753123+01:00",
  "CreatedDate": "1999-12-15T13:57:18.5753123+01:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "sint",
      "Description": "Operative mission-critical synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "sint",
      "Description": "Operative mission-critical synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 999,
      "Name": "Graham-Zulauf",
      "ToolTip": "Cumque aspernatur veritatis quis dolore accusamus omnis.",
      "Deleted": false,
      "Rank": 969,
      "Type": "id",
      "ColorBlock": 933,
      "IconHint": "at",
      "Selected": true,
      "LastChanged": "2006-05-01T13:57:18.5753123+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "nisi",
      "Hidden": false,
      "FullName": "Jerald Rohan",
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
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "consequatur",
      "Description": "User-friendly empowering frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "consequatur",
      "Description": "User-friendly empowering frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptas",
      "StrippedValue": "excepturi",
      "Description": "Fully-configurable user-facing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "excepturi",
      "Description": "Fully-configurable user-facing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "occaecati",
      "StrippedValue": "esse",
      "Description": "Multi-tiered fresh-thinking strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "esse",
      "Description": "Multi-tiered fresh-thinking strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    }
  ],
  "Description": "De-engineered bifurcated hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nihil",
      "PersonId": 70,
      "Mrmrs": "vero",
      "Firstname": "Gregory",
      "Lastname": "Bernier",
      "MiddleName": "Dooley, Kemmer and Friesen",
      "Title": "consequatur",
      "Description": "Cross-platform bifurcated implementation",
      "Email": "lonzo.abernathy@kulas.uk",
      "FullName": "Santino Rutherford",
      "DirectPhone": "(559)724-1183",
      "FormalName": "Cummerata, Rolfson and Langosh",
      "CountryId": 33,
      "ContactId": 493,
      "ContactName": "Lehner, Keeling and Ullrich",
      "Retired": 94,
      "Rank": 551,
      "ActiveInterests": 142,
      "ContactDepartment": "orchestrate user-centric schemas",
      "ContactCountryId": 557,
      "ContactOrgNr": "1007615",
      "FaxPhone": "114.341.1279 x89092",
      "MobilePhone": "1-227-709-4647",
      "ContactPhone": "562-084-9174",
      "AssociateName": "Hackett-Wisozk",
      "AssociateId": 911,
      "UsePersonAddress": false,
      "ContactFax": "perspiciatis",
      "Kanafname": "incidunt",
      "Kanalname": "id",
      "Post1": "debitis",
      "Post2": "veniam",
      "Post3": "adipisci",
      "EmailName": "alfredo.hettinger@feest.biz",
      "ContactFullName": "Mr. Toby Quigley III",
      "ActiveErpLinks": 285,
      "TicketPriorityId": 761,
      "SupportLanguageId": 250,
      "SupportAssociateId": 766,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "provident",
  "Xstop": true,
  "ActiveInterests": 639,
  "GroupId": 301,
  "ActiveStatusMonitorId": 692,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 792,
  "DbiAgentId": 181,
  "DbiLastSyncronized": "2006-05-06T13:57:18.5753123+02:00",
  "DbiKey": "praesentium",
  "DbiLastModified": "1998-02-04T13:57:18.5753123+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 503,
  "ActiveErpLinks": 209,
  "BounceEmails": [
    "dejah.schiller@friesenosinski.name",
    "simone.stehr@lesch.uk"
  ],
  "Domains": [
    "hic",
    "nemo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Ellis O'Reilly",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "maiores",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "quisquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 790
    }
  }
}
```