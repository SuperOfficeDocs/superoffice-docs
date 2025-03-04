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
Last-Modified: Sat, 26 Nov 2011 14:13:48 G11T

{
  "ContactId": 292,
  "Name": "Bashirian-Towne",
  "Department": "",
  "OrgNr": "940788",
  "Number1": "546619",
  "Number2": "1841773",
  "UpdatedDate": "2011-11-26T14:13:48.4914217+01:00",
  "CreatedDate": "2009-11-11T14:13:48.4914217+01:00",
  "Emails": [
    {
      "Value": "culpa",
      "StrippedValue": "debitis",
      "Description": "User-centric multi-tasking encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "debitis",
      "Description": "User-centric multi-tasking encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 622,
      "Name": "Hodkiewicz, Adams and Upton",
      "ToolTip": "Non fuga est excepturi qui.",
      "Deleted": true,
      "Rank": 355,
      "Type": "sit",
      "ColorBlock": 62,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "2022-05-17T14:13:48.4914217+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "pariatur",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Seth Padberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "distinctio",
      "StrippedValue": "dolorem",
      "Description": "Realigned hybrid software",
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
      "Value": "distinctio",
      "StrippedValue": "dolorem",
      "Description": "Realigned hybrid software",
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
  "Phones": [
    {
      "Value": "eos",
      "StrippedValue": "mollitia",
      "Description": "Customer-focused clear-thinking application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "mollitia",
      "Description": "Customer-focused clear-thinking application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "quis",
      "Description": "Reduced dedicated service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 658
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "quis",
      "Description": "Reduced dedicated service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 658
        }
      }
    }
  ],
  "Description": "Right-sized systematic secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "est",
      "PersonId": 465,
      "Mrmrs": "saepe",
      "Firstname": "Rollin",
      "Lastname": "Nienow",
      "MiddleName": "Wilderman-Stehr",
      "Title": "soluta",
      "Description": "Team-oriented foreground throughput",
      "Email": "carmen_wyman@prosacco.info",
      "FullName": "Mrs. Lempi Durgan",
      "DirectPhone": "312-630-6581 x916",
      "FormalName": "West Inc and Sons",
      "CountryId": 87,
      "ContactId": 342,
      "ContactName": "Jerde-Sawayn",
      "Retired": 198,
      "Rank": 278,
      "ActiveInterests": 98,
      "ContactDepartment": "empower leading-edge web services",
      "ContactCountryId": 51,
      "ContactOrgNr": "571686",
      "FaxPhone": "359-337-0770 x04616",
      "MobilePhone": "376.559.9988",
      "ContactPhone": "1-200-181-0316",
      "AssociateName": "Stracke-Botsford",
      "AssociateId": 308,
      "UsePersonAddress": false,
      "ContactFax": "doloribus",
      "Kanafname": "qui",
      "Kanalname": "eveniet",
      "Post1": "dolor",
      "Post2": "eum",
      "Post3": "ullam",
      "EmailName": "olga.bergstrom@rice.info",
      "ContactFullName": "Otha Ondricka",
      "ActiveErpLinks": 627,
      "TicketPriorityId": 252,
      "SupportLanguageId": 132,
      "SupportAssociateId": 899,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1745714",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": false,
  "ActiveInterests": 276,
  "GroupId": 278,
  "ActiveStatusMonitorId": 47,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 639,
  "DbiAgentId": 491,
  "DbiLastSyncronized": "2001-08-19T14:13:48.4914217+02:00",
  "DbiKey": "suscipit",
  "DbiLastModified": "2012-10-24T14:13:48.4914217+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 683,
  "ActiveErpLinks": 278,
  "BounceEmails": [
    "wellington.ratke@muellerrodriguez.ca",
    "kaylie.schroeder@kuhlmanhoeger.name"
  ],
  "Domains": [
    "ab",
    "quasi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Domenico Casper",
    "SuperOffice:2": "Emmanuelle Greyson Effertz IV"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "ad"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 896
    }
  }
}
```