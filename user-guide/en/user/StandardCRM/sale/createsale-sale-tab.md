---
uid: help-en-createsale-sale-tab
title: CreateSale Sale-tab
description: CreateSale Sale-tab
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Enter information in the Sale tab

1. Click **New** on the top bar and select **Sale**.  
    An empty sale card opens.
    <!-- Fix reuse ID=a2 -->
    ![icon](../media/Chap07-sale/54-chap7-sale-new.bmp)
2. Type in the name of the sale in the field with a red underline. This field is mandatory.
3. Enter the required information in the other fields.  
    <!-- Fix reuse ID=a3 -->
    1. Enter the amount of the sale.

    2. Select the currency of the sale (if this option is activated).

    3. In the **Company** field, enter the company the sale is to be linked to.

    4. Enter a contact at the company, if relevant, in the **Contact** field.

    5. Enter any project you want to link to the sale in the **Project** field.

    6. You can enter a more detailed description of the sale in the large text box on the left.

    7. At the top right of the **Sale** tab, you can enter an estimated amount for the sale.

    8. The **Owner** field automatically displays the user currently logged in. You can select a different user if required.

    9. Enter the sale type in the **Sale type** field. Click the arrow to display a list of available sale types. These are defined in SuperOffice Settings and maintenance.

        > [!NOTE]
        > Some sale types are linked to a [sales guide](sales-guide.md). If you switch sale type, the associated sales guide also disappears. Any follow-ups and documents you have created in connection with the sales guide will remain on the **Activities** section tab in the diary. If you later switch back to the original sale type, the link between the follow-ups/documents and the sales guide is restored.

    10. In the **Stage** field, enter the sale's current stage:
        * If the sale type for the sale does not have any stages linked to it, the sale has the status **Open**. If you click the arrow, you can set the sale to **Sold** and **Lost**. The fields below then change so you can enter the date, competitor and reason for the sold/lost sale. See [Stalled, sold and lost sales](Status-of-sale-sold-and-lost.md).

        * If the sale type for the sale does have stages linked to it, you can click the arrow to select a sale stage. A sale type with different sale stages can be linked to a sales guide and is predefined in SuperOffice Settings and maintenance. See [Sales guide](sales-guide.md).

            > [!NOTE]
            > When you change a stage, for example from **First meeting** to **Quotation**, the first stage in the **Sales guide** section tab is marked as completed, with a tick.

    11. To the right of the **Stage** field is a percentage that indicates the probability of the sale being successful at this stage. This is linked to the stage and is specified in the SuperOffice Settings and maintenance. You can however change this manually in SuperOffice CRM if you wish.

    12. You can check the **Stalled** box to indicate that the sale has stalled. This might be the case if, say, the customer has decided to wait until next year before purchasing. See [Stalled, sold and lost sales](Status-of-sale-sold-and-lost.md).

        > [!NOTE]
        > The fields below change if you have checked **Stalled**. **Next activity** is changed to **Re-open date**, where you can enter a date for when the sale should be reopened, and **Source** is changed to **Reason (stalled)**, where you can enter why the sale cannot progress at the moment. If you have marked the sale as stalled, the **Appointment** dialog is displayed when you click **Save**. Here you can set up a future meeting or phone call to follow up the stalled sale.

    13. Enter an estimated sale date in the **Sale date** field. If you want to change the estimated sale date, click the arrow next to the date and select a new one in the calendar that appears.

    14. The **Next activity** field shows the date of the next follow-up linked to the sale (the oldest uncompleted follow-up). If this date is prior to today, it is shown in red.

    15. Enter the source of the sale in the **Source** field. Click the arrow to display a list of available options.

    16. Click in the **Visible for** field and a list is displayed allowing you to choose whether the sale will be visible to all users, private (i.e. visible only to the user defined as owner) or visible to all users in the user group that the owner belongs to.

    17. If the sale has the status **Sold** or **Lost**, you can check the **Completed** box.

    18. If you check the **Publish** box, the sale is visible to external users in Audience (requires a separate licence).
4. Click **Save** to save the information entered, or click the **Details**, **Links** or **Note** tabs to enter further information about the sale.
5. When you have entered the required information in all the tabs, click **Save** to save it. You have now created a sale card for the new sale.

## What would you like to do now?

[Enter information in the Details tab](details-tab.md)

[Enter information in the Links tab](CreateSale-LinksTab.md)
