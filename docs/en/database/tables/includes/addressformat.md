<!-- markdownlint-disable-file MD041 -->
### LabelLayout/LabelLayout2

In SuperOffice 6, we replaced the ExtraFlags formatting of labellayout with the two fields LabelLayout and LabelLayout2. We use some special characters to separate the template variables:

\[ \] is to add a space between the template variables.

\[\\n\] - is to add a new line.

\|x\| - Sometimes only the address part is needed, so a special delimiter will be used in the template string to tell where the name/title/… ends and the
address begins.

### Automatic copy street address to postal address

You would in some cases like that the Street address is automatically copied to the postal address, and this is done by adding the following bitmask to the different \*\_zip fields:

This example will automatically copy of street address for the Netherlands, which uses a German address format (check this in the admin client – lists – country).

The queries that change this:

Open ISQL, HakonClient, or another tool like it.

```SQL
Select * FROM addressformat WHERE name LIKE 'Ger%'
```

![address format -screenshot][img1]

To copy street address to postal address, and the reverse is done by updating the following in table `AddressFormat`:

```SQL
UPDATE addressformat SET address1_zip =1024 WHERE addressformat_id=9
UPDATE addressformat SET address1_zip =2048 WHERE addressformat_id=10

UPDATE addressformat SET city_zip =1025 WHERE addressformat_id=9
UPDATE addressformat SET city_zip =2049 WHERE addressformat_id=10

UPDATE addressformat SET zip_zip =1026 WHERE addressformat_id=9
UPDATE addressformat SET zip_zip =2050 WHERE addressformat_id=10
```

To get it to look up the city or zip code information from the table `ziptocity`:

```SQL
UPDATE addressformat SET address1_zip = 0 WHERE addressformat_id=9
UPDATE addressformat SET address1_zip = 0 WHERE addressformat_id=10

UPDATE addressformat SET zip_zip = 257 WHERE addressformat_id=9
UPDATE addressformat SET city_zip = 514 WHERE addressformat_id=9

UPDATE addressformat SET zip_zip = 258 WHERE addressformat_id=10
UPDATE addressformat SET city_zip = 513 WHERE addressformat_id=10
```

> [!NOTE]
> `addressformat_id = 9`  have the Street address information (`atype_idx = 2`), and `addressformat_id=10` have the postal address information (`atype_idx=1`). To make them copy between the text entered (only when adding a new customer) you update the `xxx_zip` value. If you take the number 1024 as HEX, it’s 400, 2048 in HEX is 800, and this tells the CRM client to copy between these lines.

The docs describe each field in table `AddressFormat`, but you need to know some of our internal resources (lead text to the address lines).

| Resource ID | English name |
|---|---|
| 14000 | Street Address: |
| 14001 | Postal Address: |
| 14002 | Postcode/City |
| 14003 | Country: |
| 14004 | Address: |
| 14005 | Address 1: |
| 14006 | Address 2: |
| 14007 | Address 3: |
| 14008 | State/Zipcode: |
| 14009 | City: |
| 14010 | County/Pcode: |
| 14011 | P.O. Box: |
| 14012 | Province/Pcode: |
| 14013 | City/Pcode: |
| 14014 | Postcode: |

<!-- Referenced images -->
[img1]: media/addressformat.png
