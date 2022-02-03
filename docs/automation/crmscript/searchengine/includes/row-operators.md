| Value          | Logical operator | Expression  | Result                                     |
|----------------|:----------------:|:-----------:|--------------------------------------------|
| OperatorAnd    | AND              | A && B      | Only rows matching both conditions         |
| OperatorNotAnd | NAND             | !(A && B)   | Rows matching 0 or 1 condition but not both |
| OperatorOr     | OR               | A \|\| B    | Rows matching either condition (or both)   |
| OperatorNotOr  | NOR              | !(A \|\| B) | Only rows matching no conditions |