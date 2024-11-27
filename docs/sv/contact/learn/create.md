---
uid: help-sv-contact-create
title: Skapa kontakt
description: Så skapar du en kontakt i SuperOffice.
author: SuperOffice RnD
date: 12.15.2022
keywords: person, contact
topic: howto
language: sv
---

# Skapa en ny kontakt

Du kan lägga till kontakter i SuperOffice CRM på många olika sätt:

* Följ anvisningarna nedan för att lägga till en kontakt från det övre fältet **eller** fönstret Företag.
* [Skanna ett visitkort][1] med SuperOffice Mobile CRM-appen.
* [Massimportera][2] ett stort antal kontakter (kräver administratörsbehörighet).

![Du kan lägga till en kontakt från företagskortet i två steg -screenshot][img1]

## Steg

1. Öppna fönstret Kontakt.

    * Klicka på **Nytt** i det övre fältet och välj **Kontakt**.
    * Du kan också gå till det önskade företaget i fönstret Företag, välja detaljkortet **Kontakter** och klicka på knappen **Lägg till** under detaljkortet.

2. I den övre delen av fliken skriver du in följande information:

    * Kontaktens förnamn och/eller efternamn. Obligatoriskt: Du måste ange antingen förnamn eller efternamn.
    * Titulering (***Hr/Fr***)
    * Företag. Välj ett företag i listan eller börja skriva ett företagsnamn för att söka. Om kontakten inte är knuten till något företag kan du välja **(Välj ingen)**.
    * Kontaktbild. Du kan lägga in en bild genom att dra bildfilen från Windows Explorer och släppa den i bildfältet längst upp till vänster på fliken.

    Du kan också lägga till en bild genom att högerklicka på bildfältet längst upp till vänster på fliken. Klicka på länken och bläddra till önskad bild och klicka på **Öppna** för att lägga till bilden.

3. Skriv in kontaktinformation i fliken **Kontakt**.

    <details><summary>Vad ska du ange i de olika fälten?</summary>

    [!include[Steps to populate company fields](includes/contact-fields.md)]

    </details>

4. Gå till fliken **Detaljer**. Här kan du ange ytterligare information om kontakten.

    <details><summary>Vad ska du ange i de olika fälten?</summary>

    [!include[Steps to populate company details](includes/contact-details.md)]

    </details>

5. Gå till fliken **Mer**. Här finns användardefinierade fält för kontakten.

6. Gå till fliken **Intressen**. Här kan du ange intressen och alternativ för e-marknadsföring/abonnemang för kontakten.

7. Gå till fliken **Anteckning**. Här kan du skriva vadsomhelst.

8. Gå till fliken **www**. Läs mer nedan.

9. Klicka på **Rättslig grund** nederst på kontaktkortet.

    [Gå igenom och redigera samtyckesinformationen][7] i dialogrutan **Integritet** om det är nödvändigt. Klicka på **Stäng** när du är klar.

10. Markera **Tidigare anställd** (längst ner på kontaktkortet) om kontakten har slutat på företaget. En kontakt som registrerats som "Slutat" visas normalt sett inte på listorna över kontakter eller projektdeltagare.

11. När du har lagt in alla nödvändiga uppgifter klickar du på knappen **Spara**.

    Informationen om kontakten sparas nu i databasen och visas på kontaktkortet. Om du har kopplat kontakten till ett företag visas kontakten på fliken **Kontakter** i fönstret Företag.

12. Gå till detaljkortet **Relationer**. Här kan du [lägga till relationer][8] mellan den här kontakten och en annan kontakt eller ett annat företag.

## <a id="more-tab"></a>Fliken Mer (fönstret Kontakt)

Fliken **Mer** innehåller användardefinierade fält för kontakter. Om ditt företag till exempel säljer IT-produkter och behöver fält för varje kontakts maskinvara och programvara kan du ange att dessa fält ska läggas in på den här fliken under Inställningar och underhåll.

Andra exempel: Anställningsår, ERP, användartyp, CXM-information.

## <a id="interests-tab"></a>Fliken Intressen (fönstret Kontakt)

På fliken **Intressen** finns följande alternativ:

* **Intressen:** Här kan du ange vilka intressen en kontakt har. Intressen används för att skapa urval för utskick och liknande. [!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!TIP]
    > Intressen kan vara användbar information när du till exempel definierar urval. Om du till exempel har definierat *referenskund* som intresse kan du skapa ett urval som innehåller alla dina referenskunder. Då är det enkelt att skapa marknadsföringskampanjer mot denna kundgrupp.

* **E-marknadsföring/prenumerationer:** Om kontakten har givit sitt samtycke till att ta emot elektronisk marknadsföring (utskick) klickar du på **E-marknadsföring**. Genom att aktivera alternativet **E-marknadsföring** för en kontakt anger du samtidigt rättslig grund för ändamålet **E-marknadsföring**. Det ändras till **Legitimt intresse**.

    Du kan även ange vilken typ av e-marknadsföring som kontakten ska ta emot (s.k. abonnemangstyper). Dessa inställningar kan ha justerats av kunden själv via en kundportal.

## Fliken www (fönstret Kontakt)

[!include[About the www tab](../../learn/includes/www-tab.md)]

## Fliken ERP (fönstret Kontakt)

[!include[About the ERP tab](../../learn/includes/erp-tab.md)]

## Fliken Anteckning (fönstret Kontakt)

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

[!include[Tip](../../learn/includes/tip-open-website.md)]

## Relaterade ämnen

* [Lägg till en post som favorit][4]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: add-relation.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/add-contact-from-company-card.png
