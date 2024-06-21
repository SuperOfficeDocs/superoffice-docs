---
uid: help-da-udef-edit
title: Redigering af brugerdefinerede felt
description: Redigering af brugerdefinerede felt
author: Bergfrid Dias
date: 01.26.2024
version: 10
keywords: udef, tilpasset felt, brugerdefinered felt
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Redigering af brugerdefinerede felt

1. [!inkluder[Gå til felter og vælg fane](includes/goto-fields.md)]

1. Dobbeltklik på det nødvendige felt i listen **Felt**.

1. Foretag de nødvendige ændringer i de forskellige felter. (Se listen over [feltegenskaber][1]).

    Brug rullelisten **Type** til at vælge en ny type. Du vil kun se kompatible felttyper. Det vil sige, hvor eksisterende data kan konverteres til at passe til den nye felttype.

1. Klik på **Gem**.

1. Klik på **Udgiv** for at gøre ændringerne tilgængelige for SuperOffice-brugere.

> [!NOTE]
> Du skal publicere ændringerne for brugerdefinerede felter, før du [definerer side 1-felter][2] for de forskellige brugergrupper og gemmer (ikke publicerer).

## Konverter felttype

Ikke alle konverteringer er mulige, fordi forskellige typer brugerdefinerede feltværdier lagres i forskellige tabeller i databasen og bruger forskellige grundlæggende datatyper.

| Felttype | Nummer | Decimal | Kort tekst | Lang tekst | Dato | Ubegrænset dato | Afkrydsningsfelt | Liste |
|:--|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
| Nummer | x | x | x | | | | | |
| Decimal | x | x | x | | | | | |
| Kort tekst | x | | x | | | | | |
| Lang tekst | | | | x | | | | |
| Dato | | | x | | x | x | | |
| Ubegrænset dato | | | x | | | x | | |
| Afkrydsningsfelt | | | x | | | | x | |
| Liste | | | x | | | | | x |

**Sådan læses tabellen:**

Felttyperne i venstre kolonne er kompatible med og kan konverteres til typerne markeret med et x. For eksempel kan et nummer konverteres til en decimal og en kort tekst. (Og det er åbenlyst kompatibelt med sig selv.)

<!-- Referenced links -->
[1]: add-udef.md#properties
[2]: edit-udef-layout.md#page-1

<!-- Referenced images -->
