---
uid: help-sv-specialized-lists
title: Specialiserade listor
description: Specialiserade listor
keywords: specialiserad lista, Allmänt – Relation, Allmänt – Land
author: digitaldiina
date: 11.12.2025
version: 11.6
content_type: reference
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
redirect_from:
  - /sv/admin/lists/learn/specialized-lists
  - /sv/admin/lists/learn/adding-items-to-relation-list
  - /sv/admin/lists/learn/add-items-to-country-list
  - /sv/admin/lists/learn/country
language: sv
---

# Specialiserade listor

Vissa listor i Inställningar och underhåll använder dialogrutor med fält som är anpassade efter listans syfte. Dessa kallas *specialiserade listor*.

Stegen för att lägga till eller redigera poster är i stort sett desamma som för vanliga och användardefinierade listor. Se [Lägg till poster][21] för generell instruktion.

## Tillgängliga specialiserade listor

* [Företag – Kategori][20]
* [Dokument – Mall][1]
* [E-post – Mall][2]
* [Händelse – Typ][3]
* [Allmänt – Land](#country)
* [Allmänt – Valuta][5]
* [Allmänt – Relation](#relation)
* [Allmänt – Resurs][7]
* [GUI – Applikation][8]
* [GUI – Webbpanel][9]
* [Utskicksdomäner][19]
* [Integritet – Rättslig grund][10]
* [Integritet – Källa][11]
* [Projektstatus][12]
* [Projekt – Typ, status][13]
* [Försäljning – Beloppsklass][14]
* [Försäljning – Fas][15]
* [Försäljning – Roll (Intressent)][16]
* [Försäljning – Typ, Faser, Offert][17]
* [Uppgiftsmeny][18]

## Exempel

Dessa exempel beskriver fält som är specifika för varje lista. **Namn** är alltid *obligatoriskt*. Det valfria fältet **Beskrivning** används som förklaring eller verktygstips.

### <a id="country"></a>Allmänt – Land-lista

På flera ställen i SuperOffice CRM kan du välja ett land från en lista. Länderna (och deras flaggor) hämtas från ISO:s standardiserade landlista. Landlistan är fördefinierad i skärmbilden **Listor** under Inställningar och underhåll. Du kan redigera befintliga poster eller lägga till nya.

| Fält | Beskrivning |
|---|---|
| **Toppdomän** | Tvåbokstavskod som används i internetadresser (t.ex. *NO* för Norge eller *DE* för Tyskland). |
| **Postprefix** | Bokstäver som placeras före postnummer vid internationell post (t.ex. *N* för Norge). |
| **Adressformat i vy** | Format som visas i företagspanelen. |
| **Adressformat för utskrift (inrikes / utrikes)** | Alternativa format som används för utskrift beroende på postkrav. |
| **Ledtexter för org.nr** | Anpassad etikett för fältet **Org.nr** i företagspanelen (t.ex. *Org. nr* i stället för *VAT No*). |
| **Valuta** | Välj en valuta från listan [Allmänt – Valuta][5]. |
| **Det här landets prefix** | Riktnummer för att ringa till landet (t.ex. *47* för Norge). |
| **Utlandsprefix** | Prefix för att ringa internationella samtal (oftast *00*). |

> [!NOTE]
> Vanligtvis räcker det att välja **adressformat i vy**.
> Alla tre adressfält kan användas vid behov – särskilt för länder med olika krav på visning och utskrift.

### <a id="relation"></a>Allmänt – Relation-lista

[Detaljkortet **Relationer**][4] i företags- och kontaktvyn visar kopplingar mellan personer eller företag, till exempel ägarstruktur eller tidigare anställningar.

| Fält | Beskrivning |
|---|---|
| **Namn** | Aktiv form av relationen. Visas i kolumnen **har relation** på detaljkortet **Relationer** (t.ex. *äger*). |
| **Passiv form** | Passiv form av relationen. Visas också i kolumnen **har relation** (t.ex. *ägs av*). |
| **Detta är en relation mellan** | Anger vilka entitetstyper (företag och/eller kontakt) som är aktiva respektive passiva. Fälten motsvarar dem i **Relation**-dialogrutan. |
| **Exempel** | Visar hur relationen visas i praktiken. |

> [!NOTE]
> Fälten **Namn** och **Passiv form** ska beskriva [relationen][6] tydligt med aktiv och passiv verbform.
> Exempel: *äger / ägs av*, *anställer / anställs av*, *leder / leds av*.

## Relaterat innehåll

* [Lägg till och ta bort företags- och kontaktrelationer][1]

<!-- Refererade länkar -->
[1]: ../../document/templates/learn/index.md
[2]: ../../email/admin/add-email-template.md
[3]: ../../diary/admin/add-follow-up-type.md
[5]: ../../sale/admin/add-currency.md
[4]: ../../learn/section-tabs/relations-tab.md
[6]: ../../learn/basics/relations.md
[7]: ../../diary/admin/add-resource.md
[8]: ../../customization/admin/other-applications.md
[9]: ../../customization/web-panels/admin/add-web-panel.md
[10]: ../../security/privacy/admin/add-legal-base.md
[11]: ../../security/privacy/admin/add-source.md
[12]: ../../project/admin/project-status.md
[13]: ../../project/admin/project-type.md
[14]: ../../saint/admin/sale-amount-class.md
[15]: ../../sale/admin/sale-stage.md
[16]: ../../sale/learn/stakeholders/index.md#role
[17]: ../../sale/admin/sale-type.md
[18]: ../../customization/admin/add-items-to-task-menu.md
[19]: ../../marketing/mailing/admin/add-domain.md
[20]: ../../lead/admin/add-company-category.md
[21]: add-items.md
