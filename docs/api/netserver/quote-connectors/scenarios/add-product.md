---
title: quote_scenario_add_product
description: Quote connector scenario - adding a product
author: {github-id}       
so.date:
keywords: quote
so.topic: guide
---

# Scenario – adding a product

1. The user will click the **ADD** button to open the QUOTE LINE DIALOG.

2. The user enters a search value: "Glops"

    ![40][img1]

3. The client calls the ERP connector `IQuoteConnector.FindProduct`("Glops").

4. The ERP connector searches the ERP database and gets back a list of matching products.

5. The user selects a product from the result list. This gives us the ERP Product key of the product.

6. The client calls `IQuoteConnector.GetQuoteLineFromProduct( quoteContext, erpKey )` to get the full information for the product.

7. The client updates the dialog with values from the new QuoteLine.

    ![41][img2]

## The user changes the QUANTITY from 1 to 10 and hits TAB

1. The system calls ERP Connector: `IQuoteConnector.OnQuoteLineChanged( quoteline, quotecontext )` with the quoteline amount = 10 rather than 1.

2. The ERP connector receives a new discount from the ERP system: Assume now that the ERP system thinks 10% would be a good discount for this quote. So the QuoteLine.ERPDiscountPercent = 10.

3. The system calculates the other value: ERPDiscountAmount = 10% \* UnitListPrice \* Quantity.

    Since the UserValueOverride = None, this means that the ERP connector shall copy the ERPDiscountAmount into the DiscountAmount field and the ERPDiscountPercent in the DiscountPercent field.

4. Then the connector calculates the TotalPrice, the Earning percent, and the Earning amount.

5. The system updates the GUI with the new values from the quote line.

## The user changes the UnitListprice from 13.00 to 14.00

1. Again, the system calls ERP Connector: `IQuoteConnector.OnQuoteLineChanged`

2. Assume now that the ERP connector returns with ERPDiscountPercent field updated to 12.

3. The system calculates the ERPDiscountAmount.

4. The system sees that the `UserValueOverride` is still none, so both ERP values are copied to the user discount fields.

5. Then the connector calculates the TotalPrice, the Earning percent, and the Earning amount.

6. The system updates the GUI with the new values from the quote line.

## The user changes the DISCOUNT PERCENT from 12% back to 10%

1. The system sets the Quoteline. UserValueOverride = DiscountPercent

2. Again the system calls ERP Connector: `IQuoteConnector.OnQuoteLineChanged`

3. The system calculates the `ERPDiscountAmount` from the ERPDiscountPercent, but this time does not copy the ERP values to the user discount fields, since the user has entered a discount value (the UserValueOverride is not *NONE*).

4. The system calculates the `QuoteLine.DiscountAmount` from the DiscountPercent value since the UserValueOverride field is PercentField. And then the TotalPrice, the Earning percent and the Earning amount.

## The user clicks the SAVE button

The system calls the ERP Connector: `IQuoteConnector.RecalculateAlternative()` to update all the quote alternative total.

<!-- Referenced images -->
[img1]: media/image040.jpg
[img2]: media/image041.jpg
