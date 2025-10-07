---
uid: help-sv-company-create
title: Skapa ett nytt företag
description: Skapa ett nytt företag
keywords: skapa företag, företag, skapa företagskort, lägg till intressen
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---  

# Skapa ett nytt företag

I **fönstret Företag** kan du skapa och hantera företagsuppgifter, inklusive anpassade fält och ytterligare data. Titta på denna [videoguide om att skapa ett företag][1].

## Steg för att skapa ett företag

1. Klicka på **Nytt** i toppraden och välj **Företag**.

1. På fliken **Företag**:
    * Ange **Företagsnamn** (obligatoriskt, markerat med röd text).
    * Fyll i fältet **Land**. Adressformatet för landet uppdateras automatiskt. Ditt förvalda land baseras på dina inställningar. Du kan ändra detta under **Personliga inställningar** > **Inställningar** > **System**.
    * Fyll i eventuella ytterligare fält som **Postnummer**, **Telefon**, **E-post** och **Webbsida**.

   ![Tomt företagskort med obligatoriska och valfria fält. -screenshot][img1]

1. Välj kategori och branschtillhörighet i fälten **Kategori** och **Bransch**. Båda är obligatoriska för att kunna spara posten.

1. (Valfritt) Lägg till ytterligare detaljer:
    * Gå till fliken **Mer** för att [ange anpassade fält][12].
    * Gå till fliken **Intressen** för att [specificera intressen](#interests-tab).
    * Gå till fliken **Anteckning** för att [lägga till anteckningar][5].

1. Klicka på **Spara** för att spara alla uppgifter.

## <a id="fields"></a>Viktiga fält förklarade

Följande fält finns tillgängliga i företagskortet. Vissa fält fylls i automatiskt medan andra kräver inmatning.

> [!NOTE]
> Fält och layout kan variera beroende på konfigurationer i [skärmdesignern][9] och andra UI-anpassningar.

* **Avdelning:** Specificera en avdelning om företaget har flera filialer eller divisioner.
* **Adressfält:** Uppdateras automatiskt baserat på valt land.
* **Postnummer och ort:** Om du anger ett postnummer som finns i SuperOffice-databasen fylls ortnamnet i automatiskt om fältet är tomt. Du kan också ange ett ortnamn manuellt, och då föreslås ett postnummer.
* **Telefon/Fax/E-post/Webbsida:** Ange flera uppgifter med beskrivningar, t.ex. *Växel*. Klicka utanför tabellen eller tryck på TABB för att stänga inmatningsfältet.
* **Vår kontakt:** Tilldelar automatiskt ditt namn. Klicka på pilen för att välja en annan person från din organisation.
* **Huvudkontakt:** Välj kontaktpersonen som ska vara huvudkontakt för denna kund. Kontakter måste läggas till för företaget innan de kan väljas.
* **Kod:** Genereras automatiskt efter att företaget sparats. Koden baseras på företagsnamnet men kan redigeras manuellt.
* **Nummer:** Tilldelar automatiskt nästa tillgängliga företagsnummer. Standardnumret börjar vid 10001 och ökar med 1 för varje nytt företag. Denna inställning kan ändras under Inställningar och underhåll.
* **Org. nr.:** Ange företagets organisationsnummer.
* **Stopp** och **Inga utskick**-kryssrutor:
  * **Stopp:** Indikerar att företaget kräver särskild hantering. Om du väljer **Stopp** visas en stoppskylt på företagskortet. Du kan också lägga till en kommentar som förklarar varför företaget är markerat. Alternativet är endast tillgängligt i redigeringsläge.
  * **Inga utskick:** Förhindrar att företaget får direktutskick. Denna inställning kan endast användas i redigeringsläge.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Dubbletter

Om du anger ett företag som liknar ett som redan finns i SuperOffice CRM visas dialogrutan **Dubbletter**. Detta hjälper dig att undvika [oavsiktlig registrering av ett befintligt företag][2].

* Granska listade dubbletter för att upprätthålla datakonsistens och undvika onödiga poster.
* Välj att fortsätta med den nya posten eller byta till ett av de listade företagen.

## <a id="interests-tab"></a>Lägg till intressen

Intressen kan hjälpa dig att skapa riktade urval. Till exempel kan du definiera *referenskund* som ett intresse och bygga ett urval för marknadsföringskampanjer riktade till dessa konton.

1. Gå till fliken **Intressen**.

1. I redigeringsläget markerar du relevanta rutor för att ange intressen. Tillgängliga intressen definieras i **Inställningar och underhåll**.

    > [!NOTE]
    > I visningsläge visas endast valda intressen. I redigeringsläge kan fler alternativ finnas tillgängliga.

1. Om du markerar ett eller flera intressen visas en punkt bredvid flikens namn.

    ![Fliken Intressen med kryssrutor för att välja företagsintressen. -screenshot][img2]

1. Klicka på **Spara** för att lagra de valda intressena.

## Relaterat innehåll

* [Lägg till en post som favorit][4]
* [Dialogrutan Inställningar][3] – standardvärden och listvärden

<!-- Referenced links -->
[1]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/company--contact/add-company.mp4
[2]: ../../learn/basics/duplicates.md
[3]: ../../learn/getting-started/preferences.md
[4]: ../../learn/basics/fav.md
[5]: ../../learn/basics/notes.md
[9]: ../../customization/screen-designer/admin/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/new-company.png
[img2]: ../../../media/loc/en/company/interests.png
