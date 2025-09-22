---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 683,
  "Name": "Mills LLC",
  "Department": "",
  "OrgNr": "687216",
  "Number1": "918648",
  "Number2": "1221920",
  "UpdatedDate": "2007-10-23T11:24:47.7814202+02:00",
  "CreatedDate": "2017-10-05T11:24:47.7814202+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "quis",
      "Description": "Persistent exuding capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "quis",
      "Description": "Persistent exuding capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 106,
      "Name": "Weissnat LLC",
      "ToolTip": "Optio hic dolor doloribus beatae dolores rerum.",
      "Deleted": false,
      "Rank": 32,
      "Type": "quia",
      "ColorBlock": 615,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2002-10-27T11:24:47.7814202+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Darron Gottlieb",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 392
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cupiditate",
      "StrippedValue": "rerum",
      "Description": "Face to face bottom-line archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "rerum",
      "Description": "Face to face bottom-line archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "distinctio",
      "Description": "Vision-oriented national approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 867
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "distinctio",
      "Description": "Vision-oriented national approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 867
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ex",
      "StrippedValue": "velit",
      "Description": "Optimized radical structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 826
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "velit",
      "Description": "Optimized radical structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 826
        }
      }
    }
  ],
  "Description": "Persistent 24/7 adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 335,
      "Mrmrs": "distinctio",
      "Firstname": "Meaghan",
      "Lastname": "Gulgowski",
      "MiddleName": "Beatty LLC",
      "Title": "odit",
      "Description": "Cross-platform 4th generation algorithm",
      "Email": "amanda@morissettepowlowski.ca",
      "FullName": "Miss Darlene Koby Carter",
      "DirectPhone": "624-934-0117 x94572",
      "FormalName": "Orn, VonRueden and Hegmann",
      "CountryId": 138,
      "ContactId": 802,
      "ContactName": "Altenwerth LLC",
      "Retired": 604,
      "Rank": 293,
      "ActiveInterests": 8,
      "ContactDepartment": "",
      "ContactCountryId": 629,
      "ContactOrgNr": "1405422",
      "FaxPhone": "242-854-8552 x346",
      "MobilePhone": "784.522.2869 x554",
      "ContactPhone": "1-690-120-4096",
      "AssociateName": "Wilkinson-Blanda",
      "AssociateId": 37,
      "UsePersonAddress": false,
      "ContactFax": "iusto",
      "Kanafname": "aut",
      "Kanalname": "autem",
      "Post1": "consequatur",
      "Post2": "qui",
      "Post3": "est",
      "EmailName": "myrtis_weber@joneseffertz.us",
      "ContactFullName": "Mr. Hollie Pacocha",
      "ActiveErpLinks": 533,
      "TicketPriorityId": 444,
      "SupportLanguageId": 294,
      "SupportAssociateId": 710,
      "CategoryName": "VIP Customer",
      "PersonNumber": "878034",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "alias",
  "Xstop": true,
  "ActiveInterests": 560,
  "GroupId": 900,
  "ActiveStatusMonitorId": 613,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 452,
  "DbiAgentId": 291,
  "DbiLastSyncronized": "2014-08-09T11:24:47.7814202+02:00",
  "DbiKey": "inventore",
  "DbiLastModified": "2003-08-05T11:24:47.7814202+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 391,
  "ActiveErpLinks": 962,
  "BounceEmails": [
    "samir@bruen.ca",
    "jermain.orn@wolff.com"
  ],
  "Domains": [
    "est",
    "omnis"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Miss Jace Funk Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "ipsum",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 761
    }
  }
}
```