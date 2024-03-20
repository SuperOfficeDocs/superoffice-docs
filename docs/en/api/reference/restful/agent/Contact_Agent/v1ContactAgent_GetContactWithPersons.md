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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 227
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 660,
  "Name": "Schmitt, Carroll and Cormier",
  "Department": "",
  "OrgNr": "666551",
  "Number1": "621884",
  "Number2": "417686",
  "UpdatedDate": "2014-11-13T12:19:44.9142138+01:00",
  "CreatedDate": "2000-11-03T12:19:44.9142138+01:00",
  "Emails": [
    {
      "Value": "natus",
      "StrippedValue": "sed",
      "Description": "Ameliorated systemic success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "sed",
      "Description": "Ameliorated systemic success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 210,
      "Name": "Lemke, Wiegand and Wiza",
      "ToolTip": "Ipsum inventore voluptatem sit autem unde quidem.",
      "Deleted": false,
      "Rank": 838,
      "Type": "impedit",
      "ColorBlock": 257,
      "IconHint": "pariatur",
      "Selected": false,
      "LastChanged": "2011-11-01T12:19:44.9142138+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magnam",
      "StyleHint": "culpa",
      "Hidden": false,
      "FullName": "Mr. Kianna Dietrich IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 835
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "laborum",
      "Description": "Realigned high-level attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 698
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "laborum",
      "Description": "Realigned high-level attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 698
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ratione",
      "StrippedValue": "dolor",
      "Description": "Grass-roots clear-thinking productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "dolor",
      "Description": "Grass-roots clear-thinking productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magni",
      "StrippedValue": "explicabo",
      "Description": "Centralized cohesive definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 384
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "explicabo",
      "Description": "Centralized cohesive definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 384
        }
      }
    }
  ],
  "Description": "Exclusive homogeneous internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quidem",
      "PersonId": 903,
      "Mrmrs": "adipisci",
      "Firstname": "Domenico",
      "Lastname": "Watsica",
      "MiddleName": "Ernser LLC",
      "Title": "quod",
      "Description": "Devolved discrete frame",
      "Email": "eldon_zemlak@powlowski.uk",
      "FullName": "Ms. Anais Alize Rohan II",
      "DirectPhone": "054-644-3824 x079",
      "FormalName": "Douglas-Thiel",
      "CountryId": 590,
      "ContactId": 228,
      "ContactName": "Luettgen Inc and Sons",
      "Retired": 93,
      "Rank": 90,
      "ActiveInterests": 885,
      "ContactDepartment": "",
      "ContactCountryId": 989,
      "ContactOrgNr": "603265",
      "FaxPhone": "1-507-385-8785",
      "MobilePhone": "1-309-758-3916",
      "ContactPhone": "742.744.5634 x278",
      "AssociateName": "Wunsch-Leuschke",
      "AssociateId": 928,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "cumque",
      "Kanalname": "id",
      "Post1": "recusandae",
      "Post2": "eius",
      "Post3": "distinctio",
      "EmailName": "ernest@torphykuhic.name",
      "ContactFullName": "Abbey Osinski",
      "ActiveErpLinks": 148,
      "TicketPriorityId": 659,
      "SupportLanguageId": 698,
      "SupportAssociateId": 937,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 767
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": true,
  "ActiveInterests": 840,
  "GroupId": 739,
  "ActiveStatusMonitorId": 451,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 882,
  "DbiAgentId": 388,
  "DbiLastSyncronized": "2014-04-16T12:19:44.9142138+02:00",
  "DbiKey": "aliquid",
  "DbiLastModified": "2001-12-06T12:19:44.9142138+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 851,
  "ActiveErpLinks": 328,
  "BounceEmails": [
    "una_bartoletti@rempel.com",
    "alda_metz@brekkemiller.us"
  ],
  "Domains": [
    "perferendis",
    "fugiat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Marisa Lubowitz",
    "SuperOffice:2": "Dr. Geraldine Mckenna Boyle PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "eveniet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 206
    }
  }
}
```