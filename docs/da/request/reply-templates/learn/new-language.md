---
uid: help-da-reply-template-language
title: Oprettelse af ny sprogversion af svarskabelon
description: Oprettelse af ny sprogversion af svarskabelon
keywords: oversæt svarskabelon, ny sprogversion, svarskabelon, sag
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Oprettelse af ny sprogversion af svarskabelon

Det kan være aktuelt at have samme svarskabelon tilgængelig på flere sprog, hvis du f.eks. skal sende samme svar til kunder i flere lande.

## Tilføj sprog til svarskabelon

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Svarskabeloner**.

2. Gå til den mappe, som svarskabelonen ligger i.

3. Klik på svarskabelonen. Du kommer til skærmbilledet **Vis svarskabeloner**.

4. Klik på **Rediger svarskabelon**. Du kommer til skærmbilledet **Egenskaber for svarskabelon**.

5. Klik på knappen **Ny sprogversion** nederst i skærmbilledet. Der tilføjes en ny fane med navnet **(Sprog ikke angivet)**.

6. **Sprog**: I denne liste skal du vælge, hvilket sprog den aktuelle sprogversion af svarskabelon er på. Rullemenuen indeholder registrerede [kundesprog][2].

7. Indtast teksten på de relevante sprog i de andre faner, og foretag de nødvendige ændringer i denne sprogversion af svarskabelonen. Du kan læse mere om dette i [Oprettelse af svarskabeloner][1].

8. Klik på **OK**. Ændringerne gemmes. Fanen **(Uspecificeret sprog)** ændres til det valgte sprog.

> [!TIP]
> Klik på knappen **Slet valgt sprogversion** for at slette den aktive sprogversion (den valgte sprogfane).

## Fejlfinding

### Hvorfor er knappen "Ny sprogversion" ikke synlig i footeren?

Hvis knappen **Ny sprogversion** ikke er synlig, betyder det, at der ikke er defineret nogen kundesprog i systemet. For at løse dette skal en administrator [tilføje kundesprog][3] i **Indstillinger og vedligeholdelse** under **Valgmuligheder** > **Kundesprog**.

### Hvorfor er et specifikt sprog ikke tilgængeligt på listen?

Hvis et specifikt sprog mangler i rullemenuen **Sprog**, er det ikke blevet føjet til listen over kundesprog. Bed din administrator om at tilføje det manglende sprog i **Indstillinger og vedligeholdelse**.

<!-- Referenced links -->
[1]: create.md
[2]: ../../../admin/options/learn/custlang/index.md
[3]: ../../../admin/options/learn/custlang/update.md
