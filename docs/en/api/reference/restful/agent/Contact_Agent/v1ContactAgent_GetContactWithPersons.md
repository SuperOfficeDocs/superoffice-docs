---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 129
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 99,
  "Name": "Kohler Inc and Sons",
  "Department": "",
  "OrgNr": "756146",
  "Number1": "1060606",
  "Number2": "1500089",
  "UpdatedDate": "2014-11-28T13:13:22.4145151+01:00",
  "CreatedDate": "2014-08-22T13:13:22.4145151+02:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "quia",
      "Description": "Re-engineered interactive archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 822
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quia",
      "Description": "Re-engineered interactive archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 822
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 276,
      "Name": "Sporer, Mosciski and Runolfsson",
      "ToolTip": "Qui sed et delectus est error doloribus.",
      "Deleted": false,
      "Rank": 338,
      "Type": "debitis",
      "ColorBlock": 434,
      "IconHint": "ullam",
      "Selected": true,
      "LastChanged": "2011-02-05T13:13:22.4145151+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Karlie Greenfelder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "animi",
      "Description": "Inverse next generation forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "animi",
      "Description": "Inverse next generation forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Face to face solution-oriented algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Face to face solution-oriented algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consectetur",
      "StrippedValue": "minima",
      "Description": "Upgradable neutral info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 652
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "minima",
      "Description": "Upgradable neutral info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 652
        }
      }
    }
  ],
  "Description": "Reverse-engineered modular service-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 160,
      "Mrmrs": "blanditiis",
      "Firstname": "Cecile",
      "Lastname": "Toy",
      "MiddleName": "Reichert, Ortiz and Brekke",
      "Title": "culpa",
      "Description": "Front-line clear-thinking challenge",
      "Email": "deonte_balistreri@stoltenbergrenner.us",
      "FullName": "Willy Erdman",
      "DirectPhone": "1-399-493-9234",
      "FormalName": "Schneider LLC",
      "CountryId": 262,
      "ContactId": 959,
      "ContactName": "Sauer Group",
      "Retired": 836,
      "Rank": 281,
      "ActiveInterests": 12,
      "ContactDepartment": "",
      "ContactCountryId": 765,
      "ContactOrgNr": "367375",
      "FaxPhone": "199.443.8364 x07685",
      "MobilePhone": "1-543-456-9177 x129",
      "ContactPhone": "(062)587-0268",
      "AssociateName": "Shanahan-Connelly",
      "AssociateId": 869,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "et",
      "Kanalname": "asperiores",
      "Post1": "omnis",
      "Post2": "unde",
      "Post3": "adipisci",
      "EmailName": "tamara_erdman@little.us",
      "ContactFullName": "Lenora Becker",
      "ActiveErpLinks": 398,
      "TicketPriorityId": 616,
      "SupportLanguageId": 848,
      "SupportAssociateId": 856,
      "CategoryName": "VIP Customer",
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
  "NoMailing": true,
  "Kananame": "porro",
  "Xstop": false,
  "ActiveInterests": 751,
  "GroupId": 890,
  "ActiveStatusMonitorId": 473,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 320,
  "DbiAgentId": 806,
  "DbiLastSyncronized": "2017-03-21T13:13:22.4145151+01:00",
  "DbiKey": "incidunt",
  "DbiLastModified": "2000-01-28T13:13:22.4145151+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 449,
  "ActiveErpLinks": 561,
  "BounceEmails": [
    "efren_swift@lebsack.ca",
    "carmella@roob.biz"
  ],
  "Domains": [
    "officia",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1530909883",
    "SuperOffice:2": "Mrs. Julia Joana Volkman III"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "praesentium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 236
    }
  }
}
```