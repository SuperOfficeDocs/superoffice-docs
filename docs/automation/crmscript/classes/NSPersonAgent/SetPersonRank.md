---
title: Bool SetPersonRank(Integer personId, Integer desiredRank)
path: /EJScript/Classes/NSPersonAgent/Member functions/Bool SetPersonRank(Integer p_0, Integer p_1)
intellisense: 1
classref: 1
sortOrder: 4924
keywords: SetPersonRank(Integer,Integer)
---


Directly set the rank field of a person record, adjusting all other person records under the same contact as needed.\<para/>This call may affect multiple records, potentially all person records belonging to one contact.\<para/>You must have write access for to affected records for this method to succeed.



* **personId:** Id of person to change
* **desiredRank:** Desired rank to set, legal values are from 1 to the number of person records on this contact. Out of range values will be moved to the closest valid value and processed.
* **Returns:** If movement occurred, or the person already had exactly the desired rank value, then the return value will be true. If movement did not occur, for any other reason, the return value is false.


