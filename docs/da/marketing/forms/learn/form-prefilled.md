---
uid: help-da-form-prefilled
title: Brug af forudfyldte felter i formularer
description: Brug af forudfyldte felter i formularer
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formularer
so.topic: howto
language: da
---

# Brug af forudfyldte felter i formularer

For at spare dine kunder tid og besvær med at udfylde deres navn, e-mail-adresse, telefonnummer osv. I formularer kan du tilføje felt-id'er og skabelonvariabler til formularlinkene/URL'erne. Når kunden åbner en formular, udfyldes eksisterende kundedata ved hjælp af SuperOffice-data.

1. [Opret en ny formular][1].

2. For hvert felt, der skal udfyldes på forhånd: Klik på **Avancerede indstillinger** ![ikon][img1] for at vise feltet **Identifikator**, hvor du kan tilføje et ID i feltet. Det bliver til et entydigt ID for dette felt og ændres ikke, feltnavnet/-etiketten eller sproget ændres. På den måde kan du sikre, at links til dette felt ikke brydes efter udgivelse af formularen.

3. [Udgiv formularer][2].

4. Vælg **Vis med forudfyldte felter** for at føje felt-ID'er til linket/JavaScript.
    Det skal se nogenlunde ud som følger:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

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

<!-- Referenced images -->
[img1]: ../../../../../common/icons/cog-wheel.png
