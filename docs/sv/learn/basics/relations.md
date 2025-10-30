---
uid: help-sv-company-contact-relations
title: Företags- och kontaktrelationer i SuperOffice CRM
description: Lär dig hur du visar, lägger till och hanterar relationer mellan företag och kontakter i SuperOffice CRM, för att underlätta uppföljning av komplexa affärsförbindelser och anpassade kopplingar.
keywords: lägga till relation, ta bort relation, relation, person, kontakt, företag
author: Bergfrid Skaara Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/admin/lists/learn/relation
  - /sv/company/learn/add-relation
  - /sv/company/learn/delete-relation
  - /sv/contact/learn/add-relation
  - /sv/contact/learn/delete-relation
---

# Företags- och kontaktrelationer i SuperOffice CRM

Relationer i SuperOffice CRM gör det möjligt att skapa kopplingar mellan företag och kontakter. Relationer består alltid av två parter: en aktiv och en passiv. Till exempel, "Företag A äger Företag B," där Företag A är den aktiva parten och Företag B är den passiva parten. Denna guide ger en översikt över hur du visar, lägger till och hanterar dessa relationer, vilket gör det enklare att följa upp komplexa strukturer, samarbeten eller andra anpassade relationer som ditt företag behöver.

## Exempel på relationer

Exempel inkluderar ägarstrukturer, partnerskapsavtal eller personliga relationer mellan kontakter.

| Typ | Aktiv | Passiv |
|---|---|---|
| Företag - företag | Företaget ABC AB samarbetar med konsultföretaget Firman AB | Konsultföretaget ABC AB samarbetar med företaget Firman AB |
| Företag - kontakt | Företaget ABC AB anställer Greg Campbell (konsultföretaget Firman AB) | Greg Campbell (konsultföretaget ABC AB) anställs av företaget Firman AB |
| Kontakt - företag | Peter Johnson äger företaget ABC AB | Företaget ABC AB ägs av Peter Johnson. |
| Kontakt - kontakt | Mark Johnson (konsultföretaget Firman AB) är son till Peter Johnson (företaget ABC AB). | Peter Johnson (företaget ABC AB) är pappa till Mark Johnson (konsultföretaget Firman AB). |

## Visa relationer

Detaljkortet **Relationer**, som finns tillgänglig på både Företags- och Kontaktkortet, visar relationer mellan den aktuella enheten och andra företag eller kontakter.

![Relationer (Företagskortet) -screenshot][img2]

[!include[Kolumner i Relationsfliken](../includes/table-relations-tab-columns.md)]

För att visa fler detaljer eller redigera, dubbelklicka på en rad för att öppna dialogrutan **Relation**.

## <a id="add"></a>Lägg till relation

1. Gå till Företags- eller Kontaktkortet där du vill lägga till en relation.

1. Välj detaljkortet **Relationer**.

1. Klicka på **Lägg till** för att öppna dialogrutan **Relation**.

    ![Relationer-dialogruta -screenshot][img1]

1. **Ange parterna:**

    * **Aktiv:** Välj ett företag eller en kontakt.
    * **Passiv:** Välj den andra enheten som är inblandad i relationen.

1. **Välj relationstyp:** Välj typen av relation, som "äger", "anställd av" eller "partner" från **Relation**-listan. De tillgängliga alternativen beror på om relationen är mellan en kontakt och ett företag eller mellan två kontakter.

    **Resultat**-fältet uppdateras automatiskt baserat på dina val.

1. Lägg till en beskrivning (valfritt): Lägg till ytterligare information om det behövs.

1. Klicka på **Spara** för att skapa relationen.

## <a id="delete"></a>Ta bort relation

1. Gå till detaljkortet **Relationer** på antingen Företags- eller Kontaktkortet.

1. Hitta relationen som du vill ta bort, högerklicka på den och välj **Ta bort**.

1. I dialogrutan som visas, klicka på **Ja** för att bekräfta.

## Ytterligare tips

* **Söka i listrutan:** När du väljer den aktiva och passiva parten, börja skriva namnet för att snabbt hitta företaget eller kontakten.

* **Relationstyper:** Relationstyper definieras i **Inställningar och Underhåll**. Att anpassa dessa typer gör det enklare att spegla ditt företags specifika behov.

## Relaterat innehåll

* [Ta bort poster i SuperOffice CRM][2]
* [Gruppera informationen i detaljkort][1]
* [Lägga till poster i listan Allmänt – Relation][3]
* [Anpassade fält i relationer][4]

<!-- Referenced links -->
[1]: ../section-tabs/index.md
[2]: deleting-elements.md
[3]: ../../admin/lists/specialized-lists.md#relation
[4]: ../../custom-objects/learn/extra-field.md#relation

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/relation.png
[img2]: ../../../media/loc/en/company/relations-detail.png
