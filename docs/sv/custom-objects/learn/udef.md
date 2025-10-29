---
uid: help-sv-udef
title: Användardefinierade fält
description: Användardefinierade fält
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.1
keywords: udef, anpassa fält, användardefinierad fält
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/custom-objects/learn/udef/index
---

# Användardefinierade fält

Ett *användardefinierat* fält (udef) är ett anpassat fält som du lägger till i en standard SuperOffice-databastabell. Du kan utöka följande enheter:

* Företag
* Kontakt
* Dokument
* Uppföljning
* Projekt
* Försäljning

Användardefinierade fält hanteras i Inställningar och underhåll, i **Fält**-skärmen. I applikationen är användardefinierade fält synliga på **Mer**-fliken för den enhet de lades till. Till exempel visas ett användardefinierat fält på ett företag på **Mer**-fliken i Företagsskärmen.

> [!NOTE]
> Alla kan **uppdatera** data lagrade i ett användardefinierat fält. Endast en administratör kan lägga till (eller ta bort) ett användardefinierat fält. Du behöver en Development Tools-licens för att anpassa layouten för **Mer**-fliken och använda sidan 1-fält.

## <a id="field-types"></a>Fälttyper

* **Nummer**: Heltal, obegränsat antal siffror.
* **Kort text**: Text med högst 39 tecken. I fältet **Textlängd**, som aktiveras när du väljer det här alternativet, anger du det maximala antalet tecken som användarna kan skriva i fältet.
* **Lång text**: Text med högst 199 tecken. I fältet **Textlängd**, som aktiveras när du väljer det här alternativet, anger du det maximala antalet tecken som användarna kan skriva i fältet.
* **Datum**: Datum mellan 1970-01-01 och 2038-01-19.
* **Obegränsat datum**: Valfritt datum.
* **Kryssruta**: En kryssruta.
* **Lista**: En listruta. Välj en lista från systemet i fältet nedan.
* **Decimal**: en siffra med decimaler.

## <a id="limit"></a>Maximalt antal fält

Följande begränsningar gäller för antalet användardefinierade fält som du kan lägga till på flikarna Företag, Kontakt, Projekt och Försäljning.

* **Nummer**, **Datum**, **Kryssruta** och **Lista**: Max 60 totalt.
* **Kort text** och **Obegränsat datum**: Max 40 totalt.
* **Lång text**: Max 9 totalt.
* **Decimal**: Max 10 totalt.

> [!NOTE]
> Det rekommenderas att indexera fält för bättre prestanda, särskilt i stora datamängder. Fyra fält i varje grupp är reserverade för index. Om inga fält indexeras, reduceras det totala antalet användardefinierade fält till 103 eftersom 16 platser förblir outnyttjade.

## <a id="index"></a>Indexerade fält

Indexering snabbar upp datahämtning och förbättrar användarupplevelsen.

Du kan indexera så många fält du behöver genom att markera rutan **Indexerad** när du skapar eller redigerar ett fält. Indexen uppdateras automatiskt när du publicerar dina ändringar.

**Nyheter från version 10.3.1:**

* Du kan nu indexera fler än 4 fält i varje grupp (Long, Double, String[40], String[200]).

* Data flyttas inte längre mellan fält när du publicerar indexändringar, vilket gör publiceringen snabbare oavsett tabellstorlek (antal rader).

## <a id="page-1"></a>Sidan 1-fält

Bland de användardefinierade fälten som visas på fliken **Mer** i SuperOffice CRM kan du välja ut *tre* fält som ska fungera som så kallade sidan 1-fält (eftersom de visas på "förstasidan" i sina respektive bilder eller dialogrutor).

**Platser:**

* Fliken **Företag** i fönstret Företag
* Fliken **Kontakt** på kontaktkortet
* Fliken **Projekt** i fönstret Projekt
* Fliken **Försäljning** i fönstret Försäljning
* Fliken **Detaljer** i dialogrutan Dokument

> [!NOTE]
> Sida-1 fält kräver licensen Development Tools och är inte tillgängligt om organisationen använder en annan layout via [Skärmdesignern][8].

## Exempel

### Användardefinierade fält för företag

Ditt företag säljer programvara och supporttjänster för användarna. Supportavdelningen behöver veta hur många anställda och datorer varje kund har. De behöver också veta vilken typ av underhållsavtal kunderna har och när de löper ut.

Du kan lägga till dessa fält i fönstret Företag:

| Fältnamn | Typ | Beskrivning |
|---|---|---|
| Antal datorer | Nummer | Ett nummerfält där du kan registrera antalet datorer. |
| Antal medarbetare | Nummer | Ett nummerfält där du kan registrera antalet medarbetare. |
| Underhållsavtal | Lista | En lista över de olika typer av underhållsavtal du erbjuder. Listan måste [skapas i fönstret Listor][3]. |
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

## Relaterat innehåll

* [Legg til brukerdefinert felt][2]

<!-- Referenced links -->
[1]: ../admin/edit-udef-layout.md#page-1
[2]: ../admin/add-udef.md
[3]: ../../admin/lists/user-defined-lists.md
[8]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
