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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 598
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 530,
  "Name": "Ondricka, Littel and Ledner",
  "Department": "",
  "OrgNr": "1002060",
  "Number1": "1079894",
  "Number2": "1057279",
  "UpdatedDate": "2012-06-27T03:31:25.8853256+02:00",
  "CreatedDate": "2006-07-18T03:31:25.8853256+02:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "eos",
      "Description": "Re-contextualized value-added portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 712
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "eos",
      "Description": "Re-contextualized value-added portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 712
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 396,
      "Name": "Kohler, Runolfsdottir and Johnson",
      "ToolTip": "Nobis cupiditate libero odit.",
      "Deleted": false,
      "Rank": 622,
      "Type": "asperiores",
      "ColorBlock": 119,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "1999-08-07T03:31:25.8853256+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptates",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Nola Blick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "et",
      "Description": "Synergistic next generation process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "et",
      "Description": "Synergistic next generation process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "assumenda",
      "StrippedValue": "sit",
      "Description": "Adaptive bottom-line knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "sit",
      "Description": "Adaptive bottom-line knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "porro",
      "Description": "Organized intermediate encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "porro",
      "Description": "Organized intermediate encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Description": "Future-proofed 3rd generation capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 781,
      "Mrmrs": "aperiam",
      "Firstname": "Reinhold",
      "Lastname": "Schowalter",
      "MiddleName": "Schimmel, Klein and Mertz",
      "Title": "consectetur",
      "Description": "Monitored reciprocal product",
      "Email": "shanelle@feil.com",
      "FullName": "Mabel Fay",
      "DirectPhone": "(858)296-5693 x757",
      "FormalName": "Bauch LLC",
      "CountryId": 272,
      "ContactId": 201,
      "ContactName": "Wilderman, Streich and Kutch",
      "Retired": 814,
      "Rank": 152,
      "ActiveInterests": 581,
      "ContactDepartment": "",
      "ContactCountryId": 544,
      "ContactOrgNr": "836206",
      "FaxPhone": "(296)381-0623",
      "MobilePhone": "346.769.2459",
      "ContactPhone": "137.774.0902",
      "AssociateName": "Miller, Cummings and King",
      "AssociateId": 462,
      "UsePersonAddress": false,
      "ContactFax": "iste",
      "Kanafname": "autem",
      "Kanalname": "non",
      "Post1": "magni",
      "Post2": "non",
      "Post3": "officia",
      "EmailName": "keven@muller.com",
      "ContactFullName": "Mrs. Dulce Charles Batz V",
      "ActiveErpLinks": 359,
      "TicketPriorityId": 54,
      "SupportLanguageId": 787,
      "SupportAssociateId": 787,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aliquid",
  "Xstop": false,
  "ActiveInterests": 420,
  "GroupId": 869,
  "ActiveStatusMonitorId": 705,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 188,
  "DbiAgentId": 680,
  "DbiLastSyncronized": "2002-11-07T03:31:25.8853256+01:00",
  "DbiKey": "culpa",
  "DbiLastModified": "2011-06-18T03:31:25.8853256+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 510,
  "ActiveErpLinks": 578,
  "BounceEmails": [
    "robyn@halvorson.name",
    "alberta.koelpin@kunze.biz"
  ],
  "Domains": [
    "aut",
    "molestias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Bradley Wuckert",
    "SuperOffice:2": "799439246"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "laboriosam"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 800
    }
  }
}
```