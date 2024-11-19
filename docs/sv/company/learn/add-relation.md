---
uid: help-sv-company-add-relation
title: Lägg till relation
description: Lägg till relation
keywords: företag
author: SuperOffice RnD
date: 10.29.2024
version: 10.3.11
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Lägg till en relation(fönstret Företag)

En relation måste alltid ha två parter: en aktiv och en passiv. Till exempel äger Kontakt A Företag B, medan Företag B ägs av Kontakt A.

**Relationstyper** definieras under Inställningar och underhåll.

## Steg

[!include[Gå till företagskärmen](../../learn/includes/goto-contact.md)]

1. Välj detaljkortet **Relationer**.

1. Klicka på **Lägg till**.

    ![Dialogrutan Relationer -screenshot][img2]

1. I **Relation**-dialogen, specificera **Aktiv del**:

    * Företag: Välj företaget från rullgardinsmenyn eller börja skriva för att söka. Detta är obligatoriskt.
    * Kontakt: Valfritt, specificera en kontakt för det aktiva företaget (till exempel om kontakten är en representant, har en specifik roll, eller är en tidigare kollega till en kontakt i Företag B).

1. Specificera **Passiv del**:

    * Företag: Välj företaget för den passiva rollen med samma metod som för den aktiva delen.
    * Kontakt: Valfritt, specificera en kontakt för det passiva företaget.

1. Välj en relationstyp från **Relation**-listan, till exempel "ägare". De tillgängliga alternativen beror på om relationen är mellan två företag, ett företag och en kontakt eller mellan två kontakter.

1. Valfritt: Ange extra information i **Beskrivning**-fältet.

1. **Resultat**-fältet uppdateras automatiskt baserat på vald relation.

1. Klicka på **Spara**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../media/loc/en/company/relation.png
