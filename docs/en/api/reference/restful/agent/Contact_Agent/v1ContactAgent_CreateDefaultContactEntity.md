---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 977,
  "Name": "Lakin Group",
  "Department": "",
  "OrgNr": "475222",
  "Number1": "974902",
  "Number2": "1362744",
  "UpdatedDate": "2022-02-09T13:38:13.2802712+01:00",
  "CreatedDate": "2002-03-27T13:38:13.2802712+01:00",
  "Emails": [
    {
      "Value": "deleniti",
      "StrippedValue": "nihil",
      "Description": "Versatile asynchronous alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "nihil",
      "Description": "Versatile asynchronous alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 985,
      "Name": "Lubowitz Inc and Sons",
      "ToolTip": "Eveniet voluptatem totam.",
      "Deleted": false,
      "Rank": 713,
      "Type": "enim",
      "ColorBlock": 458,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "2018-12-01T13:38:13.2802712+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "deserunt",
      "Hidden": false,
      "FullName": "Marcos Ebert I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 180
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "voluptas",
      "Description": "Integrated asynchronous functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "voluptas",
      "Description": "Integrated asynchronous functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "a",
      "StrippedValue": "ut",
      "Description": "Object-based high-level groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "ut",
      "Description": "Object-based high-level groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "alias",
      "Description": "Open-architected dynamic projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "alias",
      "Description": "Open-architected dynamic projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "Description": "Up-sized coherent adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veritatis",
      "PersonId": 485,
      "Mrmrs": "voluptatibus",
      "Firstname": "Magali",
      "Lastname": "Pollich",
      "MiddleName": "Kessler LLC",
      "Title": "nihil",
      "Description": "Mandatory well-modulated concept",
      "Email": "ocie_dach@bartolettikulas.uk",
      "FullName": "Ms. Haven Judy Wiegand IV",
      "DirectPhone": "(907)797-4402 x3152",
      "FormalName": "Spinka, Ondricka and Denesik",
      "CountryId": 931,
      "ContactId": 735,
      "ContactName": "Simonis, Blick and Wolf",
      "Retired": 714,
      "Rank": 25,
      "ActiveInterests": 988,
      "ContactDepartment": "",
      "ContactCountryId": 597,
      "ContactOrgNr": "1131591",
      "FaxPhone": "722.949.5556 x895",
      "MobilePhone": "1-128-969-0738 x46257",
      "ContactPhone": "802.095.6451 x7982",
      "AssociateName": "Harvey, Bechtelar and Mohr",
      "AssociateId": 935,
      "UsePersonAddress": false,
      "ContactFax": "quas",
      "Kanafname": "nisi",
      "Kanalname": "est",
      "Post1": "voluptas",
      "Post2": "facilis",
      "Post3": "veritatis",
      "EmailName": "jabari_russel@pagac.ca",
      "ContactFullName": "Prof. Eusebio Jacobi IV",
      "ActiveErpLinks": 635,
      "TicketPriorityId": 592,
      "SupportLanguageId": 356,
      "SupportAssociateId": 431,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eaque",
  "Xstop": false,
  "ActiveInterests": 70,
  "GroupId": 525,
  "ActiveStatusMonitorId": 264,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 200,
  "DbiAgentId": 454,
  "DbiLastSyncronized": "2013-04-14T13:38:13.2802712+02:00",
  "DbiKey": "pariatur",
  "DbiLastModified": "2020-02-26T13:38:13.2802712+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 384,
  "ActiveErpLinks": 271,
  "BounceEmails": [
    "deanna_champlin@littlewiegand.info",
    "melody.mertz@shanahan.uk"
  ],
  "Domains": [
    "explicabo",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "561025933",
    "SuperOffice:2": "Keely Cartwright V"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "eos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 730
    }
  }
}
```