---
uid: help-en-create-companies-in-companies-tab
title: Create companies in companies tab
description: Create companies in companies tab
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# The Company tab

1. Click **New** on the top bar and select **Company**.  
    An empty company card opens. <!-- Fix reuse ID=a3 -->

    ![icon](../media/Chap03-contacts/18-chap3-NewCompany.bmp)

    Type in the name of the company in the field at the top of the **Company** tab. ***Company name*** is shown in red, indicating that this field is mandatory. If you try to create a company with the same, or similar, name as an existing company, the **Duplicates** dialog opens. [!include[For more info](../../includes/see-duplicates.md)]

2. Enter the required information in the other fields.
    <!-- Fix reuse ID=a2 -->
    [!include[Note - default values](../../includes/note-default-values.md)]

    1. If, for example, the company is an organisation with several departments, you can specify a department in the **Department** field.
    2. The address fields available will depend on which country is selected. The default is the country that your organisation belongs to. Having selected the country, the correct address format for the remaining address fields will be inserted automatically in the **Company** tab.
    3. In the **Zip code** field, enter the company’s postal code. If you enter a postal code that is defined in the SuperOffice database, the city name is filled in automatically if it is empty. You can also type in the city name in the **City** field and a postcode will be proposed in the postcode field.
    4. The **Phone** field brings up a table with **Telephone** and **Description** columns. Enter a phone number and a brief description of what sort of number it is, for example, *Switchboard*. You can enter several phone numbers. Click outside the table when you have finished, or press **TAB** until the table closes.
    5. In the **Fax** field, enter a fax number in the same way as for **Telephone**.
    6. In the **Web site** field, enter the address of the company’s homepage on the Internet in the same way as for **Telephone**.
    7. In the **E-mail** field, enter the company's e-mail address in the same way as for **Telephone**.
    8. In the **Our Contact** field, your name will be displayed automatically. Clicking the arrow brings up a list box where you can choose the name of someone else from your organisation.
    9. In the **Category** field, select the category to which the company belongs, from a predefined list of categories. Click the arrow to show the category list. This field is mandatory – if you leave it blank you will not be able to save the company.
    10. The **Code** field automatically suggests a code for the company that you are creating (after you click **Save**). The code is based on the company name. However, you can enter a different code.
    11. In the **Number** field, SuperOffice CRM automatically enters the next available company number. The default setting is 10001 for the first company number and the value increases by 1 for each new company. You can change this default setting in SuperOffice Settings and maintenance.
    12. In the **VAT No.** field, type in the company's VAT number or similar number.
    13. In the **Business** field, select from a list of different predefined types of business. Click the arrow and choose the business that best matches the company you are creating. This is a mandatory field and must therefore be filled in.
    14. In the **Main contact** field, select the contact who should be the main contact for this client. You need to add contacts to the company first.
    15. At the bottom right of this tab, three of the fields from the **More** tab may be displayed, as defined in SuperOffice Settings and maintenance. The fields displayed can vary from user group to user group.
    16. The bottom left corner of the company card contains two checkboxes: **Stop** and **No Mailings**.
        * Check **Stop** if you want to inform associates that they should pay particular attention to a certain company. A stop sign is displayed on the company card. It may also be useful to insert a note informing your associates why this company is marked with a stop. It is only possible to put a check in this field in edit mode.
        * Check **No Mailings** if you do not want the company to receive direct mailings. It is only possible to put a check in this field in edit mode.

3. Click **Save** to save the information entered, or click the **More** tab to enter further information about the company.

## Duplicates

If you try to enter a company that is similar to one that is already in SuperOffice CRM, the **Duplicates** dialog appears, asking you if you want to continue working with the current record or go to one of the records listed at the bottom of the dialog. This is to prevent you from unintentionally registering an existing company. See [Duplicates](../key-functions/Duplicates.md).
