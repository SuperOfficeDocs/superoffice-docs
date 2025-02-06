---
uid: help-no-form-prefilled
title: Bruke ferdigutfylte felt i skjema
description: Bruke ferdigutfylte felt i skjema
keywords: skjema, felt, ferdigutfylt, forhåndsutfylling av felt, forhåndsutfylt felt, feltidentifikator
author: SuperOffice RnD
date: 03.07.2024
version: 10
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Bruke ferdigutfylte felt i skjema

Hvis du vil spare kundene for tid og problemer med å fylle ut navn, e-postadresse, telefonnummer og så videre, kan du i skjemaer legge til feltidentifikatorer og malvariabler i skjemaets koblinger/URL-adresser. Når kunden åpner et skjema, fylles eksisterende kundedata ut ved hjelp av SuperOffice-data.

En feltidentifikator er en unik ID for et spesifikt felt. Den vil ikke endre seg selv om feltets navn/etikett eller språket endres. På denne måten kan du sikre at lenker til dette feltet ikke blir brutt etter at skjemaet er publisert.

## Trinn

1. [Opprett et nytt skjema][1].

2. For hvert felt som skal være ferdigutfylt: Klikk på **Avanserte alternativer** (<i class="ph ph-gear" aria-hidden="true"></i>) for å vise **Identifikator**-feltet der du kan legge til en ID for feltet.

3. [Publiser skjemaer][2].

4. Velg **Vis med forhåndsutfylte felt** for å legge til feltidentifikatorer i koblingen/JavaScript. Det skal se omtrent slik ut:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

    Hvis ingen feltidentifikatorer legges til, har du sannsynligvis ikke lagt til disse ID-ene i feltene i skjemaet.

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
