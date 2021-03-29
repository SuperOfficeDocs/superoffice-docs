---
title: crmscript_ref_Knowledge_buildExternalEntryURLWithParser_Integer_kbId_Parser_parser
description: Knowledge.buildExternalEntryURLWithParser(Integer kbId, Parser parser)
intellisense: Knowledge.buildExternalEntryURLWithParser
sortOrder: 456
keywords: buildExternalEntryURLWithParser(Integer,Parser)
so.topic: reference
---

This function builds an url to the customer center to view a knowledgebase entry.
The function fetch the baseUrl from the registry table with reg\_id 61. Then it parses the url with the input parser, and returns the url.


* **Integer:** kbId, The id of the knowledgebase entry to link to.
* **Parser:** parser, The parser to use to parse the url
* **Returns:** the url to the knowledgebase entry.


