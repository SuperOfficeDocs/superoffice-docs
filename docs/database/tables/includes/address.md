<!-- markdownlint-disable-file MD041 -->
### Values needed to access the address table

This table must contain special values that would be difficult to guess correctly. These are listed below with a description of how to use them.

 | Address type | ID | Comment |
 |---|---|---|
 | Contact | 1 | 0x0000 |
 | Person | 16384 | 0x4000 |

 | SubAddress type | ID | Comment |
 |---|---|---|
 | Postal | 1 | 0x0001 |
 | Street | 2 | 0x0002 |
 | Private | 3 | 0x0003 |

For example: A person’s private address will have Address type Person 16384 + Subtype private 3 = 16387 as `atype_idx` in the address table.
Use a bitwise OR to get the final address type value.

**New for quote:**

 | Address type | ID | Comment |
 |---|---|---|
 | Billing address | 8196 |
 | Shipping address | 8197 |
