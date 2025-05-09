---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
```


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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 49,
  "Name": "Hilll, Gleason and Lakin",
  "Department": "",
  "OrgNr": "1219443",
  "Number1": "383968",
  "Number2": "757398",
  "UpdatedDate": "2007-10-16T16:32:38.4771663+02:00",
  "CreatedDate": "2024-02-20T16:32:38.4771663+01:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "quam",
      "Description": "Digitized transitional service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quam",
      "Description": "Digitized transitional service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 657,
      "Name": "Kulas-Goldner",
      "ToolTip": "Autem ullam eum numquam omnis reiciendis doloremque.",
      "Deleted": false,
      "Rank": 891,
      "Type": "architecto",
      "ColorBlock": 774,
      "IconHint": "sequi",
      "Selected": true,
      "LastChanged": "2022-04-03T16:32:38.4771663+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facilis",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Mrs. Hillard Sophia Schmitt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "eos",
      "Description": "Implemented secondary frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "eos",
      "Description": "Implemented secondary frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nostrum",
      "StrippedValue": "qui",
      "Description": "Secured zero tolerance matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "qui",
      "Description": "Secured zero tolerance matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "et",
      "Description": "Integrated assymetric leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "et",
      "Description": "Integrated assymetric leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    }
  ],
  "Description": "Persevering object-oriented task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloribus",
      "PersonId": 815,
      "Mrmrs": "accusamus",
      "Firstname": "Mike",
      "Lastname": "Champlin",
      "MiddleName": "Christiansen Group",
      "Title": "iusto",
      "Description": "Multi-lateral coherent definition",
      "Email": "marilie@lednerschultz.com",
      "FullName": "Mr. Valentina Konopelski",
      "DirectPhone": "415-648-2811",
      "FormalName": "Ullrich-Prohaska",
      "CountryId": 424,
      "ContactId": 164,
      "ContactName": "Breitenberg LLC",
      "Retired": 678,
      "Rank": 27,
      "ActiveInterests": 414,
      "ContactDepartment": "",
      "ContactCountryId": 562,
      "ContactOrgNr": "963286",
      "FaxPhone": "1-447-110-5962 x2023",
      "MobilePhone": "171.289.9560",
      "ContactPhone": "(126)785-3318",
      "AssociateName": "Barton LLC",
      "AssociateId": 535,
      "UsePersonAddress": false,
      "ContactFax": "quibusdam",
      "Kanafname": "consequatur",
      "Kanalname": "temporibus",
      "Post1": "vel",
      "Post2": "voluptatum",
      "Post3": "sed",
      "EmailName": "kennedi_auer@trantow.uk",
      "ContactFullName": "Alfonzo Green",
      "ActiveErpLinks": 694,
      "TicketPriorityId": 2,
      "SupportLanguageId": 653,
      "SupportAssociateId": 910,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1016229",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 67,
  "GroupId": 93,
  "ActiveStatusMonitorId": 373,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 828,
  "DbiAgentId": 477,
  "DbiLastSyncronized": "2022-08-18T16:32:38.4927881+02:00",
  "DbiKey": "rem",
  "DbiLastModified": "2015-01-21T16:32:38.4927881+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 807,
  "ActiveErpLinks": 326,
  "BounceEmails": [
    "ruthie@johns.name",
    "tyrel@zemlak.uk"
  ],
  "Domains": [
    "repellendus",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Paula Kunze",
    "SuperOffice:2": "Darlene Connelly"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "a"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 832
    }
  }
}
```