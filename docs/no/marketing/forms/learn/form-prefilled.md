---
uid: help-no-form-prefilled
title: Bruke ferdigutfylte felt i skjema
description: Bruke ferdigutfylte felt i skjema
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Skjemaer
so.topic: howto
language: no
---

# Bruke ferdigutfylte felt i skjema

Hvis du vil spare kundene for tid og problemer med å fylle ut navn, e-postadresse, telefonnummer og så videre, kan du i skjemaer legge til feltidentifikatorer og malvariabler i skjemaets koblinger/URL-adresser. Når kunden åpner et skjema, fylles eksisterende kundedata ut ved hjelp av SuperOffice-data.

1. [Opprett et nytt skjema][1].

2. For hvert felt som skal være ferdigutfylt: Klikk på **Avanserte alternativer** ![icon][img1] for å vise **Identifikator**-feltet der du kan legge til en ID for feltet. Dette er en unik ID for dette feltet, og endres ikke selv om feltnavnet/etiketten eller språket endres. På denne måten kan du sørge for at koblinger til dette feltet ikke brytes etter publisering av skjemaet.

3. [Publiser skjemaer][2].

4. Velg **Vis med forhåndsutfylte felt**for å legge til feltidentifikatorer i koblingen/JavaScript.
    Det skal se omtrent slik ut:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

5. Kopier koblingen eller JavaScriptet til et tekstredigeringsprogram eller lignende.

6. Skriv inn de relevante [malvariablene][3] mellom to hakeparenteser ETTER likhetstegnet:
    ```text
    ...formId=F-FH2K4Vru&field-name-1=[[customer.name]]&field-mail=[[customer.email]]
    ```

7. Kopier hele koblingen eller skriptet og publiser.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../request/reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/cog-wheel.png
