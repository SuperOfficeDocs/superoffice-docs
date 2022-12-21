<!-- markdownlint-disable-file MD041 -->
Actor type within the ERP system, related but not identitcal to SuperOffice Entity type

This enumeration is used in: ErpConnectionActorType.ActorTypeErp; ErpExternalKey.ActorType

| ActorTypeErp or ActorType | Description |
|---|---|
| 0 | Unknown - used when initializing |
| 1 | Erp Customer |
| 2 | Supplier or Vendor |
| 3 | Both customer and supplier |
| 4 | Contact person |
| 5 | Project |
| 6 | Employee, often mapped to associate |
| 7 | Sale |

Actor type within the CRM, system, a subset of the SuperOffice Entity types

| ActorTypeCrm | Description |
|---|---|
| 0 | Unknown - used when initializing |
| 1 | Crm Customer |
| 2 | Person |
| 3 | Project |
| 4 | Sale |
