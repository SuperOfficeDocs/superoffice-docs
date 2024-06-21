---
uid: help-no-udef-edit
title: Redigere egendefinert felt
description: Redigere egendefinert felt
keywords: udef, egendefinert felt, felttype
author: Bergfrid Dias
date: 01.25.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Redigere egendefinert felt

1. [!include[Gå til Felt og velg fane](includes/goto-fields.md)]

1. Dobbeltklikk på ønsket overskrift i **Felt**-listen.

1. Gjør ønskede endringer i de ulike feltene. (Se listen over [feltegenskaper][1]).

    Nedtrekksmenyen **Type** viser kun kompatible felttyper. Det vil si, der eksisterende data kan konverteres for å passe til den nye felttypen.

1. Klikk på **Lagre**.

1. Klikk på **Publiser** for å gjøre endringene tilgjengelige for SuperOffice-brukere.

> [!NOTE]
> Du må publisere endringene for brukerdefinerte felt før du [definerer side 1-felt][2] for de forskjellige brukergruppene og lagrer (ikke publiserer).

## Konverter felttype

Ikke alle konverteringer er mulige fordi forskjellige typer brukerdefinerte feltverdier lagres i forskjellige tabeller i databasen og bruker forskjellige grunnleggende datatyper.

| Felttype | Nummer | Desimal | Kort tekst | Lang tekst | Dato | Ubegrenset dato | Avmerkingsboks | Liste |
|:--|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
| Nummer | x | x | x | | | | | |
| Desimal | x | x | x | | | | | |
| Kort tekst | x | | x | | | | | |
| Lang tekst | | | | x | | | | |
| Dato | | | x | | x | x | | |
| Ubegrenset dato | | | x | | | x | | |
| Avmerkingsboks | | | x | | | | x | |
| Liste | | | x | | | | | x |

**Slik leser du tabellen:**

Felttypene i venstre kolonne er kompatible med og kan konverteres til typene som er merket med en x. For eksempel kan et nummer konverteres til en desimal og en kort tekst. (Og det er åpenbart kompatibelt med seg selv.)

<!-- Referenced links -->
[1]: add-udef.md#properties
[2]: edit-udef-layout.md#page-1

<!-- Referenced images -->
