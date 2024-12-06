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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 27 Mar 2001 10:18:00 G3T

{
  "ContactId": 982,
  "Name": "Koelpin, Morissette and Spencer",
  "Department": "",
  "OrgNr": "1346211",
  "Number1": "722187",
  "Number2": "1023029",
  "UpdatedDate": "2001-03-27T10:18:00.2855716+02:00",
  "CreatedDate": "2015-07-20T10:18:00.2855716+02:00",
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "cupiditate",
      "Description": "Proactive cohesive internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "cupiditate",
      "Description": "Proactive cohesive internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 842,
      "Name": "Monahan-Blanda",
      "ToolTip": "Autem et tempore assumenda mollitia iusto.",
      "Deleted": true,
      "Rank": 453,
      "Type": "dignissimos",
      "ColorBlock": 875,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "1998-01-24T10:18:00.2855716+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "voluptate",
      "Hidden": true,
      "FullName": "Rafael Bednar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 112
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "voluptates",
      "Description": "Automated human-resource portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "voluptates",
      "Description": "Automated human-resource portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cumque",
      "StrippedValue": "ut",
      "Description": "Enterprise-wide full-range customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "ut",
      "Description": "Enterprise-wide full-range customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "cum",
      "Description": "Enhanced demand-driven utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "cum",
      "Description": "Enhanced demand-driven utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "Description": "Synergized stable challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "corporis",
      "PersonId": 372,
      "Mrmrs": "aut",
      "Firstname": "Elyssa",
      "Lastname": "Schneider",
      "MiddleName": "Schulist, Roob and Hauck",
      "Title": "id",
      "Description": "Focused scalable standardization",
      "Email": "rebeca_considine@cronin.us",
      "FullName": "Mrs. Leopoldo Colt Powlowski",
      "DirectPhone": "820.942.3352 x093",
      "FormalName": "Beer, Wolf and Muller",
      "CountryId": 931,
      "ContactId": 321,
      "ContactName": "VonRueden-Wilderman",
      "Retired": 481,
      "Rank": 747,
      "ActiveInterests": 422,
      "ContactDepartment": "",
      "ContactCountryId": 915,
      "ContactOrgNr": "1042231",
      "FaxPhone": "(462)035-4771",
      "MobilePhone": "(182)259-8931",
      "ContactPhone": "322.168.0167",
      "AssociateName": "Littel Inc and Sons",
      "AssociateId": 677,
      "UsePersonAddress": true,
      "ContactFax": "eveniet",
      "Kanafname": "accusamus",
      "Kanalname": "vero",
      "Post1": "modi",
      "Post2": "quibusdam",
      "Post3": "nam",
      "EmailName": "eloise_bruen@hudson.biz",
      "ContactFullName": "Dr. Nona Fabian Stamm II",
      "ActiveErpLinks": 783,
      "TicketPriorityId": 89,
      "SupportLanguageId": 52,
      "SupportAssociateId": 812,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "non",
  "Xstop": true,
  "ActiveInterests": 665,
  "GroupId": 449,
  "ActiveStatusMonitorId": 118,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 971,
  "DbiAgentId": 924,
  "DbiLastSyncronized": "2017-12-18T10:18:00.2855716+01:00",
  "DbiKey": "aperiam",
  "DbiLastModified": "2009-02-24T10:18:00.2855716+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 20,
  "ActiveErpLinks": 20,
  "BounceEmails": [
    "jayce.olson@binsmarvin.uk",
    "keven@quigley.co.uk"
  ],
  "Domains": [
    "quisquam",
    "labore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Reggie Billy Hartmann",
    "SuperOffice:2": "580857159"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "amet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 632
    }
  }
}
```