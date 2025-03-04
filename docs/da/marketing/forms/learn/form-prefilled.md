---
uid: help-da-form-prefilled
title: Brug af forudfyldte felter i formularer
description: Brug af forudfyldte felter i formularer
keywords: formular, forudfyldt, forudfyldte felt, felt-id, feltidentifikator
author: SuperOffice RnD
date: 03.04.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Brug af forudfyldte felter i formularer

For at spare dine kunder tid og besvær med at udfylde deres navn, e-mail-adresse, telefonnummer osv. I formularer kan du tilføje felt-id'er og skabelonvariabler til formularlinkene/URL'erne. Når kunden åbner en formular, udfyldes eksisterende kundedata ved hjælp af SuperOffice-data.

En feltidentifikator er en unik ID for et specifikt felt. Den vil ikke ændre sig, selvom feltets navn/etiket eller sproget ændres. På denne måde kan du sikre, at links til dette felt ikke bliver brudt efter at formularen er blevet offentliggjort.

## Trin

1. [Opret en ny formular][1].

2. For hvert felt, der skal udfyldes på forhånd: Klik på **Avancerede indstillinger** (<i class="ph ph-gear" aria-hidden="true"></i>) for at vise feltet **Identifikator**, hvor du kan tilføje et ID i feltet.

3. [Udgiv formularer][2].

4. Vælg **Vis med forudfyldte felter** for at føje felt-ID'er til linket/JavaScript. Det skal se nogenlunde ud som følger:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

    Hvis der ikke tilføjes felt-ID'er, har du sandsynligvis ikke føjet disse ID'er til felterne i formularen.

5. Kopier linket eller JavaScript til et tekstredigeringsprogram eller lignende.

6. Angiv de relevante [skabelonvariabler][3] mellem to kantede parenteser EFTER lighedstegnet:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=\[\[customer.name\]\]&field-mail=\[\[customer.email\]\]
    ```

7. Kopier hele linket eller JavaScript, og udgiv det.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../request/reply-templates/learn/template-variables.md
