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
Last-Modified: Mon, 29 May 2000 14:23:54 G5T

{
  "ContactId": 205,
  "Name": "Dach, Legros and Reichel",
  "Department": "",
  "OrgNr": "759423",
  "Number1": "548337",
  "Number2": "1449136",
  "UpdatedDate": "2000-05-29T14:23:54.9290273+02:00",
  "CreatedDate": "2011-09-30T14:23:54.9290273+02:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "impedit",
      "Description": "Stand-alone demand-driven artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 113
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "impedit",
      "Description": "Stand-alone demand-driven artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 113
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 232,
      "Name": "DuBuque Inc and Sons",
      "ToolTip": "Dignissimos nesciunt incidunt.",
      "Deleted": false,
      "Rank": 720,
      "Type": "natus",
      "ColorBlock": 562,
      "IconHint": "alias",
      "Selected": true,
      "LastChanged": "2009-04-04T14:23:54.9290273+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "libero",
      "Hidden": false,
      "FullName": "Sister Sipes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 608
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "voluptatum",
      "Description": "Enhanced client-driven Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptatum",
      "Description": "Enhanced client-driven Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vero",
      "StrippedValue": "tenetur",
      "Description": "Exclusive analyzing encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "tenetur",
      "Description": "Exclusive analyzing encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "quae",
      "Description": "Polarised cohesive algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "quae",
      "Description": "Polarised cohesive algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    }
  ],
  "Description": "Polarised background leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "deserunt",
      "PersonId": 189,
      "Mrmrs": "aut",
      "Firstname": "Theo",
      "Lastname": "Welch",
      "MiddleName": "Jacobi LLC",
      "Title": "sapiente",
      "Description": "Configurable content-based emulation",
      "Email": "sally@morissette.name",
      "FullName": "Lulu Osinski",
      "DirectPhone": "(772)882-4516",
      "FormalName": "Fahey, Sporer and Quigley",
      "CountryId": 182,
      "ContactId": 686,
      "ContactName": "Fadel, Moore and McClure",
      "Retired": 397,
      "Rank": 991,
      "ActiveInterests": 572,
      "ContactDepartment": "",
      "ContactCountryId": 99,
      "ContactOrgNr": "897837",
      "FaxPhone": "091.234.2985 x85802",
      "MobilePhone": "618.019.7476 x608",
      "ContactPhone": "1-342-774-9100",
      "AssociateName": "Daniel-Schmidt",
      "AssociateId": 305,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "voluptatem",
      "Kanalname": "dolores",
      "Post1": "ex",
      "Post2": "ea",
      "Post3": "aspernatur",
      "EmailName": "hans@hicklehudson.us",
      "ContactFullName": "Prof. Minerva Nickolas Wilderman",
      "ActiveErpLinks": 341,
      "TicketPriorityId": 389,
      "SupportLanguageId": 48,
      "SupportAssociateId": 605,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 794
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "veritatis",
  "Xstop": false,
  "ActiveInterests": 100,
  "GroupId": 699,
  "ActiveStatusMonitorId": 787,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 487,
  "DbiAgentId": 227,
  "DbiLastSyncronized": "2011-11-03T14:23:54.9446537+01:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2000-03-07T14:23:54.9446537+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 688,
  "ActiveErpLinks": 7,
  "BounceEmails": [
    "chris_kuhn@mckenzie.us",
    "aidan@dietrichmayer.co.uk"
  ],
  "Domains": [
    "fuga",
    "enim"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dorthy Quincy Harris PhD",
    "SuperOffice:2": "396508118"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "optio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 41
    }
  }
}
```