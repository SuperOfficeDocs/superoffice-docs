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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 59,
  "Name": "Lemke-Stehr",
  "Department": "",
  "OrgNr": "1592854",
  "Number1": "1241317",
  "Number2": "1688997",
  "UpdatedDate": "2022-02-21T03:45:23.1550919+01:00",
  "CreatedDate": "2006-04-21T03:45:23.1550919+02:00",
  "Emails": [
    {
      "Value": "aliquid",
      "StrippedValue": "est",
      "Description": "Switchable bi-directional forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "est",
      "Description": "Switchable bi-directional forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 706,
      "Name": "Parker LLC",
      "ToolTip": "Nulla sit suscipit possimus voluptate.",
      "Deleted": true,
      "Rank": 659,
      "Type": "exercitationem",
      "ColorBlock": 509,
      "IconHint": "occaecati",
      "Selected": false,
      "LastChanged": "2012-04-05T03:45:23.1550919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Ms. Verner Nelson Wintheiser II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "praesentium",
      "StrippedValue": "iste",
      "Description": "Visionary responsive support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 344
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "iste",
      "Description": "Visionary responsive support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 344
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "illum",
      "Description": "Re-contextualized motivating data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "illum",
      "Description": "Re-contextualized motivating data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Quality-focused 4th generation forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Quality-focused 4th generation forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "Description": "Re-engineered actuating support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 753,
      "Mrmrs": "fugiat",
      "Firstname": "Reanna",
      "Lastname": "Doyle",
      "MiddleName": "Considine Group",
      "Title": "velit",
      "Description": "Face to face 6th generation collaboration",
      "Email": "yadira@casper.info",
      "FullName": "Cecelia Yundt I",
      "DirectPhone": "490.577.8101 x20290",
      "FormalName": "Stroman-Willms",
      "CountryId": 526,
      "ContactId": 528,
      "ContactName": "Gerhold, Larson and Senger",
      "Retired": 428,
      "Rank": 445,
      "ActiveInterests": 727,
      "ContactDepartment": "",
      "ContactCountryId": 666,
      "ContactOrgNr": "1154424",
      "FaxPhone": "486-932-8971",
      "MobilePhone": "779.446.0611 x128",
      "ContactPhone": "1-084-394-6399",
      "AssociateName": "Lehner-Oberbrunner",
      "AssociateId": 411,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "deleniti",
      "Kanalname": "harum",
      "Post1": "neque",
      "Post2": "rem",
      "Post3": "amet",
      "EmailName": "blanche_cartwright@schowalter.name",
      "ContactFullName": "Cleveland Larson",
      "ActiveErpLinks": 388,
      "TicketPriorityId": 65,
      "SupportLanguageId": 684,
      "SupportAssociateId": 615,
      "CategoryName": "VIP Customer",
      "PersonNumber": "943095",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 354,
  "GroupId": 659,
  "ActiveStatusMonitorId": 388,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 390,
  "DbiAgentId": 427,
  "DbiLastSyncronized": "2008-07-09T03:45:23.1550919+02:00",
  "DbiKey": "praesentium",
  "DbiLastModified": "2022-11-15T03:45:23.1550919+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 513,
  "ActiveErpLinks": 809,
  "BounceEmails": [
    "nora@marquardtstoltenberg.name",
    "cara_hodkiewicz@mitchell.info"
  ],
  "Domains": [
    "temporibus",
    "voluptatum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1865491041",
    "SuperOffice:2": "793870326"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "magni",
    "CustomFields2": "fugiat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 716
    }
  }
}
```