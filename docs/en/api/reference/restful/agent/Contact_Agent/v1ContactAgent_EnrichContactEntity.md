---
title: POST Agents/Contact/EnrichContactEntity
uid: v1ContactAgent_EnrichContactEntity
generated: true
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "EnrichId": "saepe"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 470,
  "Name": "Muller, Volkman and McGlynn",
  "Department": "",
  "OrgNr": "1440449",
  "Number1": "1253564",
  "Number2": "517806",
  "UpdatedDate": "2005-09-24T03:45:23.2329582+02:00",
  "CreatedDate": "2019-04-29T03:45:23.2329582+02:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "at",
      "Description": "Upgradable optimizing matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "at",
      "Description": "Upgradable optimizing matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 1001,
      "Name": "Rodriguez LLC",
      "ToolTip": "Alias tenetur ut quis.",
      "Deleted": false,
      "Rank": 955,
      "Type": "saepe",
      "ColorBlock": 734,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2023-01-03T03:45:23.2329582+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Tavares Gislason",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quaerat",
      "StrippedValue": "recusandae",
      "Description": "Profound bandwidth-monitored utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "recusandae",
      "Description": "Profound bandwidth-monitored utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sequi",
      "StrippedValue": "omnis",
      "Description": "Automated assymetric capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "omnis",
      "Description": "Automated assymetric capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "modi",
      "Description": "Configurable 5th generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "modi",
      "Description": "Configurable 5th generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "Description": "Quality-focused value-added artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolor",
      "PersonId": 727,
      "Mrmrs": "tempora",
      "Firstname": "Antoinette",
      "Lastname": "Harris",
      "MiddleName": "O'Reilly, Price and Vandervort",
      "Title": "quam",
      "Description": "Streamlined reciprocal database",
      "Email": "jorge.gaylord@padberg.com",
      "FullName": "Marco Mayert",
      "DirectPhone": "(541)436-4910",
      "FormalName": "Cummings, Schoen and Roob",
      "CountryId": 497,
      "ContactId": 475,
      "ContactName": "Hane-Schmeler",
      "Retired": 357,
      "Rank": 584,
      "ActiveInterests": 378,
      "ContactDepartment": "",
      "ContactCountryId": 442,
      "ContactOrgNr": "859517",
      "FaxPhone": "(443)870-7544",
      "MobilePhone": "922-959-0261 x67173",
      "ContactPhone": "1-271-160-6785",
      "AssociateName": "Roob Inc and Sons",
      "AssociateId": 416,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "est",
      "Kanalname": "rerum",
      "Post1": "iste",
      "Post2": "fuga",
      "Post3": "expedita",
      "EmailName": "jake_sipes@terryhaag.info",
      "ContactFullName": "Gust Gerhold Jr.",
      "ActiveErpLinks": 516,
      "TicketPriorityId": 495,
      "SupportLanguageId": 153,
      "SupportAssociateId": 881,
      "CategoryName": "VIP Customer",
      "PersonNumber": "846199",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "officiis",
  "Xstop": false,
  "ActiveInterests": 93,
  "GroupId": 951,
  "ActiveStatusMonitorId": 107,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 453,
  "DbiAgentId": 987,
  "DbiLastSyncronized": "2023-05-20T03:45:23.2329582+02:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2016-07-20T03:45:23.2329582+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 40,
  "ActiveErpLinks": 367,
  "BounceEmails": [
    "fritz@brown.com",
    "tyrel_wisoky@bashirianfisher.ca"
  ],
  "Domains": [
    "voluptas",
    "sint"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Freeda Granville Erdman MD",
    "SuperOffice:2": "443976245"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "ab"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 237
    }
  }
}
```