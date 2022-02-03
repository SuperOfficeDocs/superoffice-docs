---
title: Convert legacy dynamic date ranges
uid: convert_dynamic_date_ranges
description: Converting to new dynamic date ranges
author: {AnthonyYates}
keywords: NewSelection, Selection, Find, Date
so.topic: howto
# so.envir:
so.client: web
---

# Converting to new dynamic date ranges

When [removing old date operators and replacing them with new][1], users are already having existing selections based on old operators. These selections should continue to give users the same result, which means existing criteria needs to be replaced by the equivalent new criteria.

> [!NOTE]
> The examples assume that today is 18.03.2020.

| Old criteria | Examples | New criteria |
|---|---|---|
| Last week | Monday 09.03.2020 - Sunday 15.03.2020 | Previous period 1 week |
| This week | Monday 16.03.2020 - Sunday 22.03.2020 | This period week |
| Next week | Monday 23.03.2020 - Sunday 29.03.202 | Next period 1 week |
| Last month | 01.02.2020 - 29.02.2020 | Previous period 1 month |
| This month | 01.03.2020 - 31.03.2020 | This period month |
| Next month | 01.04.2020 - 30.04.2020 | Next period 1 month |
| Last Quarter | 01.10.2019 - 31.12.2019 | Previous period 1 quarter |
| This Quarter | 01.01.2020 - 31.03.2020 | This period quarter |
| Next Quarter | 01.04.2020 - 30.06.2020 | Next period 1 quarter |
| This half | 01.01.2020 - 30.06.2020 | This period 6 months |
| This year | 01.01.2020 - 31.12.2020 | This period year |

Confused? Read our [in-depth guide to the new operators][2].

## Additional requirements

The new dynamic date criteria are going to be released as a part of New Selection. As this functionality is going to be deployed to customers by enabling a feature toggle, a convert during db upgrade is not a possible solution.

Users reading old selections requires convert of dynamic date range on the fly when NewSelection = true.

When feature toggle for New Selection is removed, a db step can convert remaining selections automatically.

<!-- Referenced links -->
[1]: operators.md
[2]: date-range-as-criteria.md
