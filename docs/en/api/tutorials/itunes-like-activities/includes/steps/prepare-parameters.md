<!-- markdownlint-disable-file MD041 -->
Section 1 in the code shows how the parameters required by the `GetArchiveListByColumns` method are created:

* the columns to be included in the selection
* the search restrictions
* the order in which the results should be sorted
* the entities to be included in the search

[!code-csharp[CS](../itunes-setdatagrid.cs?range=1-45)]

Next, an `ArchiveAgent` object is created. Then the `GetArchiveListByColumns` method is invoked to get the activity information.
