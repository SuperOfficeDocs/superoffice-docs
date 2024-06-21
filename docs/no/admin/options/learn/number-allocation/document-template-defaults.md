---
uid: help-no-document-template-defaults
title: Standardverdier for nye dokumentmaler
description: Standardverdier for nye dokumentmaler
author: Bergfrid Dias
date: 03.24.2023
keywords: tall, teller
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Standardverdier for nye dokumentmaler

Hvis du vil, kan du angi standardverdier for nye dokumentmaler. Dette betyr at verdien i feltet **Vår ref.** i bildet Dokument øker med 1 hver gang denne malen brukes. Hvis det ikke er merket av for **Opprett nye tellere automatisk for nye dokumentmaler**, brukes samme teller på alle dokumentmaler, slik at verdien i **Vår ref**-feltet øker med 1 hver gang en mal brukes, uavhengig av hvilken mal det er.

> [!NOTE]
> On feltet **Vår ref.** i bildet Dokument fungerer som tellerfelt, avhenger av om {snum} malvariabelen er angitt for den aktuelle malen. Dette defineres i Lister-bildet: Klikk på **Dokumentmal**, dobbeltklikk på dokumentmalen under **Forekomster**, og rediger deretter feltet **Vår ref (standard)** i **Rediger forekomst**-dialogboksen.

## Slik angir du at nye dokumentmaler skal få egen teller

1. [!include[Go to Options](../includes/open-options.md)]

2. Velg fanen **Nummertildeling**.

3. Nederst i fanen velger du **Opprett nye tellere automatisk for nye dokumentmaler**.

4. Klikk på **Standarder**.

5. Merk av for **Unik** hvis du vil at tellerverdiene i **Vår ref**-feltet skal være unike. Nyttig når SuperOffice CRM-brukere tildeler verdier selv.

6. Merk av for **Tillat tom** for å tillate tomme tellerfelt. Nyttig når tellerverdiene må være unike. Hvis det er merket av for **Tillat tomt**, betyr det at kravet om unike verdier ikke gjelder tomme felt.

7. Merk av for **Kun lesbar** hvis du ikke vil at SuperOffice CRM-brukerne skal kunne skrive inn verdier i **Vår ref**-feltet selv.

8. Merk av for **Tildel** for å bruke den automatiske tellerfunksjonen, slik at systemet legger inn verdier i **Vår ref.**-feltet for deg.

    [Se resultatene av ulike kombinasjoner av disse verdiene][1].

9. Skriv inn verdien du vil at telleren skal starte på, i feltet **Neste nummer**.

10. Klikk på **Lagre**.

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
