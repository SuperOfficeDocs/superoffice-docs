---
title: Numeric and date data, culture settings
uid: quote_templates_culture
description: Numeric and date data, culture settings in quote templates
author:
keywords:
topic: concept
date:
---

# Numeric and date data, culture settings

Numeric tags that have decimal values (all amounts and percentages) have 4 variants of the tag, with different formats. The decimal separator is always according to the selected language/culture (drop-downs in the **Send Quote** and **Order Confirmation** dialogs). The number of decimals is either the default or 0, 2, or 5 depending on the tag name suffix. Thus, line/totalPrice:2 will force 2 decimals, while line/totalPrice will have whatever the default number of decimals is for the culture.

Date and time tags have a similar set of variants. The tag alone will produce a "short date", with the following variants  also available:

* :ShortDate
* :ShortTime
* :ShortDateTime
* :LongDate
* :LongTime
* :LongDateTime

The actual formatting (day/month order, and so on) is always according to the selected culture.

Culture is selected by the user in the **Send Quote** and **Place Order** dialogs. The language chosen there directs the system to the correct template subfolder (English template vs. German). It also sets the .NET Culture used for the numeric and date formatting. However, sometimes the culture is not completely specified, such as German – do you mean Germany, or Switzerland, with different number formats‌.

In such cases it is possible to include the merge field Culture: in the template, specifying a .NET culture code, taken from [System.Globalization.CultureInfo][1]. For Switzerland, use "Culture:de-CH", and you will get the Swiss number formats regardless of the user's choice. This implies that such a culture code should be embedded in a special template called *Offer to Swiss customers* or something similar. Arabic-Kuwait (ar-KW) will give you 23 ﺳﺒﺘﻤﺒﺮ, 2013 as the quote/sent:LongDate.

> [!NOTE]
> Do not use the *Table of Language Culture Names, Codes, and ISO Values Method* of the [C++ AppConfig object][2] as a reference, there are slight differences.

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
[2]: https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)
