---
uid: help-sv-contact-create
title: Skapa en ny kontakt
description: Så skapar du en kontakt i SuperOffice.
keywords: skapa kontakt, lägga till kontakt, kontaktkort, kontakt
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Skapa en ny kontakt

Du kan lägga till en kontakt i SuperOffice CRM på flera olika sätt:

* Från **det övre fältet** eller **fönstret Företag** (stegen beskrivs nedan).
* [Skanna ett visitkort][1] med SuperOffice Mobile CRM-appen.
* [Massimportera kontakter][2] (kräver administratörsbehörighet).

## Steg

1. **Öppna fönstret Kontakt:**

    * Klicka på **Nytt** i det övre fältet och välj **Kontakt**.
    * Eller gå till det aktuella företaget i fönstret **Företag**, välj detaljkortet **Kontakter** och klicka på knappen **Lägg till**.

1. **Ange grundläggande kontaktuppgifter:**

    * Skriv in **Förnamn** och/eller **Efternamn** (obligatoriskt: minst ett av dessa fält måste fyllas i).
    * Valfritt: Välj en hälsningsfras (***Hr/Fr***).
    * Välj **Företag**:
      * Börja skriva för att söka efter ett företag eller välj **(Välj ingen)** om kontakten inte är kopplad till ett företag.
    * Valfritt: Lägg till en **kontaktbild** genom att dra en bildfil till bildfältet eller högerklicka för att ladda upp en bild.

    ![Tomt kontaktkort med markerade fält för Förnamn och Efternamn samt valfria fält som Titel och Företag. -screenshot][img1]

1. Fyll i fälten på fliken **Kontakt**.

    * Fyll i fältet **Land**. Detta uppdaterar automatiskt adressformatet för det angivna landet. Standardvärdet är det land som är registrerat för företaget.
    * Ange övrig kontaktinformation, såsom **Mobil** och **E-post**.

1. Lägg till ytterligare information på fliken **Detaljer** (valfritt):

    * Ange viktiga detaljer såsom **Befattning**, **Födelsedatum** och **Supportspråk**.
    * Lägg till kontaktens specifika kommunikationsuppgifter: **Webbsida**, **Chatt** och **Internet-tel.** (exempelvis Skype eller Microsoft Teams).
    * Om tillämpligt, ange **Supportprioritet** och välj en **Vår supportansvarige** (kräver en SuperOffice Service- eller Kundcenter-licens).

    ![Fliken Detaljer på kontaktkortet med ytterligare fält. -screenshot][img2]

1. Gå till fliken **Intressen** för att ange intressen och prenumerationer:

    * Markera relevanta intressen (definieras under Inställningar och underhåll).
    * Konfigurera **E-marknadsföring/prenumerationer** för att hantera juridiskt samtycke till e-postkampanjer.

1. **Granska integritetsinställningar:**

    * Klicka på **Rättslig grund** längst ned på kontaktkortet för att [granska eller uppdatera GDPR-samtycke][7] och integritetsinformation. Klicka på **Stäng** när du är klar.

1. **Markera som tidigare anställd** (valfritt):

    * Markera **Tidigare anställd** om kontakten har slutat på företaget. Tidigare anställda visas inte i kontaktlistor eller projekt.

1. Klicka på **Spara** för att lagra kontaktuppgifterna.

Kontaktinformationen sparas då i databasen och visas på kontaktkortet. Om du kopplade kontakten till ett företag visas den även på detaljkortet **Kontakter** i fönstret Företag.

## <a id="fields"></a>Viktiga fält och deras funktion

Följande fält finns på kontaktkortet. Vissa fält fylls i automatiskt, medan andra kräver manuellt inmatade uppgifter.

> [!NOTE]
> Fält och layout kan variera beroende på inställningar i [Skärmdesignern][9] och andra UI-anpassningar.

<!-- markdownlint-disable-file MD051 -->
### [Fliken Kontakt](#tab/contacts)

**Grundläggande uppgifter:**

* **Förnamn** / **Efternamn**: Minst ett av dessa fält måste fyllas i (obligatoriskt).
* **Titulering**: Valfritt. Välj **Hr/Fr** beroende på kontaktens önskemål.
* **Titel**: Ange kontaktens befattning eller yrkestitel (från visitkortet).

**Kontaktuppgifter:**

* **E-post**: Lägg till flera e-postadresser med beskrivningar, såsom *Arbete* eller *Privat*.
* **Mobil** / **Direktnummer**: Lägg till flera telefonnummer med etiketter, såsom *Mobil* eller *Arbete*.
  * Tryck på **TAB** eller klicka utanför tabellen för att spara inmatningar.

**Adress:**

* **Hemadress**: Ange kontaktens adressuppgifter.
  * Adressformatet uppdateras automatiskt baserat på fältet **Land**.
* **Land**: Anger kontaktens land. Standardvärdet hämtas från det företag som kontakten är kopplad till.
* **Använd som postadress**: Markera rutan om direktpost ska skickas till kontaktens egen adress istället för företagets.

