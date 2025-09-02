---
title: POST Agents/Contact/EnrichContactEntity
uid: v1ContactAgent_EnrichContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/EnrichContactEntity

```http
POST /api/v1/Agents/Contact/EnrichContactEntity
```

Enrich a contact with data from the AI Enrichment service.


This will update the contact with address, phone number, and email.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/EnrichContactEntity?$select=name,department,category/id
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

ContactEntity, EnrichId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| EnrichId | String |  |

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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/EnrichContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "EnrichId": "non"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 999,
  "Name": "Brown-Conroy",
  "Department": "",
  "OrgNr": "251925",
  "Number1": "1375510",
  "Number2": "788382",
  "UpdatedDate": "2003-11-08T03:46:54.5507645+01:00",
  "CreatedDate": "2014-02-25T03:46:54.5507645+01:00",
  "Emails": [
    {
      "Value": "debitis",
      "StrippedValue": "exercitationem",
      "Description": "Cross-platform mobile frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 255
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "exercitationem",
      "Description": "Cross-platform mobile frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 255
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 74,
      "Name": "Boyle-Robel",
      "ToolTip": "Aliquam maxime rerum ullam dolores modi impedit quas.",
      "Deleted": false,
      "Rank": 178,
      "Type": "cum",
      "ColorBlock": 710,
      "IconHint": "officia",
      "Selected": false,
      "LastChanged": "2025-06-06T03:46:54.5507645+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "laboriosam",
      "Hidden": false,
      "FullName": "Mireya Sawayn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "ipsam",
      "Description": "Grass-roots system-worthy archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "ipsam",
      "Description": "Grass-roots system-worthy archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "est",
      "Description": "Proactive human-resource superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "est",
      "Description": "Proactive human-resource superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "adipisci",
      "StrippedValue": "voluptatem",
      "Description": "Pre-emptive actuating capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 754
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "voluptatem",
      "Description": "Pre-emptive actuating capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 754
        }
      }
    }
  ],
  "Description": "Implemented asynchronous service-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "neque",
      "PersonId": 3,
      "Mrmrs": "consequatur",
      "Firstname": "Keaton",
      "Lastname": "Keeling",
      "MiddleName": "Feest, Collier and Botsford",
      "Title": "repellendus",
      "Description": "Open-architected methodical task-force",
      "Email": "alivia@runolfsson.name",
      "FullName": "Mr. Frederik Ondricka",
      "DirectPhone": "(172)522-4988 x432",
      "FormalName": "Stracke Group",
      "CountryId": 492,
      "ContactId": 833,
      "ContactName": "Bruen-Raynor",
      "Retired": 506,
      "Rank": 139,
      "ActiveInterests": 296,
      "ContactDepartment": "",
      "ContactCountryId": 245,
      "ContactOrgNr": "650352",
      "FaxPhone": "1-725-402-4610",
      "MobilePhone": "(455)601-5166",
      "ContactPhone": "(515)633-2508 x60375",
      "AssociateName": "Kutch LLC",
      "AssociateId": 600,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "iste",
      "Kanalname": "vitae",
      "Post1": "qui",
      "Post2": "corporis",
      "Post3": "consequuntur",
      "EmailName": "andreane@kreiger.name",
      "ContactFullName": "Miss Paige Mariela Johns V",
      "ActiveErpLinks": 160,
      "TicketPriorityId": 14,
      "SupportLanguageId": 88,
      "SupportAssociateId": 536,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1093870",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 578
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 558,
  "GroupId": 493,
  "ActiveStatusMonitorId": 573,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 620,
  "DbiAgentId": 972,
  "DbiLastSyncronized": "2007-07-13T03:46:54.5663888+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2004-06-30T03:46:54.5663888+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 352,
  "ActiveErpLinks": 893,
  "BounceEmails": [
    "vinnie_leuschke@larkin.co.uk",
    "garnett@wisozkmetz.uk"
  ],
  "Domains": [
    "libero",
    "quisquam"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Joy Connelly V",
    "SuperOffice:2": "Miss Roselyn Leola Torphy"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 619
    }
  }
}
```