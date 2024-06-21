---
uid: help-da-automation-script-create
title: Opret et script
description: Opret et script
author: Bergfrid Dias
date: 03.23.2023
keywords: script, makro
topic: howto
language: da
---

# Opret eller rediger et script

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Vælg **CRMScript**, og gør et af følgende:
    * Sådan opretter du en ny makro: Klik på **Ny makro**.
    * Sådan redigeres en eksisterende makro: Klik på makronavnet.

1. Under fanen **Information** redigerer eller indtaster du data om scriptet:

    * **Mappe**: Vælg den mappe, hvor du vil gemme scriptet.
    * **Navn**
    * **Beskrivelse**
    * **Include-navn**: Et entydigt navn til scriptet, der bruges til at inkludere dette script i et andet script.
    * **Nøgle**: Nøglen anvendes sammen med funktionen "action=parse" på kundesiderne, så du kan køre scripts og oprette scriptbaseret funktionalitet i SuperOffice Customer Centre. Nøglen forhindrer vilkårlige scripts i at kunne køres fra kundesiderne.
    * **Vis resultat af scriptkørsel som HTML**

1. På fanen **Script** kan du indtaste selve scriptet.

1. (valgfrit) Klik på **Stage** for gemme scriptet på en midlertidig placering. Det giver dig mulighed for selv at teste ændringerne.

1. Klik på **Kør script** for at udføre scriptet. Resultatet vises i fanen **Resultat** .

1. Klik på **OK**.

## Tilknyttet

* [Om CRMScript][1]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/index.yml

<!-- Referenced images -->
