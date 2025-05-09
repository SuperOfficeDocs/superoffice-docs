---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=397
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 133,
  "Name": "Dibbert Group",
  "Department": "",
  "OrgNr": "992871",
  "Number1": "206293",
  "Number2": "1374897",
  "UpdatedDate": "2009-08-02T16:32:38.4459231+02:00",
  "CreatedDate": "2000-01-26T16:32:38.4459231+01:00",
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "doloremque",
      "Description": "Operative contextually-based data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "doloremque",
      "Description": "Operative contextually-based data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 332,
      "Name": "Keeling, Lockman and Orn",
      "ToolTip": "Architecto facilis facere sapiente sequi et.",
      "Deleted": false,
      "Rank": 186,
      "Type": "aut",
      "ColorBlock": 552,
      "IconHint": "labore",
      "Selected": false,
      "LastChanged": "2000-05-10T16:32:38.4459231+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "King Flatley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "adipisci",
      "Description": "Compatible multimedia instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "adipisci",
      "Description": "Compatible multimedia instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quis",
      "StrippedValue": "modi",
      "Description": "Seamless empowering pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "modi",
      "Description": "Seamless empowering pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "harum",
      "StrippedValue": "accusantium",
      "Description": "Expanded upward-trending paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "accusantium",
      "Description": "Expanded upward-trending paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    }
  ],
  "Description": "Future-proofed web-enabled definition",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 418,
      "Mrmrs": "debitis",
      "Firstname": "Ines",
      "Lastname": "Johnson",
      "MiddleName": "Kirlin, Glover and Jacobi",
      "Title": "quod",
      "Description": "Persevering directional productivity",
      "Email": "allene.schiller@hodkiewicz.info",
      "FullName": "Rudolph Brekke",
      "DirectPhone": "787.234.5763 x2753",
      "FormalName": "Hyatt-Bergstrom",
      "CountryId": 214,
      "ContactId": 327,
      "ContactName": "Spinka-Doyle",
      "Retired": 762,
      "Rank": 72,
      "ActiveInterests": 573,
      "ContactDepartment": "",
      "ContactCountryId": 410,
      "ContactOrgNr": "1033348",
      "FaxPhone": "1-383-446-6678 x31848",
      "MobilePhone": "251-137-1001",
      "ContactPhone": "456.548.0431",
      "AssociateName": "Huel Group",
      "AssociateId": 477,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "labore",
      "Kanalname": "perspiciatis",
      "Post1": "eligendi",
      "Post2": "deleniti",
      "Post3": "ipsa",
      "EmailName": "enrique@dibbert.name",
      "ContactFullName": "Jaunita Morar",
      "ActiveErpLinks": 514,
      "TicketPriorityId": 976,
      "SupportLanguageId": 988,
      "SupportAssociateId": 307,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1162769",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 194
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "accusantium",
  "Xstop": false,
  "ActiveInterests": 714,
  "GroupId": 721,
  "ActiveStatusMonitorId": 810,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 441,
  "DbiAgentId": 751,
  "DbiLastSyncronized": "2016-11-03T16:32:38.4459231+01:00",
  "DbiKey": "consectetur",
  "DbiLastModified": "2018-09-12T16:32:38.4459231+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 55,
  "ActiveErpLinks": 972,
  "BounceEmails": [
    "reba_green@smith.info",
    "leanne@feil.co.uk"
  ],
  "Domains": [
    "dolores",
    "tenetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "754231090",
    "SuperOffice:2": "280589339"
  },
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "temporibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 900
    }
  }
}
```