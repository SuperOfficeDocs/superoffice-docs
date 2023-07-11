---
uid: help-sv-udef
title: Fält
description: Fält
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, anpassa fält
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: sv
---

# Användardefinierade fält

Flera programkomponenter i SuperOffice CRM, till exempel fönstret Företag, har en separat flik som heter **Mer**. Här kan du lägga till egna fält för att anpassa programmet efter företagets behov. [!include[SM](../../../learn/includes/are-defined-sm.md)]

Alla företag och organisationer har sina egna krav på vilken information de behöver registrera om sina kunder, försäljningar, projekt, avtal och så vidare. I fönstret **Fält** kan du skapa egna fält i SuperOffice CRM. På så sätt kan du anpassa vilken typ av information som kan registreras om företag, kontakter, projekt, försäljningar, dokument och händelser.

> [!NOTE]
> Du kan ange 3 fält som kan visas på "förstasidan" i respektive fönster eller dialogruta. [Hur][1]? Observera att detta kanske inte fungerar om du använder en annan layout via [Skärmdesigner][8].

## <a id="field-types" />Fälttyper

[!include[List of field types](includes/field-types.md)]

## Varför ska jag lägga in information i de här fälten?

* Med **sökfunktionen** kan du söka efter den information du lägger in i de här fälten och göra dynamiska urval.
    **Exempel**: Om du registrerar förfallodatumet för underhållsavtalet du tecknar med dina kunder kan du skapa ett dynamiskt urval som visar alla kunder vars avtal löper ut om mindre än en månad.

* Du kan återanvända informationen från de här fälten i dokument och e-postmeddelanden med hjälp av mallvariabler. Varje fält du lägger till får ett unikt ID som kan användas i dokument för att slå ihop kundspecifik information.
    **Exempel**: Om du skickar ett e-postmeddelande till dina kunder som informerar dem om att deras underhållsavtal snart löper ut kan du använda mallvariabeln för förfallodatum för att ange rätt förfallodatum i det meddelande som skickas.

## Var visas fälten jag skapar?

* [Fliken Mer (företag)][6]
* [Fliken Mer (kontakt)][7]
* [Fliken Mer (projekt)][3]
* [Fliken Mer (händelser)][4]
* [Fliken Mer (Dokument)][5]
* Fliken Detaljer i fönstret Försäljning

Du kan definiera *sidan 1-fält* (fält som visas på "förstasidan" i respektive fönster eller dialogruta) på följande platser:

[!include[List](includes/list-page-1-field-locations.md)]

## Exempel

### Användardefinierade fält för företag

Ditt företag säljer programvara och supporttjänster för användarna. Supportavdelningen behöver veta hur många anställda och datorer varje kund har. De behöver också veta vilken typ av underhållsavtal kunderna har och när de löper ut.

Du kan lägga till dessa fält i fönstret Företag:

| Fältnamn | Typ | Beskrivning |
|---|---|---|
| Antal datorer | Nummer | Ett nummerfält där du kan registrera antalet datorer. |
| Antal medarbetare | Nummer | Ett nummerfält där du kan registrera antalet medarbetare. |
| Underhållsavtal | Lista | En lista över de olika typer av underhållsavtal du erbjuder. Listan måste [skapas i fönstret Listor][2]. |
| Avtalet löper ut | Datum | Ett datumfält där du kan registrera avtalets förfallodatum. |
| Applikation A; Applikation B; Applikation C | Kryssruta | Tre kryssrutor där du kan markera de applikationer som kunden har köpt. |

> [!NOTE]
> Fälten som du lägger till visas på fliken **Mer** i fönstret Företag. Om du vill att de ska visas på företagskortet [definierar du dem som *sidan 1-fält*][1].

### Användardefinierade fält för försäljning

När du skapar en försäljning kan det vara praktiskt att ange vilka produkter du har sålt och hur många.

Du kan lägga till dessa fält i fönstret Försäljning:

| Fältnamn | Typ | Beskrivning |
|---|---|---|
| Produkt | Lång text | Ett textfält där du kan skriva in namnet på den sålda produkten. |
| Kvantitet | Nummer | Ett nummerfält där du kan ange antalet sålda enheter. |

> [!TIP]
> Här kan du också använda ett listfält om du har skapat en lista över de produkter du säljer.

### Användardefinierade fält för projekt

Du vill att budgeten för ett projekt ska vara lättillgänglig för projektdeltagarna.

Du kan lägga till dessa fält i fönstret Projekt:

| Fältnamn | Typ | Beskrivning | Kommentarer |
|---|---|---|---|
| Budget | Decimal | Ett nummerfält där du kan ange en summa. | [Ange att fältet ska visas på förstasidan][1]. |

<!-- Referenced links -->
[1]: page-1-fields.md
[2]: ../../../admin/lists/learn/adding-user-defined-lists.md
[3]: ../../../project/learn/index.md#more-tab
[4]: ../../../diary/learn/screen/dialog-for-followups.md
[5]: ../../../document/learn/screen/index.md
[6]: ../../../company/learn/create.md#more-tab
[7]: ../../../contact/learn/create.md#more-tab
[8]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->