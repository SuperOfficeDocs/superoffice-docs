<!-- markdownlint-disable-file MD041 -->
### How the selections in a combined selections should be put together

| combinationType | ID | Comment |
|---|---|---|
| Unknown | 0 | Combination type is unknown/indefined |
| SubtractRightFromLeft |  1 | All of left, except where it overlaps with right |
| SubtractLeftFromRight | 2 | All of right, except where it overlaps with left |
| Intersect | 3 | Those present in left AND right only |
| XOR | 4 | Those present in left or right, but not both |
| Union | 5 | All, but no duplicates for those present in left and right |
