---
title: The Dynamic Provider
uid: rest_api_search_dynamic
description: REST Web API dynamic dot-syntax search provider
author: SuperOffice Product and Engineering
keywords: search,odata
date: 2023-04-26
content_type: howto
redirect_from: /en/api/netserver/search/odata/dynamic-provider
---

# The Dynamic Provider - the dot syntax

This archive provider is as close to SQL queries as you can get. There is plenty of scope for shooting yourself in the foot. We provide all the built-in archive-providers so you don't have to deal with the
complexity of the

The following grammar defines what dot-syntax really is:

```text
dotSyntax := table [join, ...] .field
join      := outerjoin | innerjoin | rightjoin
outerjoin := .fk_field
innerjoin := :fk_field
rightjoin := .(table->fk_field)
fk_field  := foreign_key | field_name[table_name]    # note the square brackets are literals here!
table     := table name from database
field     := field name from database, or column name defined by the module handling that table
foreign_key := field name from database, where field must be defined as a foreign key in the dictionary
field_name := any field name in the current table that is of type int
table_name := target table, relation does NOT need to be defined in the dictionary in this case
```

The base table must be the same for all fields. In other words, the fields must all start on the same table.

Field names must follow this grammar, otherwise exceptions will be generated. Additionally, all
join field and table names must be valid, by reference to the runtime dictionary; but note that right-joins as well as left-joins
using the square-bracket syntax to specify target table do not need to correspond to relations declared in the dictionary.

Final field names can be anything, as long as the code handling that table recognizes the field name. If no specific
code is found for a table, a generic (dynamic) extender will be used; this requires field names to match database field names.

The dot syntax allows you to build your own custom query across whatever tables you like, including custom fields and custom tables.

You will need to reference the database schema to navigate the relations accordingly: @database-table-listing-by-name

## Examples

### Select: Category table

`category.name` - the name of a category in the @table-Category

```http
GET /api/v1/archive/dynamic?$select=category.name
Authorization: Bearer 8A:
Accept: application/json
```

Corresponds to

```sql
SELECT category.name FROM category
```

Returns category names.

```json
{
  "odata.metadata": "http://localhost/crm.web/api/v1/Archive/$metadata",
  "odata.nextLink": null,
  "value": [
    {
      "PrimaryKey": "1",
      "EntityName": "Category",
      "category.name": "Customer"
    },
    {
      "PrimaryKey": "2",
      "EntityName": "Category",
      "category.name": "Potensiell kunde"
    },
    ...
  ]
}
```

### Filtering

`category.tooltip` - the description of the category

```http
GET /api/v1/archive/dynamic?$select=category.name&$filter=category.tooltip contains 'a'
Authorization: Bearer 8A:
Accept: application/json
```

Corresponds to

```sql
SELECT category.name FROM category WHERE category.tooltip like '%a%'
```

Returns category name.

```json
{
  "odata.metadata": "http://localhost/crm.web/api/v1/Archive/$metadata",
  "odata.nextLink": null,
  "value": [
    {
      "PrimaryKey": "7",
      "EntityName": "Category",
      "category.name": "SaleItem 1"
    }
  ]
}
```

### Outer join: Contact name and category name

`contact.name` is the name from the @table-contact
`contact.category_idx` is a foreign-key to the @table-Category - which we can outer-join.
`contact.category_idx.name` - is the category's name - here we follow the category relation via an outer-join.
To make this an inner join, we use a colon instead as a prefix to the join `contact:category_idx.name`

```http
GET /api/v1/archive/dynamic?$select=contact.name,contact.category_idx,contact.category\_idx.name
Authorization: Bearer 8A:
Accept: application/json
```

Equivalent to

```sql
SELECT contact.name, contact.category_idx, category.name FROM contact LEFT JOIN category ON category_idx = category_id
```

returns

```json
{
  "odata.metadata": "http://localhost/crm.web/api/v1/Archive/$metadata",
  "odata.nextLink": null,
  "value": [
    {
      "PrimaryKey": "2",
      "EntityName": "contact",
      "contact.category_idx.name": "Samarbeidspartner",
      "contact.name": "statezerodatabase",
      "contact.category_idx": 4
    },
    {
      "PrimaryKey": "3",
      "EntityName": "contact",
      "contact.category_idx.name": "Customer",
      "contact.name": "Amadeus AS",
      "contact.category_idx": 1
    },
    ...
  ]
}
```

### Right join: Category to contact

`category.category_id` - the primary key on the category
`category.(contact->category_idx).name` - the primary key on the category right joined to contact table via the `category_idx` foreign key on the contact table.

```http
GET /api/v1/archive/dynamic?$select=category.name,category.(contact->category_idx).name
Authorization: Bearer 8A:
Accept: application/json
```

Equivalent to

```sql
SELECT category.name, contact.name FROM category RIGHT JOIN contact ON category_id = category_idx
```

Returns categories and the associated company names.

```json
{
  "odata.metadata": "http://localhost/crm.web/api/v1/Archive/$metadata",
  "odata.nextLink": null,
  "value": [
    {
      "PrimaryKey": "1",
      "EntityName": "Category",
      "category.(contact->category_idx).name": "Amadeus AS",
      "category.name": "Customer"
    },
    {
      "PrimaryKey": "1",
      "EntityName": "Category",
      "category.(contact->category_idx).name": "Arne'S Kebab",
      "category.name": "Customer"
    },
    {
      "PrimaryKey": "1",
      "EntityName": "Category",
      "category.(contact->category_idx).name": "Bjørge AS",
      "category.name": "Customer"
    },
```
