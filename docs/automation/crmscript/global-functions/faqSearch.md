---
description: Parser faqSearch(Integer root, Integer access, String message, Parser p, Integer max)
path: /EJScript/Global functions/Parser faqSearch(Integer root, Integer access, String message, Parser p, Integer max)
intellisense: 1
langref: 1
keywords: faqSearch(Integer,Integer,String,Parser,Integer)---


This method will do a faq search, using the same search engine as the customer pages do. It will fill the parser with the result. The following parser variables are available (sorted, where the top most is the best hit):




###Category parser array:###
faq.categoryId - the id of the matching category
faq.categoryName - the name of the matching category
faq.categoryLink - a url to the customer pages to the matching category
faq.categoryDescription - the decription of the matching category
faq.categoryScore - the score of the matching category, given in percentage with 2 decimals precision



###Entry parser array:###
faq.entryId - the id of the matching entry
faq.entryName - the name of the matching entry
faq.entryLink - a url to the customer pages to the matching entry
faq.entryQuestion - the question part of the matching entry
faq.entryScore - the score of the matching entry, given in percentage with 2 decimals precision


* **Integer:** root the id of the category folder where you want to search from. -1 for the whole tree
* **Integer:** access indicates what the minimum access one need for this search. See below for access codes
* **message:** String the words to search for. It will search for words containing one or more of these. Better hits gets better score
* **p:** A parser with a script for checking further access. Use an empty parser if you do not want this. The script is in the same format as used in the GUI
* **max:** Integer indicating the max number of hits




###Access codes:###
      AccessPrivate = 1
      AccessInternal = 2
      AccessRegisteredCustomers = 3
      AccessPublic = 4


