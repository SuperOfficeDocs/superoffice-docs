---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
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
  "ContactId": 731,
  "Name": "Hills LLC",
  "Department": "",
  "OrgNr": "393179",
  "Number1": "876859",
  "Number2": "1358531",
  "UpdatedDate": "2000-04-09T13:13:22.4301329+02:00",
  "CreatedDate": "2000-09-22T13:13:22.4301329+02:00",
  "Emails": [
    {
      "Value": "ratione",
      "StrippedValue": "facere",
      "Description": "Phased upward-trending groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "facere",
      "Description": "Phased upward-trending groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 476,
      "Name": "Conroy LLC",
      "ToolTip": "Excepturi quaerat.",
      "Deleted": false,
      "Rank": 82,
      "Type": "libero",
      "ColorBlock": 48,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2004-06-19T13:13:22.4301329+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Dr. Imelda Alessia Klein",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 431
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "voluptates",
      "Description": "Re-contextualized heuristic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "voluptates",
      "Description": "Re-contextualized heuristic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iure",
      "StrippedValue": "nostrum",
      "Description": "Phased solution-oriented circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "nostrum",
      "Description": "Phased solution-oriented circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "totam",
      "Description": "Progressive dynamic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 371
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "totam",
      "Description": "Progressive dynamic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 371
        }
      }
    }
  ],
  "Description": "Re-contextualized multimedia projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 140,
      "Mrmrs": "sequi",
      "Firstname": "Milton",
      "Lastname": "Ferry",
      "MiddleName": "Veum-Kulas",
      "Title": "eligendi",
      "Description": "Pre-emptive bandwidth-monitored budgetary management",
      "Email": "katharina@ziemannlehner.name",
      "FullName": "Hazle Haley",
      "DirectPhone": "1-196-489-3168",
      "FormalName": "Torp, Langosh and Ferry",
      "CountryId": 937,
      "ContactId": 646,
      "ContactName": "Fadel, Pfeffer and McClure",
      "Retired": 763,
      "Rank": 102,
      "ActiveInterests": 541,
      "ContactDepartment": "",
      "ContactCountryId": 240,
      "ContactOrgNr": "1281056",
      "FaxPhone": "686-529-2378",
      "MobilePhone": "187.855.2583 x581",
      "ContactPhone": "(221)244-8363",
      "AssociateName": "Spinka Group",
      "AssociateId": 412,
      "UsePersonAddress": true,
      "ContactFax": "voluptas",
      "Kanafname": "qui",
      "Kanalname": "qui",
      "Post1": "a",
      "Post2": "omnis",
      "Post3": "assumenda",
      "EmailName": "kenna_abernathy@rau.name",
      "ContactFullName": "Prof. Jay Maurine Stoltenberg II",
      "ActiveErpLinks": 169,
      "TicketPriorityId": 73,
      "SupportLanguageId": 830,
      "SupportAssociateId": 921,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 552
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 325,
  "GroupId": 644,
  "ActiveStatusMonitorId": 619,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 974,
  "DbiAgentId": 214,
  "DbiLastSyncronized": "1997-10-09T13:13:22.4301329+02:00",
  "DbiKey": "accusamus",
  "DbiLastModified": "2017-07-27T13:13:22.4301329+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 934,
  "ActiveErpLinks": 199,
  "BounceEmails": [
    "neal@fadel.info",
    "esmeralda_osinski@effertzhand.ca"
  ],
  "Domains": [
    "cum",
    "perferendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1660599286"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 650
    }
  }
}
```