**Ärvda fält:**

* **Vår kontakt**: Tilldelar automatiskt ditt namn. Klicka på pilen för att välja en annan person i din organisation.
* **Kategori**: Välj från en fördefinierad lista. Standardvärdet hämtas från företagets kategori om det är länkat.
* **Bransch**: Välj den relevanta branschen. Standardvärdet hämtas från företagets bransch om det är länkat.

**Systemfält:**

* **Nummer**: Genereras automatiskt som nästa tillgängliga kontaktnummer om det är konfigurerat i **Inställningar och underhåll**. Du kan redigera detta manuellt om det behövs.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Fliken Detaljer](#tab/details)

**Personuppgifter:**

* **Befattning**: Välj kontaktens yrkesroll eller titel från en fördefinierad lista (konfigureras i **Inställningar och underhåll**).
* **Födelsedatum**: Ange kontaktens födelsedatum.

**Kommunikationsuppgifter:**

* **Webbsida**: Ange en URL till kontaktens webbplats, LinkedIn, Facebook eller andra sidor. Lägg till en titel för tydlighet.
* **Chatt**: Lägg till chattadresser (exempelvis Microsoft Teams, Google Chat). Välj en tjänsteleverantör från listan.
* **Internet-tel.**: Lägg till en VOIP-adress, exempelvis Skype eller en annan internetbaserad telefonitjänst.
* **Direktfax**: Ange kontaktens faxnummer.

**Fält för Service-funktioner** *(kräver SuperOffice Service eller Kundcenter-licens)*

* **Supportspråk**: Välj kontaktens föredragna språk för alla svarsmallar.
* **Supportprioritet**: Ange prioritet för nya serviceärenden (till exempel Låg, Medel, Hög eller anpassad). Standardvärdet hämtas från företaget om inget anges.
* **Vår supportansvarige**: Välj en supportrepresentant som ska hantera kontaktens ärenden.

**Privata fält:**

* **Privat**: Lägg till personliga telefonnummer eller kontaktuppgifter som inte är kopplade till ett företag.

### [Fliken Mer](#tab/more)

Här kan du ange eventuella [användardefinierade fält][12] som är specifika för din CRM-konfiguration.

### [Fliken Intressen](#tab/interests)

**Intressen och prenumerationer:**

* **Intressen**: Markera kontaktens intressen genom att kryssa i relevanta rutor. Intressen används för att skapa riktade urval, till exempel för utskick eller kampanjer.

  * Intressen definieras i **Inställningar och underhåll**.
  * En punkt visas bredvid fliknamnet **Intressen** när ett eller flera intressen har valts.

* **E-marknadsföring/prenumerationer**: Hantera samtycke för att skicka e-postkampanjer.

  * Om kontakten har godkänt att ta emot e-postutskick aktiverar du **E-marknadsföring** för att bekräfta juridiskt samtycke. Detta sätter automatiskt rättslig grund till **Legitimt intresse**.
  * Ange vilka typer av e-marknadsföring kontakten godkänner att ta emot.
  * Prenumerationsalternativ kan även ändras av kontakten via en kundportal.

### [Fliken Anteckning](#tab/note)

[Lägg till fritextanteckning][5] om personen.

***

## <a id="interests-tab"></a>Lägg till intressen

Intressen är användbara för att skapa riktade urval, exempelvis marknadsföringskampanjer för specifika målgrupper. Om du till exempel definierar *referenskund* som ett intresse kan du snabbt skapa ett urval av alla referenskunder.

1. Gå till fliken **Intressen**.

1. I redigeringsläget, markera relevanta intressen genom att kryssa i rutorna. Tillgängliga alternativ definieras i **Inställningar och underhåll**.

1. Om du väljer ett eller flera intressen visas en punkt bredvid fliknamnet.

1. Klicka på **Spara** för att lagra dina ändringar.

## Tips

* Du kan lägga till flera telefonnummer, e-postadresser och andra uppgifter med beskrivningar (t.ex. Växelnummer).

    Om du klickar på kontaktens e-postadress på fliken **Kontakt**, visas en lista där du kan välja önskad e-postadress. Ett tomt e-postmeddelande öppnas med den valda e-postadressen i fältet **Till**.

* Använd telefonikonen för att ringa direkt om ditt system är konfigurerat för det.

* Om kontakten är kopplad till ett företag är fält som **Kategori**, **Bransch** och **Vår kontakt** ärvda från företaget och kan inte redigeras.

* Gå till [detaljkortet Relationer][8] för att länka denna kontakt till andra företag eller kontakter.

## Relaterat innehåll

* [Lägg till en kontakt som favorit][4]
* [Skanna ett visitkort][1]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/contact/scan-business-card.md
[2]: ../../admin/import/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[5]: ../../learn/basics/notes.md
[9]: ../../customization/screen-designer/admin/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/new-contact.png
[img2]: ../../../media/loc/en/contact/contact-details.png
