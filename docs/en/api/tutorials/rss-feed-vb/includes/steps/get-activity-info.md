<!-- markdownlint-disable-file MD041 -->
[!code-vb[VB](../rss-page.vb?range=1-69)]

[!code-vb[VB](../rss-page.vb?range=176-197)]

Section 1 shows how the parameters required by `GetArchiveListByColumns` are created (the columns to be included in the selection). It also defines the search restrictions and the entities to be included in the search.

Next, an `IArchiveAgent` object is retrieved using the `AgentFactory`. `GetArchiveListByColumns` method is then invoked to get the activity information.

<!-- Referenced links -->
