<!-- markdownlint-disable-file MD041 -->
### Calendar information regarding which days are to be set in red is stored in a single table

This table is used to mark specific days in the calendar as red. The format of some columns in this table needs further explanation. For every month there will be a row with reddate = month 1st midnight. This should contain a bitmap of all red days for this month in the reds column. This 32-bit bitmap is computed using least significant bit as 1st of month and 1 as red, 0 as not red.

**Example:**

September 1995. Sundays are 3rd, 10th, 17th and 24th.

Let’s say that the 15th and 23rd are to be marked red in addition to Sundays. This results in the following:

```text
Sundays
1st.................................32nd
  00100000 01000000 10000001 00000000
```

Then extra red letter days

```text
00000000 00000010 00000010 00000000
```

If we OR these together we get the correct bitmap

```text
00100000 01000010 10000011 00000000
```

Now LSB is to the left, and we split this into 8-bit portions to make it easier to manipulate. First, move binary LSB to the right as usual

```text
00000100 01000010 11000001 00000000
```

Then type this number in Windows Calculator’s scientific mode using binary numbers. Then click decimal mode to get the value

```text
12665348
```

So to set RedLetterDay for September 1995, do as follows:

Get unique ID for RedLetterDay table (id = 27 in Sequence), and increment.

```SQL
INSERT INTO RedLetterDay (redletterday_id, reddate, country_id, reds) VALUES (next_id, 809913600, mycountry, 12665348)
```

This will make September 3, 10, 15, 17, 23, 24 red in the calendar.
