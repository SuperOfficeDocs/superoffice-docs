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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 11,
  "Name": "Dooley-O'Connell",
  "Department": "",
  "OrgNr": "1515209",
  "Number1": "1482990",
  "Number2": "326676",
  "UpdatedDate": "2024-02-01T13:13:22.3520297+01:00",
  "CreatedDate": "2022-02-25T13:13:22.3520297+01:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "alias",
      "Description": "Reduced actuating solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "alias",
      "Description": "Reduced actuating solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 329,
      "Name": "Graham, Kuhn and Hand",
      "ToolTip": "Molestiae laboriosam aperiam autem laborum vel consectetur.",
      "Deleted": false,
      "Rank": 52,
      "Type": "temporibus",
      "ColorBlock": 824,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2017-10-04T13:13:22.3520297+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ratione",
      "StyleHint": "nam",
      "Hidden": false,
      "FullName": "Carolyne Harvey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "assumenda",
      "StrippedValue": "assumenda",
      "Description": "Universal empowering service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 102
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "assumenda",
      "Description": "Universal empowering service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 102
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "earum",
      "StrippedValue": "deleniti",
      "Description": "Compatible solution-oriented ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "deleniti",
      "Description": "Compatible solution-oriented ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "minima",
      "Description": "Organic bandwidth-monitored capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "minima",
      "Description": "Organic bandwidth-monitored capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 920
        }
      }
    }
  ],
  "Description": "Networked multi-state internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "culpa",
      "PersonId": 266,
      "Mrmrs": "quo",
      "Firstname": "Fannie",
      "Lastname": "Mosciski",
      "MiddleName": "Lowe-Rohan",
      "Title": "exercitationem",
      "Description": "Diverse 6th generation model",
      "Email": "reta.goldner@hagenes.co.uk",
      "FullName": "Shany White I",
      "DirectPhone": "(301)860-3221 x2890",
      "FormalName": "Rice LLC",
      "CountryId": 245,
      "ContactId": 150,
      "ContactName": "Hilpert LLC",
      "Retired": 15,
      "Rank": 288,
      "ActiveInterests": 974,
      "ContactDepartment": "",
      "ContactCountryId": 297,
      "ContactOrgNr": "1026567",
      "FaxPhone": "894-661-3007 x756",
      "MobilePhone": "162-564-4062 x7070",
      "ContactPhone": "(432)686-7957",
      "AssociateName": "Gerlach, Gleason and Baumbach",
      "AssociateId": 835,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "et",
      "Kanalname": "autem",
      "Post1": "vel",
      "Post2": "omnis",
      "Post3": "incidunt",
      "EmailName": "candace.schuster@windlerlangworth.co.uk",
      "ContactFullName": "Mr. Blaise Heidenreich",
      "ActiveErpLinks": 546,
      "TicketPriorityId": 300,
      "SupportLanguageId": 665,
      "SupportAssociateId": 473,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sint",
  "Xstop": false,
  "ActiveInterests": 922,
  "GroupId": 832,
  "ActiveStatusMonitorId": 165,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 381,
  "DbiAgentId": 178,
  "DbiLastSyncronized": "2018-08-14T13:13:22.3520297+02:00",
  "DbiKey": "saepe",
  "DbiLastModified": "2006-03-07T13:13:22.3520297+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 660,
  "ActiveErpLinks": 703,
  "BounceEmails": [
    "anissa@padberg.name",
    "landen_krajcik@thiel.ca"
  ],
  "Domains": [
    "nulla",
    "quibusdam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Sven Carroll IV",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 865
    }
  }
}
```