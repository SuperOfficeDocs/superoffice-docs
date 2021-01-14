---
title: Void addAggregate(Integer groupColumn, Integer column, String name, String type, Integer decimals, Integer uniqueColumn)
path: /EJScript/Classes/StatLib/Member functions/Void addAggregate(Integer groupColumn, Integer column, String name, String type, Integer decimals, Integer uniqueColumn)
intellisense: 1
classref: 1
sortOrder: 9072
keywords: addAggregate(Integer,Integer,String,String,Integer,Integer)
---


   
**Add an aggregate function to the specified group. An aggregate function is a function which is calculated for all values for a given column in a group. This could for instance be the average response time for each category. The functions can be:**   


Count Count the number of entries.
Sum Summarize the value.
Avg Calculate the average value.
Max Calculate the maximum value.
Min Calculate the minimum value.
CountNotEmpty Count the number of entries which are not empty (NULL).


* **groupColumn:** The column used for grouping.
* **column:** The column used for the calculation.
* **name:** The name of the calculated variable in the Parser or StatResult
* **type:** The type of function.
* **decimals:** The number of decimals to use in the calculated value
* **uniqueColumn:** The value is only calculated for the rows which have a unique value in this column.


