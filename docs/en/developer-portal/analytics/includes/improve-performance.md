<!-- markdownlint-disable-file MD041 -->
Leverage our [best practices for online app development][2] to both boost your application's performance and reduce its API usage. Both [caching][3] and [search][4] have a huge impact.

Additional columns from SuperOffice version 10.5.1

| Column | Description |
|---|---|
| NsApiSlow | True if API call is higher than treshold. You will find tresholds for methods in our documentation. |
| providerName | The [archive provider][5] used in the request (e.g., contact, sale, project). Knowing the provider helps identify the data source and optimize queries accordingly. |
| columns | Specifies which columns are requested from the archive provider. Best practice: Limit the number of columns to only those needed to reduce payload size and improve performance.  |
| restriction | Filters applied to the search query. Tip: Use indexed fields and avoid complex expressions to enhance query speed. |
| pageSize| Number of items returned per page. Default is 1000.  |
| page | The page number of the result set. Useful for paginated queries. |
| sortOrder | Sorting applied to the result set, if any. Note: Sorting on indexed fields is faster. Avoid sorting on calculated or non-indexed fields. |
| itemCount | Number of similar API calls made in the past 24 hours. Can be used to identify high-traffic endpoints and optimize caching or batching strategies. |
| url | The full URL of the API request. Useful for debugging and reproducing queries. |

<!-- Referenced links -->
[2]: ../../best-practices/index.md
[3]: ../../best-practices/index.md#caching
[4]: ../../best-practices/index.md#searching
[5]: ../../../api/netserver/archive-providers/reference/index.md
