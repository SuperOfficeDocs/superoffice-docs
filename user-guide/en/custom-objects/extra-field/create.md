---
uid: help-en-extra-fields-create
title:  Define extra fields
description: Define extra fields
author: SuperOffice RnD
so.date: 06.29.2022
keywords: extra field, custom field
so.topic: help
language: en
---

# Define extra fields

Once you have created an extra table, you need to set up fields in the table, to allow you to subsequently input data (entries) into the table. You can also create extra fields in standard tables.

> [!TIP]
> Extra fields can for instance be used as search criteria and columns in sales in SuperOffice CRM.

To create extra fields in tables:

1. Select ![icon][img1] **System settings** > **System design** > **Tables**.
2. Browse to the table you want, point at the table name and click ![icon][img2]. The **New extra field** screen opens.
3. Select a field type in the **Type** list box.
4. Click **OK**. The **Field properties** screen appears.
5. In the **Field properties** screen, enter data about the new field. The available properties depend on the type of extra field (specified in step 4).
6. Click **OK** to save, and then **Restart NetServer**.

## Field properties

| Field | Description |
|---|---|
| Cannot be empty | If you check this option, this field becomes mandatory. |
| Choose from list box | If the field is connected to an extra table, select this option to display a list of table values. |
| Choose values from list | If this option is checked, the field becomes a list box. The options in the list will be the text strings entered in the text box. There is one line per option. |
| Create index | Specify if the field is to be indexed or not. It is quicker to search for data in indexed fields. |
| Database field | The name the column will have in the database. This name must be unique in this table. In addition, the column name must be a single word, containing only underscores, letters from a to z or numbers, and must begin with "x_". You can only specify this name when the field is created; it cannot be changed later on. |
| Decimal places | The number of decimal places that are allowed in a number. |
| Default value | The default value will be used for this field. |
| Description | The default description. |
| Display value | Specify if to display the value or not. |
| External | If this option is checked, the field will be available from a customer centre. This is only relevant for default tables, since extra tables are always displayed in customer centres. |
| Header for list | This field is used to specify a header for these entries when they are displayed as "sub-entries" in a list. In our example, this means the name of the new tab in the **View contact** screen, so we enter "Computers" here. |
| Hide function buttons | (relations) Select this option to hide the function for adding new entries to relation tables. |
| Hide the field | Specify if to display the field or not. |
| Keep HTML tags | (text) Select this option to include the HTML tag in the text. |
| Name | The name of the field. In our example, this will be the names in the list in the introduction to this chapter. |
| Number of units | (time span) Enter the maximum number of units for the "largest" selected time unit. Example: If you have selected hours and minutes, and enter "4", a maximum of 4 hours can be selected, while minutes go to 60. Similarly for days and hours, a maximum of 4 days can be selected, while hours go to 24. |
| Only allow leaf nodes for hierarchical list boxes | (extra table relation) Specify if only the lowest node in a hierarchy can be selected by the user. |
| Position | Specifies this field's position among the other fields in lists. |
| Search operator | Select the search operator to use for this field. |
| Show in table | If this option is checked, this field is displayed as a column in screens where several entries are displayed in a table. |
| Show one-to-many relations | If you have selected the **Contact relation**, **Company relation** or **Request relation** field types and want to have displayed a tab containing data from this table in the contact, company or request screens, you can check this field. |
| Table | Specify which table the field belongs to. |
| Target table | Specify which table should be used. |
| Text area /Height | Select this options to specify the height (number of lines) of the text field. |
| Type | Displays the field type you have selected. |
| Update null values now | Check this option if you want to replace all null values (empty fields) in the database with the default value. Note that this operation can take a while. |
| URL | Enter the URL of the dynamic link here. |
| Use active user as default value | If this option has been checked, the field's value is set as the current user as default. In our example, this could be relevant for the "Registered by" field. |
| Use current date/time as default value | If this option has been checked, the field's value is set as the current date/time as default. In our example, this could be relevant for the "Registered date" field. |
| Use days / Use hours /Use minutes | Select the time units you want to use in the time span field. |
| Use default value | If this option is checked, the field is assigned a default value unless otherwise specified. |
| View in relational choosers | If the current table has a relation with another table (extra table relation), select this option to make this field available as a search field. Example: You have created an extra table called "Products" with an extra table relation to the **Requests** table. In this way you can search for and add products in the **Extra fields** tab when creating new requests. By selecting **View in relational choosers** for specific fields in the "Products" table, these fields will be available as search fields in the **Extra fields** tab. |

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/icons/globalmenu-settings-small.png
[img2]: ../../../media/icons/service/btn-newfield.png
