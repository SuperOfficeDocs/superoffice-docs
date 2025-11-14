---
uid: help-sv-sales-target-types
title: Ställ in en typ av försäljningsmål med undertyper
description: Att hålla koll på dina försäljningsmål kan vara stressande. Men om du definierar parametrar och dimensioner för dina försäljningsmål blir det mycket lättare att hantera dem.
keywords: försäljningsmål, dimension
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium, Unlimited sales targets
functional_right: Targets administrator
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Ställ in en typ av försäljningsmål med undertyper

Att hålla koll på dina försäljningsmål kan vara stressande. Men om du definierar parametrar och dimensioner för dina försäljningsmål blir det mycket lättare att hantera dem.

Som standard innehåller SuperOffice en måltyp: **All försäljning – Belopp**. Du kan lägga till anpassade måltyper baserat på försäljningsdata, företagsinformation eller användardefinierade fält.

## Krav

Du måste ha funktionsrättigheten **Targets administrator** för att lägga till, redigera eller ta bort måltyper.

> [!NOTE]
> För att lägga till måltyper behöver du licensen Unlimited sales targets utöver Sales Premium-licensen.

## Tillgängliga måltyper

En **måltyp** definierar vad du vill mäta. Du kan välja mellan följande systemdefinierade dimensioner:

* All försäljning
* Försäljningstyp
* Försäljningskälla
* Försäljning krediterad
* Försäljningskonkurrent
* Företagskategori
* Företagsbransch
* Företagsland

Du kan också använda dina egna användardefinierade fält, förutsatt att de innehåller listvärden.

**Varje dimension kan endast användas en gång för att undvika dubbletter.**

## Lägg till en ny måltyp

1. Klicka <i class="ph ph-list" aria-label="Huvudmeny"></i> och välj **Mål**.

1. I **Mål**-skärmen, klicka **Lägg till ny måltyp** för att definiera en anpassad försäljningsdimension. Du kan också klicka <i class="ph ph-gear" aria-label="Kugghjul"></i> (**Konfigurera mål**) på en befintlig flik för att redigera den.

    ![Mål-skärmen med Lägg till ny måltyp-knappen -screenshot][img4]

1. Klicka **Måltyp** för att välja dimensionen du vill spåra, som **Försäljningskälla** eller **Företagskategori**.

    ![Målinställningar-dialog för att skapa en ny måltyp -screenshot][img1]

1. Klicka **Måttenhet** för att välja hur resultaten beräknas:

    * **Belopp:** Totalt värde av försäljning
    * **Antal:** Antal försäljningar
    * **Vinst:** Vinstmarginal

    Alternativen beror på den valda måltypen.

1. Under **Separata mål**, välj specifika undertyper som ska spåras separat. Alternativen beror på den valda måltypen.

    Till exempel, om måltypen är **Kategori**, är undertyperna dina företagskategorier.

1. Välj kryssrutan **Tillgänglig endast på företagsnivå och gruppnivå** om denna måltyp inte ska vara tillgänglig på användarnivå.

1. Klicka **Spara**. Måltypen läggs till som en flik. Du kan nu [lägga till grupper och användare till ditt försäljningsmål][3].

## Ta bort en måltyp

För att ta bort en måltyp:

1. Öppna **Målinställningar** från den relevanta fliken.
2. Klicka **Ta bort**.

> [!WARNING]
> Att ta bort en måltyp tar permanent bort all relaterad data för alla år - tidigare, nuvarande och framtida. Du kan inte ta bort standardtypen **All försäljning – Belopp**.

## Tips och felsökning

* Efter sparning kan måltypen och måttenheten inte ändras. För att justera dessa inställningar, skapa en ny måltyp och ta bort den gamla.

* Du kan redigera listan **Separata mål** och kryssrutan **Tillgänglig endast på företagsnivå och gruppnivå** efter sparning.

    > [!NOTE]
    > Om du aktiverar tillgänglighet endast på företags-/gruppnivå efter att ha angett värden på användarnivå, visas en varning. Att spara denna ändring kommer att ta bort målen på användarnivå.

## Relaterat innehåll

* [Lägg till grupper och användare till ditt försäljningsmål][3]
* [Använda försäljningsmål i dashboard-paneler][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/target-settings.png
[img4]: ../../../../media/loc/en/sale/add-new-target-type-button.png
