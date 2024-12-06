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
  "ContactId": 858,
  "Name": "Denesik-Tremblay",
  "Department": "",
  "OrgNr": "433935",
  "Number1": "1802693",
  "Number2": "56784",
  "UpdatedDate": "2003-12-10T10:17:55.2852697+01:00",
  "CreatedDate": "2003-11-18T10:17:55.2852697+01:00",
  "Emails": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "necessitatibus",
      "Description": "Automated executive flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 528
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "necessitatibus",
      "Description": "Automated executive flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 528
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 154,
      "Name": "Carroll Inc and Sons",
      "ToolTip": "Sunt nam autem sunt soluta illum sit ipsa.",
      "Deleted": false,
      "Rank": 468,
      "Type": "perferendis",
      "ColorBlock": 768,
      "IconHint": "expedita",
      "Selected": true,
      "LastChanged": "2023-04-14T10:17:55.2852697+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Miss Odie Stiedemann DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "saepe",
      "Description": "Multi-tiered logistical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "saepe",
      "Description": "Multi-tiered logistical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "quae",
      "Description": "Proactive cohesive leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 465
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "quae",
      "Description": "Proactive cohesive leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 465
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fugit",
      "StrippedValue": "magnam",
      "Description": "Operative interactive circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "magnam",
      "Description": "Operative interactive circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "Description": "Realigned uniform customer loyalty",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "autem",
      "PersonId": 805,
      "Mrmrs": "fugit",
      "Firstname": "Tamara",
      "Lastname": "Wintheiser",
      "MiddleName": "Hahn LLC",
      "Title": "quis",
      "Description": "Robust secondary instruction set",
      "Email": "tracy@paucek.us",
      "FullName": "Mrs. Emilia Emmerich DVM",
      "DirectPhone": "607-032-0895 x57125",
      "FormalName": "Connelly Inc and Sons",
      "CountryId": 303,
      "ContactId": 89,
      "ContactName": "Tremblay-Sipes",
      "Retired": 180,
      "Rank": 987,
      "ActiveInterests": 361,
      "ContactDepartment": "",
      "ContactCountryId": 279,
      "ContactOrgNr": "988239",
      "FaxPhone": "(677)924-9370",
      "MobilePhone": "1-548-947-8705 x536",
      "ContactPhone": "017.836.8027",
      "AssociateName": "Powlowski-Jaskolski",
      "AssociateId": 109,
      "UsePersonAddress": true,
      "ContactFax": "temporibus",
      "Kanafname": "eius",
      "Kanalname": "distinctio",
      "Post1": "eius",
      "Post2": "fugiat",
      "Post3": "et",
      "EmailName": "rene_lesch@eichmann.co.uk",
      "ContactFullName": "Onie Reilly",
      "ActiveErpLinks": 590,
      "TicketPriorityId": 837,
      "SupportLanguageId": 213,
      "SupportAssociateId": 564,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ea",
  "Xstop": true,
  "ActiveInterests": 342,
  "GroupId": 87,
  "ActiveStatusMonitorId": 902,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 581,
  "DbiAgentId": 201,
  "DbiLastSyncronized": "2000-02-09T10:17:55.2852697+01:00",
  "DbiKey": "enim",
  "DbiLastModified": "2014-03-02T10:17:55.2852697+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 787,
  "ActiveErpLinks": 617,
  "BounceEmails": [
    "lilyan@faheylubowitz.us",
    "rashawn@schuppeledner.com"
  ],
  "Domains": [
    "eum",
    "libero"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Vern Elvera Farrell MD",
    "SuperOffice:2": "Scotty Tillman"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "placeat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 767
    }
  }
}
```