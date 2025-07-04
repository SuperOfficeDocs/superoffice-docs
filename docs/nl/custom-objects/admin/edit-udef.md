---
uid: help-nl-udef-edit
title: Gebruiker gedefinieerde velden bewerken
description: Gebruiker gedefinieerde velden bewerken
keywords: udef, aangepast veld, gebruiker gedefinieerde veld
author: Bergfrid Dias
date: 01.30.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
---

# Gebruiker gedefinieerde velden bewerken

1. [!include[Ga naar velden en selecteer tabblad](includes/goto-fields.md)]

1. Dubbelklik op het vereiste veld in de lijst **Velden**.

1. Maak de nodige wijzigingen in de verschillende velden. (Zie de lijst met [veld eigenschappen][1]).

    De keuzelijst **Type** ziet alleen de compatibele veldtypen. Dat wil zeggen, waar bestaande gegevens kunnen worden geconverteerd om bij het nieuwe veldtype te passen.

1. Klik op **Opslaan**.

1. Klik op **Publiceren** om de wijzigingen beschikbaar te maken voor SuperOffice-gebruikers.

> [!NOTE]
> Je moet de wijzigingen voor door de gebruiker gedefinieerde velden publiceren voordat je [pagina 1-velden definieert][2] voor de verschillende gebruikersgroepen en opslaat (niet publiceert).

## Veldtype converteren

Niet alle conversies zijn mogelijk omdat verschillende soorten waarden van door de gebruiker gedefinieerde velden worden opgeslagen in verschillende tabellen in de database en verschillende basistypen gebruiken.

| Veldtype | Nummer | Decimaal | Korte tekst | Lange tekst | Datum | Onbeperkte datum | Selectievakje | Lijst |
|:--|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
| Nummer | x | x | x | | | | | |
| Decimaal | x | x | x | | | | | |
| Korte tekst | x | | x | | | | | |
| Lange tekst | | | | x | | | | |
| Datum | | | x | | x | x | | |
| Onbeperkte datum | | | x | | | x | | |
| Selectievakje | | | x | | | | x | |
| Lijst | | | x | | | | | x |

**Hoe de tabel te lezen:**

De veldtypen in de linker kolom zijn compatibel met en kunnen worden geconverteerd naar de typen gemarkeerd met een x. Bijvoorbeeld kan een nummer worden geconverteerd naar een decimaal en een korte tekst. (En het is uiteraard compatibel met zichzelf.)

<!-- Referenced links -->
[1]: add-udef.md#properties
[2]: edit-udef-layout.md#page-1

<!-- Referenced images -->
