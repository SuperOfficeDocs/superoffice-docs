---
uid: help-sv-add-items-to-country-list
title: Lägg till poster i listan Land
description: Lägg till poster i listan Land
keywords: listan Allmänt – Land
author: SuperOffice Product and engineering
date: 06.26.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägga till poster i listan Allmänt – Land

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] när posterna är länder:

1. Skriv in namnet på posten i fältet **Namn**. Landets namn.

    [!include[Mandatory](includes/note-mandatory-field.md)]

1. Ange vilken landskod som ska användas i internetadresser för det aktuella landet i fältet **Toppdomän**, till exempel *NO* för Norge eller *DE* för Tyskland.

1. I fältet **Postprefix** anger du den eller de bokstäver som ska placeras före postnumret när du skriver till det aktuella landet från ett annat land, till exempel *N* för Norge.

1. För vart och ett av de följande tre fälten klickar du på <i class="ph ph-caret-down" aria-label="Chevron"></i> och väljer önskat adressformat i listan. Normalt tillämpas samma format på alla tre fält, men för vissa länder kan det vara bra att välja olika format beroende på vad adressen används för:
    * **Adressformat i vy**:
        Det vanliga formatet som det visas på skärmen på företagspanelen. I regel behöver du bara välja format här.
    * **Adressformat för utskrift (inrikes)** och **(utrikes)**:
        Vissa länder använder olika adressformat för brev beroende på om de postas i eller utanför landet. Ange vilket format som ska användas i vart och ett av dessa fall i fälten.

1. Företagspanelen innehåller ett fält med rubriken **Org.nr** för registrering av företagets organisationsnummer eller liknande. Du kan ändra denna ledtext under Inställningar och underhåll. Skriv önskad text i fältet **Ledtexter för org.nr**, till exempel *Org. nr* för Norge. När du lägger in ett norskt företag i SuperOffice är ledtexten för företagets organisationsnummer *Org. nr* istället för *Org.nr*.

1. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid fältet **Valuta** och välj en valuta i listan.

    > [!NOTE]
    > Alternativen definieras i listan [**Allmänt – Valuta**][2].

1. I fältet **Det här landets prefix** anger du det nummer som ska användas när man ringer till det valda landet från ett annat land, till exempel *47* för Sverige.

1. I fältet **Utlandsprefix** anger du prefixet för internationella samtal för landet du befinner dig i. Oftast är det *00*.

1. Om du vill kan du skriva en beskrivning av landet i fältet **Beskrivning**.

1. Klicka på **Spara**. Landet läggs till som en egen post i listan **Poster**. Upprepa proceduren om du vill lägga till fler länder.

<!-- Referenced links -->
[2]: ../../../sale/admin/add-currency.md
