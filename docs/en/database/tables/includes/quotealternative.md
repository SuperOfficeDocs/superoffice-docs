<!-- markdownlint-disable-file MD041 -->
Has a pre-calculated value been overriden in a QuoteAlternative or QuoteLine, and in that case what & how?

used in: QuoteAlternative.UserValueOverride; QuoteLine.UserValueOverride

| UserValueOverride | Comment |
|---|---|
| 0 | Discount data is from the ERP system and has not been overridden |
| 1 | The Total amount has been overridden; all other fields should be recalculated |
| 2 | The discount percentage has been overriden; all other fields should be recalculated |
| 3 | The discount amount has been overridden; all other fields should be recalculated |
| 4 | The earning percent has been overridden; all other fields should be recalculated |
| 5 | The earning amount has been overridden; all other fields should be recalculated |
