<!-- markdownlint-disable-file MD041 -->
[!code-vb[VB](../rss-page.vb?range=71-174)]

[!code-vb[VB](../rss-page.vb?range=199-208)]

Section 2 demonstrates how to, using the query results, generate the RSS feed. Here, we have chosen to iterates over the retrieved `ArchiveListItem` collection. It extracts data values for each `ArchiveListItem` and stores those in a `ListDictionary`.

The `ListDictionary` contains details of one activity at a time. Then the following `item` sub-element values are set based on data in the `ListDictionary`:

* title
* link
* description
* pubDate
* dc:creator

As shown in the feed code segment, this is the data referred to by the `<%= _items %>` data-binding expression.

<!-- Referenced links -->
