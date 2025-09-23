---
uid: help-sv-saint-status-create
title: Skapa ny status
description: Skapa ny status
keywords: SAINT, statusövervakning, bild, visualisera, sökning
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: 
  - /sv/sale/saint/learn/admin/create-status
  - /sv/sale/saint/learn/admin/select-image-for-status
  - /sv/saint/admin/select-image-for-status
index: true
---

# Skapa ny status

[!include[Requirement](../includes/note-saint-req.md)]

## Varför ska du skapa en statusövervakning?

Du vill övervaka företag som du har väldigt få aktiviteter tillsammans med, för att undvika missnöjda kunder och kundomsättning. Med denna statusövervakning ser du enkelt alla kunder som behöver uppmärksamhet.

![Skapa en statusövervakning genom att klicka på knappen lägg till i fönstret -screenshot][img1]

## Steg

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Klicka på **Lägg till** under listan **Statusövervakning**.

1. Fyll i följande fält i dialogrutan:

    * **Namn**: Ange ett beskrivande namn för den status du vill lägga till.

        Tillval: Klicka på <i class="ph ph-translate" aria-label="Translate"></i> för att [lägga till översättningar av][8] statusnamnet.

    * **Beskrivning**: Ange en förklarande beskrivning av statusen och vilka åtgärder som krävs eller rekommenderas. I det här fältet kan du också använda [mallvariabler][9] för att anpassa texten till relevant företag, kontakt eller projekt.

    Namnet och beskrivningen visas i SuperOffice CRM när användaren håller muspekaren över statusbilden eller öppnar statusbilden för företaget. Du kan sedan [redigera beskrivningen][2].

1. Klicka på **Spara**. Statusen visas i statuslistan.

1. Om det finns flera statusar i listan, anger du vilken prioritet du vill att den nya statusen ska ha. Klicka på statusen och använd pilknapparna till höger om statuslistan för att flytta den upp eller ner i listan.

### Ange kriterier för statusen

Varje status måste innehålla minst ett kriterium. Efter att ha skapat statusen:

1. Välj den nya statusen i listan.
1. Välj **Lägg till** för att infoga ett nytt kriterium.
1. Välj en kriteriumtyp, ställ in villkoret och ange ett värde.
1. Upprepa vid behov, välj sedan **Regenerera vald statusövervakning** för att aktivera statusen.

## <a id="image"></a>Välja en bild för en status

Du kan lägga till en bild som ska visas på företags-, kontakt- eller projektkort som uppfyller statuskriterierna. Bilden visas som ett ljust vattenstämpel (40% transparens) så att den inte skymmer annat innehåll.

Att lägga till en bild är valfritt. Det kan hjälpa till att dra uppmärksamhet och symbolisera den åtgärd du vill att användarna ska vidta. Om du bara vill använda statusen för sökningar eller urval kan du lämna den utan bild.

1. I statuslistan väljer du önskad status.
1. På höger sida av skärmen markerar du **Visualisera** för att visa bilden.
1. Välj **Ändra bild**.
1. Gör något av följande:
    * Välj en av de befintliga bilderna från listan **Bilder**.
    * Välj **Lägg till**, ladda upp en fil, ange en beskrivning och välj **Spara**.
1. Välj **OK** för att bekräfta.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Använd enkla, ljusfarget bilder som representerar statusen på ett meningsfullt sätt. Till exempel kan ett spindelnät symbolisera inaktivitet.

### Vad innehåller statuslistan?

* Ikonen **Visualisera** (<i class="ph ph-eye" aria-hidden="true"></i>) indikerar om man kan [visa en statusbild][3] för företag, kontakt eller projektkort som uppfyller statuskriterierna. Ikonen visas bara om du har markerat **Visualisera** på fliken **Bild** för statusen i fråga.

* Ett rött kryss indikerar att statusen måste återskapas. [Statusen måste återskapas][4] varje gång du lägger till, redigerar eller tar bort ett kriterium eller om du till exempel ändrar syftet för en uppgift. Statusar med röda kryss uppdateras inte och returnerar inte aktuella data när mana använder SuperOffice CRM.

* **Namn** – namnet på statusarna. Borttagna statusar visas i rött om **Visa borttagna** är markerat.

* **Prioritet** – statusarnas prioritet. Prioriteten avgör vilken status som ska visas om ett företag, en kontakt eller ett projekt uppfyller kriterierna för flera statusar.

## Varför måste jag ange prioritet för en status?

Ett företag, en kontakt eller ett projekt kan uppfylla kriterierna för flera olika statusar, men det är bara möjligt att visa en statusbild på företagskortet, kontaktkortet eller projektkortet i SuperOffice CRM. En prioritetsordning måste därför anges för visning av statusar i SuperOffice CRM. Om ett företag, en kontakt eller ett projekt inte uppfyller kriterierna för högsta prioritet, visas statusen med näst högsta prioritet. Om företaget, kontakten eller projektet inte uppfyller dessa kriterier, visas nästa och så vidare.

Om ett företag, en kontakt eller ett projekt har flera aktiva statusar, visas statusen med lägre prioritet som länkar i statusdialogrutan. Den här dialogrutan visas när användaren klickar på statusbilden i SuperOffice CRM eller väljer **Visa statusinformation** i menyn **Företag**, **Kontakt** eller **Projekt** för ett företag, en kontakt eller ett projekt med en aktiv status.

## Relaterat innehåll

* [Ange statuskriterier][6]
* [Ange periodlängd][7]
* [Administrera statusövervakning][4]

<!-- Referenced links -->
[2]: edit-status.md
[3]: select-image-for-status.md
[4]: manage-status-monitors.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
