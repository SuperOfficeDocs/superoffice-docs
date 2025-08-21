---
uid: search-api
title: search
description: "Introduction to API search capabilities and archive providers."
author: SuperOfficeDevNet
date: 02.02.2022
updated: 02.12.2024
keywords: search
content_type: concept
redirect_from: /en/api/netserver/search
---

# Search

SuperOffice CRM offers a versatile and robust search framework to manage and retrieve data efficiently. Whether you're working with simple lists or complex selections, SuperOffice provides specialized tools and APIs to meet a wide range of business needs. Here’s an overview of the key search capabilities, including **Archive Providers**, **MDO Providers**, **Selections / Find**, and **OData**, that enable you to harness your data effectively.

---

## Archive Providers for efficient and dynamic data retrieval

[Archive Providers][0] serve as the foundation for many search operations in SuperOffice. Functioning like database views, they provide a structured way to query and retrieve data.

* **Key features:**
  * Unique archive names to identify data sources.
  * Available columns for flexible field selection.
  * Dynamic joins for optimized performance, retrieving only the necessary fields.

* **Use case:** Need to retrieve all appointments, sales, or documents with specific filters? Archive Providers allow you to do this efficiently with their robust query capabilities.

* **Integration with OData:** These providers underpin OData queries, translating options like `$select`, `$filter`, and `$orderBy` into backend logic to fetch targeted data.

[Reference of all archive providers.][1]

---

## MDO Providers for tailored data lists

[Multi-Department Organization (MDO) Providers][5] specialize in managing hierarchical lists tailored to user roles and organizational structures.

* **Key features:**
  * Filtered data based on user group associations.
  * Hierarchical organization with `Heading` tables to structure data meaningfully.
  * Wide range of supported lists, such as categories, countries, currencies, and user roles.

* **Use case:** MDO Providers are perfect for situations where users need context-aware dropdown lists, like categories relevant to their department.

* **API access:** Available through APIs, allowing seamless integration into custom applications.

[Reference of all mdo providers.][4]

---

## Selections/Find for dynamic and static data sets

Selections allow users to create and save specific subsets of data for repeated use. They come in two flavors: **Dynamic** (auto-updating) and **Static** (manually managed). Both the Selection page and **Find** dialog use *special* "V2" type archive providers, a powerful tool for creating complex queries across multiple entities.

The [Selection/Find][2] operations are designed to provide a more flexible and dynamic way to search for data compared to traditional Archive Providers. They offer advanced filtering, grouping, and multi-entity support for intricate queries.

* **Selection V2 providers:**
  * Advanced filtering with multiple criteria and logical groupings.
  * Coverage for a wide range of entities, including contacts, projects, and appointments.
  * Focus on providing a streamlined way to execute complex searches across multiple entities. Users can define criteria with AND/OR logic to fine-tune their queries.

* **Use case 1:** Marketing teams can use Selections to target dynamic groups of customers based on purchase history or static lists for event invitations.
* **Use case 2:** A sales manager could use Find operations to pull a list of all customers with active projects, filtering by both customer type and project status.

The difference between **V2 Selection/Find Archive Providers** and **normal Archive Providers** lies in their **focus and flexibility**:

### Normal Archive Providers

* **Purpose:** Designed to retrieve structured data based on predefined entities and relationships. They function similarly to database views, optimized for performance by dynamically creating joins based on the fields requested.
* **Use Cases:** Ideal for simpler, operational queries where users need access to specific fields, such as pulling lists of appointments, sales, or documents.
* **Key Characteristics:**
  * Focused on operational data retrieval.
  * Limited flexibility in query customization.

### V2 Selection/Find Archive Providers

* **Purpose:** Built to handle more **complex query logic and dynamic selections**, these providers enable users to create and manage saved searches with advanced filtering and grouping.
* **Use Cases:** Suited for dynamic or static selection scenarios, like creating marketing lists, identifying key accounts, or building multi-criteria dashboards.
* **Key Characteristics:**
  * **Advanced Filtering:** Supports multi-layered criteria with logical operators (AND/OR) for intricate queries.
  * **Criteria Groups:** Allows grouping of restrictions into hierarchies for fine-grained control.
  * **Dynamic Selections:** Enables queries that update automatically when the underlying data changes.
  * **Multi-Entity Support:** Can combine multiple entity types (e.g., contacts, appointments, projects) into a single query.

### In Summary

* **Normal Archive Providers** are straightforward and performant for retrieving predefined sets of data with basic filtering.
* **V2 Selection/Find Archive Providers** are more powerful and flexible, designed for users needing advanced query capabilities, complex selection management, and dynamic, multi-criteria searches.

See the [Search Options][3] section for more details on Selections and Find operations.

---

## OData queries for modern and flexible API

SuperOffice [supports OData][6], a widely-used standard for querying data. By leveraging Archive Providers, OData queries make it easy to fetch CRM data programmatically.

* **Key features:**
  * `$select` to specify fields.
  * `$filter` for precise result sets.
  * `$top` and `$skip` for pagination.
  * `$orderBy` for sorting.

* **Use case:** Developers building custom dashboards can use OData to display real-time data, such as top-performing sales reps or overdue tasks.

---

## Summary

SuperOffice’s search capabilities are designed to cater to a variety of needs—from simple dropdown lists powered by MDO Providers to intricate dynamic queries with Archive Providers and OData. By combining these tools, businesses can access the right data at the right time, improving decision-making and operational efficiency.

See the [Search Options][3] section for more details on Selections and Find operations as a user in SuperOffice CRM.

<!-- Links -->

[0]: ../archive-providers/index.md
[1]: ../archive-providers/reference/index.md
[2]: find-selection/index.md
[3]: ../../search-options/learn/index.md
[4]: ../mdo-providers/index.md
[5]: ../lists/index.md
[6]: ../search/odata/index.md
