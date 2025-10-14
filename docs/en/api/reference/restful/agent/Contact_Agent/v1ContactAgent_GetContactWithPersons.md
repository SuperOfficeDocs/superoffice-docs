---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact


NsApiSlow threshold: 2000 ms.






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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 585
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 884,
  "Name": "Heidenreich-Rowe",
  "Department": "",
  "OrgNr": "550802",
  "Number1": "1033978",
  "Number2": "1061561",
  "UpdatedDate": "2008-04-02T03:40:46.38999+02:00",
  "CreatedDate": "2017-02-28T03:40:46.38999+01:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "error",
      "Description": "Business-focused stable hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "error",
      "Description": "Business-focused stable hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 189,
      "Name": "Mayert Group",
      "ToolTip": "Dolorem doloremque delectus accusantium ullam delectus.",
      "Deleted": true,
      "Rank": 272,
      "Type": "reprehenderit",
      "ColorBlock": 856,
      "IconHint": "animi",
      "Selected": false,
      "LastChanged": "2000-11-14T03:40:46.405616+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "quam",
      "Hidden": true,
      "FullName": "Julia Kunde",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "minus",
      "StrippedValue": "vitae",
      "Description": "Multi-channelled secondary archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 562
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "vitae",
      "Description": "Multi-channelled secondary archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 562
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "asperiores",
      "StrippedValue": "quaerat",
      "Description": "De-engineered tangible encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 646
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "quaerat",
      "Description": "De-engineered tangible encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 646
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "asperiores",
      "StrippedValue": "et",
      "Description": "Team-oriented bottom-line synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "et",
      "Description": "Team-oriented bottom-line synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "Description": "Quality-focused user-facing collaboration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aliquam",
      "PersonId": 386,
      "Mrmrs": "omnis",
      "Firstname": "Price",
      "Lastname": "Mraz",
      "MiddleName": "Lind-Fadel",
      "Title": "nisi",
      "Description": "Visionary executive functionalities",
      "Email": "dominique.mills@osinski.biz",
      "FullName": "Lysanne Thompson",
      "DirectPhone": "964.775.7104 x026",
      "FormalName": "Hudson LLC",
      "CountryId": 976,
      "ContactId": 419,
      "ContactName": "Zieme-Lang",
      "Retired": 772,
      "Rank": 153,
      "ActiveInterests": 49,
      "ContactDepartment": "",
      "ContactCountryId": 33,
      "ContactOrgNr": "456147",
      "FaxPhone": "1-135-867-8292 x15932",
      "MobilePhone": "829-593-7729 x797",
      "ContactPhone": "1-651-635-9566 x6441",
      "AssociateName": "Becker-Towne",
      "AssociateId": 639,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "labore",
      "Kanalname": "incidunt",
      "Post1": "animi",
      "Post2": "dicta",
      "Post3": "cumque",
      "EmailName": "kris_mante@gleasonbarrows.uk",
      "ContactFullName": "Broderick Hettinger",
      "ActiveErpLinks": 761,
      "TicketPriorityId": 752,
      "SupportLanguageId": 258,
      "SupportAssociateId": 332,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1674624",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "atque",
  "Xstop": true,
  "ActiveInterests": 393,
  "GroupId": 795,
  "ActiveStatusMonitorId": 882,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 242,
  "DbiAgentId": 893,
  "DbiLastSyncronized": "2023-04-02T03:40:46.405616+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2013-07-27T03:40:46.405616+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 182,
  "ActiveErpLinks": 358,
  "BounceEmails": [
    "kaci@kerluke.info",
    "eldridge@leannon.ca"
  ],
  "Domains": [
    "voluptas",
    "id"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Miller McGlynn",
    "SuperOffice:2": "1628797404"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 148
    }
  }
}
```