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
  "ContactId": 640
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 711,
  "Name": "Boyer, Effertz and Walter",
  "Department": "",
  "OrgNr": "652321",
  "Number1": "528091",
  "Number2": "1481451",
  "UpdatedDate": "1998-05-01T03:45:23.1861021+02:00",
  "CreatedDate": "1999-05-20T03:45:23.1861021+02:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "sequi",
      "Description": "Future-proofed high-level firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "sequi",
      "Description": "Future-proofed high-level firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 474,
      "Name": "Yost Inc and Sons",
      "ToolTip": "Ab maiores fugiat culpa.",
      "Deleted": false,
      "Rank": 562,
      "Type": "eaque",
      "ColorBlock": 142,
      "IconHint": "voluptatem",
      "Selected": true,
      "LastChanged": "2017-11-23T03:45:23.1861021+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ab",
      "Hidden": false,
      "FullName": "Mrs. Juvenal Travon Pfannerstill MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 247
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "corrupti",
      "Description": "Distributed logistical Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "corrupti",
      "Description": "Distributed logistical Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "temporibus",
      "StrippedValue": "totam",
      "Description": "Front-line stable extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "totam",
      "Description": "Front-line stable extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sequi",
      "StrippedValue": "neque",
      "Description": "Automated disintermediate knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "neque",
      "Description": "Automated disintermediate knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "Description": "Fully-configurable multi-state open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "modi",
      "PersonId": 460,
      "Mrmrs": "voluptas",
      "Firstname": "Malinda",
      "Lastname": "Schinner",
      "MiddleName": "Jacobi-Langosh",
      "Title": "consequatur",
      "Description": "Open-source human-resource installation",
      "Email": "greg_rosenbaum@heidenreich.co.uk",
      "FullName": "Magali Shanahan",
      "DirectPhone": "347.900.1385",
      "FormalName": "Larson, Lang and Borer",
      "CountryId": 674,
      "ContactId": 661,
      "ContactName": "Herman LLC",
      "Retired": 18,
      "Rank": 113,
      "ActiveInterests": 495,
      "ContactDepartment": "",
      "ContactCountryId": 539,
      "ContactOrgNr": "530844",
      "FaxPhone": "981-743-4180 x4571",
      "MobilePhone": "060-681-1653 x946",
      "ContactPhone": "1-996-346-2325",
      "AssociateName": "Bode LLC",
      "AssociateId": 242,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "ut",
      "Kanalname": "non",
      "Post1": "architecto",
      "Post2": "sapiente",
      "Post3": "consectetur",
      "EmailName": "isabelle@swift.name",
      "ContactFullName": "Caden Grant I",
      "ActiveErpLinks": 945,
      "TicketPriorityId": 421,
      "SupportLanguageId": 537,
      "SupportAssociateId": 833,
      "CategoryName": "VIP Customer",
      "PersonNumber": "370695",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "temporibus",
  "Xstop": false,
  "ActiveInterests": 370,
  "GroupId": 950,
  "ActiveStatusMonitorId": 734,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 603,
  "DbiAgentId": 225,
  "DbiLastSyncronized": "2023-08-13T03:45:23.1861021+02:00",
  "DbiKey": "beatae",
  "DbiLastModified": "2020-06-20T03:45:23.1861021+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 381,
  "ActiveErpLinks": 386,
  "BounceEmails": [
    "elsie_deckow@douglaslind.biz",
    "lonnie.hessel@hintzbayer.biz"
  ],
  "Domains": [
    "qui",
    "suscipit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Cheyenne Pouros DDS",
    "SuperOffice:2": "307682762"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "eligendi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 682
    }
  }
}
```