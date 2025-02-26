---
uid: help-da-using-document-templates-for-multiple-languages
title: brug af dokumentskabeloner til flere sprog
description: brug af dokumentskabeloner til flere sprog
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger og vedligeholdelse
topic: help
language: da
---

# Anvendelse af dokumentskabeloner på flere sprog i projekt- og salgsguiderne

Hvis dit firma har afdelinger i flere lande, kan det være nyttigt at have dokumentskabelonerne i projekt- og salgsguiderne tilgængelige på flere sprog. Først skal du placere dokumentskabelonerne for de forskellige sprog i de rigtige mapper og derefter angive, hvem der skal bruge de forskellige sprogversioner.

## Tilføj dokumentskabeloner for sprog

1. Åbn Windows Stifinder, og gå til mappen *\\SuperOffice\\SO_Arc\\Skabelon*.

2. Opret en mappe for hvert af de sprog, du vil have dokumentskabeloner til (se følgende tabel). For eksempel *\\SuperOffice\\SO_Arc\\Template\\GE*.

3. Placer dokumentskabeloner til de forskellige sprog i de relevante sprogmapper. Hver dokumentskabelon skal have nøjagtigt samme filnavn og filtype som hovedskabelonen. Hovedskabelonen er dokumentskabelonen på hovedsproget, som du bruger i SuperOffice. Du finder den på listen **Dokumentskabelon** på skærmbilledet **Lister** (dobbeltklik på en dokumentskabelon på listen for at se filnavnet/filtypen). Se Tilføj elementer til listen Dokument - Skabelon

> [!TIP]
> Hvis dokumentskabelonen for det pågældende sprog IKKE findes i sprogmappen, bruges dokumentskabelonen på hovedsproget.

### Mappenavne for de forskellige sprog

[!include[Sprogkoder](../../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Angiv dokumentsprog for brugere

Du skal nu vælge de korrekte dokumentsprog for de brugere, der skal bruge dokumentskabelonerne på de forskellige sprog:

1. Åbn skærmbilledet **Præferencer**, vælg **System** på listen **Vis gruppe**, og vælg **Foretrukket dokumentsprog**.

2. Klik på **Tilføj** under listen **Aktive indstillinger**.

3. Vælg **Bruger** under **Denne indstilling gælder for**.

    > [!TIP]
    > Hvis divisionerne bruger satellitdatabaser, kan du vælge at angive dokumentsprog for databaser. Du kan også vælge dokumentsprog for grupper, men i så fald skal den pågældende gruppe være primærgruppen af de brugere, du angiver dokumentsproget for.

4. Klik på listen **Mål**, og vælg den ønskede bruger.

5. Vælg det ønskede sprog på listen **Foretrukket dokumentsprog**.

6. Klik på **Gem**.

7. Gentag trin 2-6 for hver bruger, du vil angive dokumentsproget for.
