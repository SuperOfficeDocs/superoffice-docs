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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 16 Aug 2004 12:15:26 G8T

{
  "ContactId": 252,
  "Name": "Altenwerth LLC",
  "Department": "",
  "OrgNr": "370157",
  "Number1": "1506739",
  "Number2": "790428",
  "UpdatedDate": "2004-08-16T12:15:26.5706414+02:00",
  "CreatedDate": "1999-09-01T12:15:26.5706414+02:00",
  "Emails": [
    {
      "Value": "voluptates",
      "StrippedValue": "magni",
      "Description": "Inverse didactic adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "magni",
      "Description": "Inverse didactic adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 795,
      "Name": "Christiansen-Lemke",
      "ToolTip": "Nulla magni eligendi vero dolorem consectetur voluptatem assumenda.",
      "Deleted": true,
      "Rank": 286,
      "Type": "delectus",
      "ColorBlock": 831,
      "IconHint": "expedita",
      "Selected": false,
      "LastChanged": "2004-03-07T12:15:26.5706414+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Mrs. Cristina Gusikowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "nemo",
      "Description": "Assimilated human-resource extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 482
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "nemo",
      "Description": "Assimilated human-resource extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 482
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Open-source neutral database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Open-source neutral database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "incidunt",
      "Description": "Proactive real-time algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "incidunt",
      "Description": "Proactive real-time algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    }
  ],
  "Description": "Phased holistic hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nobis",
      "PersonId": 606,
      "Mrmrs": "consectetur",
      "Firstname": "Loren",
      "Lastname": "Gutkowski",
      "MiddleName": "Gleason, McKenzie and Lueilwitz",
      "Title": "laudantium",
      "Description": "Object-based systemic artificial intelligence",
      "Email": "sarina@maggio.name",
      "FullName": "Breanne Aufderhar",
      "DirectPhone": "(904)439-9490 x506",
      "FormalName": "Yundt-McDermott",
      "CountryId": 533,
      "ContactId": 889,
      "ContactName": "Nicolas LLC",
      "Retired": 674,
      "Rank": 220,
      "ActiveInterests": 236,
      "ContactDepartment": "",
      "ContactCountryId": 84,
      "ContactOrgNr": "448943",
      "FaxPhone": "(247)896-4815",
      "MobilePhone": "521.626.3642 x469",
      "ContactPhone": "1-041-008-3042 x7873",
      "AssociateName": "Douglas, Upton and Feeney",
      "AssociateId": 248,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "quae",
      "Kanalname": "aut",
      "Post1": "quia",
      "Post2": "itaque",
      "Post3": "neque",
      "EmailName": "rachelle@barton.co.uk",
      "ContactFullName": "Devan Ortiz",
      "ActiveErpLinks": 956,
      "TicketPriorityId": 662,
      "SupportLanguageId": 223,
      "SupportAssociateId": 583,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolores",
  "Xstop": false,
  "ActiveInterests": 923,
  "GroupId": 249,
  "ActiveStatusMonitorId": 562,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 50,
  "DbiAgentId": 796,
  "DbiLastSyncronized": "2022-02-26T12:15:26.5756415+01:00",
  "DbiKey": "porro",
  "DbiLastModified": "2009-12-18T12:15:26.5756415+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 917,
  "ActiveErpLinks": 448,
  "BounceEmails": [
    "glenda@reichel.co.uk",
    "missouri@schulist.co.uk"
  ],
  "Domains": [
    "facere",
    "dicta"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1796563726",
    "SuperOffice:2": "Nathanael Kshlerin I"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 538
    }
  }
}
```